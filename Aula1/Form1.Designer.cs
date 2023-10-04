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
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.mtbSala = new System.Windows.Forms.MaskedTextBox();
            this.lblHE = new System.Windows.Forms.Label();
            this.lblHS = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefone = new System.Windows.Forms.TextBox();
            this.mtbHE = new System.Windows.Forms.TextBox();
            this.mtbHS = new System.Windows.Forms.TextBox();
            this.EDITAR = new System.Windows.Forms.Button();
            this.tabela = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.horarioentrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.horariosaida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.senha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnMenssage
            // 
            this.btnMenssage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMenssage.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenssage.Location = new System.Drawing.Point(192, 442);
            this.btnMenssage.Name = "btnMenssage";
            this.btnMenssage.Size = new System.Drawing.Size(109, 26);
            this.btnMenssage.TabIndex = 9;
            this.btnMenssage.Text = "CONFIRMA";
            this.btnMenssage.UseVisualStyleBackColor = false;
            this.btnMenssage.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNome.Location = new System.Drawing.Point(57, 76);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "NOME";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(59, 92);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(530, 20);
            this.txbNome.TabIndex = 1;
            this.txbNome.TextChanged += new System.EventHandler(this.txbNome_TextChanged);
            // 
            // txbSenha
            // 
            this.txbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha.Location = new System.Drawing.Point(59, 266);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(448, 20);
            this.txbSenha.TabIndex = 8;
            this.txbSenha.TextChanged += new System.EventHandler(this.txbPront_TextChanged);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSenha.Location = new System.Drawing.Point(57, 244);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(44, 13);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "SENHA";
            this.lblSenha.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(56, 130);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 29;
            this.lblCPF.Text = "CPF";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(59, 153);
            this.mtbCPF.Mask = "000,000,000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(87, 20);
            this.mtbCPF.TabIndex = 2;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTelefone.Location = new System.Drawing.Point(341, 130);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(63, 13);
            this.lblTelefone.TabIndex = 31;
            this.lblTelefone.Text = "TELEFONE";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSala.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSala.Location = new System.Drawing.Point(58, 192);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(34, 13);
            this.lblSala.TabIndex = 34;
            this.lblSala.Text = "SALA";
            // 
            // mtbSala
            // 
            this.mtbSala.Location = new System.Drawing.Point(59, 208);
            this.mtbSala.Mask = "000";
            this.mtbSala.Name = "mtbSala";
            this.mtbSala.Size = new System.Drawing.Size(33, 20);
            this.mtbSala.TabIndex = 4;
            // 
            // lblHE
            // 
            this.lblHE.AutoSize = true;
            this.lblHE.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblHE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHE.Location = new System.Drawing.Point(331, 188);
            this.lblHE.Name = "lblHE";
            this.lblHE.Size = new System.Drawing.Size(130, 13);
            this.lblHE.TabIndex = 36;
            this.lblHE.Text = "HORARIO DE ENTRADA";
            // 
            // lblHS
            // 
            this.lblHS.AutoSize = true;
            this.lblHS.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHS.Location = new System.Drawing.Point(466, 189);
            this.lblHS.Name = "lblHS";
            this.lblHS.Size = new System.Drawing.Size(110, 13);
            this.lblHS.TabIndex = 38;
            this.lblHS.Text = "HORARIO DE SAIDA";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(341, 193);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(36, 13);
            this.lblData.TabIndex = 40;
            this.lblData.Text = "DATA";
            // 
            // mtbData
            // 
            this.mtbData.Location = new System.Drawing.Point(344, 209);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(100, 20);
            this.mtbData.TabIndex = 5;
            this.mtbData.ValidatingType = typeof(System.DateTime);
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelefone.Location = new System.Drawing.Point(344, 153);
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(192, 20);
            this.mtbTelefone.TabIndex = 3;
            // 
            // mtbHE
            // 
            this.mtbHE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbHE.Location = new System.Drawing.Point(334, 208);
            this.mtbHE.Name = "mtbHE";
            this.mtbHE.Size = new System.Drawing.Size(35, 20);
            this.mtbHE.TabIndex = 6;
            // 
            // mtbHS
            // 
            this.mtbHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbHS.Location = new System.Drawing.Point(469, 211);
            this.mtbHS.Name = "mtbHS";
            this.mtbHS.Size = new System.Drawing.Size(35, 20);
            this.mtbHS.TabIndex = 7;
            // 
            // EDITAR
            // 
            this.EDITAR.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.EDITAR.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDITAR.Location = new System.Drawing.Point(59, 442);
            this.EDITAR.Name = "EDITAR";
            this.EDITAR.Size = new System.Drawing.Size(109, 26);
            this.EDITAR.TabIndex = 41;
            this.EDITAR.Text = "EDITAR";
            this.EDITAR.UseVisualStyleBackColor = false;
            this.EDITAR.Click += new System.EventHandler(this.EDITAR_Click);
            // 
            // tabela
            // 
            this.tabela.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.nome,
            this.CPF,
            this.telefone,
            this.sala,
            this.horarioentrada,
            this.horariosaida,
            this.senha,
            this.data});
            this.tabela.HideSelection = false;
            this.tabela.Location = new System.Drawing.Point(59, 330);
            this.tabela.Name = "tabela";
            this.tabela.Size = new System.Drawing.Size(530, 94);
            this.tabela.TabIndex = 42;
            this.tabela.UseCompatibleStateImageBehavior = false;
            this.tabela.View = System.Windows.Forms.View.Details;
            this.tabela.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.tabela.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabela_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // nome
            // 
            this.nome.Text = "nome";
            // 
            // CPF
            // 
            this.CPF.Text = "CPF";
            // 
            // telefone
            // 
            this.telefone.Text = "telefone";
            // 
            // sala
            // 
            this.sala.Text = "sala";
            // 
            // horarioentrada
            // 
            this.horarioentrada.Text = "horarioentrada";
            // 
            // horariosaida
            // 
            this.horariosaida.Text = "horariosaida";
            // 
            // senha
            // 
            this.senha.Text = "senha";
            // 
            // data
            // 
            this.data.Text = "data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.EDITAR);
            this.Controls.Add(this.mtbHS);
            this.Controls.Add(this.mtbHE);
            this.Controls.Add(this.mtbTelefone);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblHS);
            this.Controls.Add(this.lblHE);
            this.Controls.Add(this.mtbSala);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnMenssage);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenssage;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.MaskedTextBox mtbSala;
        private System.Windows.Forms.Label lblHE;
        private System.Windows.Forms.Label lblHS;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MaskedTextBox mtbData;
        private System.Windows.Forms.TextBox mtbTelefone;
        private System.Windows.Forms.TextBox mtbHE;
        private System.Windows.Forms.TextBox mtbHS;
        private System.Windows.Forms.Button EDITAR;
        private System.Windows.Forms.ListView tabela;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader CPF;
        private System.Windows.Forms.ColumnHeader telefone;
        private System.Windows.Forms.ColumnHeader sala;
        private System.Windows.Forms.ColumnHeader horarioentrada;
        private System.Windows.Forms.ColumnHeader horariosaida;
        private System.Windows.Forms.ColumnHeader senha;
        private System.Windows.Forms.ColumnHeader data;
    }
}

