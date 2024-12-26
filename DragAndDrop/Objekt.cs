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
        public string MyNamespace { get; set; }
        public ModifikatorPrEnum Modifikator { get; set; }
        public string WhatItIs {  get; set; }
        public string Nazev { get; set; }
        public List<Objekt> Realizace { get; set; }
        public List<Vlastnost> Vlastnosti { get; set; }


    }
}
