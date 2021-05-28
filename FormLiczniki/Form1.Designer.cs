
namespace FormLiczniki
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
            this.textBoxNazwa = new System.Windows.Forms.TextBox();
            this.textBoxTyp = new System.Windows.Forms.TextBox();
            this.ButtonWprowadz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.Location = new System.Drawing.Point(175, 110);
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.Size = new System.Drawing.Size(391, 27);
            this.textBoxNazwa.TabIndex = 0;
            // 
            // textBoxTyp
            // 
            this.textBoxTyp.Location = new System.Drawing.Point(185, 245);
            this.textBoxTyp.Name = "textBoxTyp";
            this.textBoxTyp.Size = new System.Drawing.Size(391, 27);
            this.textBoxTyp.TabIndex = 1;
            // 
            // ButtonWprowadz
            // 
            this.ButtonWprowadz.Location = new System.Drawing.Point(367, 347);
            this.ButtonWprowadz.Name = "ButtonWprowadz";
            this.ButtonWprowadz.Size = new System.Drawing.Size(199, 152);
            this.ButtonWprowadz.TabIndex = 3;
            this.ButtonWprowadz.Text = "Wprowadz";
            this.ButtonWprowadz.UseVisualStyleBackColor = true;
            this.ButtonWprowadz.Click += new System.EventHandler(this.ButtonWprowadz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nazwa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Typ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonWprowadz);
            this.Controls.Add(this.textBoxTyp);
            this.Controls.Add(this.textBoxNazwa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNazwa;
        private System.Windows.Forms.TextBox textBoxTyp;
        private System.Windows.Forms.Button ButtonWprowadz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

