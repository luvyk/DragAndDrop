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
    public partial class SelectBoxToEdit : Form
    {
        private Canvas? _canvas;
        private List<Vlastnost>? _vlastnosti;
        private List<Metoda>? _metody;
        public SelectBoxToEdit(Canvas canvas)
        {
            InitializeComponent();
            _canvas = canvas;
            NastavTabulkuC();

            _vlastnosti = null;
            _metody = null;
        }

        public SelectBoxToEdit(List<Vlastnost> vlastnosti, Canvas c)
        {
            InitializeComponent();
            _vlastnosti = vlastnosti;
            NastavTabulkuV();

            _metody = null;
            _canvas = c;
        }

        public SelectBoxToEdit(List<Metoda> metody, Canvas c)
        {
            InitializeComponent();
            _metody = metody;
            NastavTabulkuM();

            _canvas = c;
            _vlastnosti = null;
        }


        private void NastavTabulkuM()
        {
            dataGridView.DataSource = "";
            dataGridView.Refresh();

            BindingList<Metoda> bindingList = new BindingList<Metoda>();
            foreach (Metoda m in _metody)
            {
                bindingList.Add(m);
            }
            dataGridView.DataSource = bindingList;
            dataGridView.Refresh();
        }
        private void NastavTabulkuV()
        {
            dataGridView.DataSource = "";
            dataGridView.Refresh();

            BindingList<Vlastnost> bindingList = new BindingList<Vlastnost>();
            foreach (Vlastnost v in _vlastnosti)
            {
                bindingList.Add(v);
            }
            dataGridView.DataSource = bindingList;
            dataGridView.Refresh();
        }

        private void NastavTabulkuC()
        {
            dataGridView.DataSource = "";
            dataGridView.Refresh();
            BindingList<Objekt> bindingList = new BindingList<Objekt>();

            //bindingList.Add(_canvas._boxes[0]._text);
            foreach (Box box in _canvas._boxes)
            {
                bindingList.Add(box._text);
            }
            dataGridView.DataSource = bindingList;
            dataGridView.Refresh();
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (_vlastnosti != null)
            {
                int selectedIndex = dataGridView.CurrentCell.RowIndex;

                VlastnostForms vf = new VlastnostForms(_vlastnosti[selectedIndex], _canvas);
                vf.Show();

            }
            else if (_metody != null)
            {
                int selectedIndex = dataGridView.CurrentCell.RowIndex;
                EditMetoda m = new EditMetoda(_metody[selectedIndex], _canvas);
                m.Show();

            }
            else if (_canvas != null)
            {
                int selectedIndex = dataGridView.CurrentCell.RowIndex;
                EditForm f = new EditForm(_canvas, selectedIndex);
                f.Show();
                dataGridView.Refresh();
                //MessageBox.Show($"Zvolil jste {selectedIndex}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            

            if (_vlastnosti != null)
            {
                int selectedIndex = dataGridView.CurrentCell.RowIndex;
                _vlastnosti.RemoveAt(selectedIndex);
                NastavTabulkuV();
            }
            else
            if (_metody != null)
            {
                if (dataGridView.CurrentCell.RowIndex == null)
                    return;

                int selectedIndex = dataGridView.CurrentCell.RowIndex;
                _metody.RemoveAt(selectedIndex);

                NastavTabulkuM();
            }
            else
            if (_canvas != null)
            {
                int selectedIndex = dataGridView.CurrentCell.RowIndex;
                _canvas._boxes.RemoveAt(selectedIndex);

                NastavTabulkuC();
            }

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_canvas != null)
            {
                
            }

            if (_vlastnosti != null)
            {
                Vlastnost v = new Vlastnost();
                VlastnostForms vlastnostForms = new VlastnostForms(v, _canvas);
                vlastnostForms.Show();
                _vlastnosti.Add(v);

                dataGridView.DataSource = "";
                dataGridView.Refresh();
                dataGridView.DataSource = _vlastnosti;
                dataGridView.Refresh();
            }

            if (_metody != null)
            {
                Metoda m = new Metoda();
                EditMetoda MetodaWindow = new EditMetoda(m, _canvas);
                MetodaWindow.Show();
                _metody.Add(m);

                dataGridView.DataSource = "";
                dataGridView.Refresh();
                dataGridView.DataSource = _metody;
                dataGridView.Refresh();
            }
        }
    }
}
