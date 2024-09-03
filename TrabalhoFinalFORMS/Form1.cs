using TrabalhoFinalFORMS.DAO;
using TrabalhoFinalFORMS.Models;
using System;
using System.Windows.Forms;
namespace TrabalhoFinalFORMS
{
    public partial class Form1 : Form
    {
        private FuncionarioDAO funcionarioDAO;
        public Form1()
        {
            InitializeComponent();
            funcionarioDAO = new FuncionarioDAO();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
              

                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    MessageBox.Show("O nome do funcionario não pode estar em branco, por gentileza colocar um nome", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtCpf.Text))
                {
                    MessageBox.Show("O CPF do funcionario não pode estar em branco, por gentileza colocar um nome", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Funcionario funcionario = new Funcionario
                {
                    Nome = txtNome.Text,
                    Cpf = txtCpf.Text
                };

                FuncionarioDAO f1 = new FuncionarioDAO();
                f1.Insert(funcionario);

                MessageBox.Show("Funcionário cadastrado com sucesso!");

                txtNome.Clear();
                txtCpf.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro:{ex.Message}", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizarLista_Click(object sender, EventArgs e)
        {
            try
            {
                List<Funcionario> listafuncionarios = funcionarioDAO.List();
                dgvFuncionarios.DataSource = listafuncionarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtIdDeletar.Text.Trim(), out int idFuncionario))
                {
                    var funcionarioExistente = funcionarioDAO.List().FirstOrDefault(f => f.IdFuncionario == idFuncionario);

                    if (funcionarioExistente != null)
                    {
                        var confirmarResultado = MessageBox.Show("Tem certeza que deseja deletar esse funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (confirmarResultado == DialogResult.Yes)
                        {
                            FuncionarioDAO f1 = new FuncionarioDAO();
                            f1.Delete(funcionarioExistente);

                            MessageBox.Show("Funcionário deletado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtIdDeletar.Clear();
                        }
                        else if (confirmarResultado == DialogResult.No)
                        {
                            MessageBox.Show("Operação cancelada", "Cancelado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtIdDeletar.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum funcionário encontrado com o ID fornecido.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por gentileza, insira um ID válido", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtIdAtualizar.Text.Trim(), out int idFuncionario))
                {
                    Funcionario funcionario = funcionarioDAO.List().FirstOrDefault(f => f.IdFuncionario == idFuncionario);

                    if (funcionario != null)
                    {
                        txtNomeAtualizar.Text = funcionario.Nome;
                        txtCPFAtualizar.Text = funcionario.Cpf;
                    }
                    else
                    {
                        MessageBox.Show("Nenhum funcionário encontrado com o ID fornecido.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNomeAtualizar.Clear();
                        txtCPFAtualizar.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um ID válido.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCPFAtualizar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtIdAtualizar.Text.Trim(), out int idFuncionario))
                {
                    Funcionario funcionario = new Funcionario
                    {
                        IdFuncionario = idFuncionario,
                        Nome = txtNomeAtualizar.Text.Trim(),
                        Cpf = txtCPFAtualizar.Text.Trim()
                    };

                    funcionarioDAO.Update(funcionario);

                    MessageBox.Show("Funcionário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtIdAtualizar.Clear();
                    txtNomeAtualizar.Clear();
                    txtCPFAtualizar.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, insira um ID válido.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}