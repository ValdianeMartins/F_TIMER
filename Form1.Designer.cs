
namespace F_TIMER
{
    partial class F_TIMER
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.btn_Parar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Reiniciar = new System.Windows.Forms.Button();
            this.img_Carro = new System.Windows.Forms.PictureBox();
            this.btn_IniciarCarro = new System.Windows.Forms.Button();
            this.btn_PararCarro = new System.Windows.Forms.Button();
            this.timer_Carro = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_Carro)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.Location = new System.Drawing.Point(21, 35);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_Iniciar.TabIndex = 0;
            this.btn_Iniciar.Text = "INICIAR";
            this.btn_Iniciar.UseVisualStyleBackColor = true;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // btn_Parar
            // 
            this.btn_Parar.Location = new System.Drawing.Point(126, 35);
            this.btn_Parar.Name = "btn_Parar";
            this.btn_Parar.Size = new System.Drawing.Size(75, 23);
            this.btn_Parar.TabIndex = 1;
            this.btn_Parar.Text = "PARAR";
            this.btn_Parar.UseVisualStyleBackColor = true;
            this.btn_Parar.Click += new System.EventHandler(this.btn_Parar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Btn_Reiniciar
            // 
            this.Btn_Reiniciar.Location = new System.Drawing.Point(234, 35);
            this.Btn_Reiniciar.Name = "Btn_Reiniciar";
            this.Btn_Reiniciar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Reiniciar.TabIndex = 3;
            this.Btn_Reiniciar.Text = "REINICIAR";
            this.Btn_Reiniciar.UseVisualStyleBackColor = true;
            this.Btn_Reiniciar.Click += new System.EventHandler(this.Btn_Reiniciar_Click);
            // 
            // img_Carro
            // 
            this.img_Carro.Image = global::F_TIMER.Properties.Resources.CARRO3;
            this.img_Carro.Location = new System.Drawing.Point(21, 142);
            this.img_Carro.Name = "img_Carro";
            this.img_Carro.Size = new System.Drawing.Size(114, 87);
            this.img_Carro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Carro.TabIndex = 4;
            this.img_Carro.TabStop = false;
            // 
            // btn_IniciarCarro
            // 
            this.btn_IniciarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IniciarCarro.Location = new System.Drawing.Point(21, 94);
            this.btn_IniciarCarro.Name = "btn_IniciarCarro";
            this.btn_IniciarCarro.Size = new System.Drawing.Size(75, 30);
            this.btn_IniciarCarro.TabIndex = 5;
            this.btn_IniciarCarro.Text = "iniciar carro";
            this.btn_IniciarCarro.UseVisualStyleBackColor = true;
            this.btn_IniciarCarro.Click += new System.EventHandler(this.btn_IniciarCarro_Click);
            // 
            // btn_PararCarro
            // 
            this.btn_PararCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PararCarro.Location = new System.Drawing.Point(102, 94);
            this.btn_PararCarro.Name = "btn_PararCarro";
            this.btn_PararCarro.Size = new System.Drawing.Size(70, 30);
            this.btn_PararCarro.TabIndex = 6;
            this.btn_PararCarro.Text = "parar carro";
            this.btn_PararCarro.UseVisualStyleBackColor = true;
            this.btn_PararCarro.Click += new System.EventHandler(this.btn_PararCarro_Click);
            // 
            // timer_Carro
            // 
            this.timer_Carro.Interval = 10;
            this.timer_Carro.Tick += new System.EventHandler(this.timer_Carro_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "inicial 12 fim 340";
            // 
            // F_TIMER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_PararCarro);
            this.Controls.Add(this.btn_IniciarCarro);
            this.Controls.Add(this.img_Carro);
            this.Controls.Add(this.Btn_Reiniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Parar);
            this.Controls.Add(this.btn_Iniciar);
            this.Name = "F_TIMER";
            this.Text = "F_TIMER";
            this.Load += new System.EventHandler(this.F_TIMER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Carro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Iniciar;
        private System.Windows.Forms.Button btn_Parar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Reiniciar;
        private System.Windows.Forms.PictureBox img_Carro;
        private System.Windows.Forms.Button btn_IniciarCarro;
        private System.Windows.Forms.Button btn_PararCarro;
        private System.Windows.Forms.Timer timer_Carro;
        private System.Windows.Forms.Label label2;
    }
}

