using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragAndDrop.Odpadky;

namespace DragAndDrop
{
    public class Vlastnost
    {
        public ModifikatorPrEnum Modifikator { get; set; }
        public bool JeDatTypSlozeny { get; set; }
        //public string? DatovyTyp { get { return "nasrat"; } set { } }
        public string? DatovyTyp { get; set; }
        public string Nazev { get; set; }
        public string Getter { get; set; }
        public string Setter { get; set; }
        public Objekt? KompozicneAgregacniVztah {  get; set; }
        public bool? Multiplicita {  get; set; }
        public TypVztahu? TypVztahu { get; set; }

        public Vlastnost()
        {
            Modifikator = ModifikatorPrEnum.IsPublic;
            JeDatTypSlozeny = false;
            DatovyTyp = string.Empty;
            Nazev = string.Empty;
            Getter = string.Empty;
            Setter = string.Empty;
            KompozicneAgregacniVztah = null;
            TypVztahu = null;
            Multiplicita = null;
        }

    }
}
