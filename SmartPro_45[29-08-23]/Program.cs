using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_45_29_08_23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>()
            {
                25,6,398,-754,521,69,-584,-6,3,9,12,4,-2,84,972
            };

            #region Select
            var list = from a 
                       in sayilar
                       select a;

            
                               
            foreach ( var item in list ) 
            {
                Console.WriteLine( item );
            }
            Console.WriteLine("----------\nListelendi.\n");
            #endregion

            #region Low To High

            var LtH = from s
                      in sayilar
                      orderby s ascending
                      select s;

            Console.WriteLine("Küçükten Büyüğe Sıralama");
            foreach ( var item in LtH ) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------\nListelendi.\n");


            #endregion

            #region High to Low 
            var HtL = from d
                      in sayilar
                      orderby d descending
                      select d;

            Console.WriteLine("Büyükten Küçüğe Sıralama");
            foreach (var item in HtL)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            #endregion

            #region Divisible by Two

            var DbT = from q 
                             in sayilar
                             where q % 2 == 0
                             select q;

            Console.WriteLine("İkiye Bölünebilen Sayılar\n-------------------");
            foreach ( var item in DbT )
            {
                Console.WriteLine(item);
            }

            Console.Write("\n");
            #endregion

            #region Dörde bölünen yediye bölünmeyen küçükten büyüğe

            var question = from t
                           in sayilar
                           where t % 4 == 0 && t % 7 != 0
                           orderby t ascending
                           select t;

            Console.WriteLine("Soru:\n------");
            foreach ( var item in question )
            {
                Console.WriteLine(item);
            }
            #endregion


            #region 3 bölünebilen en büyük en küçük

            var quest = (from l
                        in sayilar
                        where l % 3 == 0
                        orderby l ascending
                        select l).ToList();

            Console.Write("\nEn küçük: {0}", quest[0]);
            Console.WriteLine("\nEn Büyük: {0}", quest[quest.Count-1]);

            quest.Reverse();
            Console.Write("\nEn Büyük: {0}\n", quest[0]) ;
            
            //2 Way

            var questv1 = from r
                          in sayilar
                          where r % 3 == 0
                          select r;

            Console.WriteLine("En büyük: {0}, En Küçük: {1}", questv1.Min(), questv1.Max());





                          #endregion


            Console.ReadKey();
        }
    }
}
