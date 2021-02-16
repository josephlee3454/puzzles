using System;
using System.Collections.Generic;
namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static void RandArray(int[] numbers)
        {
            
        }

        public static int[] RandomArray()
        {   
            int[] arr = new int[10];
            Random rand = new Random();
            for(int i = 0; i < arr.Length; i++)//makes array
            {
                arr[i] =rand.Next(5,25);
                Console.WriteLine(arr[i]);
            
            }
            int max = arr[0];
            int min = arr[0];
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
                if (arr[i]<min)
                {
                    min = arr[i];
                }
                sum += arr[i];
            }
            Console.WriteLine($"max is {max}, the min values is {min}, sum is {sum}.");
            return arr; 

        

        }
        
        public static string Tosscoin()
        {
            Console.WriteLine("toss a coin");

            Random rand = new Random();
            int result = rand.Next(1,3);
            Console.WriteLine($"the coin side is {result}");
  
            if(result==1)
            {
                Console.WriteLine("HEADS!!!!!!!!!!!");
                return "HEADS";
            }
            else{
                Console.WriteLine("TAILS!!!!!!!!!!!!");
                return "TAILS";
            }
        }
// Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
         public static List <string> Names()
        {
            List <string> listOfNames = new List <string>();

            listOfNames.Add("Todd");
            listOfNames.Add("Tiffany");
            listOfNames.Add("Charlie");
            listOfNames.Add("Geneva");
            listOfNames.Add("Sydney");
            // Shuffle the list 
            Random rand = new Random();
            List <string> newlistOfNames = new List <string>();
            for(int i = 0; i < 5; i++)
            {
                int idx = rand.Next(0,listOfNames.Count);
                newlistOfNames.Add(listOfNames[idx]);
                listOfNames.RemoveAt(idx);
                Console.WriteLine(newlistOfNames[i]);
            }
            // Return a list that longer than 5 characters
            for (int i = 0; i < newlistOfNames.Count; i++)
            {
                if (newlistOfNames[i].Length < 5)
                {
                    newlistOfNames.RemoveAt(i);
                }
            }
            Console.WriteLine("New List: ");
            for (int i = 0; i < newlistOfNames.Count; i++)
            {
                Console.WriteLine(newlistOfNames[i]);
            }
            return newlistOfNames;
        }
        


    }
    
}
