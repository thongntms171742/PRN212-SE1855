﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace OOP1
{
    public class Employee
    {
        #region Nhóm các thuộc tính của Employee
        private int _id;
        private string _id_card;
        private string _name;
        private string _email;
        private string _phone;
        #endregion
        
        #region Các nhóm constructer của Employee
        public Employee() 
        {
            this._id = 1;
            this._id_card = "000000";
            this._name = "Obana";
        }

        public Employee(int id, string id_card, string name, string email, string phone)
        {
            this._id = id;
            this._id_card = id_card;
            this._name = name;
            Email = email;
            Phone = phone;
        }
        #endregion

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Id_Card
        { 
            get { return _id_card; } 
            set { _id_card = value; }
        }
    
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public void PrintInfor()
        {
            string msg = $"{Id}\t{Id_Card}\t{Name}\t{Email}\t{Phone}";
            Console.WriteLine(msg);
        }
        public override string ToString()
        {
            string msg = $"{Id}\t{Id_Card}\t{Name}\t{Email}\t{Phone}";
            return msg;
        }
    }
}
