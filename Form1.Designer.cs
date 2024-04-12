namespace FS19
{
    partial class Form1
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
            this.lblNomeSave = new System.Windows.Forms.Label();
            this.cbSaveGame = new System.Windows.Forms.ComboBox();
            this.txtFarmMoney = new System.Windows.Forms.TextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.cbListaDeFarm = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lblNomeSave
            // 
            this.lblNomeSave.AutoSize = true;
            this.lblNomeSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeSave.Location = new System.Drawing.Point(12, 9);
            this.lblNomeSave.Name = "lblNomeSave";
            this.lblNomeSave.Size = new System.Drawing.Size(47, 16);
            this.lblNomeSave.TabIndex = 0;
            this.lblNomeSave.Text = "Save:";
            // 
            // cbSaveGame
            // 
            this.cbSaveGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbSaveGame.FormattingEnabled = true;
            this.cbSaveGame.Location = new System.Drawing.Point(15, 30);
            this.cbSaveGame.Name = "cbSaveGame";
            this.cbSaveGame.Size = new System.Drawing.Size(267, 24);
            this.cbSaveGame.TabIndex = 1;
            // 
            // txtFarmMoney
            // 
            this.txtFarmMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtFarmMoney.Location = new System.Drawing.Point(75, 60);
            this.txtFarmMoney.Name = "txtFarmMoney";
            this.txtFarmMoney.Size = new System.Drawing.Size(207, 22);
            this.txtFarmMoney.TabIndex = 5;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(12, 63);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(57, 16);
            this.lblMoney.TabIndex = 4;
            this.lblMoney.Text = "Money:";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCarregar.Location = new System.Drawing.Point(12, 251);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(97, 42);
            this.btnCarregar.TabIndex = 3;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // cbListaDeFarm
            // 
            this.cbListaDeFarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbListaDeFarm.FormattingEnabled = true;
            this.cbListaDeFarm.Location = new System.Drawing.Point(15, 88);
            this.cbListaDeFarm.Name = "cbListaDeFarm";
            this.cbListaDeFarm.Size = new System.Drawing.Size(267, 157);
            this.cbListaDeFarm.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 362);
            this.Controls.Add(this.cbListaDeFarm);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.txtFarmMoney);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.cbSaveGame);
            this.Controls.Add(this.lblNomeSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeSave;
        private System.Windows.Forms.ComboBox cbSaveGame;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.TextBox txtFarmMoney;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.CheckedListBox cbListaDeFarm;
    }
}

