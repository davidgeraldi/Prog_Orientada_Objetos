namespace exercicio2_aula3
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
            this.components = new System.ComponentModel.Container();
            this.cara = new System.Windows.Forms.RadioButton();
            this.coroa = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxCara = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoroa = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoroa)).BeginInit();
            this.SuspendLayout();
            // 
            // cara
            // 
            this.cara.AutoSize = true;
            this.cara.Location = new System.Drawing.Point(129, 91);
            this.cara.Name = "cara";
            this.cara.Size = new System.Drawing.Size(57, 20);
            this.cara.TabIndex = 0;
            this.cara.TabStop = true;
            this.cara.Text = "Cara";
            this.cara.UseVisualStyleBackColor = true;
            // 
            // coroa
            // 
            this.coroa.AutoSize = true;
            this.coroa.Location = new System.Drawing.Point(278, 91);
            this.coroa.Name = "coroa";
            this.coroa.Size = new System.Drawing.Size(65, 20);
            this.coroa.TabIndex = 1;
            this.coroa.TabStop = true;
            this.coroa.Text = "Coroa";
            this.coroa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione Cara ou Coroa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Girar Moeda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxCara
            // 
            this.pictureBoxCara.Image = global::exercicio2_aula3.Properties.Resources.cara;
            this.pictureBoxCara.Location = new System.Drawing.Point(115, 161);
            this.pictureBoxCara.Name = "pictureBoxCara";
            this.pictureBoxCara.Size = new System.Drawing.Size(212, 199);
            this.pictureBoxCara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCara.TabIndex = 3;
            this.pictureBoxCara.TabStop = false;
            // 
            // pictureBoxCoroa
            // 
            this.pictureBoxCoroa.Image = global::exercicio2_aula3.Properties.Resources.coroa;
            this.pictureBoxCoroa.Location = new System.Drawing.Point(115, 161);
            this.pictureBoxCoroa.Name = "pictureBoxCoroa";
            this.pictureBoxCoroa.Size = new System.Drawing.Size(212, 199);
            this.pictureBoxCoroa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoroa.TabIndex = 5;
            this.pictureBoxCoroa.TabStop = false;
            this.pictureBoxCoroa.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxCoroa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxCara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coroa);
            this.Controls.Add(this.cara);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoroa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton cara;
        private System.Windows.Forms.RadioButton coroa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxCara;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxCoroa;
        private System.Windows.Forms.Label label2;
    }
}

