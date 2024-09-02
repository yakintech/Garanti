using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern.Models
{
    public class ProductService
    {

        private ILogger _logger;

        public ProductService(ILogger logger)
        {
            _logger = logger;
        }


        public void AddProduct(string name)
        {

            //db operations
            // add product to db
            // log
            _logger.Log("Product added: " + name);
        }
    }
}
