using Microsoft.AspNetCore.Components;

namespace CSStack.PrimeBlazor.Bootstrap
{
    public partial class BootstrapComponent
    {
        [Inject] public required DialogService DialogService { get; set; }

        [Inject] public required NotificationService NotificationService { get; set; }
    }
}