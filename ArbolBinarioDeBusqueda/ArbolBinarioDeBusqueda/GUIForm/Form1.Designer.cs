namespace ArbolBinarioDeBusqueda {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLeftSide = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxUESLogo = new System.Windows.Forms.PictureBox();
            this.panelMainForm = new System.Windows.Forms.Panel();
            this.groupBoxExit = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearchKey = new System.Windows.Forms.Button();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowPostorder = new System.Windows.Forms.Button();
            this.btnShowInorder = new System.Windows.Forms.Button();
            this.btnShowPreorder = new System.Windows.Forms.Button();
            this.panelLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUESLogo)).BeginInit();
            this.panelMainForm.SuspendLayout();
            this.groupBoxExit.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftSide
            // 
            this.panelLeftSide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLeftSide.Controls.Add(this.pictureBox1);
            this.panelLeftSide.Controls.Add(this.pictureBox2);
            this.panelLeftSide.Controls.Add(this.pictureBoxUESLogo);
            this.panelLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSide.Location = new System.Drawing.Point(0, 0);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.Size = new System.Drawing.Size(200, 579);
            this.panelLeftSide.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 403);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 212);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxUESLogo
            // 
            this.pictureBoxUESLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxUESLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUESLogo.Image")));
            this.pictureBoxUESLogo.Location = new System.Drawing.Point(23, 22);
            this.pictureBoxUESLogo.Name = "pictureBoxUESLogo";
            this.pictureBoxUESLogo.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxUESLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxUESLogo.TabIndex = 8;
            this.pictureBoxUESLogo.TabStop = false;
            // 
            // panelMainForm
            // 
            this.panelMainForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMainForm.Controls.Add(this.groupBoxExit);
            this.panelMainForm.Controls.Add(this.groupBox4);
            this.panelMainForm.Controls.Add(this.groupBox3);
            this.panelMainForm.Controls.Add(this.groupBox2);
            this.panelMainForm.Controls.Add(this.groupBox1);
            this.panelMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainForm.Location = new System.Drawing.Point(200, 0);
            this.panelMainForm.Name = "panelMainForm";
            this.panelMainForm.Size = new System.Drawing.Size(575, 579);
            this.panelMainForm.TabIndex = 6;
            this.panelMainForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMainForm_MouseDown);
            // 
            // groupBoxExit
            // 
            this.groupBoxExit.Controls.Add(this.btnExit);
            this.groupBoxExit.ForeColor = System.Drawing.Color.White;
            this.groupBoxExit.Location = new System.Drawing.Point(305, 405);
            this.groupBoxExit.Name = "groupBoxExit";
            this.groupBoxExit.Size = new System.Drawing.Size(228, 144);
            this.groupBoxExit.TabIndex = 8;
            this.groupBoxExit.TabStop = false;
            this.groupBoxExit.Text = "Cerrar menú";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(104)))), ((int)(((byte)(137)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(51, 57);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 43);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(305, 214);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(228, 144);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vista gráfica";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(104)))), ((int)(((byte)(137)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(51, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mostrar dibujo";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearchKey);
            this.groupBox3.Controls.Add(this.txtSearchKey);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(305, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 150);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar clave";
            // 
            // btnSearchKey
            // 
            this.btnSearchKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(104)))), ((int)(((byte)(137)))));
            this.btnSearchKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchKey.ForeColor = System.Drawing.Color.Black;
            this.btnSearchKey.Location = new System.Drawing.Point(50, 77);
            this.btnSearchKey.Name = "btnSearchKey";
            this.btnSearchKey.Size = new System.Drawing.Size(125, 36);
            this.btnSearchKey.TabIndex = 1;
            this.btnSearchKey.Text = "Buscar";
            this.btnSearchKey.UseVisualStyleBackColor = false;
            this.btnSearchKey.Click += new System.EventHandler(this.btnSearchKey_Click);
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.BackColor = System.Drawing.Color.White;
            this.txtSearchKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchKey.ForeColor = System.Drawing.Color.Black;
            this.txtSearchKey.Location = new System.Drawing.Point(50, 35);
            this.txtSearchKey.Multiline = true;
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(125, 33);
            this.txtSearchKey.TabIndex = 0;
            this.txtSearchKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGenerateKey);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(42, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 150);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generar clave";
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(104)))), ((int)(((byte)(137)))));
            this.btnGenerateKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateKey.ForeColor = System.Drawing.Color.Black;
            this.btnGenerateKey.Location = new System.Drawing.Point(51, 52);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(125, 43);
            this.btnGenerateKey.TabIndex = 1;
            this.btnGenerateKey.Text = "Generar nueva clave";
            this.btnGenerateKey.UseVisualStyleBackColor = false;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowPostorder);
            this.groupBox1.Controls.Add(this.btnShowInorder);
            this.groupBox1.Controls.Add(this.btnShowPreorder);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(42, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 341);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recorrido";
            // 
            // btnShowPostorder
            // 
            this.btnShowPostorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(104)))), ((int)(((byte)(137)))));
            this.btnShowPostorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPostorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPostorder.ForeColor = System.Drawing.Color.Black;
            this.btnShowPostorder.Location = new System.Drawing.Point(50, 233);
            this.btnShowPostorder.Name = "btnShowPostorder";
            this.btnShowPostorder.Size = new System.Drawing.Size(125, 43);
            this.btnShowPostorder.TabIndex = 0;
            this.btnShowPostorder.Text = "Postorder";
            this.btnShowPostorder.UseVisualStyleBackColor = false;
            this.btnShowPostorder.Click += new System.EventHandler(this.btnShowPostorder_Click);
            // 
            // btnShowInorder
            // 
            this.btnShowInorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(104)))), ((int)(((byte)(137)))));
            this.btnShowInorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowInorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInorder.ForeColor = System.Drawing.Color.Black;
            this.btnShowInorder.Location = new System.Drawing.Point(50, 140);
            this.btnShowInorder.Name = "btnShowInorder";
            this.btnShowInorder.Size = new System.Drawing.Size(125, 43);
            this.btnShowInorder.TabIndex = 0;
            this.btnShowInorder.Text = "Inorder";
            this.btnShowInorder.UseVisualStyleBackColor = false;
            this.btnShowInorder.Click += new System.EventHandler(this.btnShowInorder_Click);
            // 
            // btnShowPreorder
            // 
            this.btnShowPreorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(104)))), ((int)(((byte)(137)))));
            this.btnShowPreorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPreorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPreorder.ForeColor = System.Drawing.Color.Black;
            this.btnShowPreorder.Location = new System.Drawing.Point(50, 54);
            this.btnShowPreorder.Name = "btnShowPreorder";
            this.btnShowPreorder.Size = new System.Drawing.Size(125, 43);
            this.btnShowPreorder.TabIndex = 0;
            this.btnShowPreorder.Text = "Preorder";
            this.btnShowPreorder.UseVisualStyleBackColor = false;
            this.btnShowPreorder.Click += new System.EventHandler(this.btnShowPreorder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(775, 579);
            this.Controls.Add(this.panelMainForm);
            this.Controls.Add(this.panelLeftSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Menu principal";
            this.panelLeftSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUESLogo)).EndInit();
            this.panelMainForm.ResumeLayout(false);
            this.groupBoxExit.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeftSide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxUESLogo;
        private System.Windows.Forms.Panel panelMainForm;
        private System.Windows.Forms.GroupBox groupBoxExit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSearchKey;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowPostorder;
        private System.Windows.Forms.Button btnShowInorder;
        private System.Windows.Forms.Button btnShowPreorder;
    }
}

