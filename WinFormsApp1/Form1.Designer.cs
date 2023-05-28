namespace lista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxLista = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxLista
            // 
            this.TextBoxLista.Location = new System.Drawing.Point(89, 32);
            this.TextBoxLista.Name = "TextBoxLista";
            this.TextBoxLista.Size = new System.Drawing.Size(414, 250);
            this.TextBoxLista.TabIndex = 0;
            this.TextBoxLista.Text = "TextBoxLista";
            this.TextBoxLista.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sortuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBoxLista);
            this.Name = "Form1";
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox TextBoxLista;
        private Button button1;
    }
}