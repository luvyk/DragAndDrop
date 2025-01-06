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
    public partial class VyberAPriradPolozku : Form
    {
        private Canvas _canvas;
        private Metoda? _metoda;
        public Vlastnost? Vlastnost { get; set; }
        public VyberAPriradPolozku(Canvas c, Vlastnost v, Metoda m)
        {
            _canvas = c;
            Vlastnost = v;
            _metoda = m;
            BindingList<Objekt> objekts = new BindingList<Objekt>();

            InitializeComponent();
            if (_metoda == null)
            {
                foreach (Box b in _canvas._boxes)
                {
                    objekts.Add(b._text);
                }


                dataGridView1.DataSource = objekts;
                dataGridView1.Refresh();

                comboBox1.Items.Add(TypVztahu.Dependence);
                comboBox1.Items.Add(TypVztahu.Agregace);
                comboBox1.Items.Add(TypVztahu.Kompozice);
                comboBox1.Items.Add(TypVztahu.Asociace);

                comboBox1.SelectedItem = Vlastnost.TypVztahu;
            }
            else
            {
                comboBox1.Enabled = false;

                foreach (Box b in _canvas._boxes)
                {
                    objekts.Add(b._text);
                }
                dataGridView1.DataSource = objekts;
                dataGridView1.Refresh();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (_metoda == null)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                Vlastnost.KompozicneAgregacniVztah = _canvas._boxes[index]._text;
                Vlastnost.TypVztahu = (TypVztahu)comboBox1.SelectedItem!;
                if ((TypVztahu)comboBox1.SelectedItem == TypVztahu.Asociace)
                {
                    Vlastnost.Multiplicita = checkBox1.Checked;
                }
                this.Close();
            }
            else
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                _metoda.VracimDefinovanyObjekt = true;
                _metoda.NavratovyObjekt = _canvas._boxes[index]._text;
                this.Close();
            }
        }
    }
}
