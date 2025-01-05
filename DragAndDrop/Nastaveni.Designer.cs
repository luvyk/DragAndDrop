namespace DragAndDrop
{
    partial class Nastaveni
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
            Uloz = new Button();
            Nacti = new Button();
            GenerujKod = new Button();
            SuspendLayout();
            // 
            // Uloz
            // 
            Uloz.Location = new Point(12, 12);
            Uloz.Name = "Uloz";
            Uloz.Size = new Size(282, 54);
            Uloz.TabIndex = 0;
            Uloz.Text = "Ulož";
            Uloz.UseVisualStyleBackColor = true;
            Uloz.Click += Uloz_Click;
            // 
            // Nacti
            // 
            Nacti.Location = new Point(12, 72);
            Nacti.Name = "Nacti";
            Nacti.Size = new Size(282, 54);
            Nacti.TabIndex = 1;
            Nacti.Text = "Nacti";
            Nacti.UseVisualStyleBackColor = true;
            Nacti.Click += Nacti_Click;
            // 
            // GenerujKod
            // 
            GenerujKod.Location = new Point(12, 132);
            GenerujKod.Name = "GenerujKod";
            GenerujKod.Size = new Size(282, 54);
            GenerujKod.TabIndex = 2;
            GenerujKod.Text = "Generuj C# kód";
            GenerujKod.UseVisualStyleBackColor = true;
            GenerujKod.Click += GenerujKod_Click;
            // 
            // Nastaveni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 501);
            Controls.Add(GenerujKod);
            Controls.Add(Nacti);
            Controls.Add(Uloz);
            Name = "Nastaveni";
            Text = "Nastaveni";
            ResumeLayout(false);
        }

        #endregion

        private Button Uloz;
        private Button Nacti;
        private Button GenerujKod;
    }
}