using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using DragAndDrop.Odpadky;

namespace DragAndDrop
{
    public partial class Nastaveni : Form
    {
        private Canvas _canvas;
        public Nastaveni(Canvas canvas)
        {
            InitializeComponent();
            _canvas = canvas;
        }

        private void Uloz_Click(object sender, EventArgs e)
        {
            List<Objekt> list = new List<Objekt>();

            foreach (Box x in _canvas._boxes)
            {
                list.Add(x._text);
            }

            foreach (Objekt o in list)
            {
                foreach (Vlastnost v in o.Vlastnosti)
                {
                    if (v.KompozicneAgregacniVztah != null)
                    {
                        string staryNazev = v.KompozicneAgregacniVztah.Nazev;
                        v.KompozicneAgregacniVztah = new Objekt();
                        v.KompozicneAgregacniVztah.Nazev = staryNazev;
                    }
                }
                foreach (Metoda m in o.Metody)
                {
                    if (m.NavratovyObjekt != null)
                    {
                        string staryNazev = m.NavratovyObjekt.Nazev;
                        m.NavratovyObjekt = new Objekt();
                        m.NavratovyObjekt.Nazev = staryNazev;
                    }

                    for (int i = 0; i < m.ObjektoveParametry.Count; i++)
                    {
                        string staryNazev = m.ObjektoveParametry[i].Nazev;
                        m.ObjektoveParametry[i] = new Objekt();
                        m.ObjektoveParametry[i].Nazev = staryNazev;
                    }

                }
            }

            string json = JsonSerializer.Serialize(list);

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog(); // Nastavení vlastností dialogu
            folderBrowserDialog.Description = "Vyberte složku";
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog.ShowNewFolderButton = true;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;
                int countOfFiles = Directory.GetFiles(folderPath).Count();

                File.WriteAllText(folderPath + $"\\Save - {countOfFiles}.json", json);
            }
        }

