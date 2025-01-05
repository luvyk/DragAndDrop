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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox3 = new TextBox();
            button2 = new Button();
            button3 = new Button();
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
            // textBox1
            // 
            textBox1.Location = new Point(12, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(146, 23);
            textBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(12, 99);
            button1.Name = "button1";
            button1.Size = new Size(146, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(146, 23);
            textBox3.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(12, 288);
            button2.Name = "button2";
            button2.Size = new Size(146, 41);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(164, 288);
            button3.Name = "button3";
            button3.Size = new Size(146, 41);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // EditMetoda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 341);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Name = "EditMetoda";
            Text = "EditMetoda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox3;
        private Button button2;
        private Button button3;
    }
}