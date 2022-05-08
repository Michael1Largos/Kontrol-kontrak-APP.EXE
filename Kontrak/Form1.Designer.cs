namespace Kontrak
{
    partial class Form1
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
            this.nomor = new System.Windows.Forms.TextBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.show_nama = new System.Windows.Forms.TextBox();
            this.show_nomor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nomor
            // 
            this.nomor.Location = new System.Drawing.Point(111, 29);
            this.nomor.Name = "nomor";
            this.nomor.Size = new System.Drawing.Size(100, 20);
            this.nomor.TabIndex = 0;
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(111, 55);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(100, 20);
            this.nama.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nomor Induk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(111, 81);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 4;
            this.save_button.Text = "Submit";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(111, 110);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 5;
            this.show.Text = "show";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // show_nama
            // 
            this.show_nama.Location = new System.Drawing.Point(111, 139);
            this.show_nama.Name = "show_nama";
            this.show_nama.Size = new System.Drawing.Size(100, 20);
            this.show_nama.TabIndex = 6;
            // 
            // show_nomor
            // 
            this.show_nomor.Location = new System.Drawing.Point(111, 165);
            this.show_nomor.Name = "show_nomor";
            this.show_nomor.Size = new System.Drawing.Size(100, 20);
            this.show_nomor.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show_nomor);
            this.Controls.Add(this.show_nama);
            this.Controls.Add(this.show);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.nomor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomor;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.TextBox show_nama;
        private System.Windows.Forms.TextBox show_nomor;
    }
}

