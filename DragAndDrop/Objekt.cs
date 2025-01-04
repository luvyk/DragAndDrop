using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragAndDrop
{
    public class Objekt : INamespecable
    {
        public List<string> Usings { get; set; }
        public string MyNamespace { get; set; } //+1
        public ModifikatorPrEnum Modifikator { get; set; }
        public string WhatItIs {  get; set; }
        public string Nazev { get; set; }
        public List<Objekt>? Realizace { get; set; }
        public List<string> RealizaceUvnitr {  get; set; }
        public List<Vlastnost> Vlastnosti { get; set; }
        public string Konstruktor { get; set; }
        public List<Metoda> Metody { get; set; }

        public Objekt()
        {
            Usings = new List<string>();
            MyNamespace = string.Empty;
            Modifikator = ModifikatorPrEnum.IsPublic;
            WhatItIs = "class";
            Nazev = string.Empty;
            Realizace = new List<Objekt>();
            Vlastnosti = new List<Vlastnost>();
            Konstruktor = string.Empty;
            Metody = new List<Metoda>();
            RealizaceUvnitr = new List<string>();
        }
    }
}
