using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_12_Ejer
{
    internal class NotificacionEmail : Notificacion
    {
        private bool email; //Se usa?
        private string correo;
        public  string Correo { get; set; }
        public bool Email { get; set; }
        public NotificacionEmail(string name, string mensaje, bool email, string correo):base(name, mensaje)
        {
            Email = email;
            Correo = correo;
        }

        public string ViaEmail()
        {
            if(Email == true)
            {
                return Correo;
            }
            else
            {
                return "Desconocido";
            }
        } // Retorna por strign El correo del remitente
        public override void InfoGeneral()
        {
            Console.WriteLine("{0} Te envio un mensaje\nRemitente via email: {1}\nCantidad de mensajes {2}",Nombre, ViaEmail(), CantidadMensaje());
        } // Muestra la info general

    }
}
