using System;

    // Основной класс
    class Automobile
    {
        // Свойства основного класса
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Конструктор сгд
        public Automobile(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        // Методы основного класса
        public virtual void StartEngine()
        {
            Console.WriteLine("Двигатель автомобиля запущен.");
        }

        public virtual void StopEngine()
        {
            Console.WriteLine("Двигатель автомобиля остановлен.");
        }

        public void Bibipka()
        {
            Console.WriteLine("Сигнал автомобиля: Джага-джага!");
        }
    }

    // Грузовики - наследник Автомобили
    class Truck : Automobile
    {
        public int LoadCapacity { get; set; }

        public Truck(string make, string model, int year, int loadCapacity) : base(make, model, year)
        {
            LoadCapacity = loadCapacity;
        }

        public override void StartEngine()
        {
            Console.WriteLine("Двигатель грузовика запущен.");
        }

        public void CarryCargo()
        {
            Console.WriteLine("Грузовик перевозит груз.");
        }
    }

    // Легковые - наследник Автомобили
    class LegkiyCar : Automobile
    {
        public int DodikiCapacity { get; set; }

        public LegkiyCar(string make, string model, int year, int dodikiCapacity) : base(make, model, year)
        {
            DodikiCapacity = dodikiCapacity;
        }

        public override void StopEngine()
        {
            Console.WriteLine("двигатель легковушки выключен.");
        }

        public void DriveToWork()
        {
            Console.WriteLine("легковушка едет на работу.");
        }
    }

    // Автобусы - наследник Автомобили
    class Bus : Automobile
    {
        public int DodikiCapacity { get; set; }

        public Bus(string make, string model, int year, int dodikiCapacity) : base(make, model, year)
        {
            DodikiCapacity = dodikiCapacity;
        }

        public void PickUpDodikov()
        {
            Console.WriteLine("Автобус подбирает пассажиров.");
        }

        public sealed override void StartEngine()
        {
            Console.WriteLine("Двигатель автобуса запущен.");
        }
    }

    class Program
    {
        static void Main()
        {
            Truck truck = new Truck("КамАЗ", "6520", 2000, 10000);
            LegkiyCar car = new LegkiyCar("Toyota", "Camry", 2023, 5);
            Bus bus = new Bus("Поджопник", "Пазик", 1991, 28);

            truck.StartEngine();
            truck.CarryCargo();
            truck.Bibipka();

            car.StopEngine();
            car.DriveToWork();
            car.Bibipka();

            bus.PickUpDodikov();
            bus.StartEngine();
            bus.Bibipka();
        }
    }