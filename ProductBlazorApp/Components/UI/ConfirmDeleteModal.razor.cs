using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;

namespace ProductBlazorApp.Components.UI
{
    public partial class ConfirmDeleteModal
    {
        [Parameter] public string ProductName { get; set; } = string.Empty;
        [Parameter] public EventCallback OnConfirm { get; set; }
        [Parameter] public EventCallback OnCancel { get; set; }


        private async Task OnConfirmDelete()
        {
            await OnConfirm.InvokeAsync();
        }

        private async Task HandleBackdropClick(MouseEventArgs e)
        {

            await OnCancel.InvokeAsync();
        }
    }
}
