using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon.Bangazon.Models
{
    internal class user
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Usernmame { get; set; }
        public DateTime Created_at { get; set; }
        public bool isSeller { get; }
    }
}
