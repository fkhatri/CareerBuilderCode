using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.Repository.Entities
{
    public class Order
    {
        public int OrderId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DOB { get; set; }

        public string City { get; set; }

        public string State { get; set; }
    }

    public class OrderUsers
    {
        public int OrderId { get; set; }

        public string  UserId { get; set; }

        public bool IsSelected { get; set; }

        public bool IsModified { get; set; }
    }
}
