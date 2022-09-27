using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    internal class Class1
    {
        public List<int> a = new List<int>();
        int count = 0;
        Random rnd = new Random();
        void Masiv()
        {
            

            if (count <= 10)
            {
                a.Add(rnd.Next(30));
                Console.WriteLine("The {0} number is {1}",count,a[count]);
                count++;
                Masiv();
            }
            else
                return;
           
        }
        int suma = 0;
        int count_1 = 0;
        void MasivSum()
        {
            if(count_1 < count)
            { 
             int[] array = a.ToArray();
            suma += array[count_1];
            count_1++;
            MasivSum();
            }
            else
            Console.WriteLine("Suma -> {0}",suma);

        }
        int count_2 = 0;
        
        void SumaOfNumber()
        {
            int[] new_array = a.ToArray();


            if (count_2 < count)
            {
                int SumOfNumber = 0;

                if (new_array[count_2] > 10)
                {
                    SumOfNumber += new_array[count_2] % 10; 
                    SumOfNumber += new_array[count_2] /= 10; 
                    Console.WriteLine("Suma {0} number == {1}", a[count_2], SumOfNumber);
                    count_2++;
                    SumaOfNumber();
                }
                else
                {
                    Console.WriteLine("Suma {0} number == {1}", a[count_2], new_array[count_2]);
                    count_2++;
                    SumaOfNumber();
                }

            }
            else
            {
                return;
            }



        }

        static void Main()
        {

            
            Class1 c = new Class1();
            c.Masiv();
            c.MasivSum();
            c.SumaOfNumber();
            Console.ReadKey();




        }
    }
}
