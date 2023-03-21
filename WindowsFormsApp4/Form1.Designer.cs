namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBitcoin = new System.Windows.Forms.TextBox();
            this.lbBitcoin = new System.Windows.Forms.Label();
            this.lbEuro = new System.Windows.Forms.Label();
            this.lbDolar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cotação Dolar:";
            // 
            // txtDolar
            // 
            this.txtDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolar.Location = new System.Drawing.Point(215, 131);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(99, 28);
            this.txtDolar.TabIndex = 19;
            // 
            // btnConverter
            // 
            this.btnConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.Location = new System.Drawing.Point(370, 154);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(144, 53);
            this.btnConverter.TabIndex = 18;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnDollar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Real:";
            // 
            // txtReal
            // 
            this.txtReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReal.Location = new System.Drawing.Point(162, 172);
            this.txtReal.Name = "txtReal";
            this.txtReal.Size = new System.Drawing.Size(100, 28);
            this.txtReal.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cotação Euro:";
            // 
            // txtEuro
            // 
            this.txtEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuro.Location = new System.Drawing.Point(215, 97);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(99, 28);
            this.txtEuro.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Cotação Bitcoin:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtBitcoin
            // 
            this.txtBitcoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBitcoin.Location = new System.Drawing.Point(215, 63);
            this.txtBitcoin.Name = "txtBitcoin";
            this.txtBitcoin.Size = new System.Drawing.Size(99, 28);
            this.txtBitcoin.TabIndex = 23;
            // 
            // lbBitcoin
            // 
            this.lbBitcoin.AutoSize = true;
            this.lbBitcoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBitcoin.Location = new System.Drawing.Point(357, 60);
            this.lbBitcoin.Name = "lbBitcoin";
            this.lbBitcoin.Size = new System.Drawing.Size(144, 26);
            this.lbBitcoin.TabIndex = 25;
            this.lbBitcoin.Text = "Bitcoin: 00.00";
            // 
            // lbEuro
            // 
            this.lbEuro.AutoSize = true;
            this.lbEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEuro.Location = new System.Drawing.Point(377, 86);
            this.lbEuro.Name = "lbEuro";
            this.lbEuro.Size = new System.Drawing.Size(124, 26);
            this.lbEuro.TabIndex = 26;
            this.lbEuro.Text = "Euro: 00.00";
            // 
            // lbDolar
            // 
            this.lbDolar.AutoSize = true;
            this.lbDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDolar.Location = new System.Drawing.Point(371, 112);
            this.lbDolar.Name = "lbDolar";
            this.lbDolar.Size = new System.Drawing.Size(130, 26);
            this.lbDolar.TabIndex = 27;
            this.lbDolar.Text = "Dolar: 00.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(130, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 37);
            this.label8.TabIndex = 28;
            this.label8.Text = "Conversor Moeda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(562, 220);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbDolar);
            this.Controls.Add(this.lbEuro);
            this.Controls.Add(this.lbBitcoin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBitcoin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReal);
            this.ForeColor = System.Drawing.Color.Gold;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Conversor de Moeda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBitcoin;
        private System.Windows.Forms.Label lbBitcoin;
        private System.Windows.Forms.Label lbEuro;
        private System.Windows.Forms.Label lbDolar;
        private System.Windows.Forms.Label label8;
    }
}

