using DotNetConfDemo4.Model;
using DotVVM.Framework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetConfDemo4.Services
{
    public class ProductCatalogService
    {
        private readonly AppDbContext dbContext;

        public ProductCatalogService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void LoadProducts(GridViewDataSet<ProductListDTO> dataSet)
        {
            // get products
            IQueryable<Products> query = dbContext.Products;
            
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

    }
}
