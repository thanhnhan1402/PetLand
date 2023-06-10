using PetLand.BAL.Services.Implements;
using PetLand.BAL.Services.Interfaces;
using PetLand.DAL.Entities;
using PetLand.DAL.Reponsitories.Implements;
using PetLand.DAL.Reponsitories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private PetLandContext _context;
        
        public UnitOfWork(PetLandContext context)
        {
            _context = context;
            Product = new ProductReponsitory(_context);
        }

        public IProductReponsitory Product
        {
            get;
            private set;
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public Task commitAsync()
        {
            throw new NotImplementedException();
        }
    }
}
