﻿using System;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Collections Demo Problem!!!");
            Console.WriteLine("Enter the option ");
            switch (Console.ReadLine())
            {
                case "1":
                    List.ListDemo();
                    break;
                case "2":
                    SortedList.SortedListDemo();
                    break;
                case "3":
                    Stack.StackDemo();
                    break;
                case "4":
                    Queue.QueueDemo();
                    break;
                case "5":
                    Dictionary.DictionaryDemo();
                    break;
                case "6":
                    HashSet.HashSetDemo();
                    break;
                default:
                    Console.WriteLine("Enter a valid option!!!");
                    break;
            }

        }
    }
}
