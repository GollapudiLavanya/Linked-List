﻿using System;

namespace LinkedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------Linked List--------------------");
            LinkedList linkedList = new LinkedList();

            //Adding elements to the list
            linkedList.AddAtFirst(30);
            linkedList.AddAtFirst(56);
            linkedList.AddAtFirst(70);

            //Dispaly the list
            linkedList.Display();
        }
    }
}