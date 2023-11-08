using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string HesapKodu { get; set; }
        public decimal ToplamBorç { get; set; }

        public ICollection<Transaction> Transactions { get; set; }

    }
}
