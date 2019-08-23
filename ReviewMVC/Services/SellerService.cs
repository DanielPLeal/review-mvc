using System;
using System.Collections.Generic;
using System.Linq;
using ReviewMVC.Models;
using System.Threading.Tasks;

namespace ReviewMVC.Services
{    
    public class SellerService
    {
        private readonly ReviewMVCContext _context;

        public SellerService(ReviewMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
