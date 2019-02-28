using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToCS_Assignment_3
{
    
    /*Objective:
    Write a program to input Valid Alphabet and Valid String and then 
    determine the Length of the string and also print the reverse string.*/

    class Program
    {
        public static string[] ElementsOfAlphabet(string str, string[] array)     //For seprating elements of alphabet by ','
        {
            array = str.Split(',');
            return array;
        }
        public static int NumberOfElementsIn(string str)      //This counts the number of elements in Alphabet
        {
            int i,count = 1;
            for (i = 0; i < str.Length; i++)
                if (str[i] == ',')
                    count++;
            return count;
        }

        static void Main(string[] args)
        {
            int length=0,tem;
            string temp,RevString="";
            string[] RevStringArray=new string[50];

            Console.Write("Enter Valid Alphabet = { ");     
            string Alphabet = Console.ReadLine();           //Take Alphabet input
            Console.Write("\nEnter Valid String : ");       
            string str = Console.ReadLine();                //Take String input

            int size = NumberOfElementsIn(Alphabet);
            string[] array = new string[size];              //array of required size is initialized
            array = ElementsOfAlphabet(Alphabet, array);    //Now array conatains elements of Alphabet
            for(int i = 0; i < str.Length;)                 //This is the main loop
            {
                for(int j = 0; j < size; j++)               //This loop finds the element of Alphabet in String
                {
                    if (i >= str.Length)
                        break;
                    temp = array[j];                        //temp contains the element of Alphabet
                    if (str[i] == temp[0])                  
                    {
                        RevStringArray[length] = temp;      //Storing the tokens of string in RevStringArray 
                        i = i + temp.Length;                //i starts from 0 and will increment it self in a way...
                                                                //that it point to next token in string
                        length++;                           //This count the number of tokens in string
                    }
                }
            }
            for(int i = length; i >=0; i--)
            {
                RevString = RevString + RevStringArray[i];    //we concatnate the token of string with empty string in reverse order
            }
            Console.WriteLine("\n\nLength : " + length);
            Console.WriteLine("Reverser String : "+ RevString);
            Console.ReadKey();
        }
    }
}
