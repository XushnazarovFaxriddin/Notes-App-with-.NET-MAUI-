namespace Notes.Models;

internal class About
{
    public string Title => "Notes"; // AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "http://xushnazarov.uz";

    public string Message => "This app is written in XAML and C# with .NET MAUI.";
}