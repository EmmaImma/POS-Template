using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Template
{
    internal class DBConnection
    {
        public string MyConnection() 
        {
            string con = @"Data Source=PROJECT-DIRECTO\SQLEXPRESS02;Initial Catalog=POS;Integrated Security=True";
            return con;
        }
    }
}
