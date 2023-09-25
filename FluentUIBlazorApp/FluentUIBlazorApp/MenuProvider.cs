namespace FluentUIBlazorApp;

public static class MenuProvider
{
    private static Action<List<MenuItem>> onMenuChanged = e => { };

    public static void Subscribe(Action<List<MenuItem>> listener) => onMenuChanged = listener;

    public static void Publish(List<MenuItem> items) => onMenuChanged.Invoke(items);
}
