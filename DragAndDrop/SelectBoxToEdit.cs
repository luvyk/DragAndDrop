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
        private Canvas _canvas;
        public SelectBoxToEdit(Canvas canvas)
        {
            InitializeComponent();
            _canvas = canvas;

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

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
