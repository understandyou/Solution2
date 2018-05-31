using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Net.Mail;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //MailMessage mailMessage = new MailMessage("fengyuyjiu@163.com", "understandyou9958@qq.com", "head", "body");
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.163.com";
            //smtpClient.UseDefaultCredentials = true;
            smtpClient.Credentials = new System.Net.NetworkCredential("fengyuyjiu", "emailkey123");
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add("understandyou9958@qq.com");
            mailMessage.SubjectEncoding = Encoding.UTF8;
            mailMessage.BodyEncoding = Encoding.UTF8;
            mailMessage.Subject = "the is tou";
            mailMessage.Body = "the is body";
            mailMessage.IsBodyHtml = false;
            mailMessage.From = new MailAddress("fengyuyjiu@163.com");
            mailMessage.Priority = MailPriority.Normal;

            try
            {
                smtpClient.Send(mailMessage);
                Console.WriteLine("ok");

            }
            catch (Exception ex)
            {
                Console.WriteLine("errot："+ex.ToString());
            }
            Console.ReadLine();
            //byte[] result = new byte[1024];
            //Socket sk = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //try
            //{
            //    sk.Connect("127.0.0.1", 3256);
            //    int rec = sk.Receive(result);

            //    Console.WriteLine(Encoding.UTF8.GetString(result,0,rec));
            //    Console.ReadKey();
            //    sk.Close();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("message:"+ex.Message);
            //}

        }
    }
}
