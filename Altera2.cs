using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Agenda
{
	/// <summary>
	/// Tela de alteração de um registro selecionado anteriormente.
	/// </summary>
	public class Altera2 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private String Nome1 = "";
		private String Telefone1 = "";
		private String Telefone2 = "";
		private String Telefone3 = "";
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private String Telefone4 = "";

		/// <summary>
		/// Construtor normal.
		/// </summary>
		public Altera2()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Construtor que recebe os dados existentes no registro a serem
		/// modificados e atualiza as variáveis globais com estes.
		/// </summary>
		/// <param name="nome1"></param>
		/// <param name="telefone1"></param>
		/// <param name="telefone2"></param>
		/// <param name="telefone3"></param>
		/// <param name="telefone4"></param>
		public Altera2(String nome1, String telefone1, String telefone2, String telefone3, String telefone4)
		{
			InitializeComponent();
			this.Nome1 = nome1;
			this.Telefone1 = telefone1;
			this.Telefone2 = telefone2;
			this.Telefone3 = telefone3;
			this.Telefone4 = telefone4;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Altera2));
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
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
			this.textBox1.Location = new System.Drawing.Point(72, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(424, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Telefone 1 :";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(88, 40);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(120, 20);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(440, 112);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 24);
			this.button1.TabIndex = 4;
			this.button1.Text = "Fechar";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.Location = new System.Drawing.Point(376, 112);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(56, 24);
			this.button2.TabIndex = 5;
			this.button2.Text = "Alterar";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(304, 72);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(120, 20);
			this.textBox5.TabIndex = 17;
			this.textBox5.Text = "";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(224, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 16);
			this.label5.TabIndex = 16;
			this.label5.Text = "Telefone 4 :";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(88, 72);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(120, 20);
			this.textBox4.TabIndex = 15;
			this.textBox4.Text = "";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 16);
			this.label4.TabIndex = 14;
			this.label4.Text = "Telefone 3 :";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(304, 40);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(120, 20);
			this.textBox3.TabIndex = 13;
			this.textBox3.Text = "";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(224, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 16);
			this.label3.TabIndex = 12;
			this.label3.Text = "Telefone 2 :";
			// 
			// Altera2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(504, 142);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(512, 176);
			this.MinimumSize = new System.Drawing.Size(512, 176);
			this.Name = "Altera2";
			this.Text = "Alterar";
			this.Load += new System.EventHandler(this.Alterar_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Fecha a tela de alteração de registro selecionado.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Executa a alteração que foi feita nos campos.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button2_Click(object sender, System.EventArgs e)
		{
			if(textBox1.Text.Length > 100)
			{
				MessageBox.Show("Máximo 100 caracteres no Nome !","Alteração",MessageBoxButtons.OK,MessageBoxIcon.Error);
				textBox1.Focus();
			}
			else if(textBox2.Text.Length > 14)
			{
				MessageBox.Show("Máximo 14 caracteres no Telefone !","Alteração",MessageBoxButtons.OK,MessageBoxIcon.Error);
				textBox2.Focus();
			}
			else if(textBox1.Text.Length < 6)
			{
				MessageBox.Show("Mínimo 6 caracteres no Nome !","Alteração",MessageBoxButtons.OK,MessageBoxIcon.Error);
				textBox1.Focus();
			}
			else if(textBox2.Text.Length < 3)
			{
				MessageBox.Show("Mínimo 3 caracteres no Telefone !","Alteração",MessageBoxButtons.OK,MessageBoxIcon.Error);
				textBox2.Focus();
			}
			else
			{
				try
				{
					DataSet confirma;
					clRegras regras = new clRegras();
					confirma = regras.Alterar
						(
						Nome1.ToString().Trim(),
						textBox1.Text.ToString().Trim(),
						Telefone1.ToString().Trim(),
						textBox2.Text.ToString().Trim(),
						Telefone2.ToString().Trim(),
						textBox3.Text.ToString().Trim(),
						Telefone3.ToString().Trim(),
						textBox4.Text.ToString().Trim(),
						Telefone4.ToString().Trim(),
						textBox5.Text.ToString().Trim()
						);
					if(confirma != null)
					{
						this.Close();
						Application.DoEvents();
						MessageBox.Show("Alterado com sucesso !","Alteração",MessageBoxButtons.OK,MessageBoxIcon.Information);
					}
					else
					{
						this.Close();
						Application.DoEvents();
						MessageBox.Show("Não Alterado !\nOcorreu algum problema !","Alteração",MessageBoxButtons.OK,MessageBoxIcon.Error);
					}
				}

				catch(Exception ex)
				{
					throw new Exception(ex.Message);
				}
			}
		}

		/// <summary>
		/// Carrega os campos do formulário com o atual conteúdo do registro
		/// que será atualizado.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Alterar_Load(object sender, System.EventArgs e)
		{
			textBox1.Text = this.Nome1.Trim();
			textBox2.Text = this.Telefone1.Trim();
			textBox3.Text = this.Telefone2.Trim();
			textBox4.Text = this.Telefone3.Trim();
			textBox5.Text = this.Telefone4.Trim();
		}
	}
}
