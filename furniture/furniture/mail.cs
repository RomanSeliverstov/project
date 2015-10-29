using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;


namespace furniture
{
    class mail
    {
      
        
        public void SendMail(string email)
        {
            var client = new SmtpClient("smtp.yandex.ru");
            client.Credentials = new NetworkCredential("nokianzor@yandex.ru", "nokian2h2900n");
            client.Port = 587;
            client.EnableSsl = true;
            MailMessage Message = new MailMessage();
            client.Send("nokianzor@yandex.ru","Kristenka93@mail.ru", "asdad","some text");

        }
    }
}
