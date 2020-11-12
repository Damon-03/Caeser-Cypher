using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaeserCypher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you message"); 
            string message = Console.ReadLine(); // Recieves the Message you want to encode.
            int mesLen = message.Length; // Stores the length of the message in a int.
            string[] messageChar = new string[mesLen]; // Creates an array with the size of the message.
            for(int i = 0; i < mesLen; i++) // Stores the characters in the message into the array.
            {
                messageChar[i] = message[i];
            }
        }
    }
}
