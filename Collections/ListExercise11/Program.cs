using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var todo = new List<string>();
            todo.Add("one");
            todo.Add("big");
            todo.Add("two");
            todo.Add("car");
            todo.Add("red");
            todo.Add("there");
            todo.Add("blank");
            todo.Add("name");
            todo.Add("nine");
            todo.Add("ten");

            todo.RemoveAt(4);
            todo.Insert(4,"new value");

            todo.RemoveAt(todo.Count - 1);
            todo.Insert(todo.Count - 1, "Last Position");
            todo.Sort();

            if (todo.Contains("FooBar"))
            {
                Console.WriteLine("List contains foobar!");
            }
            else
            {
                Console.WriteLine("List dosent contain foobar!");
            }

            foreach (var item in todo)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
