using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class Program
    {
    static void Main(string[] args)
    {
        int[] arr = new int[20];
        string? temp = null;
        int control = 0;
Console.WriteLine("Please enter 20 integer");
for(int i = 0 ;i <  20 ;i++)
{
    temp = Console.ReadLine();
    if (temp == null || temp == "" || !(int.TryParse(temp, out control)))
    {
    Console.WriteLine("do not enter null");
    i--;
    }
    else{
        arr[i] = int.Parse(temp);
    }
    
}
   // arr[i] = int.Parse(Console.ReadLine()); // sayıları aldık
int[] tiny = new int[3];
int[] big = new int[3];
Array.Sort(arr);
for(int i = 0 ;i < 3 ;i++)
tiny[i] = arr[i]; // küçük olan ilk 3 sayı buraya
Array.Reverse(arr);
for(int i = 0 ;i < 3 ;i++)
big[i] = arr[i]; // büyük olan ilk 3 sayı buraya
int averageSmall = 0;
int averageBig = 0;
foreach (var item in tiny)
    averageSmall += item;
foreach (var item in big)
    averageBig += item;

Console.WriteLine(" average of smallest numbers is :" + (averageSmall/3));
Console.WriteLine(" average of biggest numbers is :" + (averageBig/3));
Console.WriteLine("sum of averages " + ((averageBig+averageSmall)/3));
    }
    }
}
