using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletCtrl.Models
{
    public class User
    {
        public int Id { get; set; }
        public string LoginID { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }
    }
}
