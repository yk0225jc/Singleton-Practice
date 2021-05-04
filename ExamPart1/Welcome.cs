//Written by Jiameng Zhou
//3/31/2021
using System;
using System.Collections.Generic;


namespace ExamPart1
{
    public class Welcome
    {
        private static Welcome instance = new Welcome();
        public List<Message> messages = new List<Message>();

        
        private Welcome()//Add the messages to the Constructor 
        {
            for (int i = 0; i < 10; i++)
            {
                messages.Add(new Message("Hello World " + DateTime.Now));
            }
            for (int i = 0; i < 10; i++)
            {
                messages.Add(new Message("Spring Break is soon " + DateTime.Now));
            }
            for (int i = 0; i < 10; i++)
            {
                messages.Add(new Message("GoodBye Mankato " + DateTime.Now));
            }
        }
        public static Welcome GetInstance()
        {
            return instance;
        }



    }
}


