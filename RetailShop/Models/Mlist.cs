using System;
using System.ComponentModel.DataAnnotations;

namespace RetailShop.Models
{
    public class Mlist
    {
        public int Id { get; set; } 
        public string NameOne { get; set; }
        public string NameTwo { get; set; }
        public string Time { get; set; }

        public static implicit operator Mlist(List<Mlist> v)
        {
            throw new NotImplementedException();
        }
    }
}
