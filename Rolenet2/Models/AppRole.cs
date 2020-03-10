using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rolenet2.Models
{
    public class AppRole : IdentityRole<int>
    {
        //public string Name;
        public AppRole()
        {

        }
        public AppRole( string name)
        {
            Name =  name;
        }
    }
}
