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

namespace DragAndDrop
{
    public partial class MultiEditForm : Form
    {
        private Canvas _canvas;
        private int _index;
        private string _WhatItWillBe;
        public BindingList<BindingString> BindingVyber = new BindingList<BindingString>();
        public MultiEditForm(Canvas canvas, int index, string Wh)
        {
            _canvas = canvas;
            _index = index;
            _WhatItWillBe = Wh;
            InitializeComponent();

            BindingList<BindingString> bindingList = new BindingList<BindingString>();
            foreach (Box s in _canvas._boxes)
            {
                foreach(string b in s._text.Usings)
                {
                    bool isItThere = false;
                    foreach (BindingString c in bindingList)
                    {
                        if(c.String==b) 
                            isItThere= true;
                    }
                    //if(!bindingList.Contains(new BindingString(b)))
                    if(!isItThere)
                        bindingList.Add(new BindingString(b));
                    
                }
            }
            Nabidka.DataSource = bindingList;
            Nabidka.Refresh();
            
        }

        private void Uloz_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (BindingString s in BindingVyber)
            {
                list.Add(s.String);
            }
            _canvas._boxes[_index]._text.Usings = list;
            this.Close();
        }

        private void Presun_Click(object sender, EventArgs e)
        {
            string OneUsing = Nabidka.CurrentCell.Value.ToString();
            BindingVyber.Add(new BindingString(OneUsing));
            Vyber.DataSource = "";
            Vyber.Refresh();
            Vyber.DataSource = BindingVyber;
            Vyber.Refresh();
        }

        private void Vloz_Click(object sender, EventArgs e)
        {
            BindingVyber.Add(new BindingString(NovyText.Text));
            Vyber.DataSource = "";
            Vyber.Refresh();
            Vyber.DataSource = BindingVyber;
            Vyber.Refresh();
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
