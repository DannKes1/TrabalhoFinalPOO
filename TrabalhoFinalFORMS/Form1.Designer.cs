namespace TrabalhoFinalFORMS
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            CadastrarFunc = new TabControl();
            tabPage1 = new TabPage();
            btnCadastrar = new Button();
            txtCpf = new TextBox();
            txtNome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            label4 = new Label();
            btnAtualizarLista = new Button();
            dgvFuncionarios = new DataGridView();
            tabPage3 = new TabPage();
            btnDeletar = new Button();
            txtIdDeletar = new TextBox();
            label6 = new Label();
            label5 = new Label();
            tabPage4 = new TabPage();
            btnAtualizar = new Button();
            txtCPFAtualizar = new TextBox();
            label10 = new Label();
            txtNomeAtualizar = new TextBox();
            label9 = new Label();
            btnBuscar = new Button();
            txtIdAtualizar = new TextBox();
            label8 = new Label();
            label7 = new Label();
            CadastrarFunc.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).BeginInit();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // CadastrarFunc
            // 
            CadastrarFunc.AccessibleDescription = "";
            CadastrarFunc.AccessibleName = "";
            CadastrarFunc.Controls.Add(tabPage1);
            CadastrarFunc.Controls.Add(tabPage2);
            CadastrarFunc.Controls.Add(tabPage3);
            CadastrarFunc.Controls.Add(tabPage4);
            CadastrarFunc.Location = new Point(-2, 1);
            CadastrarFunc.Name = "CadastrarFunc";
            CadastrarFunc.SelectedIndex = 0;
            CadastrarFunc.Size = new Size(979, 612);
            CadastrarFunc.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnCadastrar);
            tabPage1.Controls.Add(txtCpf);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(971, 584);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastrar Funcionario";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(430, 238);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(113, 36);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpf.Location = new Point(555, 161);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(260, 29);
            txtCpf.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(141, 161);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(275, 29);
            txtNome.TabIndex = 3;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(555, 133);
            label3.Name = "label3";
            label3.Size = new Size(244, 25);
            label3.TabIndex = 2;
            label3.Text = "Insira o CPF do funcionario:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(141, 133);
            label2.Name = "label2";
            label2.Size = new Size(263, 25);
            label2.TabIndex = 1;
            label2.Text = "Insira o nome do Funcionario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(351, 22);
            label1.Name = "label1";
            label1.Size = new Size(283, 32);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Funcionarios";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(btnAtualizarLista);
            tabPage2.Controls.Add(dgvFuncionarios);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(971, 584);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Listar Funcionario";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(359, 13);
            label4.Name = "label4";
            label4.Size = new Size(237, 32);
            label4.TabIndex = 2;
            label4.Text = "Lista de Funcionarios";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAtualizarLista
            // 
            btnAtualizarLista.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtualizarLista.Location = new Point(386, 468);
            btnAtualizarLista.Name = "btnAtualizarLista";
            btnAtualizarLista.Size = new Size(177, 46);
            btnAtualizarLista.TabIndex = 1;
            btnAtualizarLista.Text = "Atualizar a Lista";
            btnAtualizarLista.UseVisualStyleBackColor = true;
            btnAtualizarLista.Click += btnAtualizarLista_Click;
            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.AllowUserToOrderColumns = true;
            dgvFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFuncionarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionarios.Location = new Point(3, 48);
            dgvFuncionarios.Name = "dgvFuncionarios";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvFuncionarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dgvFuncionarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvFuncionarios.RowTemplate.Height = 25;
            dgvFuncionarios.Size = new Size(968, 391);
            dgvFuncionarios.TabIndex = 0;
            dgvFuncionarios.CellContentClick += dgvFuncionarios_CellContentClick;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnDeletar);
            tabPage3.Controls.Add(txtIdDeletar);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(971, 584);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Deletar Funcionario";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeletar.Location = new Point(419, 240);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(94, 38);
            btnDeletar.TabIndex = 4;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // txtIdDeletar
            // 
            txtIdDeletar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdDeletar.Location = new Point(381, 172);
            txtIdDeletar.Name = "txtIdDeletar";
            txtIdDeletar.Size = new Size(175, 33);
            txtIdDeletar.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(337, 139);
            label6.Name = "label6";
            label6.Size = new Size(259, 30);
            label6.TabIndex = 2;
            label6.Text = "Digite o Id do Funcionario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(363, 14);
            label5.Name = "label5";
            label5.Size = new Size(233, 32);
            label5.TabIndex = 1;
            label5.Text = "Deletar Funcionarios";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Click += label5_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnAtualizar);
            tabPage4.Controls.Add(txtCPFAtualizar);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(txtNomeAtualizar);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(btnBuscar);
            tabPage4.Controls.Add(txtIdAtualizar);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(label7);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(971, 584);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Atualizar Funcionario";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtualizar.Location = new Point(423, 432);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(98, 37);
            btnAtualizar.TabIndex = 8;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // txtCPFAtualizar
            // 
            txtCPFAtualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCPFAtualizar.Location = new Point(278, 384);
            txtCPFAtualizar.Name = "txtCPFAtualizar";
            txtCPFAtualizar.Size = new Size(389, 33);
            txtCPFAtualizar.TabIndex = 7;
            txtCPFAtualizar.TextChanged += txtCPFAtualizar_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(319, 356);
            label10.Name = "label10";
            label10.Size = new Size(294, 25);
            label10.TabIndex = 6;
            label10.Text = "Insira o novo CPF do Funcionario:";
            // 
            // txtNomeAtualizar
            // 
            txtNomeAtualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeAtualizar.Location = new Point(278, 302);
            txtNomeAtualizar.Name = "txtNomeAtualizar";
            txtNomeAtualizar.Size = new Size(389, 33);
            txtNomeAtualizar.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(319, 274);
            label9.Name = "label9";
            label9.Size = new Size(310, 25);
            label9.TabIndex = 4;
            label9.Text = "Insira o novo nome do Funcionario:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(423, 207);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(98, 37);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtIdAtualizar
            // 
            txtIdAtualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdAtualizar.Location = new Point(278, 154);
            txtIdAtualizar.Name = "txtIdAtualizar";
            txtIdAtualizar.Size = new Size(389, 33);
            txtIdAtualizar.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(278, 126);
            label8.Name = "label8";
            label8.Size = new Size(389, 25);
            label8.TabIndex = 1;
            label8.Text = "Insira o ID do Funcionario que deseja alterar:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(368, 22);
            label7.Name = "label7";
            label7.Size = new Size(209, 30);
            label7.TabIndex = 0;
            label7.Text = "Atualizar Funcionario";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 610);
            Controls.Add(CadastrarFunc);
            Name = "Form1";
            Text = "Form1";
            CadastrarFunc.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl CadastrarFunc;
        private TabPage tabPage1;
        private Button btnCadastrar;
        private TextBox txtCpf;
        private TextBox txtNome;
        private Label label3;
        private Label label2;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button btnAtualizarLista;
        private DataGridView dgvFuncionarios;
        private Label label1;
        private Label label4;
        private Label label5;
        private Button btnDeletar;
        private TextBox txtIdDeletar;
        private Label label6;
        private Button btnAtualizar;
        private TextBox txtCPFAtualizar;
        private Label label10;
        private TextBox txtNomeAtualizar;
        private Label label9;
        private Button btnBuscar;
        private TextBox txtIdAtualizar;
        private Label label8;
        private Label label7;
    }
}