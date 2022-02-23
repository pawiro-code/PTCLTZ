using System;

public class Program
{

    public static int funkcja(int s, int n=0)
    {
        int sciezka1 = 0;
        int sciezka2 = 0;
       
        sciezka1 = 3 * s + 1;
        sciezka2 = s / 2;
        
        if((s == 1)||(s == 1))
        {
            return n;
        }

        if(sciezka1 % 2 != 0)
        {
            n++;
            if(sciezka2 == 1)
            {
                return n;
            }
            else
            {
                return funkcja(sciezka2, n);
            }
        }
        else
        {
            n++;
            if (sciezka1 == 1)
            {
                return n;
            }
            else
            {
                return funkcja(sciezka1, n);
            }

        }






    }
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //wyniki
        int[] tab = new int[n];

        for(int i = 0; i < n; i++)
        {
            int s = int.Parse(Console.ReadLine());
            tab[i] = funkcja(s, 0);


        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(tab[i]);
        }
    }
}
