using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace todolist
{
    class Program
    {

         static List<string> list = new List<string>();
        static void Main(string[] args)
        {
            while (true) {
                Console.Clear();
            Console.WriteLine("1. Add to list");
            Console.WriteLine("2. View list");
            Console.WriteLine("3. Delete From list");
            Console.WriteLine("4. Task completed");

            int choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1: AddToList(); break;
                    case 2: ViewList(); break;
                    case 3: DeleteFromList(); break;
                    case 4: MarkAsCompleted(); break;
                    case 5: return; break;
                    default: Console.WriteLine("Invalid number"); break;

                }
            }

        }
            static void AddToList()
            {
                Console.Clear();
                Console.WriteLine("Write your task");
                string newTask = Console.ReadLine();
                list.Add(newTask);
                Console.WriteLine("Task added successfully");
                Console.ReadKey();
            }
        static void ViewList()
        {
            Console.Clear();
            if(list.Count == 0)
            {
                Console.WriteLine("No tasks yet");
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {list[i]}");
                }
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static void DeleteFromList()
        {
            Console.Clear();
            ViewList();
            Console.WriteLine("choose which task do you wanna delete");
            int delete = int.Parse(Console.ReadLine());
            if (delete > 0 && delete <= list.Count)
            {
                list.RemoveAt(delete);
            }
            else
            {
                Console.WriteLine("invalid intake");
            }
            Console.ReadKey();
            
        }
        static void MarkAsCompleted()
        {
            Console.Clear();
            ViewList();
            Console.WriteLine("wich task do you wanna mark as completed?");
            int completed = int.Parse(Console.ReadLine()) - 1;
            if(completed > 0 && completed <= list.Count)
            {
                Console.WriteLine($"The {completed -1}. task has been completed");
            }
            Console.ReadKey();
        }
    }
}