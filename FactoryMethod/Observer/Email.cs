using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Mail;

namespace FactoryMethod.Observer
{
    class Email
    {
        public void send(string email,string model)
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("test28.03.2021@gmail.com", "DAN");
            // кому отправляем
            MailAddress to = new MailAddress(email);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Ожидаемый товар появился в магазине ";
            // текст письма
            m.Body = "Товар "+model+" можно заказать";
            // письмо представляет код html
            m.IsBodyHtml = false;
     

            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("test28.03.2021@gmail.com", "DCe~qMEw9kR%");
            smtp.EnableSsl = true;
            smtp.Send(m);
            Console.Read();

        }
       
    }
}
