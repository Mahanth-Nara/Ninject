using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc.Core.Models
{
    public class UserModel
    {
        public Int64 ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Address { get; set; }

        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public DateTime AddedDate { get; set; }
    }
}
