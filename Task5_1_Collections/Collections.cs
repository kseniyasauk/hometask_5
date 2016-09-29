using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_1_Collections
{
    static class Collections
    {
        static List<int> list = new List<int>();
        static LinkedList<int> linkedList = new LinkedList<int>();
        static Dictionary<int,int> dictionary = new Dictionary<int, int>();
        static Queue<int> queue = new Queue<int>();
        static Stack<int> stack = new Stack<int>();
        static SortedSet<int> sortedSet = new SortedSet<int>();
        static SortedDictionary<int,int> sortedDictionary = new SortedDictionary<int, int>();


        public static long AddToList()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                list.Add(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long AddToLinkedList()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                linkedList.AddLast(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long AddToDictionary()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                dictionary.Add(i,i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long AddToQueue()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                queue.Enqueue(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long AddToStack()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                stack.Push(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long AddToSortedSet()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                sortedSet.Add(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long AddToSortedDictionary()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                sortedDictionary.Add(i,i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long ReadFromList()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                int r = list[i];
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long ReadFromLinkedList()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                var elementAt = linkedList.ElementAt(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long ReadFromDictionary()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                var keyValuePair = dictionary.ElementAt(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long ReadFromQueue()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                var peek = queue.Peek();
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long ReadFromStack()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                var peek = stack.Peek();
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long ReadFromSortedSet()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                var elementAt = sortedSet.ElementAt(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long ReadFromSortedDictionary()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                var keyValuePair = sortedDictionary.ElementAt(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long RemoveFromList()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                list.Remove(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long RemoveFromLinkedList()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                linkedList.Remove(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long RemoveFromDictionary()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                dictionary.Remove(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long RemoveFromQueue()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                queue.Dequeue();
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long RemoveFromStack()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                stack.Pop();
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long RemoveFromSortedSet()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                sortedSet.Remove(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long RemoveFromSortedDictionary()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                sortedDictionary.Remove(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long FindInList()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                //list[i];
            }
            var find = list.Find(x => x < 50000);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long FindInLinkedList()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                linkedList.Find(i);
            }
            
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long FindInDictionary()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                var containsKey = dictionary.ContainsKey(i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long FindInQueue()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            //for (int i = 0; i < 100000; i++)
            //{
            //    queue.
            //}
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long FindInStack()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            //for (int i = 0; i < 100000; i++)
            //{
            //    stack.
            //}
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long FindInSortedSet()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                var getViewBetween = sortedSet.GetViewBetween(i - 1, i + 1);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static long FindInSortedDictionary()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                sortedDictionary.TryGetValue(i, out i);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }

        public static void WriteToFile(string path, List<string> content)
        {
            File.AppendAllLines(path,content);
        }

        public static List<string> AddMethodsToList()
        {
            List<string> content = new List<string>();
            content.Add("Operation 'Add': ");
            content.Add($"List: {AddToList()}");
            content.Add($"LinkedList: {AddToLinkedList()}");
            content.Add($"Dictionary: {AddToDictionary()}");
            content.Add($"Queue: {AddToQueue()}");
            content.Add($"Stack: {AddToStack()}");
            content.Add($"SortedSet: {AddToSortedSet()}");
            content.Add($"SortedDictionary: {AddToSortedDictionary()}");

            content.Add("Operation 'Read': ");
            content.Add($"List: {ReadFromList()}");
            content.Add($"LinkedList: {ReadFromLinkedList()}");
            content.Add($"Dictionary: {ReadFromDictionary()}");
            content.Add($"Queue: {ReadFromQueue()}");
            content.Add($"Stack: {ReadFromStack()}");
            content.Add($"SortedSet: {ReadFromSortedSet()}");
            content.Add($"SortedDictionary: {ReadFromSortedDictionary()}");

            content.Add("Operation 'Remove': ");
            content.Add($"List: {RemoveFromList()}");
            content.Add($"LinkedList: {RemoveFromLinkedList()}");
            content.Add($"Dictionary: {RemoveFromDictionary()}");
            content.Add($"Queue: {RemoveFromQueue()}");
            content.Add($"Stack: {RemoveFromStack()}");
            content.Add($"SortedSet: {RemoveFromSortedSet()}");
            content.Add($"SortedDictionary: {RemoveFromDictionary()}");

            content.Add("Operation 'Find': ");
            content.Add($"List: {FindInList()}");
            content.Add($"LinkedList: {FindInLinkedList()}");
            content.Add($"Dictionary: {FindInDictionary()}");
            content.Add($"Queue: {FindInQueue()}");
            content.Add($"Stack: {FindInStack()}");
            content.Add($"SortedSet: {FindInSortedSet()}");
            content.Add($"SortedDictionary: {FindInSortedDictionary()}");

            return content;
        }

        public static void Start()
        {
            String config = ConfigurationManager.AppSettings["file"];
            WriteToFile(config,AddMethodsToList());

            //Console.WriteLine("Operation 'Add': ");
            //Console.WriteLine($"List: {AddToList()}");
            //Console.WriteLine($"LinkedList: {AddToLinkedList()}");
            //Console.WriteLine($"Dictionary: {AddToDictionary()}");
            //Console.WriteLine($"Queue: {AddToQueue()}");
            //Console.WriteLine($"Stack: {AddToStack()}");
            //Console.WriteLine($"SortedSet: {AddToSortedSet()}");
            //Console.WriteLine($"SortedDictionary: {AddToSortedDictionary()}");

            //Console.WriteLine("Operation 'Read': ");
            //Console.WriteLine($"List: {ReadFromList()}");
            //Console.WriteLine($"LinkedList: {ReadFromLinkedList()}");
            //Console.WriteLine($"Dictionary: {ReadFromDictionary()}");
            //Console.WriteLine($"Queue: {ReadFromQueue()}");
            //Console.WriteLine($"Stack: {ReadFromStack()}");
            //Console.WriteLine($"SortedSet: {ReadFromSortedSet()}");
            //Console.WriteLine($"SortedDictionary: {ReadFromSortedDictionary()}");

            //Console.WriteLine("Operation 'Remove': ");
            //Console.WriteLine($"List: {RemoveFromList()}");
            //Console.WriteLine($"LinkedList: {RemoveFromLinkedList()}");
            //Console.WriteLine($"Dictionary: {RemoveFromDictionary()}");
            //Console.WriteLine($"Queue: {RemoveFromQueue()}");
            //Console.WriteLine($"Stack: {RemoveFromStack()}");
            //Console.WriteLine($"SortedSet: {RemoveFromSortedSet()}");
            //Console.WriteLine($"SortedDictionary: {RemoveFromDictionary()}");

            //Console.WriteLine("Operation 'Find': ");
            //Console.WriteLine($"List: {FindInList()}");
            //Console.WriteLine($"LinkedList: {FindInLinkedList()}");
            //Console.WriteLine($"Dictionary: {FindInDictionary()}");
            //Console.WriteLine($"Queue: {FindInQueue()}");
            //Console.WriteLine($"Stack: {FindInStack()}");
            //Console.WriteLine($"SortedSet: {FindInSortedSet()}");
            //Console.WriteLine($"SortedDictionary: {FindInSortedDictionary()}");
        }

    }
}
