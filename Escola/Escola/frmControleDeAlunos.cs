using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Escola.escola2DataSetTableAdapters;

namespace Escola
{
    public partial class frmControleDeAlunos : Form
    {
        public frmControleDeAlunos()
        {
            InitializeComponent();
        }

        private void frmControleDeAlunos_Load(object sender, EventArgs e)
        {
            dtgPesquisas.AutoGenerateColumns = false;
            ConfigurarColunasDataGridView();
            this.alunosTableAdapter.Fill(this.escola2DataSet.Alunos);


        }


        private void btnPesquisa_Click(object sender, EventArgs e)
        {

            string filtro = txtPesquisar.Text.Trim();
            if (rbAluno.Checked)
            {
                alunosBindingSource.Filter = $"NOME LIKE '%{filtro}%'";
                ConfigurarColunas(modoCurso: false);
            }
            else
            {

                alunosBindingSource.Filter = $"CURSO LIKE '%{filtro}%'";
                ConfigurarColunas(modoCurso: true);
            }
            dtgPesquisas.ReadOnly = false;
            dtgPesquisas.AllowUserToAddRows = true;
            dtgPesquisas.AllowUserToDeleteRows = true;


        }
        private void ConfigurarColunasDataGridView()
        {
            dtgPesquisas.Columns.Clear();

            dtgPesquisas.Columns.Add("ID_ALUNO", "ID Aluno");
            dtgPesquisas.Columns["ID_ALUNO"].DataPropertyName = "ID_ALUNO";

            dtgPesquisas.Columns.Add("NOME", "Nome");
            dtgPesquisas.Columns["NOME"].DataPropertyName = "NOME";

            dtgPesquisas.Columns.Add("TELEFONE", "Telefone");
            dtgPesquisas.Columns["TELEFONE"].DataPropertyName = "TELEFONE";


            dtgPesquisas.Columns.Add("EMAIL", "Email");
            dtgPesquisas.Columns["EMAIL"].DataPropertyName = "EMAIL";

            dtgPesquisas.Columns.Add("CURSO", "Curso");
            dtgPesquisas.Columns["CURSO"].DataPropertyName = "CURSO";

            dtgPesquisas.Columns.Add("NASCIMENTO", "Nascimento");
            dtgPesquisas.Columns["NASCIMENTO"].DataPropertyName = "NASCIMENTO";

        }
        private void ConfigurarColunas(bool modoCurso)
        {
            var colunas = dtgPesquisas.Columns;
            foreach (DataGridViewColumn coluna in colunas)
            {
                coluna.Visible = false;
            }
            if (modoCurso)
            {

                if (colunas.Contains("ID_ALUNO"))
                {
                    colunas["ID_ALUNO"].Visible = true;
                    colunas["ID_ALUNO"].Width = 80;
                }

                if (colunas.Contains("NOME"))
                {
                    colunas["NOME"].Visible = true;
                    colunas["NOME"].Width = 200;
                }

                if (colunas.Contains("CURSO"))
                {
                    colunas["CURSO"].Visible = true;
                    colunas["CURSO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            else
            {
                foreach (DataGridViewColumn coluna in dtgPesquisas.Columns)
                {
                    coluna.Visible = true;

                }

            }
            dtgPesquisas.ReadOnly = false;
            dtgPesquisas.AllowUserToAddRows = true;
            dtgPesquisas.AllowUserToDeleteRows = true;
        }
        private void alunosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alunosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.escola2DataSet);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            txtPesquisar.Text = "";
            alunosBindingSource.Filter = "";
            ConfigurarColunas(modoCurso: false);
        }
    }
}
