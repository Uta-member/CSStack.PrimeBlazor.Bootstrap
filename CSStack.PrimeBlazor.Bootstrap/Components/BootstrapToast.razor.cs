using Microsoft.AspNetCore.Components;

namespace CSStack.PrimeBlazor.Bootstrap
{
    public partial class BootstrapToast
    {
        [Parameter]
        public string? Detail { get; set; }

        [Parameter]
        public string? Summary { get; set; }
    }
}