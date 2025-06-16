using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HelloWPF
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

      
        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnDangnNhap_Click(object sender, RoutedEventArgs e)
        {
            //ta giả đò làm đăng nhập
            //nếu thnahf công thì vào Mainwinform
            //nếu thất bại thì thông báo failed 
            if (txtUserName.Text=="obama" &&
                txtPassword.Password=="123")
            {
                //mở màn hình MainƯindow
                MainWindow mw = new MainWindow();
                mw.Show();
                //đóng cửa sổ đăng nhập
                Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập sai rồi cha");
            }
        }
    }
}
