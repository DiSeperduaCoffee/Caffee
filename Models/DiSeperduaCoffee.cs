using System;
using System.ComponentModel.DataAnnotations;

namespace DiSeperduaCoffee.Models
{
    public class DiSeperduaCoffe
    {
        public int Id { get; set; }
        public string Menu { get; set; }

         [DataType(DataType.Date)]
        public DateTime Varian { get; set; }
        public string Harga { get; set; }
        public decimal Komposisi { get; set; }
    }
}

