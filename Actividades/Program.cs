using System;
using System.Runtime.Versioning;

namespace Metodes
{
    class Pr21
    {
        public static void Main()
        {
            string numRom, MsgOutput;
            int num;
            const string MsgInputNumber = "Introdueix un número romà (en majúscules): ";
            const string MsgCorrect = "El número romà {0} equival al número {1}.";
            const string MsgError = "El número romà no és vàlid.";

            do
            {
                Console.Write(MsgInputNumber);
                numRom = Console.ReadLine().ToUpper();
            } while (!ValidateRoman(numRom));

            num = GetNumberFromRoman(numRom);
            MsgOutput = num >= 0 ? MsgCorrect : MsgError;
            Console.WriteLine(MsgOutput, numRom, num);
        }
        public static bool ValidateRoman(string rom)
        {
            bool result = true;
            string[] invalidChains = { "IIII", "VV", "XXXX", "LL", "CCCC",
                                       "DD", "MMMM", "IL", "IC", "ID", "IM", 
                                       "VX", "VL", "VC", "VD", "VM", "XD",
                                       "XM", "LC", "LD", "LM", "DM"};
            foreach (string s in invalidChains)
            {
                result = rom.Contains(s);
            }
            return result;
        }
        public static int GetNumberFromRoman(string numRom)
        {
            const int I = 1, V = 5, X = 10, L = 50, C = 100, D = 500, M = 1000;
            int result = 0;
            char prev = ' ';

            for (int i = numRom.Length - 1; i > -1; i--)
            {

            }
            
            /*
            for (int i = 0; i < numRom.Length; i++)
            {
                if (i > 0)
                {
                    prev = numRom[i - 1];
                }
                switch (numRom[i])
                {
                    case 'I':
                        result += I;
                        break;
                    case 'V':
                        if (prev == 'I')
                        {
                            result += V - (I * 2);
                        } else
                        {
                            result += V;
                        }
                        break;
                    case 'X':
                        if (prev == 'V')
                        {
                            result = -1;
                            i = numRom.Length;
                        } else if (prev == 'I')
                        {
                            result += X - (I * 2);
                        } else
                        {
                            result += X;
                        }
                        break;
                    case 'L':
                        if ((prev == 'V') || (prev == 'I'))
                        {
                            result = -1;
                            i = numRom.Length;
                        }
                        else if (prev == 'X')
                        {
                            result += L - (X * 2);
                        } else
                        {
                            result += L;
                        }
                        break;
                    case 'C':
                        if ((prev == 'V') || (prev == 'I') || (prev == 'L'))
                        {
                            result = -1;
                            i = numRom.Length;
                        }
                        else if (prev == 'X')
                        {
                            result += C - (X * 2);
                        }
                        else
                        {
                            result += C;
                        }
                        break;
                    case 'D':
                        if ((prev == 'V') || (prev == 'I') || (prev == 'L'))
                        {
                            result = -1;
                            i = numRom.Length;
                        }
                        else if (prev == 'C')
                        {
                            result += D - (C * 2);
                        } else
                        {
                            result += D;
                        }
                        break;
                    case 'M':
                        if ((prev == 'V') || (prev == 'I') || (prev == 'L') || (prev == 'D'))
                        {
                            result = -1;
                            i = numRom.Length;
                        }
                        else if (prev == 'C')
                        {
                            result += M - (C * 2);
                        } else
                        {
                            result += M;
                        }
                        break;
                }
            }
            */
            return result;
        }
    }
}