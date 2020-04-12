using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;

namespace PointOfSale
{
    class DBConnection
    {
        public string MyConnection()
        {
            string con = @"Data Source=DESKTOP-LQJTKTO\USMAN;Initial Catalog=PointOfSale;Integrated Security=True";
            return con;
        }
    }
}
