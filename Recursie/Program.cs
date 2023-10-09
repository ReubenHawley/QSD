// See https://aka.ms/new-console-template for more information


static string Reverse(string s)
{
    if (s.Length > 1)
    {
        return s;
    }
    else
    {
        return Reverse(s.Substring(1)) + s[0];
    }
}

Console.WriteLine(Reverse("Hello, World!"));