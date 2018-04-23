using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Agenda
{
	/// <summary>
	/// Tela de alteração de registros.
	/// </summary>
	public class Alteracao : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Data.DataSet dataSet1;
		public String Nome1 = "";
		public String Telefone1 = "";
		public String Telefone2 = "";
		public String Telefone3 = "";
		public String Telefone4 = "";

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// Construtor que desabilita o botão de atualização ao iniciar.
		/// </summary>
		public Alteracao()
		{
			InitializeComponent();
			button2.Enabled = false;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Alteracao));
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.dataSet1 = new System.Data.DataSet();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome :";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(56, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(320, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// dataGrid1
			// 
			this.dataGrid1.BackgroundColor = System.Drawing.Color.White;
			this.dataGrid1.CaptionText = "Agenda:";
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(8, 40);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(432, 168);
			this.dataGrid1.TabIndex = 3;
			this.dataGrid1.Click += new System.EventHandler(this.dataGrid1_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(384, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 24);
			this.button1.TabIndex = 2;
			this.button1.Text = "Procura";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.Location = new System.Drawing.Point(320, 216);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(56, 24);
			this.button2.TabIndex = 4;
			this.button2.Text = "Alterar";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.Location = new System.Drawing.Point(384, 216);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(56, 24);
			this.button3.TabIndex = 5;
			this.button3.Text = "Fechar";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "NewDataSet";
			this.dataSet1.Locale = new System.Globalization.CultureInfo("pt-BR");
			// 
			// Alteracao
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(448, 246);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(456, 280);
			this.MinimumSize = new System.Drawing.Size(456, 280);
			this.Name = "Alteracao";
			this.Text = "Alteração";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Fecha a tela de atualização.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button3_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Chama a 2a tela de alteração após ter sido selecionado o registro
		/// no dataGrid.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button2_Click(object sender, System.EventArgs e)
		{
			Altera2 altera = new Altera2(Nome1, Telefone1, Telefone2, Telefone3, Telefone4);
			altera.ShowDialog();
			this.Close();
		}

		/// <summary>
		/// Pesquisa os registros antes de deletar.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				button2.Enabled = false;

				clRegras regras = new clRegras();
				regras.IniciarTransacao();

				String SQL = regras.Query2(textBox1.Text);

				if(textBox1.Text.Length > 100)
				{
					MessageBox.Show("Máximo 100 caracteres !","Consulta",MessageBoxButtons.OK,MessageBoxIcon.Error);
					textBox1.Focus();
				}
				else if(textBox1.Text.Length < 1)
				{
					//String SQLTudo = regras.QueryTudo();
					dataGrid1.DataSource = regras.Consulta(textBox1.Text.ToString().Trim());

					//Cria-se um Data Set aqui para a hora que vc ecolher no
					//dataGrid o RecordSet do DataSet esteza com o conteudo a
					//ser selecionado.
					dataSet1 = regras.CriaDataSet();
					regras.FazerTransacao();
				}
				else if(regras.Consulta(textBox1.Text.ToString().Trim()) != null)
				{
					dataGrid1.DataSource = regras.Consulta(textBox1.Text.ToString().Trim());

					//Cria-se um Data Set aqui para a hora que vc ecolher no
					//dataGrid o RecordSet do DataSet esteza com o conteudo a
					//ser selecionado.
					dataSet1 = regras.CriaDataSet();
					regras.FazerTransacao();
				}
				else
				{
					MessageBox.Show("Nenhum registro encontrado !","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Information);
					dataGrid1.DataSource = null;
				}
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		/// <summary>
		/// Evento que acontece ao se selecionar algum registro no dataGrid.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dataGrid1_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(dataGrid1.CurrentRowIndex >= 0) 
				{
					Nome1 = dataSet1.Tables[0].Rows[dataGrid1.CurrentRowIndex][1].ToString();
					Telefone1 = dataSet1.Tables[0].Rows[dataGrid1.CurrentRowIndex][2].ToString();
					Telefone2 = dataSet1.Tables[0].Rows[dataGrid1.CurrentRowIndex][3].ToString();
					Telefone3 = dataSet1.Tables[0].Rows[dataGrid1.CurrentRowIndex][4].ToString();
					Telefone4 = dataSet1.Tables[0].Rows[dataGrid1.CurrentRowIndex][5].ToString();

					if(
						MessageBox.Show
						(
						"Nome: " 
						+ Nome1.ToString() 
						+ "\nTelefone 1 : " 
						+ Telefone1.ToString()
						+ "\nTelefone 2 : " 
						+ Telefone2.ToString()
						+ "\nTelefone 3 : " 
						+ Telefone3.ToString()
						+ "\nTelefone 4 : " 
						+ Telefone4.ToString()
						,"Selecionar este registro para alterar ?"
						,MessageBoxButtons.YesNo
						,MessageBoxIcon.Question
						,MessageBoxDefaultButton.Button2
						,MessageBoxOptions.ServiceNotification
						) == DialogResult.Yes
						)
					{
						button2.Enabled = true;
					}
					else
					{
						button2.Enabled = false;
						Nome1 = "";
						Telefone1 = "";
					}
				}
			}
			catch(Exception Ex)
			{
				MessageBox.Show(Ex.Message);
			}
		}
	}
}
