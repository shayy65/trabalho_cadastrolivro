namespace Trabalho_Cadastro_de_Livro
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_editora = new System.Windows.Forms.TextBox();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.txt_sinopse = new System.Windows.Forms.TextBox();
            this.dataGrid_livro = new System.Windows.Forms.DataGridView();
            this.cb_genero = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_exluir = new System.Windows.Forms.Button();
            this.txt_valoraquisicao = new System.Windows.Forms.TextBox();
            this.txt_lucro = new System.Windows.Forms.TextBox();
            this.txt_valorvenda = new System.Windows.Forms.TextBox();
            this.lb_aaa = new System.Windows.Forms.Label();
            this.lb_lucro = new System.Windows.Forms.Label();
            this.lb_valoraquisicao = new System.Windows.Forms.Label();
            this.txt_ano = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_livro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Livros";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(87, 74);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 27);
            this.txt_codigo.TabIndex = 1;
            // 
            // txt_editora
            // 
            this.txt_editora.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_editora.Location = new System.Drawing.Point(433, 221);
            this.txt_editora.Name = "txt_editora";
            this.txt_editora.Size = new System.Drawing.Size(176, 27);
            this.txt_editora.TabIndex = 2;
            // 
            // txt_titulo
            // 
            this.txt_titulo.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titulo.Location = new System.Drawing.Point(284, 74);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(325, 27);
            this.txt_titulo.TabIndex = 4;
            // 
            // txt_autor
            // 
            this.txt_autor.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_autor.Location = new System.Drawing.Point(433, 169);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(176, 27);
            this.txt_autor.TabIndex = 6;
            // 
            // txt_sinopse
            // 
            this.txt_sinopse.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sinopse.Location = new System.Drawing.Point(87, 119);
            this.txt_sinopse.Name = "txt_sinopse";
            this.txt_sinopse.Size = new System.Drawing.Size(522, 27);
            this.txt_sinopse.TabIndex = 7;
            // 
            // dataGrid_livro
            // 
            this.dataGrid_livro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_livro.Location = new System.Drawing.Point(0, 396);
            this.dataGrid_livro.Name = "dataGrid_livro";
            this.dataGrid_livro.RowHeadersWidth = 51;
            this.dataGrid_livro.RowTemplate.Height = 24;
            this.dataGrid_livro.Size = new System.Drawing.Size(638, 184);
            this.dataGrid_livro.TabIndex = 8;
            // 
            // cb_genero
            // 
            this.cb_genero.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_genero.FormattingEnabled = true;
            this.cb_genero.Items.AddRange(new object[] {
            "Romance",
            "Terror",
            "Comédia",
            "Biografia ou Autobiografia",
            "Suspense",
            "Autoajuda",
            "Poema",
            "Conto",
            "Novela",
            "Acadêmico/Cientifíco",
            "Religioso",
            "Livro reportagem"});
            this.cb_genero.Location = new System.Drawing.Point(87, 169);
            this.cb_genero.Name = "cb_genero";
            this.cb_genero.Size = new System.Drawing.Size(162, 27);
            this.cb_genero.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Código";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Autor(a)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(361, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Editora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ano";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gênero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sinopse";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(223, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Título";
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastrar.Location = new System.Drawing.Point(380, 330);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(112, 41);
            this.bt_cadastrar.TabIndex = 18;
            this.bt_cadastrar.Text = "Cadastrar";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limpar.Location = new System.Drawing.Point(267, 330);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(85, 41);
            this.bt_limpar.TabIndex = 19;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // bt_exluir
            // 
            this.bt_exluir.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exluir.Location = new System.Drawing.Point(518, 330);
            this.bt_exluir.Name = "bt_exluir";
            this.bt_exluir.Size = new System.Drawing.Size(91, 41);
            this.bt_exluir.TabIndex = 20;
            this.bt_exluir.Text = "Excluir";
            this.bt_exluir.UseVisualStyleBackColor = true;
            this.bt_exluir.Click += new System.EventHandler(this.bt_exluir_Click);
            // 
            // txt_valoraquisicao
            // 
            this.txt_valoraquisicao.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valoraquisicao.Location = new System.Drawing.Point(87, 277);
            this.txt_valoraquisicao.Name = "txt_valoraquisicao";
            this.txt_valoraquisicao.Size = new System.Drawing.Size(100, 27);
            this.txt_valoraquisicao.TabIndex = 21;
            // 
            // txt_lucro
            // 
            this.txt_lucro.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lucro.Location = new System.Drawing.Point(284, 277);
            this.txt_lucro.Name = "txt_lucro";
            this.txt_lucro.Size = new System.Drawing.Size(111, 27);
            this.txt_lucro.TabIndex = 22;
            // 
            // txt_valorvenda
            // 
            this.txt_valorvenda.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorvenda.Location = new System.Drawing.Point(498, 277);
            this.txt_valorvenda.Name = "txt_valorvenda";
            this.txt_valorvenda.Size = new System.Drawing.Size(111, 27);
            this.txt_valorvenda.TabIndex = 23;
            // 
            // lb_aaa
            // 
            this.lb_aaa.AutoSize = true;
            this.lb_aaa.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_aaa.Location = new System.Drawing.Point(437, 280);
            this.lb_aaa.Name = "lb_aaa";
            this.lb_aaa.Size = new System.Drawing.Size(55, 24);
            this.lb_aaa.TabIndex = 24;
            this.lb_aaa.Text = "Preço";
            // 
            // lb_lucro
            // 
            this.lb_lucro.AutoSize = true;
            this.lb_lucro.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lucro.Location = new System.Drawing.Point(203, 280);
            this.lb_lucro.Name = "lb_lucro";
            this.lb_lucro.Size = new System.Drawing.Size(75, 24);
            this.lb_lucro.TabIndex = 25;
            this.lb_lucro.Text = "Lucro %";
            // 
            // lb_valoraquisicao
            // 
            this.lb_valoraquisicao.AutoSize = true;
            this.lb_valoraquisicao.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valoraquisicao.Location = new System.Drawing.Point(25, 280);
            this.lb_valoraquisicao.Name = "lb_valoraquisicao";
            this.lb_valoraquisicao.Size = new System.Drawing.Size(56, 24);
            this.lb_valoraquisicao.TabIndex = 26;
            this.lb_valoraquisicao.Text = "Valor ";
            // 
            // txt_ano
            // 
            this.txt_ano.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ano.Location = new System.Drawing.Point(87, 221);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(100, 27);
            this.txt_ano.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(637, 578);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.lb_valoraquisicao);
            this.Controls.Add(this.lb_lucro);
            this.Controls.Add(this.lb_aaa);
            this.Controls.Add(this.txt_valorvenda);
            this.Controls.Add(this.txt_lucro);
            this.Controls.Add(this.txt_valoraquisicao);
            this.Controls.Add(this.bt_exluir);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_genero);
            this.Controls.Add(this.dataGrid_livro);
            this.Controls.Add(this.txt_sinopse);
            this.Controls.Add(this.txt_autor);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.txt_editora);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_livro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_editora;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.TextBox txt_sinopse;
        private System.Windows.Forms.DataGridView dataGrid_livro;
        private System.Windows.Forms.ComboBox cb_genero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_exluir;
        private System.Windows.Forms.TextBox txt_valoraquisicao;
        private System.Windows.Forms.TextBox txt_lucro;
        private System.Windows.Forms.TextBox txt_valorvenda;
        private System.Windows.Forms.Label lb_aaa;
        private System.Windows.Forms.Label lb_lucro;
        private System.Windows.Forms.Label lb_valoraquisicao;
        private System.Windows.Forms.TextBox txt_ano;
    }
}

