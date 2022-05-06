namespace appEstudiantes
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btncurso = new System.Windows.Forms.Button();
            this.btnestudiante = new System.Windows.Forms.Button();
            this.btnprincipal = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnprincipal);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 605);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 330);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(256, 275);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            this.panel3.Controls.Add(this.btncurso);
            this.panel3.Controls.Add(this.btnestudiante);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 115);
            this.panel3.TabIndex = 2;
            // 
            // btncurso
            // 
            this.btncurso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncurso.FlatAppearance.BorderSize = 0;
            this.btncurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncurso.ForeColor = System.Drawing.Color.White;
            this.btncurso.Location = new System.Drawing.Point(0, 52);
            this.btncurso.Name = "btncurso";
            this.btncurso.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btncurso.Size = new System.Drawing.Size(256, 52);
            this.btncurso.TabIndex = 1;
            this.btncurso.Text = "Editar notas";
            this.btncurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncurso.UseVisualStyleBackColor = true;
            this.btncurso.Click += new System.EventHandler(this.btncurso_Click);
            // 
            // btnestudiante
            // 
            this.btnestudiante.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnestudiante.FlatAppearance.BorderSize = 0;
            this.btnestudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnestudiante.ForeColor = System.Drawing.Color.White;
            this.btnestudiante.Location = new System.Drawing.Point(0, 0);
            this.btnestudiante.Name = "btnestudiante";
            this.btnestudiante.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnestudiante.Size = new System.Drawing.Size(256, 52);
            this.btnestudiante.TabIndex = 0;
            this.btnestudiante.Text = "Editar estudiante";
            this.btnestudiante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnestudiante.UseVisualStyleBackColor = true;
            this.btnestudiante.Click += new System.EventHandler(this.btnestudiante_Click);
            // 
            // btnprincipal
            // 
            this.btnprincipal.BackColor = System.Drawing.Color.Black;
            this.btnprincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnprincipal.FlatAppearance.BorderSize = 0;
            this.btnprincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprincipal.ForeColor = System.Drawing.Color.White;
            this.btnprincipal.Image = ((System.Drawing.Image)(resources.GetObject("btnprincipal.Image")));
            this.btnprincipal.Location = new System.Drawing.Point(0, 100);
            this.btnprincipal.Name = "btnprincipal";
            this.btnprincipal.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnprincipal.Size = new System.Drawing.Size(256, 57);
            this.btnprincipal.TabIndex = 1;
            this.btnprincipal.Text = "Menu principal";
            this.btnprincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprincipal.UseVisualStyleBackColor = false;
            this.btnprincipal.Click += new System.EventHandler(this.btnprincipal_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 100);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(256, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1064, 605);
            this.panel4.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 14.26415F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.label6.Location = new System.Drawing.Point(171, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "un mundo mejor\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 14.26415F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.label5.Location = new System.Drawing.Point(95, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "\"Forjando mentes creativas para";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 21.73585F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(375, 39);
            this.label4.TabIndex = 4;
            this.label4.Text = "I.E. CARLOS MORALES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 21.73585F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(138, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "DE CHIMBOTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 21.73585F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(331, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "A LA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 21.73585F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "BIENVENIDO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(488, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 564);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 605);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPrincipal";
            this.Text = "IE. Carlos Morales de Chimbote";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btncurso;
        private System.Windows.Forms.Button btnestudiante;
        private System.Windows.Forms.Button btnprincipal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

