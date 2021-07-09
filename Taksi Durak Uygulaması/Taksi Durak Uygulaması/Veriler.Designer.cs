
namespace Taksi_Durak_Uygulaması
{
    partial class Veriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Veriler));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnVerileriGüncelle = new System.Windows.Forms.Button();
            this.btnVerileriSil = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1250, 359);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnVerileriGüncelle
            // 
            this.btnVerileriGüncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnVerileriGüncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerileriGüncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnVerileriGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerileriGüncelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVerileriGüncelle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVerileriGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerileriGüncelle.Location = new System.Drawing.Point(12, 437);
            this.btnVerileriGüncelle.Name = "btnVerileriGüncelle";
            this.btnVerileriGüncelle.Size = new System.Drawing.Size(158, 37);
            this.btnVerileriGüncelle.TabIndex = 36;
            this.btnVerileriGüncelle.Text = "Verileri Güncelle";
            this.btnVerileriGüncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerileriGüncelle.UseVisualStyleBackColor = false;
            this.btnVerileriGüncelle.Click += new System.EventHandler(this.btnVerileriGüncelle_Click);
            // 
            // btnVerileriSil
            // 
            this.btnVerileriSil.BackColor = System.Drawing.Color.Transparent;
            this.btnVerileriSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerileriSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnVerileriSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerileriSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVerileriSil.ForeColor = System.Drawing.Color.Firebrick;
            this.btnVerileriSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerileriSil.Location = new System.Drawing.Point(210, 437);
            this.btnVerileriSil.Name = "btnVerileriSil";
            this.btnVerileriSil.Size = new System.Drawing.Size(105, 37);
            this.btnVerileriSil.TabIndex = 37;
            this.btnVerileriSil.Text = "Verileri Sil";
            this.btnVerileriSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerileriSil.UseVisualStyleBackColor = false;
            this.btnVerileriSil.Click += new System.EventHandler(this.btnVerileriSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Transparent;
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.Location = new System.Drawing.Point(1166, 427);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(76, 57);
            this.btnKapat.TabIndex = 38;
            this.btnKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Silver;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(0, 359);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1250, 62);
            this.richTextBox1.TabIndex = 39;
            this.richTextBox1.Text = "";
            // 
            // Veriler
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1250, 486);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnVerileriSil);
            this.Controls.Add(this.btnVerileriGüncelle);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Veriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veriler";
            this.Load += new System.EventHandler(this.Veriler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnVerileriGüncelle;
        private System.Windows.Forms.Button btnVerileriSil;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}