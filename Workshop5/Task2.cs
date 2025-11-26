//namespace Workshop5
//{
//    class Vehicle
//    {
//        public string Brand { get; set; }
//        public int Speed { get; set; }

//        public void Start()
//        {
//            Console.WriteLine(Brand + " started.");
//        }

//        public void Stop()
//        {
//            Console.WriteLine(Brand + " stopped.");
//        }

//        public virtual void DisplayInfo()
//        {
//            Console.WriteLine("Brand: " + Brand);
//            Console.WriteLine("Speed: " + Speed);
//        }
//    }

//    class Car : Vehicle
//    {
//        public int Seats { get; set; }

//        public override void DisplayInfo()
//        {
//            base.DisplayInfo();
//            Console.WriteLine("Seats: " + Seats);
//        }
//    }

//    class Motorcycle : Vehicle
//    {
//        public string Type { get; set; }

//        public override void DisplayInfo()
//        {
//            base.DisplayInfo();
//            Console.WriteLine("Type: " + Type);
//        }
//    }
//}

