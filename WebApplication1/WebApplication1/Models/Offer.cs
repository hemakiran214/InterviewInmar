using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Offer
    {
        public string OfferName { get; private set; }

        public IList<Product> Products { get; private set; }

        public Offer(string offerName, IList<Product> products)
        {
            OfferName = offerName;
            Products = products;
        }
    }
}
