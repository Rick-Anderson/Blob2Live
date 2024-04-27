using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string tree = "/tree/live/";        

        string permUrl = "https://github.com/dotnet/AspNetCore.Docs.ja-jp/blob/" +
            "1f5a72104e002c33aa4355a80901a9852852b219/aspnetcore/tutorials/" +
            "web-api-help-pages-using-swagger/samples/3.0/TodoApi.Swashbuckle/" +
            "readme.md?plain=1#L53";

        if (args.Length != 1)       // test case
            Console.WriteLine("Usage: UpdateGitHubUrl <github_url>");
        else if (args.Length == 1) // default is most of our URLs need the live branch
            permUrl = args[0];
        else                       // for repo's with main, we need main.
        {
            permUrl = args[0];
            tree = "/tree/main/";
        }

        string liveUrl = Regex.Replace(permUrl, @"/blob/[a-z0-9-]+/", tree);

        Console.WriteLine(liveUrl);
    }
}

