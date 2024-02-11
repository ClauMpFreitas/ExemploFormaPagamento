using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ExemploFormaPagamento
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void BtncalcularClick(object sender, EventArgs e)
		{
			double vcompra, vpagar=0;
			vcompra=double.Parse(txtcompra.Text);
			
			if (cmbforma.SelectedIndex==0)
				vpagar=vcompra*0.95;
			else if (cmbforma.SelectedIndex==1)
				vpagar=vcompra*0.98;
			else if (cmbforma.SelectedIndex==2)
				vpagar=vcompra;
			
			txtpagar.Text=vpagar.ToString();
		}
		void BtnnovoClick(object sender, EventArgs e)
		{
			txtcompra.Clear();
			txtpagar.Clear();
			cmbforma.SelectedIndex=-1;
			cmbforma.Text = "Escolha uma opção";
			txtcompra.Focus();
		}
	}
}
