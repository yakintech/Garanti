using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garanti.Domain.Models
{
    //Bazi tablolarda sira numarasi tutulmasi gerektigi icin olusturuldu.
    public interface ISort
    {
        int SortOrder { get; set; }
    }
}
