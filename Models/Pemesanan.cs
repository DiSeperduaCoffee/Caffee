using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiSeperduaCoffee.Models
{
    public class Pemesanan
    {
        public int Id { get; set; }
        public string Menu { get; set; }
        public string Pembayaran { get; set; }
        public decimal Jumlah { get; set; }
        public decimal Harga { get; set; }

    }
}