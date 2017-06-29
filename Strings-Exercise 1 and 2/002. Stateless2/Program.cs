using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stateless2
{
    class Program
    {
        static void Main(string[] args)
        {
            var state = Console.ReadLine();


            while (state != "collapse")
            {
                var fiction = Console.ReadLine();
                if (state.Contains(fiction))
                {
                    state = state.Replace(fiction, "");
                }
                if (state.Length == 0)
                {
                    Console.WriteLine("(void)");
                }
                else
                {
                    while (fiction.Length > 0)
                    {
                        fiction = fiction.Substring(1, fiction.Length - 2);
                        if (state.Contains(fiction))
                        {
                            state = state.Replace(fiction, "");
                        }
                    }
                }
            }
        }
    }
}
