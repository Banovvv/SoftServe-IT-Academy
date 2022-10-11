using System;

namespace SoftServe_IT_Academy.Tasks._Solid.Task5
{
    public class Invoice
    {
        public long Amount { get; set; }
        public DateTime InvoiceDate { get; set; }
        public void FileLogger()
        {
            // Code for initialization i.e. Creating Log file with specified  
            // details
        }
        public void Add()
        {
            Console.WriteLine("Adding amount...");
            // Code for adding invoice
            // Once Invoice has been added , send mail 
            string mailMessage = "Your invoice is ready.";
            MailSender.SendEmail(mailMessage);
        }
        public void Delete()
        {
            Console.WriteLine("Deleting amount...");
            // Code for Delete invoice
        }
    }
    public interface IFileLogger
    {
        void Info();
        void Check();
        void Debug();
    }
    public class FileLogger : IFileLogger
    {
        public void Check()
        {
            throw new NotImplementedException();
        }

        public void Debug()
        {
            throw new NotImplementedException();
        }

        public void Info()
        {
            throw new NotImplementedException();
        }
    }
    public class MailSender
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public static void SendEmail(string mailMessage)
        {
            Console.WriteLine("Sending Email: {0}", mailMessage);
            // Code for getting Email setting and send invoice mail
        }
    }
}
