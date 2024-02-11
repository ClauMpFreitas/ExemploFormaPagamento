/*
 * Criado por SharpDevelop.
 * Usuário: Diogo Freitas
 * Data: 06/03/2023
 * Hora: 21:19
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace ExemploFormaPagamento
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtcompra;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbforma;
		private System.Windows.Forms.Button btncalcular;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtpagar;
		private System.Windows.Forms.Button btnnovo;
		private System.Windows.Forms.PictureBox pictureBox1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.txtcompra = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbforma = new System.Windows.Forms.ComboBox();
			this.btncalcular = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtpagar = new System.Windows.Forms.TextBox();
			this.btnnovo = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 10);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(190, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Digite o valor da compra";
			// 
			// txtcompra
			// 
			this.txtcompra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtcompra.Location = new System.Drawing.Point(13, 46);
			this.txtcompra.Margin = new System.Windows.Forms.Padding(4);
			this.txtcompra.Name = "txtcompra";
			this.txtcompra.Size = new System.Drawing.Size(190, 26);
			this.txtcompra.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 86);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(170, 32);
			this.label2.TabIndex = 2;
			this.label2.Text = "Forma de pagamento";
			// 
			// cmbforma
			// 
			this.cmbforma.FormattingEnabled = true;
			this.cmbforma.Items.AddRange(new object[] {
			"Dinheiro ou pix",
			"Cartão de débito",
			"Cartão de crédito"});
			this.cmbforma.Location = new System.Drawing.Point(190, 86);
			this.cmbforma.Margin = new System.Windows.Forms.Padding(4);
			this.cmbforma.Name = "cmbforma";
			this.cmbforma.Size = new System.Drawing.Size(180, 26);
			this.cmbforma.TabIndex = 3;
			this.cmbforma.Text = "Escolha uma opção";
			// 
			// btncalcular
			// 
			this.btncalcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncalcular.Location = new System.Drawing.Point(376, 132);
			this.btncalcular.Margin = new System.Windows.Forms.Padding(4);
			this.btncalcular.Name = "btncalcular";
			this.btncalcular.Size = new System.Drawing.Size(189, 39);
			this.btncalcular.TabIndex = 4;
			this.btncalcular.Text = "Calcular";
			this.btncalcular.UseVisualStyleBackColor = true;
			this.btncalcular.Click += new System.EventHandler(this.BtncalcularClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 199);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(150, 32);
			this.label3.TabIndex = 5;
			this.label3.Text = "Valor a pagar";
			// 
			// txtpagar
			// 
			this.txtpagar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtpagar.Location = new System.Drawing.Point(132, 199);
			this.txtpagar.Margin = new System.Windows.Forms.Padding(4);
			this.txtpagar.Name = "txtpagar";
			this.txtpagar.Size = new System.Drawing.Size(211, 26);
			this.txtpagar.TabIndex = 6;
			// 
			// btnnovo
			// 
			this.btnnovo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnnovo.Location = new System.Drawing.Point(376, 246);
			this.btnnovo.Margin = new System.Windows.Forms.Padding(4);
			this.btnnovo.Name = "btnnovo";
			this.btnnovo.Size = new System.Drawing.Size(189, 39);
			this.btnnovo.TabIndex = 7;
			this.btnnovo.Text = "Nova compra";
			this.btnnovo.UseVisualStyleBackColor = true;
			this.btnnovo.Click += new System.EventHandler(this.BtnnovoClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(607, 24);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(201, 161);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(821, 310);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnnovo);
			this.Controls.Add(this.txtpagar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btncalcular);
			this.Controls.Add(this.cmbforma);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtcompra);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculando formas de pagamento";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
