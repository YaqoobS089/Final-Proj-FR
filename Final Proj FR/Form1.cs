using System.Collections;
using System.Reflection;

namespace Final_Proj_FR
{
    public partial class Form1 : Form
    {
        bool istrue = true;
        public bool jumplock = false;
        bool dino1selected;
        bool dino2selected;
        bool dino3selected;
        bool dino4selected;

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


            if (istrue == true)
            {
                jump();
                Thread.Sleep(50);
                fall();
                istrue = true;
            }

        }




        private void jump()
        {

            istrue = false;
            for (int i = 0; i <= 40; i = i + 2)
            {

                Dino.Location = new Point(91, 252 - i * 2);
                Thread.Sleep(1);


            }

        }
        private void fall()
        {
            istrue = false;
            for (int i = 0; i <= 40; i = i + 3)
            {
                Dino.Location = new Point(91, 172 + i * 2);
                Thread.Sleep(1);

            }


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

            for(int i = 0; i <= 650; i++)
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
        //public static bool Selected(bool x)
        //{
        //
        //    return true;
        //}
    }
}
