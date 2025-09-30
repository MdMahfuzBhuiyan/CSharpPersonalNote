
using Generics;
using System.Collections;
using System.Diagnostics;

BubbleSort<double> bubbleSort = new BubbleSort<double>([3.3, 1.2, 5.9, 7.7, 3.1, 4.6, 9.2]);
bubbleSort.Sort();

foreach(var item in bubbleSort.Items)
    Console.WriteLine(item);


#region Built-in Generics

List<int> list = new List<int>();
list.Add(3);
list.Add(4);
list.Add(5);

int c = list.Count;

list[0] = 5;
int m = list[2];
list.Remove(3);
list.Clear();

LinkedList<int> l = new LinkedList<int>();
l.AddLast(3);
l.AddFirst(4);

Dictionary<string, int> dic = new Dictionary<string, int>();
dic.Add("asp.net", 50);
dic.Add("C#", 20);

dic["asp.net"] = 45;
int mm = dic["C#"];

HashSet<int> r = new HashSet<int>();
r.Add(5);
r.Add(6);
r.Add(5);


Queue<int> q = new Queue<int>();
q.Enqueue(5);
q.Enqueue(6);

int a1 = q.Dequeue();



Stack<int> st = new Stack<int>();
st.Push(3);
st.Push(4);

int a2 = st.Pop();

PriorityQueue<int, double> a3 = new PriorityQueue<int, double>();

a3.Enqueue(5, 3);
a3.Enqueue(7, 2);
a3.Enqueue(9, 5);

Console.WriteLine(a3.Dequeue());
Console.WriteLine(a3.Dequeue());
Console.WriteLine(a3.Dequeue());

#endregion


#region Non Generic Collections

ArrayList arrayList = new ArrayList();
arrayList.Add(1);
arrayList.Add(2.3);
arrayList.Add(true);
arrayList.Add("hello");

Stack a4 = new Stack();

Queue a5 = new Queue();

Hashtable ht = new Hashtable();
ht.Add("hello", 5);
ht.Add(3, 9);

#endregion

// calculating run time
Stopwatch sw = Stopwatch.StartNew();
sw.Stop();
long v = sw.ElapsedMilliseconds;