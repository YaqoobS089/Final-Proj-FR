using System.Collections;
using System.Reflection;
using System;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Final_Proj_FR
{
    public partial class Form1 : Form
    {
        bool onground = true;
        public bool jumplock = false;
        bool dino1selected;
        bool dino2selected;
        bool dino3selected;
        bool dino4selected;
        int time1left = 0;
        int time2left = 0;
        bool goingup = true;


        public Form1()
        {
            InitializeComponent();
            Dino.Visible = false;
            shopDino1.Visible = false;
            shopDino2.Visible = false;
            shopDino3.Visible = false;
            GrayDinoSelected.Visible = false;
            shopDino4.Visible = false;
            yellowDinoSelected.Visible = false;
            brownDinoSelected.Visible = false;
            GrayDinoSelected.Visible = false;
            warmBlueDinoSelected.Visible = false;
            meteor.Visible = false;
            EXITbutton.Visible = false;

            Dino.Location = new Point(91, 252);
            meteor.Location = new Point(658, 291);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Dino_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) {
                timer1.Interval -= 2;
                if (timer1.Interval <= 2) {
                    timer1.Interval = 3;
                }
            }

            if (e.KeyCode == Keys.Left) 
            {
                timer1.Interval += 2;
                if (timer1.Interval >= 21)
                {
                    timer1.Interval = 20;
                }
            }

            if (e.KeyCode == Keys.Up) {
                if (onground == true)
                {
                    onground = false;
                    time2left = 0;
                }
            }
            /*if (onground == true)
            {
                jump();
                Thread.Sleep(50);
                fall();
                onground = true;
            }*/

        }




        


        private void Shopbutton_Click(object sender, EventArgs e)
        {
            Dino.Visible = false;
            startbutton.Visible = false;
            Shopbutton.Visible = false;
            shopDino1.Visible = true;
            shopDino2.Visible = true;
            shopDino3.Visible = false;
            shopDino4.Visible = true;
            yellowDinoSelected.Visible = false;
            brownDinoSelected.Visible = false;
            GrayDinoSelected.Visible = true;
            warmBlueDinoSelected.Visible = false;
            EXITbutton.Visible = true;
            if (dino1selected == true)
            {
                shopDino1.Visible = false;
                shopDino2.Visible = true;
                shopDino3.Visible = true;
                shopDino4.Visible = true;
                warmBlueDinoSelected.Visible = true;
                brownDinoSelected.Visible = false;
                GrayDinoSelected.Visible = false;
                yellowDinoSelected.Visible = false;

            }
            else if (dino2selected == true)
            {
                shopDino1.Visible = true;
                shopDino2.Visible = false;
                shopDino3.Visible = true;
                shopDino4.Visible = true;
                warmBlueDinoSelected.Visible = false;
                brownDinoSelected.Visible = true;
                GrayDinoSelected.Visible = false;
                yellowDinoSelected.Visible = false;
            }
            else if (dino3selected == true)
            {
                shopDino1.Visible = true;
                shopDino2.Visible = true;
                shopDino3.Visible = false;
                shopDino4.Visible = true;
                warmBlueDinoSelected.Visible = false;
                brownDinoSelected.Visible = false;
                GrayDinoSelected.Visible = true;
                yellowDinoSelected.Visible = false;
            }
            else if (dino4selected == true)
            {
                shopDino1.Visible = true;
                shopDino2.Visible = true;
                shopDino3.Visible = true;
                shopDino4.Visible = false;
                warmBlueDinoSelected.Visible = false;
                brownDinoSelected.Visible = false;
                GrayDinoSelected.Visible = false;
                yellowDinoSelected.Visible = true;
            }


        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            Dino.Visible = true;
            startbutton.Visible = false;
            Shopbutton.Visible = false;
            startbutton.Enabled = false;
            Shopbutton.Enabled = false;
            meteor.Visible = true;

            //this.timeleft = 20;
            //InitializeComponent();

            timer1.Interval = 10;
            timer1.Start();

            timer2.Interval = 50;
            timer2.Start();



            // start things


            for (int i = 0; i <= 650; i++)
            {

                //Thread.Sleep(1);
                meteor.Location = new Point(654 - i, 290);
            }





        }


        public void shopDino1_Click(object sender, EventArgs e)
        {
            warmBlueDinoSelected.Visible = true;
            yellowDinoSelected.Visible = false;
            brownDinoSelected.Visible = false;
            GrayDinoSelected.Visible = false;
            shopDino1.Visible = false;
            shopDino2.Visible = true;
            shopDino3.Visible = true;
            shopDino4.Visible = true;
            dino1selected = true;
            dino2selected = false;
            dino3selected = false;
            dino4selected = false;





        }

        public void shopDino2_Click(object sender, EventArgs e)
        {
            shopDino1.Visible = true;
            shopDino2.Visible = false;
            shopDino3.Visible = true;
            shopDino4.Visible = true;
            warmBlueDinoSelected.Visible = false;
            yellowDinoSelected.Visible = false;
            brownDinoSelected.Visible = true;
            GrayDinoSelected.Visible = false;
            dino1selected = false;
            dino2selected = true;
            dino3selected = false;
            dino4selected = false;


        }

        public void shopDino3_Click(object sender, EventArgs e)
        {
            warmBlueDinoSelected.Visible = false;
            yellowDinoSelected.Visible = false;
            brownDinoSelected.Visible = false;
            GrayDinoSelected.Visible = true;
            shopDino1.Visible = true;
            shopDino2.Visible = true;
            shopDino3.Visible = false;
            shopDino4.Visible = true;
            dino1selected = false;
            dino2selected = false;
            dino3selected = true;
            dino4selected = false;
        }

        public void shopDino4_Click(object sender, EventArgs e)
        {
            warmBlueDinoSelected.Visible = false;
            yellowDinoSelected.Visible = true;
            brownDinoSelected.Visible = false;
            GrayDinoSelected.Visible = false;
            shopDino1.Visible = true;
            shopDino2.Visible = true;
            shopDino3.Visible = true;
            shopDino4.Visible = false;
            dino1selected = false;
            dino2selected = false;
            dino3selected = false;
            dino4selected = true;
        }

        public void shopDino3_Click_1(object sender, EventArgs e)
        {

        }

        public void warmBlueDinoSelected_Click(object sender, EventArgs e)
        {

        }

        public void EXITbutton_Click(object sender, EventArgs e)
        {
            Dino.Visible = false;
            shopDino1.Visible = false;
            shopDino2.Visible = false;
            shopDino3.Visible = false;
            GrayDinoSelected.Visible = false;
            shopDino4.Visible = false;
            yellowDinoSelected.Visible = false;
            brownDinoSelected.Visible = false;
            GrayDinoSelected.Visible = false;
            warmBlueDinoSelected.Visible = false;
            meteor.Visible = false;
            EXITbutton.Visible = false;
            Shopbutton.Visible = true;
            startbutton.Visible = true;

            Dino.Location = new Point(91, 252);
        }

        public void brownDinoSelected_Click(object sender, EventArgs e)
        {

        }

        public void yellowDinoSelected_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time1left++;
            int i = time1left * 2; //5 
            meteor.Location = new Point(654 - i, 290);

            if (time1left >= 360) //140
            {
                time1left = 0;
                //timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time2left++;
            int i = (time2left % 21)*10;

            if (onground == false)
            {
                if (goingup == true)
                {
                    Dino.Location = new Point(91, 252 - i);
                    if (i >= 200)
                    {
                        goingup = false;
                        time2left = 0;
                    }
                }
                else
                {
                    Dino.Location = new Point(91, 52 + i);
                    if (i >= 200)
                    {
                        goingup = true;
                        onground = true;
                    }
                }
            }
           


            
        }
    }
}
