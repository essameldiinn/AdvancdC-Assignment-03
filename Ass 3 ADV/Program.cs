using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ass_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 

            //          Array
            //          List<T>
            //          Dictionary<TKey, TValue>
            //          SortedDictionary<TKey, TValue>
            //          SortedList<TKey, TValue>
            //          HashSet<T>
            //          Hashtable

            //          | Collection | Structure | Time Complexity(Access / Insert / Delete / Search) | Business Case | Code Example(Project Reference) |
            //| ---------------- | ------------------------------ | --------------------------------------------- | ----------------------------------------- | --------------------------------------- |
            //| List<T> | Dynamic array | O(1) / O(n) / O(n) / O(n) | Ordered list of items with fast access    | Implemented in `AnagramGrouping.csproj` |
            //| Dictionary | Hash table | O(1) / O(1) / O(1) / O(1) | Mapping keys to values(e.g., ID to Name) | Used in FrequencyCounter.csproj |
            //| SortedDictionary | BST(Red - Black Tree) | O(log n) for all | Keep data sorted by key | StudentDirectory.csproj |
            //| SortedList | Internal array + binary search | O(log n) / O(n) / O(n) / O(log n) | Faster key lookup with sorted keys | EmployeeDirectory.csproj |
            //| HashSet | Hash table | O(1) / O(1) / O(1) / O(1) | Maintain uniqueness | UniqueValues.csproj |
            //| Hashtable | Legacy hash table | O(1) / O(1) / O(1) / O(1) | Generic fast - access mapping(non - generic) | Used in multiple tasks |














            #endregion

            #region Part 02
            #region 1
            //Hashtable freqTable = new Hashtable();
            //foreach (int num in arr)
            //{
            //    if (freqTable.ContainsKey(num))
            //        freqTable[num] = (int)freqTable[num] + 1;
            //    else
            //        freqTable[num] = 1;
            //}

            #endregion
            #region 2
            //string maxKey = "";
            //int maxValue = int.MinValue;
            //foreach (DictionaryEntry entry in hashtable)
            //{
            //    if ((int)entry.Value > maxValue)
            //    {
            //        maxValue = (int)entry.Value;
            //        maxKey = (string)entry.Key;
            //    }
            //}

            #endregion
            #region 3
            //string target = "apple";
            //bool found = false;
            //foreach (DictionaryEntry entry in hashtable)
            //{
            //    if ((string)entry.Value == target)
            //    {
            //        Console.WriteLine(entry.Key);
            //        found = true;
            //    }
            //}
            //if (!found) Console.WriteLine("Key not found");

            #endregion
            #region 4
            //var map = new Dictionary<string, List<string>>();
            //foreach (var word in words)
            //{
            //    var key = String.Concat(word.OrderBy(c => c));
            //    if (!map.ContainsKey(key))
            //        map[key] = new List<string>();
            //    map[key].Add(word);
            //}

            #endregion
            #region 5
            //HashSet<int> set = new();
            //foreach (int num in arr)
            //{
            //    if (!set.Add(num)) return true;
            //}
            //return false;

            #endregion
            #region 6
            //SortedDictionary<int, string> students = new();
            //students.Add(101, "Alice");
            //students.Remove(101);
            //var name = students[102];

            #endregion
            #region 7
            //SortedList<int, string> employees = new();
            //employees.Add(1, "Ahmed");
            //employees.Add(2, "Sara");
            //foreach (var emp in employees)
            //    Console.WriteLine($"{emp.Key}: {emp.Value}");

            #endregion
            #region 8
            //var fullSet = new HashSet<int>(Enumerable.Range(1, N));
            //var inputSet = new HashSet<int>(arr);
            //fullSet.ExceptWith(inputSet);

            #endregion
            #region 9
            //List<int> nums = new() { 1, 2, 2, 3 };
            //HashSet<int> unique = new(nums);

            #endregion
            #region 10
            //Hashtable swapped = new();
            //foreach (DictionaryEntry entry in hashtable)
            //swapped[(string)entry.Value] = entry.Key;

            #endregion
            #region 11
            //HashSet<int> union = new(set1);
            //union.UnionWith(set2);

            #endregion
            #region 12
            //char target = 'A';
            //int count = dict.Keys.Count(k => k.StartsWith(target));

            #endregion
            #endregion
        }
    }
}