namespace DragAndDrop
{
    partial class EditMetoda
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
            comboBox1 = new ComboBox();
            Special = new TextBox();
            NavratovaHodnota = new TextBox();
            VraciObjekt = new Button();
            Nazev = new TextBox();
            Save = new Button();
            Cancel = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            NormalParam = new DataGridView();
            textBox2 = new TextBox();
            PridejNormalP = new Button();
            OdeberNormalP = new Button();
            SmazObjekt = new Button();
            Presun = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NormalParam).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 23);
            comboBox1.TabIndex = 0;
            // 
            // Special
            // 
            Special.Location = new Point(12, 41);
            Special.Name = "Special";
            Special.PlaceholderText = "virtual";
            Special.Size = new Size(146, 23);
            Special.TabIndex = 1;
            // 
            // NavratovaHodnota
            // 
            NavratovaHodnota.Location = new Point(12, 70);
            NavratovaHodnota.Name = "NavratovaHodnota";
            NavratovaHodnota.PlaceholderText = "Návratová hodnota";
            NavratovaHodnota.Size = new Size(146, 23);
            NavratovaHodnota.TabIndex = 2;
            // 
            // VraciObjekt
            // 
            VraciObjekt.Location = new Point(12, 99);
            VraciObjekt.Name = "VraciObjekt";
            VraciObjekt.Size = new Size(146, 23);
            VraciObjekt.TabIndex = 3;
            VraciObjekt.Text = "Vracení objektu";
            VraciObjekt.UseVisualStyleBackColor = true;
            VraciObjekt.Click += VraciObjekt_Click;
            // 
            // Nazev
            // 
            Nazev.Location = new Point(12, 128);
            Nazev.Name = "Nazev";
            Nazev.Size = new Size(146, 23);
            Nazev.TabIndex = 4;
            Nazev.Text = "Nazev";
            // 
            // Save
            // 
            Save.Location = new Point(12, 416);
            Save.Name = "Save";
            Save.Size = new Size(146, 41);
            Save.TabIndex = 5;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(12, 369);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(146, 41);
            Cancel.TabIndex = 6;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 157);
            button1.Name = "button1";
            button1.Size = new Size(146, 23);
            button1.TabIndex = 7;
            button1.Text = "Parametry";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tělo metody";
            textBox1.Size = new Size(283, 444);
            textBox1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 463);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(435, 398);
            dataGridView1.TabIndex = 9;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(453, 463);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(435, 398);
            dataGridView2.TabIndex = 10;
            // 
            // NormalParam
            // 
            NormalParam.AllowUserToAddRows = false;
            NormalParam.AllowUserToDeleteRows = false;
            NormalParam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NormalParam.Location = new Point(453, 12);
            NormalParam.Name = "NormalParam";
            NormalParam.ReadOnly = true;
            NormalParam.Size = new Size(435, 398);
            NormalParam.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(453, 416);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(276, 23);
            textBox2.TabIndex = 12;
            // 
            // PridejNormalP
            // 
            PridejNormalP.Location = new Point(735, 416);
            PridejNormalP.Name = "PridejNormalP";
            PridejNormalP.Size = new Size(75, 23);
            PridejNormalP.TabIndex = 13;
            PridejNormalP.Text = "Přidej";
            PridejNormalP.UseVisualStyleBackColor = true;
            PridejNormalP.Click += PridejNormalP_Click;
            // 
            // OdeberNormalP
            // 
            OdeberNormalP.Location = new Point(816, 416);
            OdeberNormalP.Name = "OdeberNormalP";
            OdeberNormalP.Size = new Size(72, 23);
            OdeberNormalP.TabIndex = 14;
            OdeberNormalP.Text = "Odeber";
            OdeberNormalP.UseVisualStyleBackColor = true;
            OdeberNormalP.Click += OdeberNormalP_Click;
            // 
            // SmazObjekt
            // 
            SmazObjekt.Location = new Point(453, 867);
            SmazObjekt.Name = "SmazObjekt";
            SmazObjekt.Size = new Size(435, 23);
            SmazObjekt.TabIndex = 15;
            SmazObjekt.Text = "Smaž";
            SmazObjekt.UseVisualStyleBackColor = true;
            SmazObjekt.Click += SmazObjekt_Click;
            // 
            // Presun
            // 
            Presun.Location = new Point(12, 867);
            Presun.Name = "Presun";
            Presun.Size = new Size(435, 23);
            Presun.TabIndex = 16;
            Presun.Text = "Přesuň";
            Presun.UseVisualStyleBackColor = true;
            Presun.Click += Presun_Click;
            // 
            // EditMetoda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 967);
            Controls.Add(Presun);
            Controls.Add(SmazObjekt);
            Controls.Add(OdeberNormalP);
            Controls.Add(PridejNormalP);
            Controls.Add(textBox2);
            Controls.Add(NormalParam);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(Cancel);
            Controls.Add(Save);
            Controls.Add(Nazev);
            Controls.Add(VraciObjekt);
            Controls.Add(NavratovaHodnota);
            Controls.Add(Special);
            Controls.Add(comboBox1);
            Name = "EditMetoda";
            Text = "EditMetoda";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)NormalParam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox Special;
        private TextBox NavratovaHodnota;
        private Button VraciObjekt;
        private TextBox Nazev;
        private Button Save;
        private Button Cancel;
        private Button button1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView NormalParam;
        private TextBox textBox2;
        private Button PridejNormalP;
        private Button OdeberNormalP;
        private Button SmazObjekt;
        private Button Presun;
    }
}