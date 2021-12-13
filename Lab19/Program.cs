using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PC> listPC = new List<PC>()
            {
                new PC(){Id=1, Name="ASUS", ProcType="Intel Core i7", ProcFreq=3.2 , RamCap=32, HddCap=512, VideoCap=16,Cost=400000, Number=3},
                new PC(){Id=2, Name="DELL", ProcType="Intel Core i5", ProcFreq=2.8 , RamCap=16, HddCap=512, VideoCap=8,Cost=250000, Number=1},
                new PC(){Id=3, Name="ACER", ProcType="Intel Core i5", ProcFreq=2.8 , RamCap=8, HddCap=256, VideoCap=6,Cost=200000, Number=6},
                new PC(){Id=4, Name="ASUS", ProcType="Intel Core i3", ProcFreq=2.0 , RamCap=8, HddCap=256, VideoCap=4,Cost=150000, Number=15},
                new PC(){Id=5, Name="ASUS", ProcType="AMD Ryzen 7", ProcFreq=3.0 , RamCap=32, HddCap=1024, VideoCap=8,Cost=270000, Number=4},
                new PC(){Id=6, Name="ACER", ProcType="Intel Core i7", ProcFreq=3.2 , RamCap=16, HddCap=1024, VideoCap=8,Cost=350000, Number=10},
                new PC(){Id=7, Name="ASRock", ProcType="Intel Core i3", ProcFreq=1.8 , RamCap=16, HddCap=512, VideoCap=2,Cost=185000, Number=31},
                new PC(){Id=8, Name="MSI", ProcType="Intel Core i3", ProcFreq=1.8 , RamCap=8, HddCap=256, VideoCap=4,Cost=110000, Number=3},
                new PC(){Id=9, Name="DELL", ProcType="AMD Ryzen 3", ProcFreq=1.8 , RamCap=8, HddCap=256, VideoCap=2,Cost=110000, Number=1},
                new PC(){Id=10, Name="Lenovo", ProcType="AMD Ryzen 5", ProcFreq=2.6 , RamCap=16, HddCap=512, VideoCap=8,Cost=118000, Number=2}
            };

            //Console.WriteLine("Введите тип процессора (Intel Core ix, AMD Ryzen x)");
            //string myProc = Console.ReadLine();
            //IEnumerable<PC> pCs = listPC
            //.Where(d => d.ProcType == myProc)
            //.ToList();

            //Console.WriteLine("Введите объем оперативной памяти(Гб)");
            //int myRam = Convert.ToInt32(Console.ReadLine());
            //IEnumerable<PC> pCs = listPC
            //.Where(d => d.RamCap >= myRam)
            //.ToList();

            //Console.WriteLine("Список по увеличению стоимости");
            //IEnumerable<PC> pCs = listPC
            //.OrderBy(d => d.Cost)
            //.ToList();

            //Console.WriteLine("Список по типу процессора");
            //IEnumerable<PC> pCs = listPC
            //.OrderBy(d => d.ProcType)
            //.ToList();

            //foreach (PC d in pCs)
            //    Console.WriteLine($"{d.Id} {d.Name} {d.ProcType} {d.ProcFreq} {d.RamCap} {d.HddCap} {d.VideoCap} {d.Cost}");

            //Console.WriteLine("Самый дорогой и бюджетный компьютер");
            //int max = listPC.Max(d => d.Cost);
            //int min = listPC.Min(d => d.Cost);
            //Console.WriteLine("Самый дорогой {0}",max);
            //Console.WriteLine("Самый бюджетный {0}",min);

            //Console.WriteLine("Есть ли компьютеры с количеством больше 30ти?");
            //var PCs = listPC
            //    .Any(d => d.Number > 30);
            //if (PCs)
            //{
            //    Console.WriteLine($"Есть компьютеры больше 30 штук");
            //}
            //else
            //{
            //    Console.WriteLine("Нет компьютеров больше 30 штук");
            //}
        }
    }

    class PC
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProcType { get; set; }
        public double ProcFreq { get; set; }
        public int RamCap { get; set; }
        public int HddCap { get; set; }
        public int VideoCap { get; set; }
        public int Cost { get; set; }
        public int Number { get; set; }
    }
}
