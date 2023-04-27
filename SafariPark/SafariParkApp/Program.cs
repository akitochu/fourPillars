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
            List<Object> gameObjects = new List<object>()
            {
                new Person ("Cathy", "French"),
                new Hunter("Stephano", "Naressi", "Iphone13")
            };
            foreach (var gameObj in gameObjects)
            {
                Console.WriteLine(gameObj);
            }

            Person yolondo = new Person("Yolondo", "Young");
            SpartaWrite(yolondo);

            List<IMovable> list = new List<IMovable>()
            {
                new Person ("Cathy", "French"),
                new Hunter ("Stephano", "Naressi", "Iphone13"),
                //new Airplane (200, 5, "AlghaliFly" )
            };
            foreach (var el in list)
            {
                Console.WriteLine(el.Move());
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