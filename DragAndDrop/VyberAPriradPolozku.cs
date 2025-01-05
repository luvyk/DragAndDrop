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
        public Vlastnost Vlastnost { get; set; }
        public VyberAPriradPolozku(Canvas c, Vlastnost v)
        {
            _canvas = c;
            Vlastnost = v;
            BindingList<Objekt> objekts = new BindingList<Objekt>();

            foreach (Box b in _canvas._boxes)
            {
                objekts.Add(b._text);
            }

            InitializeComponent();

            dataGridView1.DataSource = objekts;
            dataGridView1.Refresh();

            comboBox1.Items.Add(TypVztahu.Dependence);
            comboBox1.Items.Add(TypVztahu.Agregace);
            comboBox1.Items.Add(TypVztahu.Kompozice);
            comboBox1.Items.Add(TypVztahu.Asociace);

            comboBox1.SelectedItem = Vlastnost.TypVztahu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            Vlastnost.KompozicneAgregacniVztah = _canvas._boxes[index]._text;
            this.Close();
        }
    }
}
