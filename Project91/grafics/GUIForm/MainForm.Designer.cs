namespace Project91.GUIForm {
    partial class MainForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMainForm = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDrawTree = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.btnSearchKey = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnShowPostorder = new System.Windows.Forms.Button();
            this.btnShowInorder = new System.Windows.Forms.Button();
            this.btnShowPreorder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMainForm.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(109)))), ((int)(((byte)(133)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 600);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(22, 411);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 219);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMainForm
            // 
            this.panelMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(233)))), ((int)(((byte)(222)))));
            this.panelMainForm.Controls.Add(this.groupBox5);
            this.panelMainForm.Controls.Add(this.groupBox4);
            this.panelMainForm.Controls.Add(this.groupBox2);
            this.panelMainForm.Controls.Add(this.groupBox3);
            this.panelMainForm.Controls.Add(this.groupBox1);
            this.panelMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainForm.Location = new System.Drawing.Point(200, 0);
            this.panelMainForm.Name = "panelMainForm";
            this.panelMainForm.Size = new System.Drawing.Size(650, 600);
            this.panelMainForm.TabIndex = 0;
            this.panelMainForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMainForm_MouseDown);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnExit);
            this.groupBox5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(360, 383);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(242, 157);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cerrar ventana";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnExit.Location = new System.Drawing.Point(54, 64);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 47);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDrawTree);
            this.groupBox4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(360, 202);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(242, 157);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ver gráficamente";
            // 
            // btnDrawTree
            // 
            this.btnDrawTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnDrawTree.Location = new System.Drawing.Point(54, 58);
            this.btnDrawTree.Name = "btnDrawTree";
            this.btnDrawTree.Size = new System.Drawing.Size(131, 47);
            this.btnDrawTree.TabIndex = 0;
            this.btnDrawTree.Text = "Ver dibujo";
            this.btnDrawTree.UseVisualStyleBackColor = false;
            this.btnDrawTree.Click += new System.EventHandler(this.btnDrawTree_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearchKey);
            this.groupBox2.Controls.Add(this.btnSearchKey);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(360, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 157);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar clave";
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.BackColor = System.Drawing.Color.White;
            this.txtSearchKey.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchKey.Location = new System.Drawing.Point(54, 38);
            this.txtSearchKey.Multiline = true;
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(131, 36);
            this.txtSearchKey.TabIndex = 1;
            this.txtSearchKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchKey_KeyPress);
            // 
            // btnSearchKey
            // 
            this.btnSearchKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnSearchKey.Location = new System.Drawing.Point(54, 80);
            this.btnSearchKey.Name = "btnSearchKey";
            this.btnSearchKey.Size = new System.Drawing.Size(131, 47);
            this.btnSearchKey.TabIndex = 0;
            this.btnSearchKey.Text = "Buscar";
            this.btnSearchKey.UseVisualStyleBackColor = false;
            this.btnSearchKey.Click += new System.EventHandler(this.btnSearchKey_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnShowPostorder);
            this.groupBox3.Controls.Add(this.btnShowInorder);
            this.groupBox3.Controls.Add(this.btnShowPreorder);
            this.groupBox3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(42, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 338);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recorridos";
            // 
            // btnShowPostorder
            // 
            this.btnShowPostorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnShowPostorder.Location = new System.Drawing.Point(53, 245);
            this.btnShowPostorder.Name = "btnShowPostorder";
            this.btnShowPostorder.Size = new System.Drawing.Size(131, 47);
            this.btnShowPostorder.TabIndex = 0;
            this.btnShowPostorder.Text = "Postorder";
            this.btnShowPostorder.UseVisualStyleBackColor = false;
            this.btnShowPostorder.Click += new System.EventHandler(this.btnShowPostorder_Click);
            // 
            // btnShowInorder
            // 
            this.btnShowInorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnShowInorder.Location = new System.Drawing.Point(53, 152);
            this.btnShowInorder.Name = "btnShowInorder";
            this.btnShowInorder.Size = new System.Drawing.Size(131, 47);
            this.btnShowInorder.TabIndex = 0;
            this.btnShowInorder.Text = "Inorder";
            this.btnShowInorder.UseVisualStyleBackColor = false;
            this.btnShowInorder.Click += new System.EventHandler(this.btnShowInorder_Click);
            // 
            // btnShowPreorder
            // 
            this.btnShowPreorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnShowPreorder.Location = new System.Drawing.Point(53, 58);
            this.btnShowPreorder.Name = "btnShowPreorder";
            this.btnShowPreorder.Size = new System.Drawing.Size(131, 47);
            this.btnShowPreorder.TabIndex = 0;
            this.btnShowPreorder.Text = "Preorder";
            this.btnShowPreorder.UseVisualStyleBackColor = false;
            this.btnShowPreorder.Click += new System.EventHandler(this.btnShowPreorder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerateKey);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(42, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar nueva clave";
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnGenerateKey.Location = new System.Drawing.Point(53, 56);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(131, 47);
            this.btnGenerateKey.TabIndex = 0;
            this.btnGenerateKey.Text = "Generar clave";
            this.btnGenerateKey.UseVisualStyleBackColor = false;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.panelMainForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú principal - Árbol Binario de Búsqueda";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMainForm.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMainForm;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDrawTree;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearchKey;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnShowPostorder;
        private System.Windows.Forms.Button btnShowInorder;
        private System.Windows.Forms.Button btnShowPreorder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.TextBox txtSearchKey;
    }
}