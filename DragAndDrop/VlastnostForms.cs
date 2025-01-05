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

namespace DragAndDrop
{
    public partial class VlastnostForms : Form
    {
        private Vlastnost _vlastnost;
        private Canvas _canvas;
        public VlastnostForms(Vlastnost v, Canvas c)
        {
            _vlastnost = v;
            _canvas = c;
            InitializeComponent();

            ModifikatorPristupu.Items.Add(ModifikatorPrEnum.IsInternal);
            ModifikatorPristupu.Items.Add(ModifikatorPrEnum.IsPrivate);
            ModifikatorPristupu.Items.Add(ModifikatorPrEnum.IsPublic);
            ModifikatorPristupu.Items.Add(ModifikatorPrEnum.IsProtected);

            ModifikatorPristupu.SelectedItem = _vlastnost.Modifikator;
            DatovyTyp.Text = _vlastnost.DatovyTyp;
            Nazev.Text = _vlastnost.Nazev;
            Getter.Text = _vlastnost.Getter;
            Setter.Text = _vlastnost.Setter;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _vlastnost.Modifikator = (ModifikatorPrEnum)ModifikatorPristupu.SelectedItem;
            if (!_vlastnost.JeDatTypSlozeny)
            {
                _vlastnost.DatovyTyp = DatovyTyp.Text;
            }
            _vlastnost.Nazev = Nazev.Text;
            _vlastnost.Getter = Getter.Text;
            _vlastnost.Setter = Setter.Text;

            this.Close();
        }

        private void SlozitDatTyp_Click(object sender, EventArgs e)
        {
            DatovyTyp.Text = string.Empty;
            DatovyTyp.Enabled = false;
            _vlastnost.JeDatTypSlozeny = true;
            VyberAPriradPolozku v = new VyberAPriradPolozku(_canvas, _vlastnost, null);
            v.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
