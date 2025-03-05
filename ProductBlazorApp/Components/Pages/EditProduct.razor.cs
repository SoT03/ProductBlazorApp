using Microsoft.AspNetCore.Components;
using ProductBlazorApp.Models;


namespace ProductBlazorApp.Components.Pages
{
    public partial class  EditProduct
    {
        private Product newProduct = new Product();
        [Parameter] public int? Id { get; set; }
        private bool loading = true;
        private bool isNew;

        private async Task SaveProduct()
        {
            if (newProduct.Id == 0)
            {
                await ProductService.AddProductAsync(newProduct);
            }
            else
            {
                await ProductService.UpdateProductAsync(newProduct);
            }


            NavigationManager.NavigateTo("/");
        }

        protected override async Task OnInitializedAsync()

        {
            if (Id.HasValue && Id.Value > 0)
            {
                newProduct = await ProductService.GetProductByIdAsync(Id.Value) ?? new Product();
            }
            isNew = newProduct.Id == 0;
            loading = false;
        }
    }
}
