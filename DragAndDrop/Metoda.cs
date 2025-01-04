using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragAndDrop.Odpadky;

namespace DragAndDrop
{
    public class Metoda
    {
        public ModifikatorPrEnum Pristup {  get; set; }
        public string? SpecialStatus { get; set; }
        public string? NavratovaHodnota { get; set; }
        public bool VracimDefinovanyObjekt { get; set; }
        public Objekt? NavratovyObjekt { get; set; }
        public string Nazev {  get; set; }
        public List<string>? Parametry { get; set; }
        public List<Objekt>? ObjektoveParametry { get; set; }
        public string? TeloMetody { get; set; }

        public Metoda()
        {
            Pristup = ModifikatorPrEnum.IsPublic;
            SpecialStatus = string.Empty;
            NavratovaHodnota = "void";
            VracimDefinovanyObjekt = false;
            NavratovyObjekt = null;
            Nazev = string.Empty;
            TeloMetody = string.Empty;
            Parametry = new List<string>();
            ObjektoveParametry = new List<Objekt>();
        }
    }
}
