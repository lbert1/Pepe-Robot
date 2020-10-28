namespace Pepe
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.Cod_Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vlr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntPlay = new System.Windows.Forms.Button();
            this.pBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Ativo,
            this.Vlr});
            this.dgvMain.Location = new System.Drawing.Point(4, 41);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.Size = new System.Drawing.Size(288, 400);
            this.dgvMain.TabIndex = 0;
            // 
            // Cod_Ativo
            // 
            this.Cod_Ativo.HeaderText = "Cód Ativo";
            this.Cod_Ativo.Name = "Cod_Ativo";
            // 
            // Vlr
            // 
            this.Vlr.HeaderText = "Valor";
            this.Vlr.Name = "Vlr";
            // 
            // bntPlay
            // 
            this.bntPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntPlay.ForeColor = System.Drawing.Color.Chartreuse;
            this.bntPlay.Location = new System.Drawing.Point(4, 12);
            this.bntPlay.Name = "bntPlay";
            this.bntPlay.Size = new System.Drawing.Size(75, 23);
            this.bntPlay.TabIndex = 1;
            this.bntPlay.Text = "Play";
            this.bntPlay.UseVisualStyleBackColor = true;
            this.bntPlay.Click += new System.EventHandler(this.bntPlay_Click);
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(85, 12);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(207, 23);
            this.pBar.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(295, 444);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.bntPlay);
            this.Controls.Add(this.dgvMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Pepe v1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button bntPlay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vlr;
        private System.Windows.Forms.ProgressBar pBar;
    }
}

