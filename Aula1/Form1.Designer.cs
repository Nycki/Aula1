namespace Aula1
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
            this.btnMenssage = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbPront = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMenssage
            // 
            this.btnMenssage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMenssage.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenssage.Location = new System.Drawing.Point(289, 164);
            this.btnMenssage.Name = "btnMenssage";
            this.btnMenssage.Size = new System.Drawing.Size(101, 32);
            this.btnMenssage.TabIndex = 0;
            this.btnMenssage.Text = "CONFIRMA";
            this.btnMenssage.UseVisualStyleBackColor = false;
            this.btnMenssage.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(42, 34);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(39, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "NOME";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(45, 63);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(345, 20);
            this.txbNome.TabIndex = 2;
            // 
            // txbPront
            // 
            this.txbPront.Location = new System.Drawing.Point(45, 129);
            this.txbPront.Name = "txbPront";
            this.txbPront.Size = new System.Drawing.Size(345, 20);
            this.txbPront.TabIndex = 4;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(42, 100);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(77, 13);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "PRONTIARIO ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 285);
            this.Controls.Add(this.txbPront);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnMenssage);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenssage;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbPront;
        private System.Windows.Forms.Label lbl2;
    }
}

