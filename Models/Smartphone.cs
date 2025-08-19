using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_celulares.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string _modelo { get; set; }
        protected string _imei { get; set; }
        protected string _memoria { get; set; }

        //Getters e Setters
        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        public string IMEI
        {
            get { return _imei; }
            set { _imei = value; }
        }

        public string Memoria
        {
            get { return _memoria; }
            set { _memoria = value;}
        }

        //Construtor
        public Smartphone(string numero, string modelo, string imei, string memoria)
        {
            Numero = numero;
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;
        }
        public bool Ligar()
        {
            Console.WriteLine("Ligando...");
            return true;
        }
        public bool ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
            return true;
        }

        public abstract void InstalarAplicativo(string nome);
    }
}