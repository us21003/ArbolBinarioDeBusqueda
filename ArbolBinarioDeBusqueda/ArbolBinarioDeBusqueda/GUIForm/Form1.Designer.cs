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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowPostorder);
            this.groupBox1.Controls.Add(this.btnShowInorder);
            this.groupBox1.Controls.Add(this.btnShowPreorder);
            this.groupBox1.Location = new System.Drawing.Point(315, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 222);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar arbol";
            // 
            // btnShowPostorder
            // 
            this.btnShowPostorder.Location = new System.Drawing.Point(51, 164);
            this.btnShowPostorder.Name = "btnShowPostorder";
            this.btnShowPostorder.Size = new System.Drawing.Size(75, 27);
            this.btnShowPostorder.TabIndex = 0;
            this.btnShowPostorder.Text = "Postorder";
            this.btnShowPostorder.UseVisualStyleBackColor = true;
            // 
            // btnShowInorder
            // 
            this.btnShowInorder.Location = new System.Drawing.Point(51, 98);
            this.btnShowInorder.Name = "btnShowInorder";
            this.btnShowInorder.Size = new System.Drawing.Size(75, 27);
            this.btnShowInorder.TabIndex = 0;
            this.btnShowInorder.Text = "Inorder";
            this.btnShowInorder.UseVisualStyleBackColor = true;
            // 
            // btnShowPreorder
            // 
            this.btnShowPreorder.Location = new System.Drawing.Point(51, 30);
            this.btnShowPreorder.Name = "btnShowPreorder";
            this.btnShowPreorder.Size = new System.Drawing.Size(75, 27);
            this.btnShowPreorder.TabIndex = 0;
            this.btnShowPreorder.Text = "Preorder";
            this.btnShowPreorder.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGenerateKey);
            this.groupBox2.Location = new System.Drawing.Point(52, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 94);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu principal";
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
            this.groupBox3.Text = "Buscar";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(555, 304);
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
    }
}

