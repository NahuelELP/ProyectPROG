using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_12_Ejer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notificacion noti = new Notificacion("Nahuel", "Hola como estas?");
            NotificacionEmail notiEmail = new NotificacionEmail(noti.Nombre , noti.Mensaje, "si","nahuellassos90@gmail.com");
            NotificacionSms notiSms = new NotificacionSms(noti.Nombre, noti.Mensaje, "si", "+351 937874448");
            
            noti.InfoGeneral();
            Console.WriteLine("--------------");
            notiEmail.InfoGeneral();
            Console.WriteLine("--------------");
            notiSms.InfoGeneral();
        }
    }
}