        private void Nacti_Click(object sender, EventArgs e)
        {
            _canvas._boxes.Clear();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = openFileDialog.FileName;
                string JsonFile = File.ReadAllText(folderPath);

                List<Objekt> x = JsonSerializer.Deserialize<List<Objekt>>(JsonFile);
                List<Box> boxy = new List<Box>();
                foreach (Objekt o in x) //-----------------------
                {
                    foreach (Vlastnost v in o.Vlastnosti)
                    {
                        if (v.KompozicneAgregacniVztah != null)
                        {
                            string staryNazev = v.KompozicneAgregacniVztah.Nazev;
                            Objekt staryObjekt = x.FirstOrDefault(p => p.Nazev == staryNazev);
                            v.KompozicneAgregacniVztah = staryObjekt;
                        }
                    }
                    foreach (Metoda m in o.Metody)
                    {
                        if (m.NavratovyObjekt != null)
                        {
                            string staryNazev = m.NavratovyObjekt.Nazev;
                            //m.NavratovyObjekt = new Objekt();
                            //m.NavratovyObjekt.Nazev = staryNazev;
                            Objekt staryObjekt = x.FirstOrDefault(p => p.Nazev == staryNazev);
                            m.NavratovyObjekt = staryObjekt;
                        }

                        for (int i = 0; i < m.ObjektoveParametry.Count; i++)
                        {
                            string staryNazev = m.ObjektoveParametry[i].Nazev;
                            //m.ObjektoveParametry[i] = new Objekt();
                            //m.ObjektoveParametry[i].Nazev = staryNazev;
                            Objekt staryObjekt = x.FirstOrDefault(p => p.Nazev == staryNazev);
                            m.ObjektoveParametry[i] = staryObjekt;
                        }
                    }
                }
                foreach (Objekt o in x)
                {
                    Box b = new Box(10, 10,_canvas);
                    b._text = o;
                    boxy.Add(b);
                }
                _canvas._boxes = boxy;
            }
        }
        public string PrevedModPrNaText(ModifikatorPrEnum enumerator)
        {
            string znak = "";
            switch (enumerator)
            {
                case ModifikatorPrEnum.IsInternal:
                    znak = "internal";
                    break;
                case ModifikatorPrEnum.IsPrivate:
                    znak = "private";
                    break;
                case ModifikatorPrEnum.IsPublic:
                    znak = "public";
                    break;
                case ModifikatorPrEnum.IsProtected:
                    znak = "protected";
                    break;
            }
            return znak;

        }
        private void GenerujKod_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Box box in _canvas._boxes)
            {
                foreach(string s in box._text.Usings)
                {
                    sb.Append($"using {s};\r");
                }
                sb.Append("\r");
                sb.Append($"namespace {box._text.MyNamespace} \r");
                sb.Append("{ \r");
                string text = PrevedModPrNaText(box._text.Modifikator);
                sb.Append($"{text} {box._text.WhatItIs} {box._text.Nazev}");
                try
                {
                    List<string> strings = new List<string>();
                    if (box._text.Realizace.Count > 0)
                    {
                        for (int i = 0; i < box._text.Realizace.Count; i++)
                        {
                            strings.Add(box._text.Realizace[i].Nazev);
                        }
                    }
                    if (box._text.RealizaceUvnitr.Count > 0)
                    {
                        for (int i = 0; i < box._text.RealizaceUvnitr.Count; i++)
                        {
                            strings.Add(box._text.RealizaceUvnitr[i]);
                        }
                    }
                    for (int i = 0; i < strings.Count; i++)
                    {
                        if(i == 0)
                        {
                            sb.Append($" : {strings[0]}");
                        }
                        else
                        {
                            sb.Append($", {strings[i]}" );
                        }
                    }
                    sb.Append('\r');
                    
                } catch { }

                sb.Append("{ \n");
                foreach(Vlastnost vlastnost in box._text.Vlastnosti)
                {
                    string text1 = PrevedModPrNaText(vlastnost.Modifikator);
                    sb.Append($" {text1} ");
                    
                        sb.Append($" {vlastnost.DatovyTyp} ");
                    
                    
                    sb.Append($" {vlastnost.Nazev} " + "{" + $" {vlastnost.Getter} {vlastnost.Setter} " + "} \r");
                }
                sb.Append("\r");
                sb.Append($"public {box._text.Nazev}() \r");
                sb.Append("{} \r");
                sb.Append('\n');
                foreach(Metoda m in box._text.Metody)
                {
                    string text1 = PrevedModPrNaText(m.Pristup);
                    sb.Append($"{text1} ");
                    if(m.NavratovaHodnota !="")
                    {
                        sb.Append($" {m.NavratovaHodnota} ");
                    }
                    else
                    {
                        sb.Append($" {m.NavratovyObjekt.Nazev} ");
                    }
                    sb.Append($" {m.Nazev} (");
                    int pocitadlo = 0;
                    foreach(var x in m.Parametry)
                    {
                        sb.Append($" {x} _{pocitadlo}, ");
                        pocitadlo++;
                    }
                    foreach(var x in m.ObjektoveParametry)
                    {
                        sb.Append($" {x.Nazev} _{pocitadlo}, ");
                        pocitadlo++;
                    }
                    sb.Remove(sb.Length -2 , 2);
                    sb.Append(" ) \r");
                    sb.Append("{ \r");
                    sb.Append($"{m.TeloMetody}");
                    sb.Append("} \r");
                }
                sb.Append("} \r");
            }

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog(); // Nastavení vlastností dialogu
            folderBrowserDialog.Description = "Vyberte složku";
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog.ShowNewFolderButton = true;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;
                int countOfFiles = Directory.GetFiles(folderPath).Count();

                File.WriteAllText(folderPath + $"\\VygenerovaneTridy{countOfFiles}.cs", sb.ToString());
            }

        }
    }
}
