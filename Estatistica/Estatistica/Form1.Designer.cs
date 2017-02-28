namespace Estatistica
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
            this.txtValores = new System.Windows.Forms.TextBox();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.txtValoresDesordenados = new System.Windows.Forms.TextBox();
            this.btOrdenar = new System.Windows.Forms.Button();
            this.txtValoresOrdenados = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lblElementosRol = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblMediana = new System.Windows.Forms.Label();
            this.lblContagemElementos = new System.Windows.Forms.Label();
            this.lblCalculoMedia = new System.Windows.Forms.Label();
            this.lblCalculoMediana = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValores
            // 
            this.txtValores.Location = new System.Drawing.Point(12, 12);
            this.txtValores.Name = "txtValores";
            this.txtValores.Size = new System.Drawing.Size(100, 20);
            this.txtValores.TabIndex = 0;
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(12, 38);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(100, 23);
            this.btAdicionar.TabIndex = 1;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // txtValoresDesordenados
            // 
            this.txtValoresDesordenados.Location = new System.Drawing.Point(12, 67);
            this.txtValoresDesordenados.Multiline = true;
            this.txtValoresDesordenados.Name = "txtValoresDesordenados";
            this.txtValoresDesordenados.Size = new System.Drawing.Size(100, 154);
            this.txtValoresDesordenados.TabIndex = 2;
            // 
            // btOrdenar
            // 
            this.btOrdenar.Location = new System.Drawing.Point(139, 38);
            this.btOrdenar.Name = "btOrdenar";
            this.btOrdenar.Size = new System.Drawing.Size(100, 23);
            this.btOrdenar.TabIndex = 3;
            this.btOrdenar.Text = "Ordenar";
            this.btOrdenar.UseVisualStyleBackColor = true;
            this.btOrdenar.Click += new System.EventHandler(this.btOrdenar_Click);
            // 
            // txtValoresOrdenados
            // 
            this.txtValoresOrdenados.Location = new System.Drawing.Point(139, 67);
            this.txtValoresOrdenados.Multiline = true;
            this.txtValoresOrdenados.Name = "txtValoresOrdenados";
            this.txtValoresOrdenados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtValoresOrdenados.Size = new System.Drawing.Size(100, 154);
            this.txtValoresOrdenados.TabIndex = 4;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(263, 38);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(100, 23);
            this.btCalcular.TabIndex = 5;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lblElementosRol
            // 
            this.lblElementosRol.AutoSize = true;
            this.lblElementosRol.Location = new System.Drawing.Point(260, 82);
            this.lblElementosRol.Name = "lblElementosRol";
            this.lblElementosRol.Size = new System.Drawing.Size(85, 13);
            this.lblElementosRol.TabIndex = 6;
            this.lblElementosRol.Text = "Elementos no rol";
            // 
            // lblMedia
            // 
            this.lblMedia.Location = new System.Drawing.Point(260, 127);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(100, 13);
            this.lblMedia.TabIndex = 7;
            this.lblMedia.Text = "Média";
            // 
            // lblMediana
            // 
            this.lblMediana.Location = new System.Drawing.Point(260, 172);
            this.lblMediana.Name = "lblMediana";
            this.lblMediana.Size = new System.Drawing.Size(100, 13);
            this.lblMediana.TabIndex = 8;
            this.lblMediana.Text = "Mediana";
            // 
            // lblContagemElementos
            // 
            this.lblContagemElementos.AutoSize = true;
            this.lblContagemElementos.Location = new System.Drawing.Point(371, 82);
            this.lblContagemElementos.Name = "lblContagemElementos";
            this.lblContagemElementos.Size = new System.Drawing.Size(0, 13);
            this.lblContagemElementos.TabIndex = 9;
            this.lblContagemElementos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCalculoMedia
            // 
            this.lblCalculoMedia.AutoSize = true;
            this.lblCalculoMedia.Location = new System.Drawing.Point(371, 127);
            this.lblCalculoMedia.Name = "lblCalculoMedia";
            this.lblCalculoMedia.Size = new System.Drawing.Size(0, 13);
            this.lblCalculoMedia.TabIndex = 10;
            this.lblCalculoMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCalculoMediana
            // 
            this.lblCalculoMediana.AutoSize = true;
            this.lblCalculoMediana.Location = new System.Drawing.Point(371, 172);
            this.lblCalculoMediana.Name = "lblCalculoMediana";
            this.lblCalculoMediana.Size = new System.Drawing.Size(0, 13);
            this.lblCalculoMediana.TabIndex = 11;
            this.lblCalculoMediana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 233);
            this.Controls.Add(this.lblCalculoMediana);
            this.Controls.Add(this.lblCalculoMedia);
            this.Controls.Add(this.lblContagemElementos);
            this.Controls.Add(this.lblMediana);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblElementosRol);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtValoresOrdenados);
            this.Controls.Add(this.btOrdenar);
            this.Controls.Add(this.txtValoresDesordenados);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.txtValores);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculos Estatísticos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValores;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.TextBox txtValoresDesordenados;
        private System.Windows.Forms.Button btOrdenar;
        private System.Windows.Forms.TextBox txtValoresOrdenados;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lblElementosRol;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblMediana;
        private System.Windows.Forms.Label lblContagemElementos;
        private System.Windows.Forms.Label lblCalculoMedia;
        private System.Windows.Forms.Label lblCalculoMediana;
    }
}

