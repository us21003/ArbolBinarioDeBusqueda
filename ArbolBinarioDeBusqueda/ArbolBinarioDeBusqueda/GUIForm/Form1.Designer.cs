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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowPostorder = new System.Windows.Forms.Button();
            this.btnShowInorder = new System.Windows.Forms.Button();
            this.btnShowPreorder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearchKey = new System.Windows.Forms.Button();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowPostorder);
            this.groupBox1.Controls.Add(this.btnShowInorder);
            this.groupBox1.Controls.Add(this.btnShowPreorder);
            this.groupBox1.Location = new System.Drawing.Point(315, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recorrido";
            // 
            // btnShowPostorder
            // 
            this.btnShowPostorder.Location = new System.Drawing.Point(230, 35);
            this.btnShowPostorder.Name = "btnShowPostorder";
            this.btnShowPostorder.Size = new System.Drawing.Size(75, 27);
            this.btnShowPostorder.TabIndex = 0;
            this.btnShowPostorder.Text = "Postorder";
            this.btnShowPostorder.UseVisualStyleBackColor = true;
            this.btnShowPostorder.Click += new System.EventHandler(this.btnShowPostorder_Click);
            // 
            // btnShowInorder
            // 
            this.btnShowInorder.Location = new System.Drawing.Point(127, 35);
            this.btnShowInorder.Name = "btnShowInorder";
            this.btnShowInorder.Size = new System.Drawing.Size(75, 27);
            this.btnShowInorder.TabIndex = 0;
            this.btnShowInorder.Text = "Inorder";
            this.btnShowInorder.UseVisualStyleBackColor = true;
            this.btnShowInorder.Click += new System.EventHandler(this.btnShowInorder_Click);
            // 
            // btnShowPreorder
            // 
            this.btnShowPreorder.Location = new System.Drawing.Point(27, 35);
            this.btnShowPreorder.Name = "btnShowPreorder";
            this.btnShowPreorder.Size = new System.Drawing.Size(75, 27);
            this.btnShowPreorder.TabIndex = 0;
            this.btnShowPreorder.Text = "Preorder";
            this.btnShowPreorder.UseVisualStyleBackColor = true;
            this.btnShowPreorder.Click += new System.EventHandler(this.btnShowPreorder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGenerateKey);
            this.groupBox2.Location = new System.Drawing.Point(52, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 94);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generar clave";
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Location = new System.Drawing.Point(35, 30);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(125, 32);
            this.btnGenerateKey.TabIndex = 1;
            this.btnGenerateKey.Text = "Generar nueva clave";
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearchKey);
            this.groupBox3.Controls.Add(this.txtSearchKey);
            this.groupBox3.Location = new System.Drawing.Point(52, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 105);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar clave";
            // 
            // btnSearchKey
            // 
            this.btnSearchKey.Location = new System.Drawing.Point(35, 59);
            this.btnSearchKey.Name = "btnSearchKey";
            this.btnSearchKey.Size = new System.Drawing.Size(125, 28);
            this.btnSearchKey.TabIndex = 1;
            this.btnSearchKey.Text = "Buscar";
            this.btnSearchKey.UseVisualStyleBackColor = true;
            this.btnSearchKey.Click += new System.EventHandler(this.btnSearchKey_Click);
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Location = new System.Drawing.Point(35, 19);
            this.txtSearchKey.Multiline = true;
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(125, 25);
            this.txtSearchKey.TabIndex = 0;
            this.txtSearchKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchKey_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(315, 156);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(331, 105);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vista gráfica";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mostrar dibujo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(692, 304);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Menu principal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowPostorder;
        private System.Windows.Forms.Button btnShowInorder;
        private System.Windows.Forms.Button btnShowPreorder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSearchKey;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
    }
}

