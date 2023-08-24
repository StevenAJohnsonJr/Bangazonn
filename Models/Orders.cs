using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon.Bangazon.Models
{
    internal class Orders
    {
        public int Id { get; set; }
        public int Userid { get; set; }
        public int ProductId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime StatusUpdateDate { get; set; }
    }
}
