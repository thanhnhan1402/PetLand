using PetLand.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Infrastructure
{
    public class DbFactory : IDbFactory
    {
        private PetLandContext _dbContext;

        // Team 1 addin Dependency injection
        public DbFactory(PetLandContext dbContext)
        {
            _dbContext = dbContext;
        }

        public PetLandContext Init()
        {
            if (_dbContext == null)
            {
                _dbContext = new PetLandContext();
            }
            return _dbContext;
        }
    }
}
