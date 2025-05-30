using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5_Dictionary
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, Product> Products { get; set; }
        public Category()
        {
            Products = new Dictionary<int, Product>();
        }
        /*
         * Mọi dữ liệu cần làm đủ :CRUD 
         */
        public void AddProduct(Product p)
        {
            if (Products.ContainsKey(p.Id))
            {
            return;
            }
            Products.Add(p.Id, p);
        }
        public void PrintAllProducts()
        {
            foreach(KeyValuePair<int, Product> item in Products)
            {
                Product p = item.Value;
                Console.WriteLine(p);
            }
        }
        //Lọc ra sản phậm có giá từ x tới y
        public Dictionary<int, Product>FilterProductsByPrice(double min, double max)
        {
            Dictionary<int, Product>results =  new Dictionary<int, Product>();
            results = Products.Where(item => item.Value.Price >= min && item.Value.Price <= max).ToDictionary<int, Product>();
            return results;
        }

        //Sắp xếp sản phẩm theo đơn giá tăng dần
        public Dictionary<int, Product> SortProductsByPrice()
        {
            return Products.OrderBy(item => item.Value.Price).ToDictionary<int, Product>() ;
        }

        //hãy sắp xếp sp theo đơn giá tăng dần
        //nếu đơn giá trùng nhau thì sắp xếp theo số lượng giảm dần
        public Dictionary<int, Product> ComplexSort()
        {
            return Products.OrderByDescending(item => item.Value.Quality)
                           .OrderBy(item => item.Value.Price)
                           .ToDictionary<int, Product>();
        }

        public bool UpdateProduct(Product p)
        {
            if (p == null) return false;
            if (Products.ContainsKey(p.Id) == false)
                return false;
            Products[p.Id] = p;//đè dữ liện lên ô nhớ hiện tại
            return true;       //hoặc tham chiếu đến ô nhớ khác
        }

        public bool RemoveProduct(int Id)
        {
            if (Products.ContainsKey(Id) == false) return false;
            return Products.Remove(Id); ;
        }
    }
}
