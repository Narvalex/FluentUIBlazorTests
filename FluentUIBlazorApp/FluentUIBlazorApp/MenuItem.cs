using Microsoft.Fast.Components.FluentUI;

namespace FluentUIBlazorApp;

public class MenuItem
{
    public Icon? Icon { get; set; }
    public string Text { get; set; } = "";
    public string? Href { get; set; }
}