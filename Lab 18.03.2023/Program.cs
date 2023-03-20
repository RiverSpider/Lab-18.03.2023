
using System.Collections;

while (true)
{
    Console.Write("1.Hashtable" + '\n' +
    "2. ArrayList");
    string command = Console.ReadLine();
    if (command == "1")
    {
        Hashtable hash = new Hashtable();
        string[] array = new string[10];
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1.  Add" + '\n' +
                "2.  Clear" + '\n' +
                "3.  CopyTo" + '\n' +
                "4.  ContainsValue" + '\n' +
                "5.  ContainsKey" + '\n' +
                "6.  GetHashCode" + '\n' +
                "7.  Remove" + '\n' +
                "8.  GetType" + '\n' +
                "9.  ToString" + '\n' +
                "10. Equals");
            command = Console.ReadLine();
            Console.Clear();
            if (command == "1")
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();
                hash.Add(key, value);
            }
            else if (command == "2")
            {
                hash.Clear();
            }
            else if (command == "3")
            {
                hash.Values.CopyTo(array, 10);
            }
            else if (command == "4")
            {
                string value = Console.ReadLine();
                Console.WriteLine(hash.ContainsValue(value));
                Console.ReadLine();
            }
            else if (command == "5")
            {
                string key = Console.ReadLine();
                Console.WriteLine(hash.ContainsKey(key));
                Console.ReadLine();
            }
            else if (command == "6")
            {
                Console.WriteLine(hash.GetHashCode());
                Console.ReadLine();
            }
            else if (command == "7")
            {
                string key = Console.ReadLine();
                hash.Remove(key);
            }
            else if (command == "8")
            {
                Console.WriteLine(hash.GetType());
                Console.ReadLine();
            }
            else if (command == "9")
            {
                Console.WriteLine(hash.ToString());
                Console.ReadLine();
            }
            else if (command == "10")
            {
                Console.WriteLine(hash.Equals(hash.Clone()));
                Console.ReadLine();
            }
            else
            {
                break;
            }
        }
    }
    else if (command == "2")
    {
        ArrayList list = new ArrayList();
        string[] copylist = new string[list.Count];
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1.  Add" + '\n' +
                "2.  Sort" + '\n' +
                "3.  BinarySearch" + '\n' +
                "4.  Clear" + '\n' +
                "5.  CopyTo" + '\n' +
                "6.  Contains" + '\n' +
                "7.  IndexOf" + '\n' +
                "8.  ToString" + '\n' +
                "9.  Count" + '\n' +
                "10. Reverse");
            command = Console.ReadLine();
            Console.Clear();
            if (command == "1")
            {
                string value = Console.ReadLine();
                list.Add(value);
            }
            else if (command == "2")
            {
                list.Sort();
            }
            else if (command == "3")
            {
                string value = Console.ReadLine();
                Console.WriteLine(list.BinarySearch(value));
                Console.ReadLine();
            }
            else if (command == "4")
            {
                list.Clear();
            }
            else if (command == "5")
            {
                list.CopyTo(copylist);
            }
            else if (command == "6")
            {
                string value = Console.ReadLine();
                Console.WriteLine(list.Contains(value));
                Console.ReadLine();
            }
            else if (command == "7")
            {
                string value = Console.ReadLine();
                Console.WriteLine(list.IndexOf(value));
                Console.ReadLine();
            }
            else if (command == "8")
            {
                Console.WriteLine(list.ToString());
                Console.ReadLine();
            }
            else if (command == "9")
            {
                Console.WriteLine(list.Count);
                Console.ReadLine();
            }
            else if (command == "10")
            {
                list.Reverse();
            }
            else
            {
                break;
            }
        }
    }
    else
    {
        break;
    }
}