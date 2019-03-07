using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_118_encryptions
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class SomeTests
    {
        //Roman Encyption shift each letter in the string up by 13, it is still csae sensitive
        // "Hello" would become "Uryyb"
         public static string RomanEncryption(string encryptMe, int shiftBy)
            {
              char[] message = encryptMe.ToCharArray();
              
               
                for (int i = 0; i < message.Length; i++)
                {
                    char letter = message[i];


                if (letter == ' ')
                {

                }
                else if (letter >= 'a' && letter <= 'm')
                {
                    letter = (char)(letter + shiftBy);

                }
                else if (letter <= 'z' && letter > 'm')
                    {
                        letter = (char)(letter - shiftBy);
                        
                    }
                else if (letter >= 'A' && letter <= 'M')
                {
                    letter = (char)(letter + shiftBy);
                }
                else if (letter <= 'Z' && letter > 'M')
                {
                    letter = (char)(letter - shiftBy);
                }

                message[i] = letter; 
                }

                return new string(message);
         }
            

    public static string RomanDecryption(string encryptMe, int shiftBy)
    {
        char[] message = encryptMe.ToCharArray();


        for (int i = 0; i < message.Length; i++)
        {
            char letter = message[i];


            if (letter == ' ')
            {

            }
            else if (letter >= 'a' && letter < 'm')
            {
                letter = (char)(letter + shiftBy);

            }
            else if (letter < 'z' && letter >= 'm')
            {
                letter = (char)(letter - shiftBy);

            }
            else if (letter >= 'A' && letter < 'M')
            {
                letter = (char)(letter + shiftBy);
            }
            else if (letter < 'Z' && letter >= 'M')
            {
                letter = (char)(letter - shiftBy);
            }

            message[i] = letter;
        }

        return new string(message);
    }

}

}
