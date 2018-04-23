using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Agenda
{
	/// <summary>
	/// Summary description for Anotacoes.
	/// </summary>
	public class Anotacoes : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Anotacoes()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Anotacoes));
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBox1.Location = new System.Drawing.Point(8, 8);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(688, 432);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(584, 448);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 24);
			this.button1.TabIndex = 1;
			this.button1.Text = "Fechar/Salvar";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Anotacoes
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(704, 478);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.richTextBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(712, 512);
			this.MinimumSize = new System.Drawing.Size(712, 512);
			this.Name = "Anotacoes";
			this.Text = "Anotações";
			this.Load += new System.EventHandler(this.Anotacoes_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				DataSet confirma;
				clRegras regras = new clRegras();
				confirma = regras.insereAnotacoes(richTextBox1.Text.ToString());
				if(confirma != null)
				{
					this.Close();
				}
				else
				{
					MessageBox.Show("Problemas !","Anotações",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);				
			}
		}

		private void Anotacoes_Load(object sender, System.EventArgs e)
		{
			try
			{
				DataSet confirma;
				clRegras regras = new clRegras();
				confirma = regras.leAnotacoes();

				for(int numero = 0;numero < confirma.Tables[0].Rows.Count;numero++)
				{
					String linha = confirma.Tables[0].Rows[numero][0].ToString();
					richTextBox1.Text += linha;
				}
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
