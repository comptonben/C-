using System;
using System.Threading;

namespace eventsAndDelegates
{
    public class TextService
    {
        public void OnEmailSent(object source, VideoEventArgs args)
        {
            Console.WriteLine("TextService: recieved email sent confirmation for {0}.", args.Video.Title);
            Console.WriteLine("TextService: Sending a text message...");
            Thread.Sleep(3000);
            Console.WriteLine("TextService: Text message sent.");
        }
    }
}
