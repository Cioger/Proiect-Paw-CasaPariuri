using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaPariuri.Model
{
    [Serializable]
    public class Pariu
    {
        private string numeClient;
        private float cota;
        private string locatieMeci;
        private int sumaPariata;

        public Pariu(string numeClient, float cota, string locatieMeci, int sumaPariata)
        {
            this.NumeClient = numeClient;
            this.Cota = cota;
            this.LocatieMeci = locatieMeci;
            this.SumaPariata = sumaPariata;
        }

        public override string ToString()
        {
            return "Pariul pus de clientul: "+NumeClient+" are cota: "+Cota+
                " suma pariata: "+SumaPariata+" si este in locatia: "+LocatieMeci;
        }

        public string NumeClient { get => numeClient; set => numeClient = value; }
        public float Cota { get => cota; set => cota = value; }
        public string LocatieMeci { get => locatieMeci; set => locatieMeci = value; }
        public int SumaPariata { get => sumaPariata; set => sumaPariata = value; }
    }
}
