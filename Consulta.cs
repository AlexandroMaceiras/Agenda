using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Agenda
{
	/// <summary>
	/// Tela de consulta de registros.
	/// </summary>
	public class Consulta : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button button2;
		public String Nome1 = "";
		public String Telefone1 = "";
		public String Telefone2 = "";
		public String Telefone3 = "";
		public String Telefone4 = "";
		private System.Data.DataSet dataSet1;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// Construtor simples.
		/// </summary>
		public Consulta()
		{
			InitializeComponent();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Consulta));
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.button2 = new System.Windows.Forms.Button();
			this.dataSet1 = new System.Data.DataSet();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Entre com o nome a consultar :";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(8, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(352, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(368, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 24);
			this.button1.TabIndex = 2;
			this.button1.Text = "Consultar";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.AllowNavigation = false;
			this.dataGrid1.AllowSorting = false;
			this.dataGrid1.BackgroundColor = System.Drawing.Color.White;
			this.dataGrid1.CaptionText = "Agenda: ";
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(8, 56);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(432, 144);
			this.dataGrid1.TabIndex = 3;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			this.dataGrid1.Click += new System.EventHandler(this.dataGrid1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.Location = new System.Drawing.Point(384, 208);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(56, 24);
			this.button2.TabIndex = 5;
			this.button2.Text = "Fechar";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "NewDataSet";
			this.dataSet1.Locale = new System.Globalization.CultureInfo("pt-BR");
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "";
			// 
			// Consulta
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(448, 238);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(456, 272);
			this.MinimumSize = new System.Drawing.Size(456, 272);
			this.Name = "Consulta";
			this.Text = "Consulta";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Fecha a tela de consulta.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Executa a consulta pelo nome.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, System.EventArgs e)
		{
			try
			{
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
		/// Mostra o conteudo do registro clicado no dataGrid em uma menssagem.
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
						,"Agenda - Informação Completa."
						,MessageBoxButtons.OK
						,MessageBoxIcon.Information
						);
				}
			}
			catch(Exception Ex)
			{
				MessageBox.Show(Ex.Message);
			}

		}

	}
}
