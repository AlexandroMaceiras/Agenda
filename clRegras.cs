using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Agenda
{
	/// <summary>
	/// Regras de negócio da aplicação Agenda.
	/// </summary>
	public class clRegras
	{
		/// <summary>
		/// Construtor que não faz nada.
		/// </summary>
		public clRegras()
		{		}

		public static IDbConnection conexao;
		public static IDbTransaction transacao;
		public IDbCommand comando;
		public IDbDataAdapter adaptador;
		DataSet ds;
		String str_sql;

		/// <summary>
		/// Método para incluir registros que devolve um DataSet.
		/// </summary>
		/// <param name="nome">Nome a ser incluido</param>
		/// <param name="telefone">Telefone a ser incluido</param>
		/// <returns></returns>
		public DataSet Incluir(String nome, String telefone1, String telefone2, String telefone3, String telefone4)
		{
			try
			{
				this.IniciarTransacao();
				String SQL = this.Query1(nome,telefone1,telefone2,telefone3,telefone4);
				ds = this.CriaDataSet();
				this.FazerTransacao();
			}
			catch(Exception ex)
			{
				this.DesfazerTransacao();
				throw new Exception(ex.Message);
			}
			return ds;
		}

		/// <summary>
		/// Retorna o dataSet de conirmação das anotações já incluidas na base.
		/// </summary>
		/// <param name="texto"></param>
		/// <returns></returns>
		public DataSet insereAnotacoes(String texto)
		{
			try
			{
				this.IniciarTransacao();
				String SQL = QueryInsereAnotacao(texto);
				ds = this.CriaDataSet();
				this.FazerTransacao();
			}
			catch(Exception ex)
			{
				this.DesfazerTransacao();
				throw new Exception(ex.Message);
			}
			return ds;
		}

		/// <summary>
		/// Retorna dataSet de confirmação da leitura das anotações na base.
		/// </summary>
		/// <returns></returns>
		public DataSet leAnotacoes()
		{
			try
			{
				this.IniciarTransacao();
				this.QueryLeAnotacao();
				ds = this.CriaDataSet();
				this.FazerTransacao();
			}
			catch(Exception ex)
			{
				this.DesfazerTransacao();
				throw new Exception(ex.Message);
			}
			return ds;
		}
		/// <summary>
		/// Metodo para alterar registros que retorna um DataSet.
		/// </summary>
		/// <param name="nome">Nome a ser alterado</param>
		/// <param name="telefone">Telefone as ser alterado</param>
		/// <returns></returns>
		public DataSet Alterar(String nome1, String nome2, String telefone1, String telefone11, String telefone2, String telefone22, String telefone3, String telefone33, String telefone4, String telefone44)
		{
			try
			{
				this.IniciarTransacao();
				String SQL = this.Query3(nome1,nome2,telefone1,telefone11,telefone2,telefone22,telefone3,telefone33,telefone4,telefone44);
				ds = this.CriaDataSet();
				this.FazerTransacao();
			}
			catch(Exception ex)
			{
				this.DesfazerTransacao();
				throw new Exception(ex.Message);
			}
			return ds;
		}

		/// <summary>
		/// Método para deletar registros que retorna um flag inteiro.
		/// </summary>
		/// <param name="nome1">Nome a ser deletado</param>
		/// <param name="telefone1">Telefone1 a ser deletado</param>
		/// <param name="telefone2">Telefone2 a ser deletado</param>
		/// <param name="telefone3">Telefone3 a ser deletado</param>
		/// <param name="telefone4">Telefone4 a ser deletado</param>
		/// <returns>Flag que aponta se o dataSet existe ou não (0 ou 1)</returns>
		public int Deletar(String nome1, String telefone1, String telefone2, String telefone3, String telefone4)
		{
			int flag;
			try
			{
				this.IniciarTransacao();
				String SQL = this.Query4(nome1, telefone1, telefone2, telefone3, telefone4);
				ds = this.CriaDataSet();
				this.FazerTransacao();
				if(ds != null)
				{
					flag = 1;				
				}
				else
				{
					flag = 0;
				}
			}
			catch(Exception ex)
			{
				this.DesfazerTransacao();
				throw new Exception(ex.Message);
			}
			return flag;
		}

		/// <summary>
		/// Método que faz consulta pelo nome na base.
		/// </summary>
		/// <param name="nome">Nome a ser pesquisado</param>
		/// <returns>dataTable contendo o RecordSet com o resultado da pesquisa</returns>
		public DataTable Consulta(String nome)
		{
			DataTable dtb = null;
			try
			{
				ds = this.CriaDataSet();

				if(ds.Tables[0].Rows.Count > 0)
				{
					//ds.Tables[0].TableName = "Agenda: ";

					dtb = new DataTable();
						
					dtb.Columns.Add("", typeof(string));
					dtb.Columns.Add("", typeof(string));
					dtb.Columns.Add("", typeof(string));
					dtb.Columns.Add("", typeof(string));
					dtb.Columns.Add("", typeof(string));
					//dtb.Columns.Add("", typeof(string));

					DataRow Linha;

					for(int x = 0; x < ds.Tables[0].Rows.Count; x++)
					{
						Linha = dtb.NewRow();

						for(int y = 0; y < (ds.Tables[0].Columns.Count-1); y++)
						{
						
							Linha[y] = ds.Tables[0].Rows[x][y+1];

							//Este if exclui a coluna do telefone 3 e poe a 4 no lugar.

//							if(y != 3)
//								Linha[y] = ds.Tables[0].Rows[x][y+1];
//							else
//								Linha[3] = ds.Tables[0].Rows[x][5];


							//Descobre o nome original da coluna no DataSet e poe no DataTable.
							dtb.Columns[y].ColumnName = ds.Tables[0].Columns[y+1].ColumnName.ToString();
						}
						dtb.Rows.Add(Linha);
					}
				}
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return dtb;
		}

		/// <summary>
		/// Método que faz a conexão com a base de dados.
		/// </summary>
		/// <returns>SqlConnection</returns>
		public static SqlConnection Conexao()
		{
			try
			{
				if(conexao == null)
				{
                    conexao = new SqlConnection("Data Source=DESKTOP-I7-4770;Initial Catalog=CoAppSSPOS;Persist Security Info=True;User ID=ProjecTI;Password=ProjecTI;Integrated Security=false;Trusted_Connection=True");
                    conexao.Open();
				}
				else
				{
					if(conexao.State == ConnectionState.Open)
					{
						conexao.Close();
						conexao = null;
					}
                    conexao = new SqlConnection("Data Source=DESKTOP-I7-4770;Initial Catalog=CoAppSSPOS;Persist Security Info=True;User ID=ProjecTI;Password=ProjecTI;Integrated Security=false;Trusted_Connection=True");
                    conexao.Open();
				}
			}
			catch(Exception ex)
			{
				if(conexao != null)
				{
					conexao.Close();
					conexao = null;
				}
				throw new Exception("Erro na conexão: " + ex.Message);
			}
			return (SqlConnection) conexao;
		}

		/// <summary>
		/// Transacao do Banco.
		/// </summary>
		public static SqlTransaction Transacao
		{
			get
			{
				return (SqlTransaction) transacao;
			}
			set
			{
				transacao = value;
			}
		}

		/// <summary>
		/// Método que inicia a transação utilizando a conexão existente.
		/// </summary>
		public void IniciarTransacao()
		{
			try
			{
				if(transacao == null)
				{
					transacao = Conexao().BeginTransaction();
					if(transacao == null)
					{
						throw new Exception("Transação não iniciada!");
					}
				}
			}
			catch(Exception ex)
			{
				throw new Exception("Erro ao iniciar transação: " + ex.Message);
			}
		}

		/// <summary>
		/// Método que faz a transação (Commit/Dispose).
		/// </summary>
		public void FazerTransacao()
		{
			if(transacao != null)
			{
				transacao.Commit();
				transacao.Dispose();
				conexao.Close();
			}
			transacao = null;
			conexao = null;
		}

		/// <summary>
		/// Método que faz a transação (Rollback/Dispose).
		/// </summary>
		public void DesfazerTransacao()
		{
			if(transacao != null)
			{
				transacao.Rollback();
				transacao.Dispose();
				conexao.Close();
			}
			transacao = null;
			conexao = null;
		}

		/// <summary>
		/// Comando SQL (get/set)
		/// </summary>
		public SqlCommand Comando
		{
			get	
			{
				this.comando = new SqlCommand();
				this.comando.CommandTimeout = conexao.ConnectionTimeout;
				this.comando.Connection = conexao;
				return (SqlCommand) this.comando;
			}
			set
			{
				this.comando = value;
			}
		}


		/// <summary>
		/// Adapter para SQL Server
		/// </summary>
		public SqlDataAdapter Adaptador
		{
			get 
			{
				this.adaptador = new SqlDataAdapter((SqlCommand) this.comando);
				this.comando.Transaction = transacao;
				return (SqlDataAdapter)this.adaptador;
			}
			set 
			{
				this.adaptador = value;
			}
		}

		/// <summary>
		/// Cria dataSet para a manipulação de dados de um RecordSet.
		/// </summary>
		/// <returns></returns>
		public DataSet CriaDataSet()
		{
			DataSet dsSaida = null;
			try
			{
				dsSaida = new DataSet();
				IDbCommand comando = null;
				IDbDataAdapter adaptador = null;
				comando = this.Comando;
				
				comando.CommandText = str_sql;
				comando.CommandType = CommandType.Text;
				comando.Transaction = Transacao;
				adaptador = this.Adaptador;
				adaptador.Fill(dsSaida);
				
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return dsSaida;
		}

		/// <summary>
		/// Query que inclui.
		/// </summary>
		/// <param name="nome">Nome a ser incluido</param>
		/// <param name="telefone1">Telefone a ser incluido</param>
		/// <param name="telefone2">Telefone a ser incluido</param>
		/// <param name="telefone3">Telefone a ser incluido</param>
		/// <param name="telefone4">Telefone a ser incluido</param>
		/// <returns>Query</returns>
		public String Query1(String nome, String telefone1, String telefone2, String telefone3, String telefone4)
		{
			str_sql = @"insert into Alexandro.dbo.tb_cadastro_agenda (nome, fone1, fone2, fone3, fone4) values ('" + nome + "','" + telefone1 + "','" + telefone2 + "','" + telefone3 + "','" + telefone4 + "')";
			return str_sql;
		}

		/// <summary>
		/// Query que consulta.
		/// </summary>
		/// <param name="nome">Nome a pesquisar</param>
		/// <returns>Query</returns>
		public String Query2(String nome)
		{
			str_sql = @"select id as 'Nº:', nome as 'Nome: ', fone1 as 'Telefone: ', fone2 as 'Telefone: ', fone3 as 'Telefone: ', fone4  as 'Telefone: ' from Alexandro.dbo.tb_cadastro_agenda where nome like '%" + nome + "%'";
			return str_sql;
		}

		/// <summary>
		/// Query que altera.
		/// </summary>
		/// <param name="nome1">Nome a ser alterado</param>
		/// <param name="nome2">Nome novo</param>
		/// <param name="telefone1">Telefone a ser alterado</param>
		/// <param name="telefone11">Telefone novo</param>
		/// <param name="telefone2">Telefone a ser alterado</param>
		/// <param name="telefone22">Telefone novo</param>
		/// <param name="telefone3">Telefone a ser alterado</param>
		/// <param name="telefone33">Telefone novo</param>
		/// <param name="telefone4">Telefone a ser alterado</param>
		/// <param name="telefone44">Telefone novo</param>
		/// <returns>Query</returns>
		public String Query3(String nome1, String nome2, String telefone1, String telefone11, String telefone2, String telefone22, String telefone3, String telefone33, String telefone4, String telefone44)
		{
			str_sql = @"update Alexandro.dbo.tb_cadastro_agenda set Alexandro.dbo.tb_cadastro_agenda.nome = '" + nome2 + "' "
				+ " ,Alexandro.dbo.tb_cadastro_agenda.fone1 = '" + telefone11 + "' "
				+ " ,Alexandro.dbo.tb_cadastro_agenda.fone2 = '" + telefone22 + "' "
				+ " ,Alexandro.dbo.tb_cadastro_agenda.fone3 = '" + telefone33 + "' "
				+ " ,Alexandro.dbo.tb_cadastro_agenda.fone4 = '" + telefone44 + "' "
				+ " where Alexandro.dbo.tb_cadastro_agenda.nome = '" + nome1 + "' "
				+ " and Alexandro.dbo.tb_cadastro_agenda.fone1 = '" + telefone1 + "' "
				+ " and Alexandro.dbo.tb_cadastro_agenda.fone2 = '" + telefone2 + "' "
				+ " and Alexandro.dbo.tb_cadastro_agenda.fone3 = '" + telefone3 + "' "
				+ " and Alexandro.dbo.tb_cadastro_agenda.fone4 = '" + telefone4 + "' ";

			return str_sql;
		}

		/// <summary>
		/// Query de deleção de registros na agenda.
		/// </summary>
		/// <param name="nome1">Nome a ser deletado</param>
		/// <param name="telefone1">Telefone 1 a ser deletado</param>
		/// <param name="telefone2">Telefone 2 a ser deletado</param>
		/// <param name="telefone3">Telefone 3 a ser deletado</param>
		/// <param name="telefone4">Telefone 4 a ser deletado</param>
		/// <returns>Query</returns>
		public String Query4(String nome1, String telefone1, String telefone2, String telefone3, String telefone4)
		{
			str_sql = @"delete from Alexandro.dbo.tb_cadastro_agenda where nome = '" + nome1 + "' "
				+ " and fone1 = '" + telefone1 + "' "
				+ " and fone2 = '" + telefone2 + "' "
				+ " and fone3 = '" + telefone3 + "' "
				+ " and fone4 = '" + telefone4 + "' ";

			return str_sql;
		}

        ///// <summary>
        ///// Query de pesquisa de um determinado nome e telefone
        ///// </summary>
        ///// <param name="nome1">Nome a ser pesquisado.</param>
        ///// <param name="telefone1">Telefone a ser pesquisado.</param>
        ///// <returns>Query</returns>
        //public String QueryTudo()
        //{
        //    str_sql = @"select id as 'Nº:', nome as 'Nome: ', fone1 as 'Telefone 1 : ', fone2 as 'Telefone 2 : ', fone3 as 'Telefone 3 : ', fone4  as 'Telefone 4 : ' from Alexandro.dbo.tb_cadastro_agenda";

        //    return str_sql;
        //}

		/// <summary>
		/// Query de inserção de anotações.
		/// </summary>
		/// <param name="anotacoes">Anotações a serem atualizadas.</param>
		/// <returns>Query</returns>
		public String QueryInsereAnotacao(String anotacoes)
		{
            str_sql = @"update Alexandro.dbo.tb_cadastro_anotacoes set Alexandro.dbo.tb_cadastro_anotacoes.anotacoes = '" + anotacoes + "' ";

			return str_sql;
		}

		/// <summary>
		/// query de Anotações a serem lidas da base
		/// </summary>
		/// <returns>Query</returns>
		public String QueryLeAnotacao()
		{
            str_sql = @"select anotacoes from Alexandro.dbo.tb_cadastro_anotacoes";

			return str_sql;
		}
	}
}
