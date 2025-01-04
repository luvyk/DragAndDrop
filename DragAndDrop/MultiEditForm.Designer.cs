namespace DragAndDrop
{
    partial class MultiEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            Vyber = new DataGridView();
            Nabidka = new DataGridView();
            Uloz = new Button();
            Vloz = new Button();
            NovyText = new TextBox();
            label1 = new Label();
            Presun = new Button();
            Odstran = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Vyber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Nabidka).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Vyber, 1, 0);
            tableLayoutPanel1.Controls.Add(Nabidka, 0, 0);
            tableLayoutPanel1.Controls.Add(Uloz, 0, 3);
            tableLayoutPanel1.Controls.Add(Vloz, 1, 3);
            tableLayoutPanel1.Controls.Add(NovyText, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(Presun, 0, 2);
            tableLayoutPanel1.Controls.Add(Odstran, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // Vyber
            // 
            Vyber.AllowUserToAddRows = false;
            Vyber.AllowUserToDeleteRows = false;
            Vyber.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Vyber.Dock = DockStyle.Fill;
            Vyber.Location = new Point(403, 3);
            Vyber.Name = "Vyber";
            Vyber.ReadOnly = true;
            Vyber.Size = new Size(394, 324);
            Vyber.TabIndex = 1;
            // 
            // Nabidka
            // 
            Nabidka.AllowUserToAddRows = false;
            Nabidka.AllowUserToDeleteRows = false;
            Nabidka.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Nabidka.Dock = DockStyle.Fill;
            Nabidka.Location = new Point(3, 3);
            Nabidka.Name = "Nabidka";
            Nabidka.ReadOnly = true;
            Nabidka.Size = new Size(394, 324);
            Nabidka.TabIndex = 0;
            // 
            // Uloz
            // 
            Uloz.Dock = DockStyle.Fill;
            Uloz.Location = new Point(3, 413);
            Uloz.Name = "Uloz";
            Uloz.Size = new Size(394, 34);
            Uloz.TabIndex = 2;
            Uloz.Text = "Ulož";
            Uloz.UseVisualStyleBackColor = true;
            Uloz.Click += Uloz_Click;
            // 
            // Vloz
            // 
            Vloz.Dock = DockStyle.Fill;
            Vloz.Location = new Point(403, 413);
            Vloz.Name = "Vloz";
            Vloz.Size = new Size(394, 34);
            Vloz.TabIndex = 3;
            Vloz.Text = "Vlož";
            Vloz.UseVisualStyleBackColor = true;
            Vloz.Click += Vloz_Click;
            // 
            // NovyText
            // 
            NovyText.Dock = DockStyle.Fill;
            NovyText.Location = new Point(403, 373);
            NovyText.Name = "NovyText";
            NovyText.Size = new Size(394, 23);
            NovyText.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 330);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 5;
            label1.Text = "Nabídka";
            // 
            // Presun
            // 
            Presun.Dock = DockStyle.Fill;
            Presun.Location = new Point(3, 373);
            Presun.Name = "Presun";
            Presun.Size = new Size(394, 34);
            Presun.TabIndex = 7;
            Presun.Text = "Přesuň";
            Presun.UseVisualStyleBackColor = true;
            Presun.Click += Presun_Click;
            // 
            // Odstran
            // 
            Odstran.Dock = DockStyle.Fill;
            Odstran.Location = new Point(403, 333);
            Odstran.Name = "Odstran";
            Odstran.Size = new Size(394, 34);
            Odstran.TabIndex = 8;
            Odstran.Text = "Odstraň";
            Odstran.UseVisualStyleBackColor = true;
            Odstran.Click += Odstran_Click;
            // 
            // MultiEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "MultiEditForm";
            Text = "MultiEditForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Vyber).EndInit();
            ((System.ComponentModel.ISupportInitialize)Nabidka).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView Vyber;
        private DataGridView Nabidka;
        private Button Uloz;
        private Button Vloz;
        private TextBox NovyText;
        private Label label1;
        private Button Presun;
        private Button Odstran;
    }
}