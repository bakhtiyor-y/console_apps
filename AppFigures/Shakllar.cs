
using System.Text;
using ConsoleApps;

namespace Shakl
{
    internal class Shakllar
    {
        public static void RunSelection(int[] flags)
        {
            if (flags[0] == 1)
            {
                Console.Write("Uzunligini kiriting: ");
                flags[2] = Helper.CheckForNumber("1234567890");
                flags[1] = 1;
            }

            if (flags[0] == 2)
            {
                Console.Write("Uzunligini kiriting: ");
                flags[1] = Helper.CheckForNumber("1234567890");
                flags[2] = 1;
            }

            if (flags[0] == 3)
            {
                Console.Write("Uchburchak variantini tanlang (1 yoki 2): ");
                flags[2] = Helper.CheckForDigit("12");

                Console.Write("Uchburchak bo'yini kiriting: ");
                flags[1] = Helper.CheckForNumber("1234567890");

                Console.Write("To'ldirilgan 'x' ni, to'ldirilmagan 'y' bosing: ");
                flags[3] = Helper.CheckForYESorNO("xy");
            }

            if (flags[0] == 4)
            {
                Console.Write("To'rtburchak bo'yini kiriting: ");
                flags[1] = Helper.CheckForNumber("1234567890");

                Console.Write("To'rtburchak enini kiriting: ");
                flags[2] = Helper.CheckForNumber("1234567890");

                Console.Write("To'ldirilgan 'x' ni, to'ldirilmagan 'y' bosing: ");
                flags[3] = Helper.CheckForYESorNO("xy");
            }

            Draw(flags);
        }

        public static void Draw(int[] flags)
        {
            Console.WriteLine();
            for (int i = 0; i < flags[1]; i++)
            {
                var strB = new StringBuilder();
                string strEnd;

                if (!(flags[0] == 3))
                {
                    for (int j = 0; j < flags[2]; j++)
                    {
                        if (flags[3] == 0)
                        {
                            {
                                strB.Append("* ");
                            }
                        }
                    }
                    strEnd = strB.ToString();

                    if (flags[3] == 1)
                    {
                        if (i == 0 || i == flags[1] - 1)
                        {
                            strB.Insert(0, "* ", flags[2]);
                            strEnd = strB.ToString();
                        }
                        else
                        {
                            strEnd = string.Concat("* " + strB.Insert(0, "  ", flags[2] - 2) + "* ");
                        }
                    }
                    Console.WriteLine(strEnd);
                } 
                if(flags[0] == 3)
                {
                    if (flags[2] == 1)
                    {                            
                        if (flags[3] == 1)
                        {
                            if(i == 0 || i == 1 || i == flags[1]-1)
                            {
                                strEnd = string.Concat(new string(' ', flags[1] - 1 - i) + strB.Insert(0, "* ", i + 1));
                            }
                            else
                            {
                                strEnd = string.Concat(new string(' ', flags[1] - 1 - i) + "* " + strB.Insert(0, "  ", i - 1) + "* ");
                            }                                
                        }
                        else
                        {
                            strEnd = string.Concat(new string(' ', flags[1] - 1 - i) + strB.Insert(0, "* ", i + 1));
                        }
                    } 
                    else
                    {
                        if (flags[3] == 1)
                        {
                            if (i == 0 || i == flags[1] - 1)
                            {
                                strEnd = string.Concat(new string(' ', 2 * ((flags[1] - 1) - i)) + strB.Insert(0, "* ", 2 * i + 1));
                            }
                            else
                            {
                                strEnd = string.Concat(new string(' ', 2 * ((flags[1] - 1) - i)) + "* " + strB.Insert(0, "  ", 2 * i - 1) + "* ");
                            }
                        }
                        else
                        {
                            strEnd = string.Concat(new string(' ', 2*((flags[1] - 1) - i)) + strB.Insert(0, "* ", 2*i + 1));
                        }                            
                    }
                    Console.WriteLine(strEnd);
                }
            }
            Console.WriteLine();
        }
    }
}
