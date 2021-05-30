using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaPariuri.Model
{
    [Serializable]
    public class Meci
    {
        private string locatie;
        private string echipaAcasa;
        private string echipaDeplasare;
        private int durata;

        public Meci(string echipaAcasa, string echipaDeplasare, int durata, string locatie)
        {
            this.EchipaAcasa = echipaAcasa;
            this.EchipaDeplasare = echipaDeplasare;
            this.Durata = durata;
            this.Locatie = locatie;
        }

        public override string ToString()
        {
            return "Meciul din: "+Locatie+" cu durata: "+Durata+" a fost jucat de: "
                +EchipaAcasa+" impotriva "+EchipaDeplasare;
        }

        public string EchipaAcasa { get => echipaAcasa; set => echipaAcasa = value; }
        public string EchipaDeplasare { get => echipaDeplasare; set => echipaDeplasare = value; }
        public int Durata { get => durata; set => durata = value; }
        public string Locatie { get => locatie; set => locatie = value; }
    }
}
