using ReviewMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReviewMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void addSeller(Seller sl)
        {
            Sellers.Add(sl);
        }

        public double totalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seler => seler.totalSales(initial, final));
        }
    }
}
