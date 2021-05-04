//Written by Jiameng Zhou
//3/31/2021
using System;
using System.Collections.Generic;


namespace ExamPart1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Welcome instance = Welcome.GetInstance();
            List<Message> messages = instance.messages; // to get the message list 
            
            foreach(Message message in messages)
            {
                Console.WriteLine(message.newItems);
            }
                

            Console.Read();
        }
    }
}
