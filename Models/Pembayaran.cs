using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DiSeperduaCoffee.Models
{
    public class Pembayaran
    {
        public int Id { get; set; }
        public string Pengguna { get; set; }
        public DateTime WaktuPembayaran { get; set; }
        public decimal Total { get; set; }

        
    }
}