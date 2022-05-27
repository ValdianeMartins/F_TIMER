using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F_TIMER
{
    public partial class F_TIMER : Form
    {
        int num = 0;
        int px,py;
        public F_TIMER()
        {
            InitializeComponent();
        }

        private void F_TIMER_Load(object sender, EventArgs e)
        {
            px = img_Carro.Location.X;
            py = img_Carro.Location.Y;
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_Parar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = num.ToString();
            num++;
        }

        private void Btn_Reiniciar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            num = 0;
            label1.Text = num.ToString();
            timer1.Start();
        }

        private void btn_IniciarCarro_Click(object sender, EventArgs e)
        {
            timer_Carro.Start();
        }

        private void btn_PararCarro_Click(object sender, EventArgs e)
        {
            timer_Carro.Stop();
        }

        private void timer_Carro_Tick(object sender, EventArgs e)
        {
            px+=2;
            if (px >= 680)
            {
                px = 12;
            }
            img_Carro.Location=new Point(px, py);
            px = img_Carro.Location.X;
        }
    }
}
