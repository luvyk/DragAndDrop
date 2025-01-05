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
            Nazev = new TextBox();
            Getter = new TextBox();
            Setter = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SaveButton = new Button();
            CancelButton = new Button();
            DatovyTyp = new TextBox();
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
            SlozitDatTyp.Click += SlozitDatTyp_Click;
            // 
            // Nazev
            // 
            Nazev.Location = new Point(12, 124);
            Nazev.Name = "Nazev";
            Nazev.Size = new Size(160, 23);
            Nazev.TabIndex = 2;
            // 
            // Getter
            // 
            Getter.Location = new Point(12, 168);
            Getter.Multiline = true;
            Getter.Name = "Getter";
            Getter.Size = new Size(213, 307);
            Getter.TabIndex = 3;
            // 
            // Setter
            // 
            Setter.Location = new Point(231, 168);
            Setter.Multiline = true;
            Setter.Name = "Setter";
            Setter.Size = new Size(213, 307);
            Setter.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 150);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Getter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 150);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 6;
            label2.Text = "Setter";
            label2.Click += label2_Click;
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
            CancelButton.Click += CancelButton_Click;
            // 
            // DatovyTyp
            // 
            DatovyTyp.Location = new Point(12, 70);
            DatovyTyp.Name = "DatovyTyp";
            DatovyTyp.Size = new Size(160, 23);
            DatovyTyp.TabIndex = 9;
            // 
            // VlastnostForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 502);
            Controls.Add(DatovyTyp);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Setter);
            Controls.Add(Getter);
            Controls.Add(Nazev);
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
        private TextBox Nazev;
        private TextBox Getter;
        private TextBox Setter;
        private Label label1;
        private Label label2;
        private Button SaveButton;
        private Button CancelButton;
        private TextBox DatovyTyp;
    }
}