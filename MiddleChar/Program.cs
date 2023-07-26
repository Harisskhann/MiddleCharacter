using System;

public class Program
{
    public static string GetMiddle(string s)
    {
        int length = s.Length;
        int middleIndex = length / 2;

        if (length % 2 == 0)
        {
            return s.Substring(middleIndex - 1, 2);
        }
        else
        {
            return s[middleIndex].ToString();
        }
    }
    public static void Main()
    {
        String Text;
        Console.WriteLine("Enter a text");
        Text = Convert.ToString(Console.ReadLine());
        string value=GetMiddle(Text);
        Console.WriteLine(value);
        Console.ReadLine();
    }
}