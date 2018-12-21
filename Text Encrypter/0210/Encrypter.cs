using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinMaggieTextEncrypter
{
    class Encrypter
    {
        /**
         * Encrypts text.
         * It encrypts all ascii characters by converting each character to its decimal value, adding 1,
         * converting that value to a 7-bit binary, reversing the binary, get the new decimal value,
         * and uses the new decimal value as the new ascii character to be in the encrypted text.
         * 
         * @param text, text to be encrypted
         * @param isSkipText, checks if the program should include or ignore non-ascii characters
         * @return encrypted text
         */
        public static string EncryptText(string text, bool isSkipText)
        {
            //declare variable
            string newText = "";

            //encrypt each letter in text
            foreach (char letter in text)
            {
                //if character is not a printable ascii character
                if (letter > 127)
                {
                    if (!isSkipText)
                        newText += letter;
                    continue;
                }

                //convert char to integer + 1
                int valueDec = letter + 1;

                //if integer is greater than 127, will start over from 0
                if (valueDec > 127)
                    valueDec = 128 - valueDec;

                //convert decimal value to binary array
                int[] digitsBin = ConvertToBinary(valueDec);

                //reverse binary array
                digitsBin = ReverseIntArray(digitsBin);

                //convert binary to new decimal value
                valueDec = ConvertToDecimal(digitsBin);

                //add to new string
                newText += (char)valueDec;
            }
            return newText;                 //returns encrypted text
        }

        /**
         * Decrypts text.
         * It decrypts all ascii characters by converting each character to its decimal value, 
         * converting that value to a 7-bit binary, reversing the binary, get the new decimal value, subtracting 1,
         * and uses the new decimal value as the new ascii character to be in the decrypted text.
         * 
         * @param text, text to be decrypted
         * @param isSkipText, checks if the program should include or ignore non-ascii characters
         * @return decrypted text
         */
        public static string DecryptText(string text, bool isSkipText)
        {
            //declare variable
            string newText = "";

            //decrypt each letter in text
            foreach (char letter in text)
            {
                if (letter > 127)
                {
                    if (!isSkipText)
                        newText += letter;
                    continue;
                }

                //convert char to integer
                int valueDec = letter;

                //convert decimal value to binary
                int[] digitsBin = ConvertToBinary(valueDec);

                //reverse binary
                digitsBin = ReverseIntArray(digitsBin);

                //convert binary to decimal - 1
                valueDec = ConvertToDecimal(digitsBin) - 1;

                if (valueDec < 0)
                    valueDec = 128 + valueDec;

                //add to new string
                newText += (char)valueDec;
            }
            return newText;                 //returns decrypted text
        }

        /**
         * Reverses an integer array
         * 
         * @param array, array that needs to be reversed
         * @return reversed array
         */
        public static int[] ReverseIntArray(int[] array)
        {
            int[] newArray = new int[array.Length];

            //adds original array values to new array in reverse order
            for (int i = 0; i < array.Length; i++)
                newArray[i] = array[array.Length - i - 1];
            //returns new array
            return newArray;
        }

        /**
         * Converts a binary array to its decimal value
         * 
         * @param digits, the binary array
         * @return decimal value the binary number
         */
        public static int ConvertToDecimal(int[] digits)
        {
            int valueDec = 0;

            //multiply each digit by its place value (powers of 2)
            for (int i = 0; i < digits.Length; i++)
                valueDec += digits[i] * (int)(Math.Pow(2, digits.Length - 1 - i));
            //returns decimal value
            return valueDec;
        }

        /**
         * Converts decimal number smaller than 128 to 7-bit binary array
         * 
         * @param number, to convert to binary number
         * @return a 7-bit binary number, with each digit stored in an array
         */
        public static int[] ConvertToBinary(int number)
        {
            int[] digitsBin = new int[7];
            int[] mod = new int[7];

            //finds binary value by dividing number by highest power of 2 and repeat with remainder
            for (int i = 0; i < digitsBin.Length; i++)
            {
                if (i == 0)
                {
                    //the first digit of the binary array is the number divided by 2^6
                    digitsBin[i] = number / (int)(Math.Pow(2, digitsBin.Length - 1));
                    mod[i] = number % (int)(Math.Pow(2, 6 - i));        //saves the remainder
                }
                else
                {
                    mod[i] = mod[i - 1] % (int)(Math.Pow(2, digitsBin.Length - 1 - i));             //the new remainder is the previous remainder mod the next decreasing power of 2
                    digitsBin[i] = mod[i - 1] / (int)(Math.Pow(2, digitsBin.Length - 1 - i));       //the next digit in the array is the pervious remainder divided by the next decreasing power of 2
                }
            }
            //returns 7-bit array of binary digits
            return digitsBin;
        }

    }
}
