namespace Autodize.Client.Services;

public class Notifier
{
    public event Action OnRefreshed;
    public void Refresh() => OnRefreshed?.Invoke();
}