using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Agenda
{
	/// <summary>
	/// Menu principal da Agenda.
	/// </summary>
	public class MenuPrincipal : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.MainMenu mainMenu1;
		public System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.MonthCalendar monthCalendar1;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// Construtor simples.
		/// </summary>
		public MenuPrincipal()
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
				if (components != null) 
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MenuPrincipal));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.button6 = new System.Windows.Forms.Button();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(16, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(184, 24);
			this.button1.TabIndex = 0;
			this.button1.Text = "Consulta";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.Location = new System.Drawing.Point(16, 48);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(184, 24);
			this.button2.TabIndex = 1;
			this.button2.Text = "Inclusão";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.Location = new System.Drawing.Point(16, 112);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(184, 24);
			this.button3.TabIndex = 2;
			this.button3.Text = "Deleção";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(64, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "Menu Principal";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Location = new System.Drawing.Point(16, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(216, 176);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button4.Location = new System.Drawing.Point(16, 80);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(184, 24);
			this.button4.TabIndex = 3;
			this.button4.Text = "Alteração";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button5.Location = new System.Drawing.Point(336, 224);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(72, 24);
			this.button5.TabIndex = 4;
			this.button5.Text = "Fechar";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3});
			this.menuItem1.Shortcut = System.Windows.Forms.Shortcut.F1;
			this.menuItem1.Text = "&Ajuda";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "Sobre";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "Versão";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button6.Location = new System.Drawing.Point(32, 184);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(184, 24);
			this.button6.TabIndex = 6;
			this.button6.Text = "Anotações";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(240, 48);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 7;
			// 
			// MenuPrincipal
			// 
			this.AutoScale = false;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(418, 280);
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button5);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(424, 312);
			this.Menu = this.mainMenu1;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(424, 312);
			this.Name = "MenuPrincipal";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Agenda Pessoal v. 1.4";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MenuPrincipal());
		}

		/// <summary>
		/// Consulta registos na agenda.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, System.EventArgs e)
		{
			Consulta consulta = new Consulta();
			consulta.ShowDialog();
		}

		/// <summary>
		/// Inclui registros na agenda.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button2_Click(object sender, System.EventArgs e)
		{
			Inclusao inclusao = new Inclusao();
			inclusao.ShowDialog();
		}

		/// <summary>
		/// Deleta registros na agenda.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button3_Click(object sender, System.EventArgs e)
		{
			Delecao delecao = new Delecao();
			delecao.ShowDialog();
		}

		/// <summary>
		/// Altera registros na agenda.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button4_Click(object sender, System.EventArgs e)
		{
			Alteracao alteracao = new Alteracao();
			alteracao.ShowDialog();
		}

		/// <summary>
		/// Fecha o programa.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button5_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Mostra o Copyright do menú SOBRE.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			Sobre sobre = new Sobre();
			sobre.ShowDialog();
			//MessageBox.Show(" Agenda pessoal desenvolvida por:\n\nMaceiras Sistemas S\\C Ltda.\nAv. Braz Leme, 2428 - 12\nSão Paulo - SP\n\nCopyright (c) by Alexandro Antonio Blini Maceiras.","Sobre");
		}

		/// <summary>
		/// Mostra a versão do programa.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Agenda Pessoal\n\n\nVersão 1.4","Versão");
		}

		/// <summary>
		/// Abre o form anotações.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button6_Click(object sender, System.EventArgs e)
		{
			Anotacoes anotacoes = new Anotacoes();
			anotacoes.ShowDialog();
		}
	}
}
