using System.Drawing;
using System.Drawing.Imaging;

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
            _canvas._boxes.Add(new Box(10, 10, _canvas));
            EditForm f = new EditForm(_canvas, _canvas._boxes.Count - 1);
            f.Show();
        }

        private void UpravTridu_Click(object sender, EventArgs e)
        {
            SelectBoxToEdit editForm = new SelectBoxToEdit(_canvas);
            editForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog(); // Nastavení vlastností dialogu
            folderBrowserDialog.Description = "Vyberte složku";
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog.ShowNewFolderButton = true;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;

                Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
                pictureBox.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBox.Width, pictureBox.Height));
                bmp.Save(folderPath + "\\test.png", ImageFormat.Png);
                DialogResult d = new DialogResult();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nastaveni n = new Nastaveni(_canvas);
            n.Show();
        }
    }
}
