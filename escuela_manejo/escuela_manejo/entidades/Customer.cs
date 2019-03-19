﻿using System;
namespace escuela_manejo
{
    public class Customer
    {
        /*
         *  Cliente del negocio
         */
                
        private int id_customer;
        private string id;
        private string first_name;
        private string last_name;
        private string email;
        private string address;
        private int state;
        private string phone;
        private DateTime create_date;
        private DateTime last_update;

        public int Id_customer { get => id_customer; set => id_customer = value; }
        public string Id { get => id; set => id = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public int State { get => state; set => state = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime Create_date { get => create_date; set => create_date = value; }
        public DateTime Last_update { get => last_update; set => last_update= value; }

        public Customer()
        {
        }
    }
}
