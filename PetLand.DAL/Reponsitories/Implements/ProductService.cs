using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PetLand.DAL.Entities.Product;
using PetLand.DAL;
using System.Data;
using PetLand.BAL.Services.Interfaces;
using PetLand.DAL.Entities;
//using PetLand.BAL.Models;
using System.Globalization;
using PetLand.DAL.Reponsitories.Interfaces;
using PetLand.DAL.Reponsitories.Implements;
using DAL.Infrastructure;
using PetLand.BAL.Models;

namespace PetLand.BAL.Services.Implements
{
    public class ProductService : IProductService
    {
        //private readonly PetLandContext _context;
        //private IProductReponsitory _productReponsitory;
        private IUnitOfWork _unitOfWork;
        

        public ProductService(IUnitOfWork unitOfWork)
        {
            //_context = context;
            //_productReponsitory = productRepository;
            _unitOfWork = unitOfWork;
        }

        public Task<Product> Edit(ProductViewModel product)
        {
            throw new NotImplementedException();
        }

        #region GetAllProduct
        public List<ProductViewModel> GetAll(string? keywords, List<string>? sortby, int PAGE_SIZE, int page = 1)
        {
            var newList = new List<ProductViewModel>();
            var list = _unitOfWork.Product.GetAllProdcut(keywords, sortby, PAGE_SIZE, page);
            foreach (var product in list)
            {
                ProductViewModel viewModel = new ProductViewModel();
                viewModel.ProductId = product.ProductId;
                viewModel.ProductName = product.ProductName;
                viewModel.ImageProduct = product.ImageProduct;
                viewModel.Label= product.Label;
                viewModel.Description = product.Description;
                viewModel.Weight = product.Weight;
                viewModel.UnitPrice = product.UnitPrice;
                viewModel.UnitInStock = viewModel.UnitInStock;
                viewModel.CategoryId = product.CategoryId;
                newList.Add(viewModel);
            }
            return newList.ToList();
        }
        #endregion

        public Task<Product> GetById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
