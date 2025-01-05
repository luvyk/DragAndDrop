namespace DragAndDrop
{
    partial class EditForm
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
            EditUsings = new Button();
            label1 = new Label();
            NamespaceChose = new ComboBox();
            label2 = new Label();
            ModPristupuTR = new ComboBox();
            label3 = new Label();
            CoToJe = new TextBox();
            label4 = new Label();
            NewNamespace = new TextBox();
            Nazev = new TextBox();
            label5 = new Label();
            UpravRealizace = new Button();
            UpravVlastnosti = new Button();
            UpravMetody = new Button();
            SaveButton = new Button();
            Zrusit = new Button();
            SuspendLayout();
            // 
            // EditUsings
            // 
            EditUsings.Location = new Point(12, 12);
            EditUsings.Name = "EditUsings";
            EditUsings.Size = new Size(120, 23);
            EditUsings.TabIndex = 0;
            EditUsings.Text = "Usings";
            EditUsings.UseVisualStyleBackColor = true;
            EditUsings.Click += EditUsings_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 16);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 1;
            label1.Text = "Upravit \"Usings\"";
            // 
            // NamespaceChose
            // 
            NamespaceChose.FormattingEnabled = true;
            NamespaceChose.Location = new Point(11, 46);
            NamespaceChose.Name = "NamespaceChose";
            NamespaceChose.Size = new Size(121, 23);
            NamespaceChose.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 54);
            label2.Name = "label2";
            label2.Size = new Size(194, 15);
            label2.TabIndex = 3;
            label2.Text = "Vyber Namespace nebo zadej nový:";
            label2.Click += label2_Click;
            // 
            // ModPristupuTR
            // 
            ModPristupuTR.FormattingEnabled = true;
            ModPristupuTR.Location = new Point(12, 75);
            ModPristupuTR.Name = "ModPristupuTR";
            ModPristupuTR.Size = new Size(121, 23);
            ModPristupuTR.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 83);
            label3.Name = "label3";
            label3.Size = new Size(143, 15);
            label3.TabIndex = 5;
            label3.Text = "Modifikátor přístupu třídy";
            // 
            // CoToJe
            // 
            CoToJe.Location = new Point(11, 104);
            CoToJe.Name = "CoToJe";
            CoToJe.Size = new Size(122, 23);
            CoToJe.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 112);
            label4.Name = "label4";
            label4.Size = new Size(156, 15);
            label4.TabIndex = 7;
            label4.Text = "Napiš, co tvoříš, např \"class\"";
            // 
            // NewNamespace
            // 
            NewNamespace.Location = new Point(338, 46);
            NewNamespace.Name = "NewNamespace";
            NewNamespace.PlaceholderText = "Nech prázdné pokud vybíráš existující";
            NewNamespace.Size = new Size(211, 23);
            NewNamespace.TabIndex = 8;
            // 
            // Nazev
            // 
            Nazev.Location = new Point(11, 133);
            Nazev.Name = "Nazev";
            Nazev.Size = new Size(122, 23);
            Nazev.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 141);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 10;
            label5.Text = "Název";
            // 
            // UpravRealizace
            // 
            UpravRealizace.Location = new Point(12, 162);
            UpravRealizace.Name = "UpravRealizace";
            UpravRealizace.Size = new Size(120, 23);
            UpravRealizace.TabIndex = 11;
            UpravRealizace.Text = "Uprav Realizace";
            UpravRealizace.UseVisualStyleBackColor = true;
            UpravRealizace.Click += UpravRealizace_Click;
            // 
            // UpravVlastnosti
            // 
            UpravVlastnosti.Location = new Point(12, 191);
            UpravVlastnosti.Name = "UpravVlastnosti";
            UpravVlastnosti.Size = new Size(120, 23);
            UpravVlastnosti.TabIndex = 12;
            UpravVlastnosti.Text = "Uprav vlastnosti";
            UpravVlastnosti.UseVisualStyleBackColor = true;
            UpravVlastnosti.Click += UpravVlastnosti_Click;
            // 
            // UpravMetody
            // 
            UpravMetody.Location = new Point(12, 220);
            UpravMetody.Name = "UpravMetody";
            UpravMetody.Size = new Size(121, 23);
            UpravMetody.TabIndex = 13;
            UpravMetody.Text = "Uprav metody";
            UpravMetody.UseVisualStyleBackColor = true;
            UpravMetody.Click += UpravMetody_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(12, 295);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(121, 43);
            SaveButton.TabIndex = 14;
            SaveButton.Text = "Uložit";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // Zrusit
            // 
            Zrusit.Location = new Point(139, 295);
            Zrusit.Name = "Zrusit";
            Zrusit.Size = new Size(120, 43);
            Zrusit.TabIndex = 15;
            Zrusit.Text = "Zrušit (smaže objekt)";
            Zrusit.UseVisualStyleBackColor = true;
            Zrusit.Click += Zrusit_Click_1;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 368);
            Controls.Add(Zrusit);
            Controls.Add(SaveButton);
            Controls.Add(UpravMetody);
            Controls.Add(UpravVlastnosti);
            Controls.Add(UpravRealizace);
            Controls.Add(label5);
            Controls.Add(Nazev);
            Controls.Add(NewNamespace);
            Controls.Add(label4);
            Controls.Add(CoToJe);
            Controls.Add(label3);
            Controls.Add(ModPristupuTR);
            Controls.Add(label2);
            Controls.Add(NamespaceChose);
            Controls.Add(label1);
            Controls.Add(EditUsings);
            Name = "EditForm";
            Text = "EditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EditUsings;
        private Label label1;
        private ComboBox NamespaceChose;
        private Label label2;
        private ComboBox ModPristupuTR;
        private Label label3;
        private TextBox CoToJe;
        private Label label4;
        private TextBox NewNamespace;
        private TextBox Nazev;
        private Label label5;
        private Button UpravRealizace;
        private Button UpravVlastnosti;
        private Button UpravMetody;
        private Button SaveButton;
        private Button Zrusit;
    }
}