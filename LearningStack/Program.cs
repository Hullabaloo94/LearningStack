using System;
using System.Collections.Generic;

namespace LearningStack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stacks are like pancakes: The first one that enters the stack is at the bottom of the stack and the last to enter the stack is taken from the stack first. LIFO (Last in First Out).
            Stack<string> pancakes = new Stack<string>();
            pancakes.Push("first pancake made");
            pancakes.Push("second pancake made");
            pancakes.Push("last pancake made");

            /**foreach (var pancake in pancakes)
            {
                Console.WriteLine(pancake);
            }**/

            // Pop removes the last item. If in a Console.WriteLine it can be shown before it is removed.
            Console.WriteLine(pancakes.Pop());
            //Peek allows the viewing of an item without it being removed.
            Console.WriteLine(pancakes.Peek());
            Console.WriteLine(pancakes.Peek());
        }
    }
}
