using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Desafio_7
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Aluno.conectar();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				//passa sting de conexão
				MySqlConnection objcon = new MySqlConnection("server=localhost; port=3306;User Id=root; database=bd_projeto1; pwd=473318");
				//abre o banco de dados							
				objcon.Open();
				//comando para inserir dados na tabela
				MySqlCommand objCmd = new MySqlCommand("insert into tb_dados (cd_dados, nm_nome, cs_curso, nt_nota) values(null, ? , ? , ? )", objcon);
				//parametros do comando sql
				objCmd.Parameters.Add("@nm_nome", MySqlDbType.String, 60).Value = txtnome.Text;
				objCmd.Parameters.Add("@cs_curso", MySqlDbType.String, 60).Value = txtcurso.Text;
				objCmd.Parameters.Add("@nt_nota", MySqlDbType.String, 60).Value = txtnota.Text;

				//Comando para executar query
				objCmd.ExecuteNonQuery();

				MessageBox.Show("Cadrastro efetuado com sucesso!"); 

				//fecha a conexão
				objcon.Close();
			}
			catch (Exception erro)
			{
				MessageBox.Show("Não conectou: " + erro);
			}
		}
			//para nao dar erro de execução
		private void txtNome_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void txtCurso_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
