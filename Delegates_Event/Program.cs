using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Event
{
    public delegate int delegatefun(int x ,int y);
     class Program
    {public static int addnumber(int f1,int f2)
        {
          return f1 + f2;
            
        }
        static void Main(string[] args)
        {
           // delegatefun x =new delegatefun(a)
           // int delega(int x, int y) { }
        }
    }
}
