using DotNetConfDemo2.Services;
using DotVVM.Framework.ViewModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetConfDemo2.ViewModels
{
    public class ReoderDialogViewModel : DotvvmViewModelBase
    {
        private readonly ProductOrderService productOrderService;


        public ProductListDTO Product { get; set; }

        [Required]
        [Range(0, short.MaxValue)]
        public int UnitsToReorder { get; set; }

        public bool IsDisplayed { get; set; }


        public event Action ItemsReordered;


        public ReoderDialogViewModel(ProductOrderService productOrderService)
        {
            this.productOrderService = productOrderService;
        }


        public void Show(ProductListDTO productToReorder)
        {
            Product = productToReorder;
            IsDisplayed = true;
        }

        public void SubmitRequest()
        {
            productOrderService.Reorder(Product.Id, UnitsToReorder);

            ItemsReordered?.Invoke();
            Close();
        }

        public void Close()
        {
            Product = null;
            IsDisplayed = false;
            UnitsToReorder = 0;
        }

    }
}