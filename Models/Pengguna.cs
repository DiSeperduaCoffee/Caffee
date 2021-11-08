using System.Collections.Generic;
using DiSeperduaCoffe.Models;
using DiSeperduaCoffee.Data;
using Microsoft.AspNetCore.Identity;

namespace DiSeperduaCoffee.Models
{
    public class Pengguna : IdentityUser
    {
        public string Name { get; set; }

        public List<Pengguna> Penggunas { get; set; }
        }
    }
   