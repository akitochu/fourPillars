using System.Net.Cache;
using System.Runtime.CompilerServices;

namespace SafariParkApp
{
    internal class Program 
    {
        //static void Main(string[] args)
        //{
        //    //Person joe = new Person("Joe", "McCann", 40);
        //    //Console.WriteLine(joe.GetFullName());
        //    //Person nish = new("Nish", "Mandal", 52);
        //    //Console.WriteLine(nish.GetFullName());
        //    //Person martin = new Person("Martin");
        //    //Person michael = new Person("Michael", "Flynn");
        //    //michael.Age = 32;
        //    //Console.WriteLine(michael.Age);
        //    //michael.Age = 100;
        //    //Console.WriteLine($"{michael.FirstName} is Michael's first name");
        //    var alex = new Person("Alex", "Blunt") { Age = 31 };
        //    var list = new ShoppingList() { Bread = 2, Potato = 6, Milk = 2 };
        //    var manvir = new Person() { FirstName = "Manvir", LastName = "Nandra", Age = 25};
        //    Point3D p = new Point3D(3, 6, 2);
        //    var p2 = new Point3D();
        //    Point3D p3;
        //    Point3D p4 = new Point3D(1, 7);
        //    Person akito = new Person("Akito", "Oyama") { Age = 20 };
        //    Point3D pt3D = new Point3D ( 5, 2, 3 );
        //    DemoMethod(pt3D, akito);
        //}
        static void Main(string[] args)
        {
            //Hunter h = new Hunter("Marion", "Jones", "Leica") { Age = 32 };
            ////Console.WriteLine(h.Age);
            ////Console.WriteLine(h.Shoot());
            //var h2 = new Hunter("Marion", "Jones", "Leica") { Age = 32 };
            //Console.WriteLine($"h Equals h2? {h.Equals(h2)}");
            //Console.WriteLine($"h HashCode: {h2.GetHashCode}");
            //Console.WriteLine($"h Type: {h2.GetType()}");
            //Console.WriteLine($"h ToString: {h.ToString()}");
            //Console.WriteLine($"h: {h}");
            //var rect = new Rectangle(4, 3);
            //Console.WriteLine(rect);
            //Camera iPhone = new Camera("Apple");

            //List<Object> gameObjects = new List<object>()
            //{
            //    new Person ("Cathy", "French"),
            //    new Hunter("Stephano", "Naressi", iPhone)
            //};
            //foreach (var gameObj in gameObjects)
            //{
            //    Console.WriteLine(gameObj);
            //}

            //Person yolondo = new Person("Yolondo", "Young");
            //SpartaWrite(yolondo);

            //List<IMovable> list = new List<IMovable>()
            //{
            //    new Person ("Cathy", "French"),
            //    new Hunter ("Stephano", "Naressi", iPhone),
            //    //new Airplane (200, 5, "AlghaliFly" )
            //};
            //foreach (var el in list)
            //{
            //    Console.WriteLine(el.Move());
            //}


            //List<IShootable> weaponsList = new List<IShootable>
            //{
            //    new LaserGun("zapper"),
            //    new WaterPistol("moisteriser"),
            //    new Hunter("Stephano", "Naressi", iPhone),
            //    new Camera("Nikon")
            //};

            //foreach (var gun in weaponsList)
            //{
            //    Console.WriteLine(gun.Shoot());
            //}

            //Console.WriteLine("Polymorphic shootout");
            //Camera pentax = new Camera("Pentax");
            //WaterPistol pistol = new WaterPistol("Supersoaker");
            //LaserGun laserGun = new LaserGun("Acme");
            //Hunter nish = new Hunter("Nish", "Mandal", pentax);
            //Console.WriteLine(nish.Shoot());
            //nish.Shooter = pistol;
            //Console.WriteLine(nish.Shoot());
            //nish.Shooter = laserGun;
            //Console.WriteLine(nish.Shoot());
            //nish.Shooter = pistol;
            //Console.WriteLine(nish.Shoot());


            //var robOne = new Person("Bob", "Sponge") { Age = 20 };
            //var robTwo = robOne;
            //var areSame = robOne.Equals(robTwo);  //true
            //Console.WriteLine(areSame);

            //var robThree = new Person("Robert", "Sponge") { Age = 20 };
            //var areSameOneThree = robOne.Equals(robThree);  // false
            //Console.WriteLine(areSameOneThree);

            //List<Person> personList =
            //    new List<Person>
            //    {
            //        new Person("Bobert", "Sponge"),

            //        new Person("Sandy", "Cheeks"){Age = 25},

            //        new Person("Robert", "Sponge") { Age = 20 },

            //        new Person("Squilliam", "Squid"){Age = 32}
            //    };
            //var hasRob = personList.Contains(robThree); //false
            //Console.WriteLine(hasRob);

            //var equals = robOne == robThree;
            //var notEquals = robOne != robThree;

            //personList.Sort();
            //foreach (var person in personList)
            //{
            //    Console.WriteLine(person);
            //}
            //Console.WriteLine(personList[0].CompareTo(personList[1]));
            //Console.WriteLine(personList[0].CompareTo(personList[0]));
            //Console.WriteLine(personList[1].CompareTo(personList[0]));

            //Collections Lesson

            Camera cam = new Camera("MacBeth");
            var helen = new Person { FirstName = "Helen", LastName = "Troy", Age = 22 };
            var will = new Hunter("William", "Shakespeare", cam) { Age = 457 };
            Console.WriteLine("List of people");
            List<Person> thePeople = new List<Person> { helen, will };

            foreach(var person in thePeople)
            {
                Console.WriteLine(person);
            }

            var numbers = new List<int>() { 5, 4, 3, 9, 0 };
            numbers.Add(8);
            numbers.Sort();
            numbers.RemoveRange(1,2);
            numbers.Insert(2, 1);
            numbers.Reverse();
            numbers.Remove(9);
            var output = "";
            foreach(int num in numbers)
            {
                Console.Write(num);
            }

            Console.WriteLine("linkedList of People");
            LinkedList<Person> thePeopleLinked = new LinkedList<Person>();
            thePeopleLinked.AddFirst(helen);
            thePeopleLinked.AddLast(will);
            thePeopleLinked.AddLast(new Person { FirstName = "Linda", LastName = "Smith", Age = 45 });
            thePeopleLinked.AddAfter(thePeopleLinked.Find(helen) , new Person { FirstName = "John", LastName = "Green", Age = 2}); 
            foreach(var person in thePeopleLinked)
            {
                Console.WriteLine(person);
            }

            var myQueue = new Queue<Person>();
            myQueue.Enqueue(helen);
            myQueue.Enqueue(will);
            myQueue.Enqueue(new Person("Cathy"));
            Console.WriteLine("\nQueue");
            foreach(var q in myQueue)
            {
                Console.WriteLine(q);
            }
            var first = myQueue.Peek();
            var serve = myQueue.Dequeue();

            int[] original = new int[] { 1, 2, 3, 4, 5 };
            int[] reversed = new int[] { original.Length };
            var stack = new Stack<int>();
            foreach(var n in original)
            {
                stack.Push(n);
            }
            Console.WriteLine("\nStack");
            foreach (var s in stack)
            {
                Console.WriteLine(s);
            }

            //for(int i=0; i<original.Length; i++)
            //{
            //    reversed[i] = stack.Pop();
            //}

            var peopleSet = new HashSet<Person>
            {
                helen, new Person("Jasmine"), new Person("Andrei")
            };
            Console.WriteLine("\nHashSet");
            foreach(var entry in peopleSet)
            {
                Console.WriteLine(entry);
            }

            var successMartin = peopleSet.Add(new Person { FirstName = "Martin", LastName = "Beard" });
            var successHelen = peopleSet.Add(new Person { FirstName = "Helen", LastName = "Troy", Age = 22 });

            //wont add if matching hashcode entity tries to get added.

            var morePeople = new HashSet<Person> { new Person("Cathy"), new Person("Jasmine") };
            peopleSet.IntersectWith(morePeople);

            var personDict = new Dictionary<string, Person>
            {
                {"helen", helen },
                {"Sherlock", new Person("Sherlock", "Jones"){Age = 40} }
            };

            //var p = personDict["sherlock"];
            personDict.Add("will", will);

            string input = "The cat in the hat comes back";
            input = input.Trim().ToLower();
            var countDict = new Dictionary<char, int>();
            foreach(var c in input)
            {
                if(countDict.ContainsKey(c))
                {
                    countDict[c]++;
                }
                else
                {
                    countDict.Add(c, 1);
                }
            }
            Console.WriteLine("Dictionary problem");
            foreach(var entry in countDict)
            {
                Console.WriteLine(entry);
            }

            Console.WriteLine("\nKeys");
            foreach(var key in countDict.Keys)
            {
                Console.WriteLine(key + " ");
            }
            Console.WriteLine("\nValues");
            foreach(var value in countDict.Values)
            {
                Console.WriteLine(value);
            }




        }

        public static void SpartaWrite(Object obj)
        {
            Console.WriteLine(obj.ToString());
            if (obj is Hunter)
            {
                var hunterObj = (Hunter)obj;
                Console.WriteLine(hunterObj.Shoot);
            }
        }

        static void DemoMethod(Point3D pt, Person p)
        {
            pt.y = 1000;
            p.Age = 92;
        }
    }
}