using Microsoft.AspNetCore.Components;

namespace CSStack.PrimeBlazor.Bootstrap.TestApp.Client.Pages
{
    public partial class SampleDialog : ComponentBase
    {
        private async Task CloseDialog()
        {
            await Task.Delay(1000);
            DialogService.CloseDialog();
        }

        [Inject]
        public required DialogService DialogService { get; set; }
    }
}