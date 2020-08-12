using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class DataHolder
    {
        private static DataTable Customers { get; set; }
        private static DataTable CustomersWithSignLimit { get; set; }
        private static DataTable SignerCustomers { get; set; }
        private static DataTable MainCustomers { get; set; }

        static DataHolder()
        {
            if (Customers == null)
            {
                Customers = new DataTable();
                Customers.TableName = "Customers";
                Customers.Columns.Add("ID");
                Customers.Columns.Add("Name");
                Customers.Columns.Add("LastName");
                Customers.Columns.Add("Age");
                Customers.Columns.Add("Address");
                Customers.Columns.Add("Used");
            }
            if (CustomersWithSignLimit == null)
            {
                CustomersWithSignLimit = new DataTable();
                CustomersWithSignLimit.TableName = "CustomersWithSignLimit";
                CustomersWithSignLimit.Columns.Add("ID");
                CustomersWithSignLimit.Columns.Add("Name");
                CustomersWithSignLimit.Columns.Add("LastName");
                CustomersWithSignLimit.Columns.Add("Age");
                CustomersWithSignLimit.Columns.Add("Address");
            }
            if (SignerCustomers == null)
            {
                SignerCustomers = new DataTable();
                SignerCustomers.TableName = "SignerCustomers";
                SignerCustomers.Columns.Add("ID");
                SignerCustomers.Columns.Add("Name");
                SignerCustomers.Columns.Add("LastName");
                SignerCustomers.Columns.Add("Age");
                SignerCustomers.Columns.Add("Address");
            }
            if (MainCustomers == null)
            {
                MainCustomers = new DataTable();
                MainCustomers.TableName = "MainCustomers";
                MainCustomers.Columns.Add("ID");
                MainCustomers.Columns.Add("Name");
                MainCustomers.Columns.Add("LastName");
                MainCustomers.Columns.Add("Age");
                MainCustomers.Columns.Add("Address");
            }
        }

        public static DataTable RetrieveCustomers()
        {
            return Customers;
        }
        public static DataTable RetrieveMainCustomers()
        {
            return MainCustomers;
        }
        public static DataTable RetrieveSignerCustomers()
        {
            return SignerCustomers;
        }
        public static DataTable RetrieveCustomersWithSignLimit()
        {
            return CustomersWithSignLimit;
        }


        public static void SaveCustomers(int id , string name , string lastname , int age , string address,bool used)
        {
            Customers.Rows.Add(id, name, lastname, age, address,used);
        }
        public static void SaveMainCustomers(int id, string name, string lastname, int age, string address)
        {
            MainCustomers.Rows.Add(id, name, lastname, age, address);
        }
        public static void SaveSignerCustomers(int id, string name, string lastname, int age, string address)
        {
            SignerCustomers.Rows.Add(id, name, lastname, age, address);
        }
        public static void SaveCustomersWithSignLimit(int id, string name, string lastname, int age, string address)
        {
            CustomersWithSignLimit.Rows.Add(id, name, lastname, age, address);
        }
    }
}
