using DotNetConfDemo2.Model;
using DotVVM.Framework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetConfDemo2.Services
{
    public class ProductCatalogService
    {
        private readonly AppDbContext dbContext;

        public ProductCatalogService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void LoadProducts(GridViewDataSet<ProductListDTO> dataSet, ProductFilterDTO filter)
        {
            // get products
            IQueryable<Products> query = dbContext.Products;

            // apply filters
            if (!string.IsNullOrEmpty(filter.SearchText))
            {
                query = query.Where(p => p.ProductName.Contains(filter.SearchText));
            }
            if (!filter.AllowDiscontinued)
            {
                query = query.Where(p => !p.Discontinued);
            }
            if (filter.CategoryId != null)
            {
                query = query.Where(p => p.CategoryId == filter.CategoryId);
            }

            // select columns displayed in grid
            var result = query.Select(p => new ProductListDTO()
            {
                Id = p.Id,
                Name = p.ProductName,
                Category = p.Category.CategoryName,
                Supplier = p.Supplier.CompanyName,
                QuantityPerUnit = p.QuantityPerUnit,
                UnitsInStock = p.UnitsInStock,
                UnitsOnOrder = p.UnitsOnOrder,
                UnitPrice = p.UnitPrice,
                Discontinued = p.Discontinued,
                ReorderLevel = p.ReorderLevel
            });

            // apply paging and sorting
            dataSet.LoadFromQueryable(result);
        }


        public List<CategoryDTO> GetCategories()
        {
            return dbContext.Categories
                .OrderBy(c => c.CategoryName)
                .Select(c => new CategoryDTO()
                {
                    Id = c.Id,
                    Name = c.CategoryName
                })
                .ToList();
        }

    }
}
