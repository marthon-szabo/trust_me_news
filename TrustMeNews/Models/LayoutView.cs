using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrustMeNews.Data;

namespace TrustMeNews.Models
{
    public struct LayoutView
    {
        private readonly TrustMeNewsDataContext _context;

        public LayoutView(TrustMeNewsDataContext context)
        {
            _context = context;
        }

        
    }
}
