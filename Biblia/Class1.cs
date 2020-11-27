using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_9
{
    public class Class
    {
        public static int Summ (int n, TextBox TextBox3)
        {
            int Rez = 0, k;
            Random rnd = new Random();
            for (int i = 0; i<n; i++)
            {
                k = rnd.Next(2, 14);
                TextBox3.Text += k + " ";
                if (k > 8) Rez = Rez + k;
            }
            return Rez;
        }
    }
}
