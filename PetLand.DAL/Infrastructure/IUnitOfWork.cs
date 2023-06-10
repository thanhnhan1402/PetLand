using PetLand.BAL.Services.Interfaces;
using PetLand.DAL.Reponsitories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
        Task commitAsync();
        IProductReponsitory Product
        {
            get;
        }
    }
}
