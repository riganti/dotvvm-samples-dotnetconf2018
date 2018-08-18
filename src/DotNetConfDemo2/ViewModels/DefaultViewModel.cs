using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Hosting;
using DotNetConfDemo2.Services;
using DotVVM.Framework.Controls;
using DotVVM.Framework.Controls.Bootstrap;

namespace DotNetConfDemo2.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
        private readonly ProductCatalogService productCatalogService;


        public ProductFilterDTO Filters { get; set; } = new ProductFilterDTO();

        public List<CategoryDTO> Categories { get; set; }

        public GridViewDataSet<ProductListDTO> Products { get; set; } = new GridViewDataSet<ProductListDTO>()
        {
            PagingOptions =
            {
                PageSize = 20
            },
            SortingOptions =
            {
                SortExpression = nameof(ProductListDTO.Name),
                SortDescending = false
            }
        };

        [Bind(Direction.ServerToClient)]
        public string AlertText { get; set; }

        [Bind(Direction.ServerToClient)]
        public AlertType AlertType { get; set; }

        public ReoderDialogViewModel ReorderDialog { get; set; }


        public DefaultViewModel(ProductCatalogService productCatalogService, ProductOrderService productOrderService)
        {
            this.productCatalogService = productCatalogService;
            ReorderDialog = new ReoderDialogViewModel(productOrderService);

            // refresh grid and display the alert when items are reordered
            ReorderDialog.ItemsReordered += () =>
            {
                AlertType = AlertType.Success;
                AlertText = "The product was reordered successfully.";
                Products.RequestRefresh();
            };

        }

        public void ApplyFilters()
        {
            Products.PagingOptions.PageIndex = 0;
            Products.RequestRefresh();
        }
        

        public override Task PreRender()
        {
            // fill categories on first page load
            if (!Context.IsPostBack)
            {
                Categories = productCatalogService.GetCategories();
            }

            // load products on first load and whenever filters, sorting or page changes
            if (Products.IsRefreshRequired)
            {
                productCatalogService.LoadProducts(Products, Filters);
            }

            return base.PreRender();
        }
        
    }
}
