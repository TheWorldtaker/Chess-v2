using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6
{
    public struct PP
    {
        public string name;
        public sbyte pos;
        public string color;
        public bool stat;
        public sbyte id;
        public short cost;
    }
    public class Piece
    {
        public void Move(string name,sbyte ep, sbyte[] pm_king,bool Ok_pm)
        {
            switch (name)
            {
                case "W_KING":
                case "B_KING":
                    for (int j = 0; j < pm_king.Length; j++)
                    {
                        if (ep == pm_king[j])
                        {
                            Ok_pm = true;
                            break;
                        }
                        else if (j == pm_king.Length)
                        {
                            Console.WriteLine("Фигура так не ходит!");
                            Ok_pm = false;
                        }
                    }
                    break;

                    //Move1.Move(tes[i].name, ep, pm_king, Ok_pm);
            }
        }
    }
}
