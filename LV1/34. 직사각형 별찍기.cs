using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int colum = Int32.Parse(s[0]);
        int row = Int32.Parse(s[1]);

        string star = "";
        for (int x = 0; x < row; x++)                
        {
            for (int y = 0; y < colum; y++)
            {
                star += "*";
            }
            star += "\n";
        }
        
        Console.WriteLine(star);
    }
}