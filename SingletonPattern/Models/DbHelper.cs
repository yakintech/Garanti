using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Models
{
    public class DbHelper
    {
        public string Status { get; set; }
        public string connectionString { get; set; }

        private static DbHelper _dbHelper;

        private DbHelper()
        {
            Console.WriteLine("DbHelper instance created");
        }

        private DbHelper(string connectionString)
        {
            this.connectionString = connectionString;
            Console.WriteLine("DbHelper instance created with connection string");
        }

        public static DbHelper GetInstance(string constr)
        {
            if (_dbHelper == null)
            {
                _dbHelper = new DbHelper(constr);
            }
            return _dbHelper;
        }
    }
}
