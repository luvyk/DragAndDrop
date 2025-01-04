using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DragAndDrop.Odpadky;
using System.Linq;
using System.Dynamic;

namespace DragAndDrop
{
    public partial class MultiEditForm : Form
    {
        private Canvas _canvas;
        private int _index;
        private string _WhatItWillBe;
        public BindingList<BindingString> BindingVyber = new BindingList<BindingString>();
        public BindingList<Objekt> objekts = new BindingList<Objekt>();
        public MultiEditForm(Canvas canvas, int index, string Wh)
        {
            _canvas = canvas;
            _index = index;
            _WhatItWillBe = Wh;
            InitializeComponent();

            if (_WhatItWillBe == "")
            {
                BindingList<BindingString> bindingList = new BindingList<BindingString>();
                foreach (Box s in _canvas._boxes)
                {
                    foreach (string b in s._text.Usings)
                    {
                        bool isItThere = false;
                        foreach (BindingString c in bindingList)
                        {
                            if (c.String == b)
                                isItThere = true;
                        }
                        //if(!bindingList.Contains(new BindingString(b)))
                        if (!isItThere)
                            bindingList.Add(new BindingString(b));

                    }
                }
                foreach (string o in _canvas._boxes[_index]._text.Usings)
                {
                    BindingVyber.Add(new BindingString(o));
                }

                Nabidka.DataSource = bindingList;
                Nabidka.Refresh();
                Vyber.DataSource = "";
                Vyber.Refresh();
                Vyber.DataSource = BindingVyber;
                Vyber.Refresh();
            }
            else
            {
                BindingList<Objekt> bindingList = new BindingList<Objekt>();
                foreach (Box s in _canvas._boxes)
                {
                    bindingList.Add(s._text);
                    Nabidka.DataSource = bindingList;
                    Nabidka.Refresh();
                }
                foreach (Objekt o in _canvas._boxes[_index]._text.Realizace)
                {
                    objekts.Add((Objekt)o);
                }
                foreach (string o in _canvas._boxes[_index]._text.RealizaceUvnitr)
                {
                    Objekt X = new Objekt();
                    X.Nazev = o;
                    X.MyNamespace = "--BezKrabice";
                    objekts.Add(X);
                }
                Nabidka.Refresh();
                Vyber.DataSource = "";
                Vyber.Refresh();
                Vyber.DataSource = objekts;
                Vyber.Refresh();
            }

        }

        private void Uloz_Click(object sender, EventArgs e)
        {
            if (_WhatItWillBe == "")
            {
                List<string> list = new List<string>();
                foreach (BindingString s in BindingVyber)
                {
                    list.Add(s.String);
                }
                _canvas._boxes[_index]._text.Usings = list;
                this.Close();
            }
            else
            {
                _canvas._boxes[_index]._text.RealizaceUvnitr.Clear();
                _canvas._boxes[_index]._text.Realizace.Clear();

                foreach (Objekt o in objekts)
                {
                    if (o.MyNamespace == "--BezKrabice")
                    {
                        _canvas._boxes[_index]._text.RealizaceUvnitr.Add(o.Nazev);
                    }
                    else
                    {
                        _canvas._boxes[_index]._text.Realizace.Add(o);
                    }
                }
                this.Close();
            }
        }

        private void Presun_Click(object sender, EventArgs e)
        {
            if (_WhatItWillBe == "")
            {
                string OneUsing = Nabidka.CurrentCell.Value.ToString();
                BindingVyber.Add(new BindingString(OneUsing));
                Vyber.DataSource = "";
                Vyber.Refresh();
                Vyber.DataSource = BindingVyber;
                Vyber.Refresh();
            }
            else
            {
                Objekt o = Nabidka.CurrentRow.DataBoundItem as Objekt;
                objekts.Add(o);
                Vyber.DataSource = "";
                Vyber.Refresh();
                Vyber.DataSource = objekts;
                Vyber.Refresh();
            }
        }

        private void Vloz_Click(object sender, EventArgs e)
        {
            if (_WhatItWillBe == "")
            {
                BindingVyber.Add(new BindingString(NovyText.Text));
                Vyber.DataSource = "";
                Vyber.Refresh();
                Vyber.DataSource = BindingVyber;
                Vyber.Refresh();
            }
            else
            {
                Objekt o = new Objekt();
                o.Nazev = NovyText.Text;
                o.MyNamespace = "--BezKrabice";

                objekts.Add(o);
                Vyber.DataSource = "";
                Vyber.Refresh();
                Vyber.DataSource = objekts;
                Vyber.Refresh();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Odstran_Click(object sender, EventArgs e)
        {
            BindingVyber.Remove(BindingVyber[Vyber.CurrentCell.RowIndex]);
            Vyber.DataSource = "";
            Vyber.Refresh();
            Vyber.DataSource = BindingVyber;
            Vyber.Refresh();
        }
    }
}
