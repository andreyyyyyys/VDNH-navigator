using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace НОВЫЙ_НАВИГАТОР
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        public int VbIBR_TOCHKI_NACHALA_MARSHRYTA_X = 0; //
        public int VbIBR_TOCHKI_NACHALA_MARSHRYTA_Y = 0; //     координаты начала и конца маршрута
        public int VbIBR_TOCHKI_KONCA_MARSHRYTA_X = 0;   //
        public int VbIBR_TOCHKI_KONCA_MARSHRYTA_Y = 0;   //

        bool JDATb_NACHALA_MARSHRYTA = false;    //нажата кнопка выбора начала маршрута или нет
        bool JDATb_KONCA_MARSHRYTA = false;      //нажата кнопка выбора конца маршрута или нет
        bool JDATb_POSTRONIU_MARSHRYTA = false;  //начальная и конечная точка маршрута выбраны, ожидание построения

        PictureBox[] TOCHKI = new PictureBox[12];   //массив контрольных точек


        private void Form2_Load(object sender, EventArgs e)
        {
            TOCHKI[0]=pictureBox1;
            TOCHKI[1]=pictureBox2;
            TOCHKI[2]=pictureBox3;
            TOCHKI[3]=pictureBox4;
            TOCHKI[4]=pictureBox5;
            TOCHKI[5]=pictureBox6;
            TOCHKI[6]=pictureBox7;
            TOCHKI[7]=pictureBox8;
            TOCHKI[8]=pictureBox9;
            TOCHKI[9]=pictureBox10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JDATb_NACHALA_MARSHRYTA = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JDATb_KONCA_MARSHRYTA=true;
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (JDATb_NACHALA_MARSHRYTA==true)
            {
                VbIBR_TOCHKI_NACHALA_MARSHRYTA_X=e.Location.X;
                VbIBR_TOCHKI_NACHALA_MARSHRYTA_Y=e.Location.Y; //создание точки начала маршрута на карте
                Button NACHALO = new Button();
                NACHALO.Location=new Point(VbIBR_TOCHKI_NACHALA_MARSHRYTA_X, VbIBR_TOCHKI_NACHALA_MARSHRYTA_Y);
                NACHALO.Size=new Size(15, 15);
                NACHALO.BackColor=Color.Purple;
                NACHALO.Enabled=false;
                this.Controls.Add(NACHALO);
                JDATb_NACHALA_MARSHRYTA=false;
            }
            if (JDATb_KONCA_MARSHRYTA==true)
            {
                VbIBR_TOCHKI_KONCA_MARSHRYTA_X=e.Location.X;
                VbIBR_TOCHKI_KONCA_MARSHRYTA_Y=e.Location.Y;  //создание точки конца маршрута на карте
                Button KONEC = new Button();
                KONEC.Location=new Point(VbIBR_TOCHKI_KONCA_MARSHRYTA_X, VbIBR_TOCHKI_KONCA_MARSHRYTA_Y);
                KONEC.Size=new Size(15, 15);
                KONEC.BackColor=Color.Purple;
                KONEC.Enabled=false;
                this.Controls.Add(KONEC);
                JDATb_KONCA_MARSHRYTA=false;
                JDATb_POSTRONIU_MARSHRYTA=true;

            }
        }

        private void OBSHIU_TAIMER_Tick(object sender, EventArgs e)
        {

        }
    }
}
//for i in range(10):
//    print("            TOCHKI[", i, "]=pictureBox", i+1, ";", sep='')