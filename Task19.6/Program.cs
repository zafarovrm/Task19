using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19._6
{    
    class Computer
    {
        public int Id { get; set; } //Код
        public string Brand { get; set; } //марка компьютера
        public string ProcessorModel { get; set; } //Тип процессора
        public double ProcessorSpeed { get; set; } //Частота работы процессора
        public int RAM { get; set; } //Объем оперативной памяти
        public int HardDriveCapacity { get; set; } //Объем жесткого диска
        public int VideoMemoryCapacity { get; set; } //Объем памяти видеокарты
        public double Price { get; set; } //Стоимость компьютера в условных единицах
        public int Quantity { get; set; } //Количеством экземпляров, имеющихся в наличии
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> listComputer = new List<Computer>()
            {
                new Computer(){ Id =1, Brand="HP", ProcessorModel="AMD Ryzen 5 4000 Series", ProcessorSpeed=3.7, RAM=12, HardDriveCapacity=512, VideoMemoryCapacity=8192, Price=519.99, Quantity=7},
                new Computer(){ Id =2, Brand="CORSAIR", ProcessorModel="Intel 11th Generation Core i7", ProcessorSpeed=3.7, RAM=32, HardDriveCapacity=1000, VideoMemoryCapacity=8192, Price=2899.99, Quantity =12},
                new Computer(){ Id =3, Brand="Apple", ProcessorModel="Intel 8th Generation Core i5", ProcessorSpeed=3, RAM=8, HardDriveCapacity=256, VideoMemoryCapacity=4000, Price=999.99, Quantity=13},
                new Computer(){ Id =4, Brand="Lenovo", ProcessorModel="Intel 9th Generation Core i5", ProcessorSpeed=1.8, RAM=12, HardDriveCapacity=256, VideoMemoryCapacity=4000, Price=1099.99, Quantity =27},
                new Computer(){ Id =5, Brand="Dell", ProcessorModel="Intel 11th Generation Core i5", ProcessorSpeed=2.6, RAM=12, HardDriveCapacity=1000, VideoMemoryCapacity=3000, Price=689.99, Quantity=32},
                new Computer(){ Id =6, Brand="CyberPowerPC", ProcessorModel="Intel 11th Generation Core i7", ProcessorSpeed=3.6, RAM=16, HardDriveCapacity=1000, VideoMemoryCapacity=8000, Price=1849.99, Quantity=5},
                new Computer(){ Id =7, Brand="CybertronPC", ProcessorModel="AMD Ryzen Threadripper 2000 Series", ProcessorSpeed=3, RAM=128, HardDriveCapacity=5000, VideoMemoryCapacity=12000, Price=17369.99, Quantity=1},
                new Computer(){ Id =8, Brand="Apple", ProcessorModel="Intel Xeon", ProcessorSpeed=3.2, RAM=192, HardDriveCapacity=4000, VideoMemoryCapacity=131072, Price=23199.99, Quantity=2},
                new Computer(){ Id =9, Brand="CLX", ProcessorModel="AMD Ryzen Threadripper 3000 Series", ProcessorSpeed=3.7, RAM=128, HardDriveCapacity=960, VideoMemoryCapacity=11264, Price=7359.99, Quantity=3},
                new Computer(){ Id =10, Brand="MSI", ProcessorModel="Intel 11th Generation Core i7", ProcessorSpeed=3.6, RAM=16, HardDriveCapacity=1000, VideoMemoryCapacity=11000, Price=2099.99, Quantity=5},
            };         

            //есть ли хотя бы один компьютер в количестве не менее 30 штук?

            IEnumerable<Computer> computers = listComputer
                .Where(c => c.Quantity > 30)
                .ToList();
            foreach (Computer c in computers)
                Console.WriteLine($"{c.Id} {c.Brand} {c.ProcessorModel} {c.ProcessorSpeed} {c.HardDriveCapacity} {c.VideoMemoryCapacity} {c.Price} {c.Quantity}");
            Console.ReadKey();
        }
    }
}
}
