Sean's data structs in c#


* Dictionary

```
Dictionary<string, int> myDictionary = new Dictionary<string, int>();
myDictionary.Add("one", 1);
int myInt = myDictionary["one"];
List<string> keyList = myDictionary.Keys.ToList();

```

* Hash table/Hash Map

    * faster than dictionary, doesnt keep order
    * data isnt typed

```
Hashtable myTable = new Hashtable();
myTable.Add("333-44-55555", "Jisun");
var contains = myTable.ContainsKey("111-22-3333");
string empName = (string) myTable["111-22-3333"];
```


* Hash set

    *  does not allow dupes, unlike list

```
HashSet<int> mySet = new HashSet<int>();
mySet.Add(3);
mySet.Add(3); // will still only have 1 element
```

* List
````
List<int> nums = new List<int>();
nums.Add(1);
nums[0] = 10;
int count = nums.Count;
int index = nums.BinarySeach(1);
bool contains = nums.Contains(1);
int[] found = nums.Find(x => x == 1);
bool any = nums.Any(x => x == 1);
var index = nums.IndexOf(1);
arr.Insert(2, "1834");
var removed = nums.Remove("193")
nums.RemoveAt(0);
nums.Reverse();
nums.Sort();
parts.Sort(delegate(Part x, Part y)
{
    return y.Val - x.Val;     
});
````

* Linked List

    * doubly linked list
```
LinkedList<string> sentence = new LinkedList<string>();
string f = sentence.First;
string f = sentence.Last;
string f = sentence.Count;
sentence.AddFirst("eer");
sentence.AddLast("eer");
sentence.RemoveFirst("eer");
sentence.RemoveLast("eer");
```

* Array

````
var booleanArray = new bool[10];
var arrayName = new arrayType[allocationSize];
````

* Queue

    * Can use List and just push front and remove at back
    * Or use Queue class

```
Queue<string> numbers = new Queue<string>();
numbers.Enqueue("one");
var val = numbers.Dequeue();
var val = numbers.Peek();
```

* Stack
    * Can use List and just push front and remove at front
    * Or use Stack class

```
Stack<string> numbers = new Stack<string>();
numbers.Push("one");
var val = numbers.Pop();
var val = numbers.Peek();
```

* Min Heap
    
    * Just do a sortedList or SortedDictionary, it should have min at front

* Max Heap
    * Just do a sortedList or SortedDictionary, it should have max at back

* Priority Queue
    * Just do a sortedList or SortedDictionary, it should have min at front
    * make the compare func look at pri in the object 

* Binary tree

* AVL/self balancing tree

    * SortedSet<T> is implemented using a self-balancing red-black tree that gives a performance complexity of O(log n) for insert, delete, and lookup. It is used to keep the elements in sorted order, to get the subset of elements in a particular range, or to get the Min or Max element of the set.

* String builder

    * Use this to add up strings faster, internally a char []
```
StringBuilder sb = new StringBuilder();
sb.Append("This is the beginning of a sentence, ");
sb.Replace("the beginning of ", "");
sb.Insert(sb.ToString().IndexOf("a ") + 2, "complete ");
sb.Replace(",", ".");
Console.WriteLine(sb.ToString());
```

* SortedList and SortedDictionary

    * SortedList uses less memory than SortedDictionary.
    * SortedDictionary has faster insertion and removal operations for unsorted data, O(log n) as opposed to O(n) for SortedList.
    * If the list is populated all at once from sorted data, SortedList is faster than SortedDictionary.

```
SortedList<string, string> openWith = 
            new SortedList<string, string>();
openWith.Add("txt", "notepad.exe");
SortedList<int, int> openWith = 
            new SortedList<int, int>(delegate(int x, int y)
{
    return y - x;     
});

bool contains = openWith.ContainsKey("txt");
bool removed = openWith.Remove("txt");
var found = openWith.TryGetValue("txt", out val);
```
