namespace Base64
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnCodificar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnDecodificar = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.txtCodificar = new System.Windows.Forms.TextBox();
            this.txtDecodificar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnCopiarCodificado = new System.Windows.Forms.Button();
            this.btnCopiarDecodificado = new System.Windows.Forms.Button();
            this.btnCopiartexto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCodificar
            // 
            this.btnCodificar.Location = new System.Drawing.Point(28, 75);
            this.btnCodificar.Name = "btnCodificar";
            this.btnCodificar.Size = new System.Drawing.Size(75, 23);
            this.btnCodificar.TabIndex = 0;
            this.btnCodificar.Text = "Codificar";
            this.btnCodificar.UseVisualStyleBackColor = true;
            this.btnCodificar.Click += new System.EventHandler(this.btnCodificar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(190, 75);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnDecodificar
            // 
            this.btnDecodificar.Location = new System.Drawing.Point(109, 75);
            this.btnDecodificar.Name = "btnDecodificar";
            this.btnDecodificar.Size = new System.Drawing.Size(75, 23);
            this.btnDecodificar.TabIndex = 2;
            this.btnDecodificar.Text = "Decodificar";
            this.btnDecodificar.UseVisualStyleBackColor = true;
            this.btnDecodificar.Click += new System.EventHandler(this.btnDecodificar_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTexto.Location = new System.Drawing.Point(28, 45);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(619, 24);
            this.txtTexto.TabIndex = 3;
            // 
            // txtCodificar
            // 
            this.txtCodificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodificar.Location = new System.Drawing.Point(28, 138);
            this.txtCodificar.Multiline = true;
            this.txtCodificar.Name = "txtCodificar";
            this.txtCodificar.Size = new System.Drawing.Size(619, 128);
            this.txtCodificar.TabIndex = 4;
            // 
            // txtDecodificar
            // 
            this.txtDecodificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDecodificar.Location = new System.Drawing.Point(28, 296);
            this.txtDecodificar.Multiline = true;
            this.txtDecodificar.Name = "txtDecodificar";
            this.txtDecodificar.Size = new System.Drawing.Size(619, 217);
            this.txtDecodificar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Text A Codifcar / Decodificar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Text A Codifcar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Text A Decodificar";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(216, 565);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(169, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://erikrodrigu3z.blogspot.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnCopiarCodificado
            // 
            this.btnCopiarCodificado.Location = new System.Drawing.Point(572, 269);
            this.btnCopiarCodificado.Name = "btnCopiarCodificado";
            this.btnCopiarCodificado.Size = new System.Drawing.Size(75, 23);
            this.btnCopiarCodificado.TabIndex = 14;
            this.btnCopiarCodificado.Text = "Copiar";
            this.btnCopiarCodificado.UseVisualStyleBackColor = true;
            this.btnCopiarCodificado.Click += new System.EventHandler(this.btnCopiarCodificado_Click);
            // 
            // btnCopiarDecodificado
            // 
            this.btnCopiarDecodificado.Location = new System.Drawing.Point(572, 517);
            this.btnCopiarDecodificado.Name = "btnCopiarDecodificado";
            this.btnCopiarDecodificado.Size = new System.Drawing.Size(75, 23);
            this.btnCopiarDecodificado.TabIndex = 15;
            this.btnCopiarDecodificado.Text = "Copiar";
            this.btnCopiarDecodificado.UseVisualStyleBackColor = true;
            this.btnCopiarDecodificado.Click += new System.EventHandler(this.btnCopiarDecodificado_Click);
            // 
            // btnCopiartexto
            // 
            this.btnCopiartexto.Location = new System.Drawing.Point(572, 75);
            this.btnCopiartexto.Name = "btnCopiartexto";
            this.btnCopiartexto.Size = new System.Drawing.Size(75, 23);
            this.btnCopiartexto.TabIndex = 16;
            this.btnCopiartexto.Text = "Copiar";
            this.btnCopiartexto.UseVisualStyleBackColor = true;
            this.btnCopiartexto.Click += new System.EventHandler(this.btnCopiartexto_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 554);
            this.Controls.Add(this.btnCopiartexto);
            this.Controls.Add(this.btnCopiarDecodificado);
            this.Controls.Add(this.btnCopiarCodificado);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDecodificar);
            this.Controls.Add(this.txtCodificar);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.btnDecodificar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCodificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Texto A Base64";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCodificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnDecodificar;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.TextBox txtCodificar;
        private System.Windows.Forms.TextBox txtDecodificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnCopiarCodificado;
        private System.Windows.Forms.Button btnCopiarDecodificado;
        private System.Windows.Forms.Button btnCopiartexto;
    }
}

