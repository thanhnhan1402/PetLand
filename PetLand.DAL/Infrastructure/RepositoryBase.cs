using PetLand.DAL.Reponsitories.Interfaces;
using Microsoft.EntityFrameworkCore;
using PetLand.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Infrastructure
{
    public class RepositoryBase<T> where T : class
    {
        private PetLandContext _dbContext;
        protected DbSet<T> _dbSet { get; private set; }

        private IDbFactory DbFactory { get; }

        private PetLandContext DbContext
        {
            get
            {
                if (_dbContext == null)
                {
                    _dbContext = DbFactory.Init();
                }
                return _dbContext;
            }
        }

        protected RepositoryBase(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
                        
            _dbSet = DbContext.Set<T>();
        }
    }
}
