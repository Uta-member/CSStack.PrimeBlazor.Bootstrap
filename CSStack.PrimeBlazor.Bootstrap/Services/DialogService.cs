using Microsoft.AspNetCore.Components;

namespace CSStack.PrimeBlazor.Bootstrap
{
    public sealed class DialogService : PrimeDialogService
    {
        public DialogService()
            : base(
            new Dictionary<string, object>
            {
            {
                "class",
                "dialog-background"
            }
            })
        {
        }

        public void CloseDialog()
        {
            // 一番最新のダイアログだけを閉じる
            var latestDialog = DialogContexts.MaxBy(x => x.Index);
            if(latestDialog == null)
            {
                return;
            }

            CloseDialog(latestDialog);
        }

        public void ShowDialog<TDialogType>(Dictionary<string, object>? parameters = null, string? identifier = null)
            where TDialogType : ComponentBase
        {
            var index = DialogContexts.MaxBy(x => x.Index)?.Index + 1 ?? 0;
            ShowDialog(
                new PrimeDialogContext
                {
                    ComponentType = typeof(TDialogType),
                    Identifier = identifier ?? Guid.NewGuid().ToString(),
                    Index = index,
                    Parameters = parameters ?? new Dictionary<string, object>()
                });
        }
    }
}