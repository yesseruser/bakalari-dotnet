using System.Security.Authentication;
using Bakalari.NET;

Console.WriteLine("Do you have a refresh token? y/N:");
var hasTokenString = Console.ReadLine();
var hasToken = hasTokenString == "y";

Console.WriteLine("Enter your school name used in their Bakaláři URL:");
var school = Console.ReadLine();
var client = HttpClientGenerator.CreateBySchoolName(school!);

Login login;

if (hasToken)
{
    Console.WriteLine("Enter your refresh token:");
    var refreshToken = Console.ReadLine();
    
    login = (await Login.GetByRefreshToken(client, refreshToken!))!;
    
    if (login.ErrorType == "invalid_grant")
        throw new AuthenticationException("Invalid access credentials");
}
else
{
    Console.WriteLine("Enter your username:");
    var username = Console.ReadLine();

    Console.WriteLine("Enter your password:");
    var password = Console.ReadLine();

    login = (await Login.GetByPassword(client, username!, password!))!;

    if (login.ErrorType == "invalid_grant")
        throw new AuthenticationException("Invalid access credentials");
}

Console.WriteLine("Refresh token:");
Console.WriteLine(login!.RefreshToken);
var marks = await Marks.GetMarks(client);

Console.WriteLine("Marks:");
Console.WriteLine(marks!.Subjects![0].Marks![0].MarkText);