namespace Final_Proj_FR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Dino = new PictureBox();
            startbutton = new Button();
            Shopbutton = new Button();
            shopDino1 = new PictureBox();
            shopDino4 = new PictureBox();
            GrayDinoSelected = new PictureBox();
            shopDino2 = new PictureBox();
            yellowDinoSelected = new PictureBox();
            shopDino3 = new PictureBox();
            brownDinoSelected = new PictureBox();
            meteor = new PictureBox();
            EXITbutton = new Button();
            warmBlueDinoSelected = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            timer3 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Dino).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shopDino1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shopDino4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GrayDinoSelected).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shopDino2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yellowDinoSelected).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shopDino3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brownDinoSelected).BeginInit();
            ((System.ComponentModel.ISupportInitialize)meteor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)warmBlueDinoSelected).BeginInit();
            SuspendLayout();
            // 
            // Dino
            // 
            Dino.Image = Properties.Resources.unnamed_removebg_preview;
            Dino.Location = new Point(91, 252);
            Dino.Name = "Dino";
            Dino.Size = new Size(87, 90);
            Dino.SizeMode = PictureBoxSizeMode.StretchImage;
            Dino.TabIndex = 0;
            Dino.TabStop = false;
            Dino.PreviewKeyDown += Dino_PreviewKeyDown;
            // 
            // startbutton
            // 
            startbutton.Location = new Point(102, 178);
            startbutton.Name = "startbutton";
            startbutton.Size = new Size(236, 107);
            startbutton.TabIndex = 1;
            startbutton.Text = "Start";
            startbutton.UseVisualStyleBackColor = true;
            startbutton.Click += startbutton_Click;
            // 
            // Shopbutton
            // 
            Shopbutton.Location = new Point(434, 178);
            Shopbutton.Name = "Shopbutton";
            Shopbutton.Size = new Size(236, 107);
            Shopbutton.TabIndex = 2;
            Shopbutton.Text = "Shop";
            Shopbutton.UseVisualStyleBackColor = true;
            Shopbutton.Click += Shopbutton_Click;
            // 
            // shopDino1
            // 
            shopDino1.Image = Properties.Resources.warmbluedino;
            shopDino1.Location = new Point(131, 53);
            shopDino1.Name = "shopDino1";
            shopDino1.Size = new Size(154, 160);
            shopDino1.SizeMode = PictureBoxSizeMode.StretchImage;
            shopDino1.TabIndex = 3;
            shopDino1.TabStop = false;
            shopDino1.Click += shopDino1_Click;
            // 
            // shopDino4
            // 
            shopDino4.Image = Properties.Resources.yellowdino;
            shopDino4.Location = new Point(493, 276);
            shopDino4.Name = "shopDino4";
            shopDino4.Size = new Size(144, 162);
            shopDino4.SizeMode = PictureBoxSizeMode.StretchImage;
            shopDino4.TabIndex = 4;
            shopDino4.TabStop = false;
            shopDino4.Click += shopDino4_Click;
            // 
            // GrayDinoSelected
            // 
            GrayDinoSelected.Image = Properties.Resources.unnamed_removebg_preview;
            GrayDinoSelected.Location = new Point(131, 276);
            GrayDinoSelected.Name = "GrayDinoSelected";
            GrayDinoSelected.Size = new Size(154, 162);
            GrayDinoSelected.SizeMode = PictureBoxSizeMode.StretchImage;
            GrayDinoSelected.TabIndex = 5;
            GrayDinoSelected.TabStop = false;
            GrayDinoSelected.Click += shopDino3_Click;
            // 
            // shopDino2
            // 
            shopDino2.Image = Properties.Resources.blackdino;
            shopDino2.Location = new Point(493, 53);
            shopDino2.Name = "shopDino2";
            shopDino2.Size = new Size(152, 160);
            shopDino2.SizeMode = PictureBoxSizeMode.StretchImage;
            shopDino2.TabIndex = 6;
            shopDino2.TabStop = false;
            shopDino2.Click += shopDino2_Click;
            // 
            // yellowDinoSelected
            // 
            yellowDinoSelected.Image = Properties.Resources.yellowdino_removebg_preview;
            yellowDinoSelected.Location = new Point(483, 276);
            yellowDinoSelected.Name = "yellowDinoSelected";
            yellowDinoSelected.Size = new Size(154, 162);
            yellowDinoSelected.SizeMode = PictureBoxSizeMode.StretchImage;
            yellowDinoSelected.TabIndex = 8;
            yellowDinoSelected.TabStop = false;
            yellowDinoSelected.Click += yellowDinoSelected_Click;
            // 
            // shopDino3
            // 
            shopDino3.BackColor = SystemColors.Control;
            shopDino3.Image = Properties.Resources.unnamed_removebg_preview_removebg_preview;
            shopDino3.Location = new Point(131, 276);
            shopDino3.Name = "shopDino3";
            shopDino3.Size = new Size(154, 160);
            shopDino3.SizeMode = PictureBoxSizeMode.StretchImage;
            shopDino3.TabIndex = 9;
            shopDino3.TabStop = false;
            shopDino3.Click += shopDino3_Click_1;
            // 
            // brownDinoSelected
            // 
            brownDinoSelected.Image = Properties.Resources.blackdino_removebg_preview;
            brownDinoSelected.Location = new Point(491, 53);
            brownDinoSelected.Name = "brownDinoSelected";
            brownDinoSelected.Size = new Size(154, 160);
            brownDinoSelected.SizeMode = PictureBoxSizeMode.StretchImage;
            brownDinoSelected.TabIndex = 10;
            brownDinoSelected.TabStop = false;
            brownDinoSelected.Click += brownDinoSelected_Click;
            // 
            // meteor
            // 
            meteor.BackColor = Color.Transparent;
            meteor.ErrorImage = null;
            meteor.Image = (Image)resources.GetObject("meteor.Image");
            meteor.InitialImage = (Image)resources.GetObject("meteor.InitialImage");
            meteor.Location = new Point(654, 290);
            meteor.Name = "meteor";
            meteor.Size = new Size(84, 37);
            meteor.SizeMode = PictureBoxSizeMode.AutoSize;
            meteor.TabIndex = 12;
            meteor.TabStop = false;
            meteor.Click += meteor_Click;
            // 
            // EXITbutton
            // 
            EXITbutton.Location = new Point(643, 17);
            EXITbutton.Name = "EXITbutton";
            EXITbutton.Size = new Size(142, 61);
            EXITbutton.TabIndex = 13;
            EXITbutton.Text = "EXIT";
            EXITbutton.UseVisualStyleBackColor = true;
            EXITbutton.Click += EXITbutton_Click;
            // 
            // warmBlueDinoSelected
            // 
            warmBlueDinoSelected.Image = Properties.Resources.warmbluedino_removebg_preview;
            warmBlueDinoSelected.Location = new Point(131, 53);
            warmBlueDinoSelected.Name = "warmBlueDinoSelected";
            warmBlueDinoSelected.Size = new Size(154, 160);
            warmBlueDinoSelected.SizeMode = PictureBoxSizeMode.StretchImage;
            warmBlueDinoSelected.TabIndex = 11;
            warmBlueDinoSelected.TabStop = false;
            warmBlueDinoSelected.Click += warmBlueDinoSelected_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // label1
            // 
            label1.AccessibleName = "counter";
            label1.AutoSize = true;
            label1.Location = new Point(654, 17);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 14;
            label1.Text = "Time elapsed: 0";
            label1.Click += label1_Click;
            // 
            // timer3
            // 
            timer3.Tick += timer3_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(EXITbutton);
            Controls.Add(meteor);
            Controls.Add(warmBlueDinoSelected);
            Controls.Add(brownDinoSelected);
            Controls.Add(shopDino3);
            Controls.Add(yellowDinoSelected);
            Controls.Add(shopDino2);
            Controls.Add(GrayDinoSelected);
            Controls.Add(shopDino4);
            Controls.Add(shopDino1);
            Controls.Add(Shopbutton);
            Controls.Add(startbutton);
            Controls.Add(Dino);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)Dino).EndInit();
            ((System.ComponentModel.ISupportInitialize)shopDino1).EndInit();
            ((System.ComponentModel.ISupportInitialize)shopDino4).EndInit();
            ((System.ComponentModel.ISupportInitialize)GrayDinoSelected).EndInit();
            ((System.ComponentModel.ISupportInitialize)shopDino2).EndInit();
            ((System.ComponentModel.ISupportInitialize)yellowDinoSelected).EndInit();
            ((System.ComponentModel.ISupportInitialize)shopDino3).EndInit();
            ((System.ComponentModel.ISupportInitialize)brownDinoSelected).EndInit();
            ((System.ComponentModel.ISupportInitialize)meteor).EndInit();
            ((System.ComponentModel.ISupportInitialize)warmBlueDinoSelected).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Dino;
        private Button startbutton;
        private Button Shopbutton;
        private PictureBox shopDino1;
        private PictureBox shopDino4;
        private PictureBox GrayDinoSelected;
        private PictureBox shopDino2;
        private PictureBox yellowDinoSelected;
        private PictureBox shopDino3;
        private PictureBox brownDinoSelected;
        private PictureBox meteor;
        private Button EXITbutton;
        private PictureBox warmBlueDinoSelected;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label label1;
        private System.Windows.Forms.Timer timer3;
    }
}