
namespace CSStack.PrimeBlazor.Bootstrap
{
    public sealed class NotificationService : PrimeNotificationService
    {
        public NotificationService()
            : base(
            new Dictionary<string, object>
            {
            { "class", "notification-background" }
            })
        {
        }

        public void Notify(string summary, string detail)
        {
            var latestContext = NotificationContexts.MaxBy(x => x.Index);
            var index = latestContext?.Index + 1 ?? 0;
            Notify(
                new PrimeNotificationContext
                {
                    ComponentType = typeof(BootstrapToast),
                    IsAutoClose = true,
                    Identifier = Guid.NewGuid().ToString(),
                    Index = index,
                    Parameters =
                        new Dictionary<string, object>
                            {
                        { "Summary", summary },
                        { "Detail", detail }
                            },
                    StartViewTimeStamp = DateTime.Now,
                    Duration = 4000
                });
        }
    }
}