using DragAndDrop.Odpadky;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDrop
{

    public partial class EditMetoda : Form
    {
        private Metoda _metoda;
        private Canvas _canvas;
        private BindingList<BindingString> _bindingStrings = new BindingList<BindingString>();
        private BindingList<Objekt> _objekty = new BindingList<Objekt>();
        private BindingList<Objekt> _objekty2 = new BindingList<Objekt>();
        public EditMetoda(Metoda metoda, Canvas canvas)
        {
            InitializeComponent();
            _metoda = metoda;
            _canvas = canvas;

            comboBox1.Items.Add(ModifikatorPrEnum.IsInternal);
            comboBox1.Items.Add(ModifikatorPrEnum.IsPublic);
            comboBox1.Items.Add(ModifikatorPrEnum.IsPrivate);
            comboBox1.Items.Add(ModifikatorPrEnum.IsProtected);

            comboBox1.SelectedItem = _metoda.Pristup;
            Special.Text = _metoda.SpecialStatus;
            NavratovaHodnota.Text = _metoda.NavratovaHodnota;
            Nazev.Text = _metoda.Nazev;
            foreach (string s in _metoda.Parametry)
            {
                _bindingStrings.Add(new BindingString(s));
            }
            NormalParam.DataSource = _metoda.Parametry;
            NormalParam.Refresh();

            foreach (Box o in _canvas._boxes)
            {
                _objekty.Add(o._text);
            }
            dataGridView1.DataSource = _objekty;
            dataGridView1.Refresh();

            foreach (Objekt o in _metoda.ObjektoveParametry)
            {
                _objekty2.Add(o);
            }
            dataGridView2.DataSource = _objekty2;
            dataGridView2.Refresh();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            _metoda.Pristup = (ModifikatorPrEnum)comboBox1.SelectedItem;
            _metoda.SpecialStatus = Special.Text;
            _metoda.NavratovaHodnota = NavratovaHodnota.Text;
            _metoda.Nazev = Nazev.Text;
            _metoda.Parametry.Clear();
            foreach (BindingString x in _bindingStrings)
            {
                _metoda.Parametry.Add(x.String);
            }
            foreach (Objekt o in _objekty2) 
            {
                _metoda.ObjektoveParametry.Add(o);
            }
            this.Close();
        }

        private void VraciObjekt_Click(object sender, EventArgs e)
        {
            NavratovaHodnota.Enabled = false;
            NavratovaHodnota.Text = string.Empty;
            VyberAPriradPolozku p = new VyberAPriradPolozku(_canvas, null, _metoda);
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PridejNormalP_Click(object sender, EventArgs e)
        {
            _bindingStrings.Add(new BindingString(textBox2.Text));
            NormalParam.DataSource = "";
            NormalParam.Refresh();
            NormalParam.DataSource = _bindingStrings;
            NormalParam.Refresh();
        }

        private void OdeberNormalP_Click(object sender, EventArgs e)
        {
            int odeberIndex = NormalParam.CurrentCell.RowIndex;
            _bindingStrings.Remove(_bindingStrings[odeberIndex]);
            NormalParam.DataSource = "";
            NormalParam.Refresh();
            NormalParam.DataSource = _bindingStrings;
            NormalParam.Refresh();
        }

        private void SmazObjekt_Click(object sender, EventArgs e)
        {
            int smazIndex = dataGridView2.CurrentCell.RowIndex;
            _objekty2.Remove(_objekty2[smazIndex]);

            dataGridView2.DataSource = "";
            dataGridView2.Refresh();
            dataGridView2.DataSource = _objekty2;
            dataGridView2.Refresh();
        }

        private void Presun_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            _objekty2.Add(_objekty[index]);
        }
    }
}
