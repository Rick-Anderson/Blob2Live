using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string permUrl = "https://github.com/dotnet/AspNetCore.Docs.ja-jp/blob/" +
                "1f5a72104e002c33aa4355a80901a9852852b219/aspnetcore/tutorials/" +
                "web-api-help-pages-using-swagger/samples/3.0/TodoApi.Swashbuckle/" +
                "readme.md?plain=1#L53";

        if (args.Length != 1)
            Console.WriteLine("Usage: UpdateGitHubUrl <github_url>");
        else
            permUrl = args[0];            

        string liveUrl = Regex.Replace(permUrl, @"/blob/[a-z0-9-]+/", "/tree/live/");

        Console.WriteLine(liveUrl);
    }
}

