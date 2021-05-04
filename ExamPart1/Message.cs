//Written by Jiameng Zhou
//3/31/2021

namespace ExamPart1
{
    public class Message
    {
        public string newItems;

        public Message(string newItems)
        {
            this.newItems = newItems;
        }
        public string NewsItem
        {
            get
            {
                return this.newItems;
            }
            set
            {
                this.newItems = value;
            }
        }
    }
}
