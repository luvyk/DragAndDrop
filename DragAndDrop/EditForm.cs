﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DragAndDrop.Odpadky;

namespace DragAndDrop
{
    public partial class EditForm : Form
    {
        private Canvas _canvas;
        private int _index;
        public EditForm(Canvas canvas, int index)
        {
            InitializeComponent();
            _canvas = canvas;
            _index = index;

            ModPristupuTR.Items.Add(ModifikatorPrEnum.IsInternal);
            ModPristupuTR.Items.Add(ModifikatorPrEnum.IsPrivate);
            ModPristupuTR.Items.Add(ModifikatorPrEnum.IsPublic);
            ModPristupuTR.Items.Add(ModifikatorPrEnum.IsProtected);

            List<string> list = new List<string>();
            NamespaceChose.Items.Add("Vytvořit nový namespace");
            foreach (Box b in _canvas._boxes)
            {
                if (!list.Contains(b._text.MyNamespace))
                {
                    list.Add(b._text.MyNamespace);
                    NamespaceChose.Items.Add(b._text.MyNamespace);
                }
            }
            NamespaceChose.SelectedItem = _canvas._boxes[_index]._text.MyNamespace;
            ModPristupuTR.SelectedItem = _canvas._boxes[_index]._text.Modifikator;
            CoToJe.Text = _canvas._boxes[_index]._text.WhatItIs;
            Nazev.Text = _canvas._boxes[_index]._text.Nazev;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _canvas._boxes[_index]._text.Modifikator = (ModifikatorPrEnum)ModPristupuTR.SelectedItem;
            _canvas._boxes[_index]._text.WhatItIs = CoToJe.Text;
            _canvas._boxes[_index]._text.Nazev = Nazev.Text;
            if (NamespaceChose.SelectedItem != null || NamespaceChose.SelectedItem == "Vytvořit nový namespace")
            {
                _canvas._boxes[_index]._text.MyNamespace = NamespaceChose.SelectedItem.ToString();
            }
            else
            {
                _canvas._boxes[_index]._text.MyNamespace = NewNamespace.Text;
            }
            this.Close();
        }

        private void EditUsings_Click(object sender, EventArgs e)
        {
            MultiEditForm f = new MultiEditForm(_canvas, _index, "");
            f.Show();
        }

        private void UpravRealizace_Click(object sender, EventArgs e)
        {
            MultiEditForm f = new MultiEditForm(_canvas, _index, "Realizace");
            f.Show();
        }

        private void UpravVlastnosti_Click(object sender, EventArgs e)
        {
            SelectBoxToEdit s = new SelectBoxToEdit(_canvas._boxes[_index]._text.Vlastnosti, _canvas);
            s.Show();
        }

        private void UpravMetody_Click(object sender, EventArgs e)
        {
            SelectBoxToEdit s = new SelectBoxToEdit(_canvas._boxes[_index]._text.Metody, _canvas);
            s.Show();
        }

        private void Zrusit_Click(object sender, EventArgs e)
        {
            _canvas._boxes.Remove(_canvas._boxes[_index]);
            this.Close();
        }

        private void Zrusit_Click_1(object sender, EventArgs e)
        {
            _canvas._boxes.Remove(_canvas._boxes[_index]);
            this.Close();
        }
    }
}
