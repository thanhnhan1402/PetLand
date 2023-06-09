using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Infrastructure;
using PetLand.DAL.Entities;
using PetLand.DAL.Reponsitories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Globalization;

namespace PetLand.DAL.Reponsitories.Implements
{
    public class ProductReponsitory : RepositoryBase<Product>, IProductReponsitory
    {
        private readonly PetLandContext _dbContext;
        private readonly IUnitOfWork _unitOfWork;
        public ProductReponsitory(IDbFactory dbFactory, IUnitOfWork unitOfWork) : base(dbFactory)
        {
            _dbContext = dbFactory.Init();
            _unitOfWork = unitOfWork;
        }

        public Task<Product> Add(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Edit(Product product)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetAllProdcut(string? keyword, List<string> sortBy, int PAGE_SIZE, int PAGE_NUMBER)
        {
            IQueryable<Product> result = null;
            if (sortBy.Count() == 0)
            {
                sortBy = null;
            }
            if (keyword == null && sortBy == null)
            {
                result = _dbSet.Skip(PAGE_SIZE * (PAGE_NUMBER - 1)).Take(PAGE_SIZE);
                return result;
            }
            if (keyword != null && sortBy == null)
            {
                result = _dbSet.Where(x => x.ProductName.Contains(keyword)).OrderByDescending(x => x.UnitPrice).Skip(PAGE_SIZE * (PAGE_NUMBER - 1)).Take(PAGE_SIZE);

                return result;
            }
            if (keyword == null && sortBy != null)
            {
                result = Sort(sortBy, PAGE_SIZE, PAGE_NUMBER);
                return result;
            }
            if (keyword != null && sortBy != null)
            {
                result = SortSearch(keyword, sortBy, PAGE_SIZE, PAGE_NUMBER);
                return result;
            }
            return _dbSet.Where(x => x.ProductId == 0);
        }

        public Task<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        private IQueryable<Product> Sort(List<string> sortby, int PAGE_SIZE, int PAGE_NUMBER)
        {
            String sort = "";
            foreach (var item in sortby)
            {
                sort = sort + ", " + item;
            }
            sort = sort.TrimStart(',');
            sort = sort.TrimStart(' ');
            return _dbContext.Products.AsQueryable().Skip(PAGE_SIZE * (PAGE_NUMBER - 1)).Take(PAGE_SIZE);

        }
        private IQueryable<Product> SortSearch(string keyword, List<string>? sortby, int PAGE_SIZE, int PAGE_NUMBER)
        {
            String sort = "";
            foreach (var item in sortby)
            {
                sort = sort + ", " + item;
            }
            sort = sort.TrimStart(',');
            sort = sort.TrimStart(' ');
            return _dbContext.Products.Where(x => x.ProductName.Contains(keyword)).AsQueryable().Skip(PAGE_SIZE * (PAGE_NUMBER - 1)).Take(PAGE_SIZE);

        }


        
    }
}
