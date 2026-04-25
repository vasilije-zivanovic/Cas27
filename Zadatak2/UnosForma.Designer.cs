namespace Zadatak2
{
    partial class UnosForma
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Adresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Naziv = new System.Windows.Forms.TextBox();
            this.Spec = new System.Windows.Forms.TextBox();
            this.Otvoren = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Strana = new System.Windows.Forms.RadioButton();
            this.Domaca = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.0073F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.9927F));
            this.tableLayoutPanel1.Controls.Add(this.Adresa, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Naziv, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Spec, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Otvoren, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(558, 408);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Adresa
            // 
            this.Adresa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Adresa.Location = new System.Drawing.Point(153, 111);
            this.Adresa.Name = "Adresa";
            this.Adresa.Size = new System.Drawing.Size(223, 20);
            this.Adresa.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(3, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 81);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(3, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 81);
            this.label3.TabIndex = 2;
            this.label3.Text = "Otvoren?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(3, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 81);
            this.label4.TabIndex = 3;
            this.label4.Text = "Specijalitet";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(3, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 84);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tip hrane";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Naziv
            // 
            this.Naziv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Naziv.Location = new System.Drawing.Point(153, 30);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(223, 20);
            this.Naziv.TabIndex = 5;
            this.Naziv.TextChanged += new System.EventHandler(this.Naziv_TextChanged);
            // 
            // Spec
            // 
            this.Spec.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Spec.Location = new System.Drawing.Point(153, 273);
            this.Spec.Name = "Spec";
            this.Spec.Size = new System.Drawing.Size(223, 20);
            this.Spec.TabIndex = 7;
            // 
            // Otvoren
            // 
            this.Otvoren.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Otvoren.AutoSize = true;
            this.Otvoren.Location = new System.Drawing.Point(153, 165);
            this.Otvoren.Name = "Otvoren";
            this.Otvoren.Size = new System.Drawing.Size(15, 75);
            this.Otvoren.TabIndex = 8;
            this.Otvoren.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Strana);
            this.groupBox1.Controls.Add(this.Domaca);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(153, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 78);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // Strana
            // 
            this.Strana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Strana.AutoSize = true;
            this.Strana.Location = new System.Drawing.Point(97, 31);
            this.Strana.Name = "Strana";
            this.Strana.Size = new System.Drawing.Size(56, 17);
            this.Strana.TabIndex = 1;
            this.Strana.TabStop = true;
            this.Strana.Text = "Strana";
            this.Strana.UseVisualStyleBackColor = true;
            // 
            // Domaca
            // 
            this.Domaca.AutoSize = true;
            this.Domaca.Location = new System.Drawing.Point(6, 31);
            this.Domaca.Name = "Domaca";
            this.Domaca.Size = new System.Drawing.Size(65, 17);
            this.Domaca.TabIndex = 0;
            this.Domaca.TabStop = true;
            this.Domaca.Text = "Domaca";
            this.Domaca.UseVisualStyleBackColor = true;
            // 
            // UnosForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UnosForma";
            this.Size = new System.Drawing.Size(558, 408);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Adresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Naziv;
        private System.Windows.Forms.TextBox Spec;
        private System.Windows.Forms.CheckBox Otvoren;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Strana;
        private System.Windows.Forms.RadioButton Domaca;
    }
}
