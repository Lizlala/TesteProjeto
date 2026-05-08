namespace LogiN
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox2 = new PictureBox();
            label1 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            txtSenha = new TextBox();
            label3 = new Label();
            btnEntrar = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btncadastraL = new Button();
            label9 = new Label();
            txtcadastroSenha = new TextBox();
            txtNome = new TextBox();
            label10 = new Label();
            btnVoltarS = new Button();
            btnSalvarS = new Button();
            txtCpf = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            PainelUsuario = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PainelUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(568, 25);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(237, 137);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(543, 242);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(543, 260);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(290, 26);
            txtUsuario.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(640, 200);
            label2.Name = "label2";
            label2.Size = new Size(87, 19);
            label2.TabIndex = 4;
            label2.Text = "Bem vinda!";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(543, 341);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(290, 26);
            txtSenha.TabIndex = 6;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(543, 323);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 5;
            label3.Text = "Senha";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(543, 410);
            btnEntrar.Margin = new Padding(3, 2, 3, 2);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(126, 28);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 8F);
            label4.Location = new Point(820, 540);
            label4.Name = "label4";
            label4.Size = new Size(89, 16);
            label4.TabIndex = 8;
            label4.Text = "by  ASTER TECH";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, -5);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(435, 576);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btncadastraL
            // 
            btncadastraL.Location = new Point(707, 410);
            btncadastraL.Margin = new Padding(3, 2, 3, 2);
            btncadastraL.Name = "btncadastraL";
            btncadastraL.Size = new Size(126, 28);
            btncadastraL.TabIndex = 10;
            btncadastraL.Text = "Cadastrar";
            btncadastraL.UseVisualStyleBackColor = true;
            btncadastraL.Click += btncadastraL_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9.75F);
            label9.Location = new Point(56, 243);
            label9.Name = "label9";
            label9.Size = new Size(51, 17);
            label9.TabIndex = 28;
            label9.Text = "Senha:";
            // 
            // txtcadastroSenha
            // 
            txtcadastroSenha.Location = new Point(55, 263);
            txtcadastroSenha.Name = "txtcadastroSenha";
            txtcadastroSenha.Size = new Size(150, 23);
            txtcadastroSenha.TabIndex = 27;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(54, 139);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(310, 23);
            txtNome.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F);
            label10.Location = new Point(54, 62);
            label10.Name = "label10";
            label10.Size = new Size(306, 21);
            label10.TabIndex = 23;
            label10.Text = "Gerencie seus trbalhos e encomendas";
            // 
            // btnVoltarS
            // 
            btnVoltarS.BackColor = Color.White;
            btnVoltarS.FlatAppearance.BorderSize = 0;
            btnVoltarS.FlatStyle = FlatStyle.Flat;
            btnVoltarS.Font = new Font("Century Gothic", 10F);
            btnVoltarS.Location = new Point(244, 366);
            btnVoltarS.Margin = new Padding(3, 2, 3, 2);
            btnVoltarS.Name = "btnVoltarS";
            btnVoltarS.Size = new Size(94, 26);
            btnVoltarS.TabIndex = 2;
            btnVoltarS.Text = "Voltar";
            btnVoltarS.UseVisualStyleBackColor = false;
            // 
            // btnSalvarS
            // 
            btnSalvarS.BackColor = Color.FromArgb(191, 165, 187);
            btnSalvarS.FlatAppearance.BorderSize = 0;
            btnSalvarS.FlatStyle = FlatStyle.Flat;
            btnSalvarS.Font = new Font("Century Gothic", 10F);
            btnSalvarS.Location = new Point(111, 366);
            btnSalvarS.Margin = new Padding(3, 2, 3, 2);
            btnSalvarS.Name = "btnSalvarS";
            btnSalvarS.Size = new Size(94, 26);
            btnSalvarS.TabIndex = 3;
            btnSalvarS.Text = "Salvar";
            btnSalvarS.UseVisualStyleBackColor = false;
            btnSalvarS.Click += btnSalvarS_Click;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(55, 194);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(150, 23);
            txtCpf.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F);
            label5.Location = new Point(55, 174);
            label5.Name = "label5";
            label5.Size = new Size(37, 17);
            label5.TabIndex = 1;
            label5.Text = "CPF:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            label7.Location = new Point(72, 27);
            label7.Name = "label7";
            label7.Size = new Size(260, 23);
            label7.TabIndex = 2;
            label7.Text = "Cadastre-se nove usuário";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F);
            label6.Location = new Point(55, 117);
            label6.Name = "label6";
            label6.Size = new Size(52, 17);
            label6.TabIndex = 1;
            label6.Text = "Nome:";
            label6.Click += label6_Click;
            // 
            // PainelUsuario
            // 
            PainelUsuario.Controls.Add(label9);
            PainelUsuario.Controls.Add(label7);
            PainelUsuario.Controls.Add(txtcadastroSenha);
            PainelUsuario.Controls.Add(label10);
            PainelUsuario.Controls.Add(txtNome);
            PainelUsuario.Controls.Add(btnVoltarS);
            PainelUsuario.Controls.Add(label6);
            PainelUsuario.Controls.Add(btnSalvarS);
            PainelUsuario.Controls.Add(label5);
            PainelUsuario.Controls.Add(txtCpf);
            PainelUsuario.Location = new Point(428, -2);
            PainelUsuario.Name = "PainelUsuario";
            PainelUsuario.Size = new Size(493, 573);
            PainelUsuario.TabIndex = 11;
            PainelUsuario.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(917, 561);
            Controls.Add(PainelUsuario);
            Controls.Add(btncadastraL);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PainelUsuario.ResumeLayout(false);
            PainelUsuario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox txtUsuario;
        private Label label2;
        private TextBox txtSenha;
        private Label label3;
        private Button btnEntrar;
        private Label label4;
        private PictureBox pictureBox1;
        private Button btncadastraL;
        private Label label10;
        private Button btnVoltarS;
        private Button btnSalvarS;
        private TextBox txtCpf;
        private Label label5;
        private Label label7;
        private Label label6;
        private TextBox txtNome;
        private TextBox txtcadastroSenha;
        private Label label9;
        private Panel PainelUsuario;
    }
}
