using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletCtrl.Models
{
    class Transaction
    {
        public int id { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public string Type { get; set; }
        public int Category { get; set; }
        public double Amount { get; set; }
        public Boolean Recurrence { get; set; }
        public DateTime RecurrOn { get; set; }
    }
}
