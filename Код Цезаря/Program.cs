using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_Цезаря
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string key = "monotonymonotonymonotonymonotonymonotonymonotonymonoto"; //54

            string info ="heaskedmeifiknewwhowasperformingatthetheatreonsaturday"; //54
            List<string> alpha = new List<string>() { "a","b","c", "d","e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o","p","q","r","s","t","u","v","w","x","y","z" };
            char[,] matrix = new char[27 , 27];
            List<string> matrix_s = new List<string>();

            string alpha_s = "";
            for (int i = 0; i < alpha.Count; i++)
            {
                alpha_s += alpha[i];
            }
            matrix_s.Add("#" + alpha_s);


            for (int i = 0; i < alpha_s.Length; i++)
            {
                string line = "";
                string endLine = "";
                for (int j = i; j < alpha_s.Length; j++)
                {
                    line += alpha_s[j];
                }

                for(int k = 0;k < i; k++)
                {
                    endLine += alpha_s[k];
                }

                line += endLine;
                matrix_s.Add(alpha[i]+line);
            }


            for (int i = 0; i < matrix_s.Count; i++)
            {
                Console.WriteLine(matrix_s[i]);
            }


            
            List<int> x_c = new List<int>();

            for(int i = 0; i < key.Length; i++)
            {
                for(int j = 0; j < matrix_s.Count; j++)
                {
                    string line = matrix_s[j];
                    if (line[0].Equals(key[i])){
                        x_c.Add(j);
                    }
                }
            }

           
            Console.WriteLine("______________________________________");
            
            List<int> y_c = new List<int>();
            for(int j=0; j<info.Length;j++)
            {
                
               y_c.Add(matrix_s[0].IndexOf(info[j]));
            }

          

            Console.WriteLine("key "+key.Length);
            Console.WriteLine("info "+info.Length);
            
            Console.WriteLine("rows " + matrix_s.Count);
            Console.WriteLine("columns "+ matrix_s[0].Length);
            Console.WriteLine("y coord "+x_c.Count);
            Console.WriteLine("x coord "+y_c.Count);

            string answer = "";
            for(int i = 0; i < x_c.Count; i++)
            {
                string line = matrix_s[x_c[i]];
                answer += line[y_c[i]];
            }
            Console.WriteLine(answer);
            Console.WriteLine(answer.Length);

            Console.ReadLine();
            
        }
    }
}
