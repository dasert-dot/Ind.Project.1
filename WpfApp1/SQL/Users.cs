using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WpfApp1.SQL
{
    public class Users
    {
        [Key]
        public string email { get; set; }
        public string phone { get; set; }
        public string name { get; set; }
        public override string ToString()
        {
            return $"{name} - {phone}";
        }
    }
}
