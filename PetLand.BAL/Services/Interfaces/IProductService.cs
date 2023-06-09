using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetLand.BAL.Models;
using PetLand.DAL.Entities;
using static PetLand.DAL.Entities.Product;

namespace PetLand.BAL.Services.Interfaces;

    public interface IProductService
    {
        List<ProductViewModel> GetAll(string? keyword, List<string>? sortby, int PAGE_SIZE, int PAGE_NUMBER);
        Task<Product> GetById(long id);
        Task<Product> Edit(ProductViewModel product);
}

