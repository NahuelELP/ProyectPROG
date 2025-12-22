using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_12_Ejer
{
    internal class NotificacionSms : Notificacion
    {
        private bool sms;
        private int numero; //Se usa?
        public bool Sms { get; set; }
        public int Numero { get; set; }
        public NotificacionSms(string name, string mensaje, bool sms, int numero) : base(name, mensaje)
        {
            Sms = sms;
            Numero = numero;
        }
        // Metodo validar Numeros portugueses +351
        public int ViaSms()
        {
            if (Sms == true)
            {
                return Numero;
            }
            else
            {
                return 0;//que no retorne 0
            }
        }
        public override void InfoGeneral()
        {
            Console.WriteLine("{0} Te envio un mensaje\nRemitente via SMS: {1}\nCantidad de mensajes {2}", Nombre, ViaSms(), CantidadMensaje());
        }
    }
}
