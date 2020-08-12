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

        /// <summary>
        /// این سازنده بطور خودکار اجرا شده و دیتاتیبل های مربوط را آماده استفاده میکند
        /// </summary>
        static DataHolder()
        {
            if (Customers == null) // مشتریان 
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
            if (CustomersWithSignLimit == null) // مشتریان با سطح کفایت امضا
            {
                CustomersWithSignLimit = new DataTable();
                CustomersWithSignLimit.TableName = "CustomersWithSignLimit";
                CustomersWithSignLimit.Columns.Add("ID");
                CustomersWithSignLimit.Columns.Add("Name");
                CustomersWithSignLimit.Columns.Add("LastName");
                CustomersWithSignLimit.Columns.Add("Age");
                CustomersWithSignLimit.Columns.Add("Address");
            }
            if (SignerCustomers == null) // مشتریان با سطح امضا کننده
            {
                SignerCustomers = new DataTable();
                SignerCustomers.TableName = "SignerCustomers";
                SignerCustomers.Columns.Add("ID");
                SignerCustomers.Columns.Add("Name");
                SignerCustomers.Columns.Add("LastName");
                SignerCustomers.Columns.Add("Age");
                SignerCustomers.Columns.Add("Address");
            }
            if (MainCustomers == null) // مشتریان با سطح اصلی بدون نیاز به امضا برای برداشت
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


        /// <summary>
        /// دریافت مشتریان
        /// </summary>
        /// <returns></returns>
        public static DataTable RetrieveCustomers()
        {
            return Customers;
        }

        /// <summary>
        /// دریافت لیست مشتری های اصلی بدون نیاز به امضا
        /// </summary>
        /// <returns></returns>
        public static DataTable RetrieveMainCustomers()
        {
            return MainCustomers;
        }

        /// <summary>
        /// دریافت لیست مشتری های امضا کننده
        /// </summary>
        /// <returns></returns>
        public static DataTable RetrieveSignerCustomers()
        {
            return SignerCustomers;
        }

        /// <summary>
        /// دریافت لیست مشتری های کفایت امضا
        /// </summary>
        /// <returns></returns>
        public static DataTable RetrieveCustomersWithSignLimit()
        {
            return CustomersWithSignLimit;
        }

        /// <summary>
        /// ذخیره مشتری
        /// </summary>
        /// <param name="id">شناسه</param>
        /// <param name="name">نام</param>
        /// <param name="lastname">نام خانوادگی</param>
        /// <param name="age">سن</param>
        /// <param name="address">آدرس</param>
        /// <param name="used">وضعیت استفاده شدن مشتری در یک سطح</param>
        public static void SaveCustomers(int id , string name , string lastname , int age , string address,bool used)
        {
            Customers.Rows.Add(id, name, lastname, age, address,used);
        }

        /// <summary>
        /// ذخیره مشتری اصلی بدون نیاز به امضا
        /// </summary>
        /// <param name="id">شناسه</param>
        /// <param name="name">نام</param>
        /// <param name="lastname">نام خانوادگی</param>
        /// <param name="age">سن</param>
        /// <param name="address">آدرس</param>
        public static void SaveMainCustomers(int id, string name, string lastname, int age, string address)
        {
            MainCustomers.Rows.Add(id, name, lastname, age, address);
        }

        /// <summary>
        /// ذخیره مشتری های امضا کننده
        /// </summary>
        /// <param name="id">شناسه</param>
        /// <param name="name">نام</param>
        /// <param name="lastname">نام خانوادگی</param>
        /// <param name="age">سن</param>
        /// <param name="address">آدرس</param>
        public static void SaveSignerCustomers(int id, string name, string lastname, int age, string address)
        {
            SignerCustomers.Rows.Add(id, name, lastname, age, address);
        }

        /// <summary>
        /// ذخیره مشتری با کفایت امضا
        /// </summary>
        /// <param name="id">شناسه</param>
        /// <param name="name">نام</param>
        /// <param name="lastname">نام خانوادگی</param>
        /// <param name="age">سن</param>
        /// <param name="address">آدرس</param>
        public static void SaveCustomersWithSignLimit(int id, string name, string lastname, int age, string address)
        {
            CustomersWithSignLimit.Rows.Add(id, name, lastname, age, address);
        }
    }
}
