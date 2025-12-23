using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _18_12_Ejer
{
    internal class NotificacionEmail : Notificacion
    {
        private string email;
        private string correo;
        private string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        public string Correo
        {
            get 
            {
                return correo;
            }
            set 
            {
                if (Regex.IsMatch(value, patron))
                {
                    correo = value;
                }
                else
                {
                    correo = "Correo invalido";
                }
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = ViaEmail(value);
            }
        }
        public NotificacionEmail(string name, string mensaje, string email, string correo):base(name, mensaje)
        {
            Email = email;
            Correo = correo;
        }

        public string ViaEmail(string email)
        {
            if(email == "si")
            {
                return "si";
            }
            else
            {
                return "Desconocido";
            }
        } // Retorna por strign El correo del remitente
        public override void InfoGeneral()
        {
            Console.WriteLine("{0} Te envio un mensaje\nRemitente via email: {1}\nCantidad de mensajes {2}\nCorreo del remitente: {3}",Nombre, Email, CantidadMensaje(),Correo);
        } // Muestra la info general

    }
}
