using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Models
{
    public class HuaweiConcreteBuilder : PhoneBuilder
    {
        public HuaweiConcreteBuilder()
        {
            phone = new Phone();
        }

        public override void BuildName()
        {
            phone.Name = "Huawei P30 Pro";
        }

        public override void BuildBrand()
        {
            phone.Brand = "Huawei";
        }

        public override void BuildPrice()
        {
            phone.Price = "1000$";
        }

        public override void BuildId()
        {
            phone.Id = 1;
        }
    }
}
