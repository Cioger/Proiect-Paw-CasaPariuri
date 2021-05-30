using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaPariuri.Model
{
    [Serializable]
    public class Client
    {
        private string nume;
        private int varsta;
        private int telefon;
        private string mail;

        public Client(string nume, int varsta, int telefon, string mail)
        {
            this.Nume = nume;
            this.Varsta = varsta;
            this.Telefon = telefon;
            this.Mail = mail;
        }

        public override string ToString()
        {
            return "Clientul: "+Nume+" cu mailul: "+Mail+" telefonul: "+Telefon+" si varsta: "+Varsta;
        }

        public string Nume { get => nume; set => nume = value; }
        public int Varsta { get => varsta; set => varsta = value; }
        public int Telefon { get => telefon; set => telefon = value; }
        public string Mail { get => mail; set => mail = value; }
    }
}
