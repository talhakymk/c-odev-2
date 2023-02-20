using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class Program
    {
    static void Main(string[] args)
    {
        ArrayList asal = new ArrayList();
        ArrayList asaldegil = new ArrayList();
        string e = "";
        int n = 0;
        Console.WriteLine("please enter 20 positive integer");
        for(int i = 0 ; i < 20 ; i++){
            e = Console.ReadLine();
           while(!Check(e)){
           Console.WriteLine("wrong value try again");
            e = Console.ReadLine();
           }
             n = Convert.ToInt32(e);
            if(isPrime(n))
                asal.Add(n);
            else
                asaldegil.Add(n);
        }
        asal.Sort();
        asal.Reverse();
       yazdir(asal);
        asaldegil.Sort();
        asaldegil.Reverse();
       yazdir(asaldegil);
        average(asal);
        average(asaldegil);
        
    }
       static public bool Check(string num){
int sayac=0;
for(int i = 0; i < num.Length ; i++){
    if(num[i] - 48 >= 0 && num[i] - 48 <= 9 )
    sayac++;
}
if(sayac == num.Length)
return true;
else
return false;

       }

       static public void average(ArrayList a){
        double av = 0;
     foreach (int item in a)
        av += item;
     av = (av / a.Count);
     Console.WriteLine("number of element is :" + a.Count + " Average :" + av);

       }

        static public void yazdir(ArrayList A){
        foreach (var item in A)
        {
            Console.Write(item + " ");
        }
Console.Write("\n");
    }

    static public bool isPrime(int sayi){
        int sayac = 0;
for(int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                }
            }
            if (sayac == 2)
            {
                return true;
            }
            else
            {
                return false;
            }

    }

}
}
