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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFarm = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.lblMoney = new System.Windows.Forms.Label();
            this.txtFarmMoney = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabFarm.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFarm);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(515, 412);
            this.tabControl1.TabIndex = 2;
            // 
            // tabFarm
            // 
            this.tabFarm.Controls.Add(this.txtFarmMoney);
            this.tabFarm.Controls.Add(this.lblMoney);
            this.tabFarm.Location = new System.Drawing.Point(4, 22);
            this.tabFarm.Name = "tabFarm";
            this.tabFarm.Padding = new System.Windows.Forms.Padding(3);
            this.tabFarm.Size = new System.Drawing.Size(507, 386);
            this.tabFarm.TabIndex = 0;
            this.tabFarm.Text = "Farm";
            this.tabFarm.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(507, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCarregar.Location = new System.Drawing.Point(15, 474);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(97, 42);
            this.btnCarregar.TabIndex = 3;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(6, 18);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(57, 16);
            this.lblMoney.TabIndex = 4;
            this.lblMoney.Text = "Money:";
            // 
            // txtFarmMoney
            // 
            this.txtFarmMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtFarmMoney.Location = new System.Drawing.Point(69, 15);
            this.txtFarmMoney.Name = "txtFarmMoney";
            this.txtFarmMoney.Size = new System.Drawing.Size(194, 22);
            this.txtFarmMoney.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 527);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cbSaveGame);
            this.Controls.Add(this.lblNomeSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabFarm.ResumeLayout(false);
            this.tabFarm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeSave;
        private System.Windows.Forms.ComboBox cbSaveGame;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFarm;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.TextBox txtFarmMoney;
        private System.Windows.Forms.Label lblMoney;
    }
}

