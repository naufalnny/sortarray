// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
    class Program
    {
        public static void sort(int[] number){
        for (int i = 0;i <number.Count(); i++)
        {
            int final = number[i];
            int idx = i;

            while (idx>0 && number[idx-1] > final)
            {
                number[idx] = number[idx-1];
                idx--;
            }
            number[idx] = final;

        }

            
        }
        static void Main(string[] args)
        {
        int[] angka = {24,12,36,70,23};
        Console.WriteLine("Array Sebelum =");
            for (int i = 0; i < angka.Count(); i++)
            {
                Console.Write(angka[i]+ " ");
            }
        Console.WriteLine(" ");
        sort(angka);
        Console.WriteLine("Array Sesudah =");
        for(int i = 0;i < angka.Count(); i++){
            Console.Write(angka[i]+ " ");
        }
        }
    }
}

