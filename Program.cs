using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PR7_1_Халле
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Furniture[] furniture = new Furniture[4];
            Table tt = new Table();
            tt.Name = "Круглый стол";
            tt.weight = 30;
            tt.classif = "Тип: " + Furniture.Classification.Стол;

            BTYFF btyff = new BTYFF();
            btyff.Name = "Качественная двухместная кровать";
            btyff.weight = 45;
            btyff.classif = "Тип: " + Furniture.Classification.Красивая_мебель;

            Wardrobe wrd = new Wardrobe();
            wrd.Name = "Высокий шкаф";
            wrd.weight = 60;
            wrd.classif = "Тип: " + Furniture.Classification.Шкаф;

            Untitled untitled = new Untitled();

            furniture[0] = tt;
            furniture[1] = btyff;
            furniture[2] = wrd;
            furniture[3] = untitled;

            for (int i = 0; i < furniture.Length; i++)
            {
                Console.WriteLine(furniture[i].Name);
                Console.WriteLine("Вес: " + furniture[i].weight);
                Console.WriteLine(furniture[i].classif + "\n");
            }
            Console.ReadKey();
            
        }
        class Furniture
        {   
            public Furniture()
            {
                Name = "Без названия";
                Weight = 0;
                classif = "Без названия";
            }
            
            private int Weight { get; set; }
            /// <summary>
            /// Вес
            /// </summary>
            public string Name { get; set; }
            /// <summary>
            /// Название мебели
            /// </summary>
            public string classif { get; set; }
            /// <summary>
            /// Тип мебели
            /// </summary>
            public int weight
            {
                get => Weight;
                set => Weight = value;
            }
            public enum Classification
            {
                Стол, Шкаф, Красивая_мебель
                
            }
        }
        class Table : Furniture
        {

        }
        class BTYFF : Furniture
        {

        }
        class Wardrobe : Furniture
        {

        }
        class Untitled : Furniture
        {

        }

    }
}