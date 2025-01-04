namespace DragAndDrop
{
    partial class VlastnostForms
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
            ModifikatorPristupu = new ComboBox();
            SlozitDatTyp = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SaveButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // ModifikatorPristupu
            // 
            ModifikatorPristupu.FormattingEnabled = true;
            ModifikatorPristupu.Location = new Point(12, 12);
            ModifikatorPristupu.Name = "ModifikatorPristupu";
            ModifikatorPristupu.Size = new Size(160, 23);
            ModifikatorPristupu.TabIndex = 0;
            // 
            // SlozitDatTyp
            // 
            SlozitDatTyp.Location = new Point(12, 41);
            SlozitDatTyp.Name = "SlozitDatTyp";
            SlozitDatTyp.Size = new Size(160, 23);
            SlozitDatTyp.TabIndex = 1;
            SlozitDatTyp.Text = "Složený datový typ";
            SlozitDatTyp.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 131);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 307);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(231, 131);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(213, 307);
            textBox3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 113);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Getter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 113);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 6;
            label2.Text = "Setter";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(193, 12);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(113, 37);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(193, 55);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(113, 38);
            CancelButton.TabIndex = 8;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // VlastnostForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 450);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(SlozitDatTyp);
            Controls.Add(ModifikatorPristupu);
            Name = "VlastnostForms";
            Text = "VlastnostForms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ModifikatorPristupu;
        private Button SlozitDatTyp;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Button SaveButton;
        private Button CancelButton;
    }
}