using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1
{
    public class OfferService
    {
        private List<Product> Inventory { get; set; }
                   
        private void PopulateInventory()
        {
            if(Inventory == null)
            {
                Inventory = new List<Product>
                {
                    new Product("P1",1000, "P1 desc"),
                    new Product("P2",200, "P2 desc"),
                    new Product("P3",400, "P3 desc"),
                    new Product("P4",700, "P4 desc"),
                    new Product("P5",600, "P5 desc"),
                    new Product("P6",800, "P6 desc"),

                };
            }
        }

        public OfferService()
        {
            PopulateInventory();
        }

        public List<Product> GetAllProducts()
        {
            return this.Inventory;
        }

        public List<Offer> GetTodaysOffers()
        {
            Random rnd = new Random();
            var offers = new List<Offer>()
            {
                new Offer("ComboPackage1", Inventory.Skip(rnd.Next(0,3)).Take(3).ToList()),
                new Offer("ComboPackage2", Inventory.Skip(rnd.Next(0,3)).Take(3).ToList()),
                new Offer("ComboPackage3", Inventory.Skip(rnd.Next(0,3)).Take(3).ToList())
            };
            return offers;
        }
    }
}
