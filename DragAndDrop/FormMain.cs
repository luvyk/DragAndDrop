namespace DragAndDrop
{
    public partial class FormMain : Form
    {
        private Canvas _canvas;

        public FormMain()
        {
            _canvas = new Canvas();

            InitializeComponent();
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _canvas.Unselect();
            pictureBox.Refresh();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _canvas.Select(e.X, e.Y);
            pictureBox.Refresh();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            _canvas.Move(e.X, e.Y);
            pictureBox.Refresh();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            _canvas.Draw(e.Graphics);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _canvas._boxes.Add(new Box(10, 100));
            EditForm f = new EditForm(_canvas, _canvas._boxes.Count -1);
            f.Show();
        }

        private void UpravTridu_Click(object sender, EventArgs e)
        {
            SelectBoxToEdit editForm = new SelectBoxToEdit(_canvas);
            editForm.Show();
        }
    }
}
