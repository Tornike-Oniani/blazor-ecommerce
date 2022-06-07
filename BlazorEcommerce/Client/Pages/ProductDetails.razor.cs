using Microsoft.AspNetCore.Components;

namespace BlazorEcommerce.Client.Pages
{
    public partial class ProductDetails
    {
        private Product? product = null;
        private string message = String.Empty;

        [Parameter]
        public int Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            message = "Loading product...";
            ServiceResponse<Product> result = await ProductService.GetProduct(Id);
            if (!result.Success)
            {
                message = result.Message;
            }
            else
            {
                product = result.Data;
            }

        }
    }
}
