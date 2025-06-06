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
using Escola.EscolaDataSetTableAdapters;

namespace Escola
{
    public partial class frmControleDeAlunos : Form
    {
        public frmControleDeAlunos()
        {
            InitializeComponent();
        }

        private void alunosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.alunosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.escolaDataSet);
            }
            catch (System.Data.NoNullAllowedException)
            {
                MessageBox.Show($"Preencha todas as informações", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmControleDeAlunos_Load(object sender, EventArgs e)
        {
            this.alunosTableAdapter.Fill(this.escolaDataSet.Alunos);
            var tabela = alunosTableAdapter.GetData();
            alunosBindingSource.DataSource = tabela;
            dtgPesquisas.DataSource = alunosBindingSource;

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            dtgPesquisas.DataSource = null;
            dtgPesquisas.Rows.Clear();
            dtgPesquisas.Columns.Clear();

            if (rbAluno.Checked)
            {

                
                var adapter = new AlunosTableAdapter();
                var tabela = new EscolaDataSet.AlunosDataTable();
                adapter.FillAluno(tabela, "%" + txtPesquisar.Text + "%");

                alunosBindingSource.DataSource = tabela;
                dtgPesquisas.DataSource = alunosBindingSource;
                ConfigurarColunas(modoCurso: false);


            }
            else
            {
                
                var adapter = new CursosTableAdapter();
                var tabela = new EscolaDataSet.CursosDataTable();
                adapter.FillCurso(tabela, "%" + txtPesquisar.Text + "%");

                cursosBindingSource.DataSource = tabela;
                dtgPesquisas.DataSource = cursosBindingSource;
                ConfigurarColunas(modoCurso: true);

            }
        }
        private void ConfigurarColunas(bool modoCurso)
        {
            if (modoCurso)
            {
                foreach (DataGridViewColumn coluna in dtgPesquisas.Columns)
                    coluna.Visible = false;

                if (dtgPesquisas.Columns.Contains("ID_ALUNO"))
                    dtgPesquisas.Columns["ID_ALUNO"].Visible = true;
                    dtgPesquisas.Columns["ID_ALUNO"].Width = 80;

                if (dtgPesquisas.Columns.Contains("NOME"))
                    dtgPesquisas.Columns["NOME"].Visible = true;
                    dtgPesquisas.Columns["NOME"].Width = 200;


                if (dtgPesquisas.Columns.Contains("CURSO"))
                    dtgPesquisas.Columns["CURSO"].Visible = true;
                    dtgPesquisas.Columns["CURSO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                foreach (DataGridViewColumn coluna in dtgPesquisas.Columns)
                {
                    coluna.Visible = true;

                }
                dtgPesquisas.ReadOnly = false;
                dtgPesquisas.AllowUserToAddRows = true;
                dtgPesquisas.AllowUserToDeleteRows = true;

            }
        }
    }
}
