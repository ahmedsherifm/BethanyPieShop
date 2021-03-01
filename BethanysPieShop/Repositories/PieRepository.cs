using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Interfaces;
using BethanysPieShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Repositories
{
    public class PieRepository: IPieRepository
    {
        private readonly AppDbContext _appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> AllPies => _appDbContext.Pies.Include(pie=>pie.Category);
        public IEnumerable<Pie> PiesOfTheWeek => _appDbContext.Pies.Include(pie => pie.Category)
                                                                   .Where(pie => pie.IsPieOfTheWeek);

        public Pie GetPieById(int pieId) =>
            _appDbContext.Pies.Include(pie => pie.Category)
                              .FirstOrDefault(pie => pie.PieId == pieId);
    }
}
