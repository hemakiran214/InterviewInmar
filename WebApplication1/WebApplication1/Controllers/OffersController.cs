using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OffersController : ControllerBase
    {
        public OfferService service { get; set; }

        public OffersController()
        {
            service = new OfferService();
        }

        [HttpGet]
        [Route("offers")]
        public async Task<List<Offer>> GetAllOffers()
        {
            return await service.GetTodaysOffers();
        }
    }
}
