using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _29_EjersClases
{
    internal class CuentaBancaria
    {
        private string titular;
        private double saldo;
        private int numeroDeCuenta;
        public CuentaBancaria()
        {
            this.titular = "No hay titulares";
            this.saldo = 0;
            this.numeroDeCuenta = 0;
        }
        public CuentaBancaria(string titular, double saldo, int numeroDeCuenta)
        {
            this.titular = titular;
            this.saldo = saldo;
            this.numeroDeCuenta = numeroDeCuenta;
        }
        public void SetTitular(string titular)
        {
            this.titular= titular;
        }
        public string GetTitular()
        {
            return this.titular;
        }
        public void SetSaldo(double saldo)
        {
            this.saldo = saldo;
        }
        public double GetSaldo()
        {
            return this.saldo;
        }
        public int GetNumeroDeCuenta()
        {
            return this.numeroDeCuenta;
        }
        public double RetiraDinero(double retiraDinero)
        {
            return this.saldo -= retiraDinero;
        }
        public double IntroducirDinero(double introducirDinero)
        {
            return this.saldo += introducirDinero;
        }


    }
}  
/*
    programa que modele una cuenta bancaria. Cada cuenta tiene un titular, un número de cuenta y un saldo.

    El usuario podrá depositar dinero, retirar dinero y ver la información de la cuenta.

    Crear una clase CuentaBancaria: titular, numero de cuenta, saldo
    Un constructor que reciba el titular, número de cuenta y saldo inicial.

    Propiedades públicas (get/set) para leer el titular y número de cuenta, pero
    El número de cuenta solo debe poder leerse, no modificarse.

    El titular puede modificarse.
 */