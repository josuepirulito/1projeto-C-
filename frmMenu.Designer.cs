namespace _1projeto_C_
{
    partial class frmMenu
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
            this.pneMenu = new System.Windows.Forms.Panel();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pneLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnAutor = new System.Windows.Forms.Button();
            this.btnEditora = new System.Windows.Forms.Button();
            this.btnCat = new System.Windows.Forms.Button();
            this.btnLivros = new System.Windows.Forms.Button();
            this.btnFone = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnFunc = new System.Windows.Forms.Button();
            this.principal1 = new _1projeto_C_.principal();
            this.frmCliente011 = new _1projeto_C_.frmCliente01();
            this.fromAtendente1 = new _1projeto_C_.fromAtendente();
            this.pneMenu.SuspendLayout();
            this.pneLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pneMenu
            // 
            this.pneMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pneMenu.Controls.Add(this.lblUsuarioLogado);
            this.pneMenu.Controls.Add(this.label2);
            this.pneMenu.Controls.Add(this.btnSair);
            this.pneMenu.Controls.Add(this.btnCaixa);
            this.pneMenu.Controls.Add(this.btnPedido);
            this.pneMenu.Controls.Add(this.btnAutor);
            this.pneMenu.Controls.Add(this.btnEditora);
            this.pneMenu.Controls.Add(this.btnCat);
            this.pneMenu.Controls.Add(this.btnLivros);
            this.pneMenu.Controls.Add(this.btnFone);
            this.pneMenu.Controls.Add(this.btnCliente);
            this.pneMenu.Controls.Add(this.btnFunc);
            this.pneMenu.Controls.Add(this.pneLogo);
            this.pneMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pneMenu.Location = new System.Drawing.Point(0, 0);
            this.pneMenu.Name = "pneMenu";
            this.pneMenu.Size = new System.Drawing.Size(220, 504);
            this.pneMenu.TabIndex = 0;
            this.pneMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pneMenu_Paint);
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogado.Location = new System.Drawing.Point(12, 434);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(0, 20);
            this.lblUsuarioLogado.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Usuario Logado:";
            // 
            // pneLogo
            // 
            this.pneLogo.BackColor = System.Drawing.Color.DarkMagenta;
            this.pneLogo.Controls.Add(this.label1);
            this.pneLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pneLogo.Location = new System.Drawing.Point(0, 0);
            this.pneLogo.Name = "pneLogo";
            this.pneLogo.Size = new System.Drawing.Size(220, 45);
            this.pneLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "JO Livraria";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Image = global::_1projeto_C_.Properties.Resources.sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 350);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSair.Size = new System.Drawing.Size(220, 33);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = " Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaixa.FlatAppearance.BorderSize = 0;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCaixa.Image = global::_1projeto_C_.Properties.Resources.fluxo_de_caixa;
            this.btnCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaixa.Location = new System.Drawing.Point(0, 317);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCaixa.Size = new System.Drawing.Size(220, 33);
            this.btnCaixa.TabIndex = 9;
            this.btnCaixa.Text = " Caixa";
            this.btnCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaixa.UseVisualStyleBackColor = true;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedido.FlatAppearance.BorderSize = 0;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPedido.Image = global::_1projeto_C_.Properties.Resources.pedido;
            this.btnPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedido.Location = new System.Drawing.Point(0, 283);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPedido.Size = new System.Drawing.Size(220, 34);
            this.btnPedido.TabIndex = 8;
            this.btnPedido.Text = " Pedido";
            this.btnPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnAutor
            // 
            this.btnAutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAutor.FlatAppearance.BorderSize = 0;
            this.btnAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAutor.Image = global::_1projeto_C_.Properties.Resources.autoria;
            this.btnAutor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutor.Location = new System.Drawing.Point(0, 249);
            this.btnAutor.Name = "btnAutor";
            this.btnAutor.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAutor.Size = new System.Drawing.Size(220, 34);
            this.btnAutor.TabIndex = 7;
            this.btnAutor.Text = " Autores";
            this.btnAutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutor.UseVisualStyleBackColor = true;
            // 
            // btnEditora
            // 
            this.btnEditora.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditora.FlatAppearance.BorderSize = 0;
            this.btnEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditora.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditora.Image = global::_1projeto_C_.Properties.Resources.editor;
            this.btnEditora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditora.Location = new System.Drawing.Point(0, 215);
            this.btnEditora.Name = "btnEditora";
            this.btnEditora.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnEditora.Size = new System.Drawing.Size(220, 34);
            this.btnEditora.TabIndex = 6;
            this.btnEditora.Text = " Editora";
            this.btnEditora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditora.UseVisualStyleBackColor = true;
            // 
            // btnCat
            // 
            this.btnCat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCat.FlatAppearance.BorderSize = 0;
            this.btnCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCat.Image = global::_1projeto_C_.Properties.Resources.categoria;
            this.btnCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCat.Location = new System.Drawing.Point(0, 181);
            this.btnCat.Name = "btnCat";
            this.btnCat.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCat.Size = new System.Drawing.Size(220, 34);
            this.btnCat.TabIndex = 5;
            this.btnCat.Text = " Categoria";
            this.btnCat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCat.UseVisualStyleBackColor = true;
            // 
            // btnLivros
            // 
            this.btnLivros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLivros.FlatAppearance.BorderSize = 0;
            this.btnLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivros.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLivros.Image = global::_1projeto_C_.Properties.Resources.pilha_de_livros;
            this.btnLivros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLivros.Location = new System.Drawing.Point(0, 147);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLivros.Size = new System.Drawing.Size(220, 34);
            this.btnLivros.TabIndex = 4;
            this.btnLivros.Text = " Livros";
            this.btnLivros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLivros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLivros.UseVisualStyleBackColor = true;
            // 
            // btnFone
            // 
            this.btnFone.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFone.FlatAppearance.BorderSize = 0;
            this.btnFone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFone.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFone.Image = global::_1projeto_C_.Properties.Resources.telefone;
            this.btnFone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFone.Location = new System.Drawing.Point(0, 113);
            this.btnFone.Name = "btnFone";
            this.btnFone.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnFone.Size = new System.Drawing.Size(220, 34);
            this.btnFone.TabIndex = 3;
            this.btnFone.Text = " Telefones";
            this.btnFone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFone.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCliente.Image = global::_1projeto_C_.Properties.Resources.cliente;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 79);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCliente.Size = new System.Drawing.Size(220, 34);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = " Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnFunc
            // 
            this.btnFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFunc.FlatAppearance.BorderSize = 0;
            this.btnFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFunc.Image = global::_1projeto_C_.Properties.Resources.funcionario__1_;
            this.btnFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFunc.Location = new System.Drawing.Point(0, 45);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnFunc.Size = new System.Drawing.Size(220, 34);
            this.btnFunc.TabIndex = 1;
            this.btnFunc.Text = " Funcionário";
            this.btnFunc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFunc.UseVisualStyleBackColor = true;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // principal1
            // 
            this.principal1.Location = new System.Drawing.Point(214, -26);
            this.principal1.Name = "principal1";
            this.principal1.Size = new System.Drawing.Size(848, 595);
            this.principal1.TabIndex = 4;
            // 
            // frmCliente011
            // 
            this.frmCliente011.Location = new System.Drawing.Point(214, -26);
            this.frmCliente011.Name = "frmCliente011";
            this.frmCliente011.Size = new System.Drawing.Size(986, 545);
            this.frmCliente011.TabIndex = 3;
            // 
            // fromAtendente1
            // 
            this.fromAtendente1.Location = new System.Drawing.Point(214, -26);
            this.fromAtendente1.Name = "fromAtendente1";
            this.fromAtendente1.Size = new System.Drawing.Size(810, 530);
            this.fromAtendente1.TabIndex = 2;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 504);
            this.Controls.Add(this.principal1);
            this.Controls.Add(this.frmCliente011);
            this.Controls.Add(this.fromAtendente1);
            this.Controls.Add(this.pneMenu);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pneMenu.ResumeLayout(false);
            this.pneMenu.PerformLayout();
            this.pneLogo.ResumeLayout(false);
            this.pneLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pneMenu;
        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.Panel pneLogo;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnAutor;
        private System.Windows.Forms.Button btnEditora;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Button btnFone;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label label1;
        private fromAtendente fromAtendente1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.Label label2;
        private frmCliente01 frmCliente011;
        private principal principal1;
    }
}