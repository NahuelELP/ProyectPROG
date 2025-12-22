using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_12_Ejer
{
    internal class Notificacion
    {
        private string nombre; // Se usa?
        private string mensaje;
        public string Nombre { get; set; }
        public string Mensaje { get; set; }

        public Notificacion(string name, string mensaje)
        {
            Nombre = name;
            Mensaje = mensaje;
        }
        public int CantidadMensaje()
        {
            if (!(mensaje == " "))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        } //Cantidad de mensajes
        public virtual void InfoGeneral()
        {
            Console.WriteLine(Nombre +" Te envio un mensaje\nCantidad de mensajes: "+CantidadMensaje());
        }   // Info nombre y cantidad de mensajes
        public string MensajeGuardado() // Muestra el mensaje
        {
            return Mensaje;
        }
    }
}
