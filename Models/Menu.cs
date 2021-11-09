using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiSeperduaCoffee.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Varian { get; set; }
        public decimal Harga { get; set; }
        public string Komposisi { get; set; }
        public virtual List<Menu> Menus { get; set; }
    }
}

