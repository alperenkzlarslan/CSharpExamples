using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Examples.Examples
{
    public static class arrayExample
    {
        public static void Run()
        {

            string[] myPcTool = { "Mosue", "Klavye", "Kulaklık", "Monitör", "Kasa", "Hoparlör", "MousePad" };
            Console.WriteLine(myPcTool[0]);

            //Liste içindeki elemanı değiştirme 
            myPcTool[0] = "Fare";
            Console.WriteLine(myPcTool[0]);

            //Listenin eleman sayısını alma 
            Console.WriteLine(myPcTool.Length);

            //Farklı dizi tanımlamaları
            string[] cars1 = new string[4];
            string[] cars2 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };
            string[] cars3 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            for (int i5 = 0; i5 < myPcTool.Length; i5++)
            {
                Console.WriteLine(i5);
            }

            foreach (string i6 in myPcTool)
            {
                Console.WriteLine(i6);
            }

            //Arrayi alfabetik sıralama -  Array.Sort(array_name) - Sayıları da aynı şekilde sıralar 
            Array.Sort(myPcTool);
            foreach (string tool in myPcTool)
            {
                Console.WriteLine(tool);
            }

            int[] myNumList12 = { 11, 45, 9, 0, 23, 8, 54 };
            Console.WriteLine(myNumList12.Max()); // En büyük sayıyı alır 
            Console.WriteLine(myNumList12.Min()); // En küçük sayıyı alır
            Console.WriteLine(myNumList12.Sum()); // Sayıları toplar 

            //Multidimensional Array - Çok boyutlu diziler 
            int[,] numberss = { { 0, 1, 2 }, { 3, 4, 5 } };
            Console.WriteLine(numberss[0, 1]);

            //2D dizinin elemanını değiştirme 
            numberss[0, 0] = 6;
            Console.WriteLine(numberss[0, 0]);

            //2D Diziyi döngüye alma 
            foreach (int i7 in numberss)
            {
                Console.WriteLine(i7);
            }

            for (int i8 = 0; i8 < numberss.GetLength(0); i8++)
            {
                for (int i9 = 0; i9 < numberss.GetLength(1); i9++)
                {
                    Console.WriteLine(numberss[i8, i9]);
                }
            }
        }
    }
}
