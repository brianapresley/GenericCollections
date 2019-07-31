using System;
using System.Collections.Generic;

namespace GenericCollectionsProject {

    //Bowling - Generate 10 frames with scores ranging from 0-30 and calculate total.
    //Use a for loop to generate 10 scores then use a foreach loop to calculate total.

    class Program {
        static void Main(string[] args) {

            var customers = new Customers();
            customers.LoadCustomers(); //to call a method from another class
            customers.PrintCustomers();
        }
        static void Run() { 
            var rnd = new Random(); //Used to generate random number

            List<int> frames = new List<int>(10); //Collection has only 10 items

            for(var idx = 0; idx < 10; idx++) { //load 10 more
                var score = rnd.Next(0, 31);
                frames.Add(score);
            }

            int total = 0;
            foreach(var frame in frames) { // sum the scores
                total += frame;
            }

            Console.WriteLine($"Game score is {total}");
        }
    }
}

    //MY ANSWER
    //Random rnd = new Random();
    //rnd.Next(1 - 31);
    
    //int[] frames = new int[10] {rnd}
    
    //for(var idx = 0; idx < frames.Length; idx++) {
    //    total += frames[idx];
    //}
    
    
    //int total = 0;
    //int index = 0;
    //    while (index < 10) {
    //        total = total + frames[index];
    //        index = index + 1;
    //    }
    //    Console.WriteLine($"Total is {total}");


    
    //List<string> names = new List<string>()
    
    //var integers = new List<int>();
    
    //integers.Add(7);
    //integers.Add(4);
    //integers.Add(13);
    
    //integers.Remove(4);
    
    //integers.AddRange(new int[] { 4, 44, 444, 4444 });
    
    //integers[3] = 99;
    
    //foreach(var i in integers) {
    //    Console.WriteLine($"i = {i}");
    //} 