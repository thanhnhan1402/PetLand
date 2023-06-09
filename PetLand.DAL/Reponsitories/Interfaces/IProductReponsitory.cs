using PetLand.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLand.DAL.Reponsitories.Interfaces
{
    public interface IProductReponsitory
    {
        IQueryable<Product> GetAllProdcut(string? keyword, List<string>? sortby, int PAGE_SIZE, int PAGE_NUMBER);
        Task<bool> Delete(int id);
        Task<Product> GetById(int id);
        Task<Product> Edit(Product product);
        Task<Product> Add(Product product);
    }
}
