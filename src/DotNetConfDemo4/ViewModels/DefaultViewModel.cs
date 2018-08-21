using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Hosting;
using DotNetConfDemo4.Services;
using DotVVM.Framework.Controls;

namespace DotNetConfDemo4.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
        private readonly ProductCatalogService productCatalogService;

        public GridViewDataSet<ProductListDTO> Products { get; set; }


        public DefaultViewModel(ProductCatalogService productCatalogService)
        {
            this.productCatalogService = productCatalogService;

            Products = new GridViewDataSet<ProductListDTO>()
            {
                PagingOptions =
                {
                    PageSize = 10
                },
                SortingOptions =
                {
                    SortExpression = nameof(ProductListDTO.Name),
                    SortDescending = false
                }
            };
        }

        public override Task PreRender()
        {
            productCatalogService.LoadProducts(Products);

            return base.PreRender();
        }
    }
}
