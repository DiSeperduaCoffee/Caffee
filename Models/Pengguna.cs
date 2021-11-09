using System.Collections.Generic;
using DiSeperduaCoffe.Models;
using DiSeperduaCoffee.Data;
using Microsoft.AspNetCore.Identity;

namespace DiSeperduaCoffee.Models
{
    public class Pengguna : IdentityUser
    {
        public string Name { get; set; }

        public virtual List<Pengguna> Penggunas { get; set; }
        public string Avatar { get; internal set; }
        }
    }
   