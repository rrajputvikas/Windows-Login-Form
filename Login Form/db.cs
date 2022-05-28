using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Form
{
    class db
    {
        public static SqlConnection con;
        public static SqlCommand com;
        public static SqlDataReader dr;
        static db()
        { 
            con =new SqlConnection("Data Source=RAJPUTVIKAS\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True");
            con.Open();
            com = new SqlCommand();
            com.Connection = con;

            //SqlConnection con = new SqlConnection("data source=VIKASRAJPUT\\SQLEXPRESS; initial catalogue=dataServer; integrated security=true");
            //SqlCommand com = new SqlCommand();
            //con.Open();
            //com.Connection = con;
        }
    }
}
