using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _18_12_Ejer
{
    internal class NotificacionSms : Notificacion
    {
        private string sms;
        private string numero;
        private string patron = @"^\+351\s?\d{9}$";
        public string Sms { 
            get 
            {
                return sms;
            }
            set
            {
                sms = ViaSms(value);
            }
        }
        public string Numero { 
            get 
            {
                return numero;
            }
            set 
            { 
                numero = ValidarNumero(value);
            }
        }
        public NotificacionSms(string name, string mensaje, string sms, string numero) : base(name, mensaje)
        {
            Sms = sms;
            Numero = numero;
        }
        public string ViaSms(string validarSms)
        {
            if (validarSms == "si")
            {
                return "Si";
            }
            else
            {
                return "Desconocido";//que no retorne 0
            }
        }
        public string ValidarNumero(string numeroValidar)// Metodo validar Numeros portugueses +351.937.874.448
        {
            if(Regex.IsMatch(numeroValidar, patron))
            {
                return numeroValidar;
            }
            else
            {
                return "Numero no valido";
            }
        }
        public override void InfoGeneral()
        {
            Console.WriteLine("{0} Te envio un mensaje\nRemitente via SMS: {1}\nCantidad de mensajes {2}\nNumero: {3}", Nombre, Sms, CantidadMensaje(), Numero);
        }
    }
}
