using System;
using System.Threading;

namespace eventsAndDelegates
{
    public class MailService
    {
        public event EventHandler<VideoEventArgs> EmailSent;
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MailService: recieved video encoded confirmation for {0}.", args.Video.Title);
            Console.WriteLine("MailService: Sending an email...");
            Thread.Sleep(3000);

            OnEmailSent(args.Video);
        }

        protected virtual void OnEmailSent(Video video)
        {
            EmailSent?.Invoke(this, new VideoEventArgs(){ Video = video});
        }
    }
}
