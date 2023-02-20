using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    class Program
    {
    static void Main(string[] args)
    {
        string? sentence = "";
        string? vowels = "";
Console.WriteLine("Please enter a sentence");
sentence = Console.ReadLine();
sentence.ToLower();
for(int i = 0; i < sentence.Length ; i++){
    if(sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'ı' || sentence[i] == 'u' || sentence[i] == 'o' || sentence[i] == 'ü' || sentence[i] == 'ö'){
vowels += sentence[i];
    }
}
foreach (var item in vowels)
{
    Console.Write(item + " ");
}

    }
    }
}