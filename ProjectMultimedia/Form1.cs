using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMultimedia
{
    public partial class Form1 : Form
    {
        Timer tt = new Timer();
        public class CACtor
        {
            public int XD, YD;
            public Bitmap im;
            public int XS, YS;
        }
        public class actor
        {
            public int x, y, frame;
            public List<Bitmap> lim = new List<Bitmap>();
        }
        int ga=0, tttick = 0, l = 0, tttick2=0, tttick3 = 0,tttick7=0,tttick8=0, q = 0, ct = 0, w = 0,p=0,y=0,level=0,l3=0,tttick4=0,h=0,ct2=0,killbegg=0,killsegg=0,c=0,st=1,sec=0,sec1=0,l5=0,l6=0,tttick10=0,pq=0;
        actor goral, skalla, skalla2, pnn, skalla3, climb, skalla4, climb2, human, bullet2,bullett3,gate,enime,begg,bk;
        actor b1, b2, b3, b4, b5,b6,b7,b8,b10;
        actor s1, s2, s3, s4;
        actor eni;
        CACtor pnn1, pnn2;
        List<actor> bad = new List<actor>();
        List<actor> bullett = new List<actor>();
        List<actor> bullett2 = new List<actor>();
        List<actor> bullett5 = new List<actor>();
        List<actor> bullett10 = new List<actor>();
        List<actor> beggg = new List<actor>();
        List<actor> seggg = new List<actor>();
        List<actor> herob1 = new List<actor>();
        List<actor> herob2 = new List<actor>();
        List<actor> herob3 = new List<actor>();
        List<actor> herob4 = new List<actor>();
        List<actor> herob5 = new List<actor>();
        List<actor> herob6 = new List<actor>();
        List<actor> herob7 = new List<actor>();
        List<actor> herob8 = new List<actor>();
        List<actor> ss1 = new List<actor>();
        List<actor> ss2 = new List<actor>();
        List<actor> ss3 = new List<actor>();
        List<actor> ss4 = new List<actor>();
        List<CACtor> LActs = new List<CACtor>();
        List<CACtor> LActs1 = new List<CACtor>();

        float ratio = 0.1f;
        Bitmap off,off2,off3;

        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Paint += Form1_Paint;
            tt.Tick += Tt_Tick;
            tt.Start();
            this.Load += Form1_Load;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Graphics g = CreateGraphics();
            if (level == 0)
            {
                if (w == 0)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Up:
                            if (human.y - 5 < 600 && human.y - 5 > 350 && human.x >= 0 && human.x <= 40)
                            {
                                human.y -= 5;
                            }
                            else if (human.y - 5 < 400 && human.y - 5 > 150 && human.x >= 1460 && human.x <= 1500)
                            {
                                human.y -= 5;
                            }
                            break;
                        case Keys.Down:
                            if (human.y + 5 < 650 && human.y + 5 > 350 && human.x >= 0 && human.x <= 40)
                            {
                                human.y += 5;
                            }
                            else if (human.y + 5 < 450 && human.y + 5 > 150 && human.x >= 1460 && human.x <= 1500)
                            {
                                human.y += 5;
                            }
                            break;
                        case Keys.Right:
                            check();
                            p = 1;
                            if (human.y >= 100 && human.y <= 250)
                            {
                                human.y = 150;
                                if (human.frame == 4)
                                {
                                    human.frame = 2;
                                }
                                else
                                {
                                    human.frame = 4;
                                }
                            }
                            else if (human.y >= 300 && human.y < 450)
                            {
                                human.y = 350;
                                if (human.frame == 4)
                                {
                                    human.frame = 2;
                                }
                                else
                                {
                                    human.frame = 4;
                                }
                            }
                            else if (human.y >= 500 && human.y <= 650)
                            {
                                human.y = 550;
                                if (human.frame == 4)
                                {
                                    human.frame = 2;
                                }
                                else
                                {
                                    human.frame = 4;
                                }
                            }
                            human.x += 10;
                            break;
                        case Keys.Left:
                            check();
                            p = 0;
                            if (human.y >= 100 && human.y <= 250)
                            {

                                human.y = 150;
                            }
                            else if (human.y >= 300 && human.y <= 450)
                            {
                                human.y = 350;
                            }
                            else if (human.y >= 500 && human.y <= 650)
                            {
                                human.y = 550;
                            }
                            ///////////////////////////////////////////////////////
                            human.x -= 10;
                            if (human.frame == 1)
                            {
                                human.frame = 0;
                            }
                            else
                            {

                                human.frame = 1;
                            }
                            break;
                        case Keys.Space:
                            check();
                            if (q == 0)
                            {
                                human.y -= 25;
                                q = 1;
                            }
                            else if (q == 1)
                            {
                                human.y += 25;
                                q = 0;
                            }
                            break;
                        case Keys.X:
                            if (p == 0)
                            {
                                createbullet2();
                            }
                            if (p == 1)
                            {
                                createbullet3();
                            }
                            break;
                        case Keys.Z:
                            createbulletup();
                            break;
                    }
                }
            }
            if (level == 2 && c==0)
            {
                
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        if (human.y == 150 && human.x >= 0 && human.x <= 80)
                        {
                            human.x = 750;
                            human.y = 700;
                        }
                        human.y -= 10;
                        break;
                    case Keys.Down:
                        if (human.y == 150 && human.x >= 0 && human.x <= 80)
                        {
                            human.x = 750;
                            human.y = 700;
                        }
                        human.y += 10;
                        break;
                    case Keys.Right:
                        if (human.y == 150 && human.x >= 0 && human.x <= 80)
                        {
                            human.x = 750;
                            human.y = 700;
                        }
                        human.x += 10;
                        if (human.frame == 4)
                        {
                            human.frame = 2;
                        }
                        else
                        {
                            human.frame = 4;
                        }
                        break;
                    case Keys.Left:
                        if (human.y == 150 && human.x >= 0 && human.x <= 80)
                        {
                            human.x = 750;
                            human.y = 700;
                        }
                        human.x -= 10;
                        if (human.frame == 1)
                        {
                            human.frame = 0;
                        }
                        else
                        {

                            human.frame = 1;
                        }
                        break;
                    case Keys.X:
                        if (human.y == 150 && human.x >= 0 && human.x <= 80)
                        {
                            human.x = 750;
                            human.y = 700;
                        }
                        createblevel2();
                        human.frame = 5;
                        break;
                }
            }
        }

        void createblevel2()
        {
            b1 = new actor();
            b1.x = human.x;
            b1.y = human.y;
            Bitmap img;
            img = new Bitmap("6.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            b1.lim.Add(img);
            herob1.Add(b1);
            ///////////////////////////
            b2 = new actor();
            b2.x = human.x;
            b2.y = human.y;
            Bitmap img2;
            img2 = new Bitmap("6.bmp");
            img2.MakeTransparent(img2.GetPixel(0, 0));
            b2.lim.Add(img2);
            herob2.Add(b2);
            /////////////////////////////////
            b3 = new actor();
            b3.x = human.x;
            b3.y = human.y;
            Bitmap img3;
            img3 = new Bitmap("6.bmp");
            img3.MakeTransparent(img3.GetPixel(0, 0));
            b3.lim.Add(img3);
            herob3.Add(b3);
            ///////////////////////////////////
            b4 = new actor();
            b4.x = human.x;
            b4.y = human.y;
            Bitmap img4;
            img4 = new Bitmap("6.bmp");
            img4.MakeTransparent(img4.GetPixel(0, 0));
            b4.lim.Add(img4);
            herob4.Add(b4);
            /////////////////////////////////////
            b5 = new actor();
            b5.x = human.x;
            b5.y = human.y;
            Bitmap img5;
            img5 = new Bitmap("6.bmp");
            img5.MakeTransparent(img5.GetPixel(0, 0));
            b5.lim.Add(img5);
            herob5.Add(b5);
            ////////////////////////////////
            b6 = new actor();
            b6.x = human.x;
            b6.y = human.y;
            Bitmap img6;
            img6 = new Bitmap("6.bmp");
            img6.MakeTransparent(img6.GetPixel(0, 0));
            b6.lim.Add(img6);
            herob6.Add(b6);
            ////////////////////////////////////////
            b7 = new actor();
            b7.x = human.x;
            b7.y = human.y;
            Bitmap img7;
            img7 = new Bitmap("6.bmp");
            img7.MakeTransparent(img7.GetPixel(0, 0));
            b7.lim.Add(img7);
            herob7.Add(b7);
            ////////////////////////////////////////
            b8 = new actor();
            b8.x = human.x;
            b8.y = human.y;
            Bitmap img8;
            img8 = new Bitmap("6.bmp");
            img8.MakeTransparent(img8.GetPixel(0, 0));
            b8.lim.Add(img8);
            herob8.Add(b8);
            ////////////////////////////////////////
        }
        void movebullet()
        {
            for (int i = 0; i < bad.Count; i++)
            {
                if (bad[i].y == 170)
                {
                    if (bad[i].x == 1500)
                    {
                        bad[i].y += 10;

                    }
                    else
                        bad[i].x +=10;
                }
                else if (bad[i].y == 370)
                {
                    if (bad[i].x == 0)
                    {
                        bad[i].y += 10;
                    }
                    else
                        bad[i].x -= 10;

                }
                else if (bad[i].y == 570)
                {
                    bad[i].x += 10;
                }

                else
                    bad[i].y += 10;

                //////////////////////////////////////////////


            }
        }
        void movebullet2()
        { 
            for (int i = 0; i < bullett.Count; i++)
            {
                bullett[i].x -= 20;
            }
        }
        void movebullet3()
        {
            for (int i = 0; i < bullett2.Count; i++)
            {
                bullett2[i].x += 20;
            }
        }
        void movebullet5()
        {
            for (int i = 0; i < bullett5.Count; i++)
            {
                bullett5[i].y -= 20;
            }
        }
        void moveherob1()
        {
            for(int i=0;i<herob1.Count;i++)
            {
                herob1[i].x += 15;
            }
        }
        void moveherob2()
        {
            for (int i = 0; i < herob2.Count; i++)
            {
                herob2[i].x -= 15;
            }
        }
        void moveherob3()
        {
            for (int i = 0; i < herob3.Count; i++)
            {
                herob3[i].y += 15;
                herob3[i].x += 15;
            }
        }
        void moveherob4()
        {
            for (int i = 0; i < herob4.Count; i++)
            {
                herob4[i].y -= 15;
                herob4[i].x -= 15;
            }
        }
        void moveherob5()
        {
            for (int i = 0; i < herob5.Count; i++)
            {
                herob5[i].y += 15;
                herob5[i].x -= 15;
            }
        }
        void moveherob6()
        {
            for (int i = 0; i < herob6.Count; i++)
            {
                herob6[i].y -= 15;
                herob6[i].x += 15;
            }
        }
        void moveherob7()
        {
            for (int i = 0; i < herob7.Count; i++)
            {
                herob7[i].y -=15;
            }
        }
        void moveherob8()
        {
            for (int i = 0; i < herob8.Count; i++)
            {
                herob8[i].y += 15;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
           // background();
            //////////////////////////////////
            off2 = new Bitmap(ClientSize.Width, ClientSize.Height);

            pnn1 = new CACtor();
            pnn1.XD = 600;
            pnn1.YD = 300;
            pnn1.XS = 0;
            pnn1.YS = 0;
            pnn1.im = new Bitmap("gameover.bmp");
            LActs.Add(pnn1);
            ////////////////////////////////////////////
            off3 = new Bitmap(ClientSize.Width, ClientSize.Height);

            pnn2 = new CACtor();
            pnn2.XD = 600;
            pnn2.YD = 300;
            pnn2.XS = 0;
            pnn2.YS = 0;
            pnn2.im = new Bitmap("victory.bmp");
            pnn2.im.MakeTransparent(pnn2.im.GetPixel(0, 0));
            LActs1.Add(pnn2);
            ///////////////////////////////////////////////////////
            eni = new actor();
            eni.x = 10;
            eni.y = 365;
            Bitmap img50;
            img50 = new Bitmap("s1.bmp");
            img50.MakeTransparent(img50.GetPixel(0, 0));
            eni.lim.Add(img50);
            Bitmap img51;
            img51 = new Bitmap("s2.bmp");
            img51.MakeTransparent(img51.GetPixel(0, 0));
            eni.lim.Add(img51);
            Bitmap img52;
            img52 = new Bitmap("s3.bmp");
            img52.MakeTransparent(img52.GetPixel(0, 0));
            eni.lim.Add(img52);
            Bitmap img53;
            img53 = new Bitmap("s4.bmp");
            img53.MakeTransparent(img53.GetPixel(0, 0));
            eni.lim.Add(img53);
            Bitmap img54;
            img54 = new Bitmap("s5.bmp");
            img54.MakeTransparent(img54.GetPixel(0, 0));
            eni.lim.Add(img54);
            Bitmap img55;
            img55 = new Bitmap("s6.bmp");
            img55.MakeTransparent(img55.GetPixel(0, 0));
            eni.lim.Add(img55);
            eni.frame = 0;
            g.DrawImage(eni.lim[eni.frame], eni.x, eni.y);
            ////////////////////////////////////////////////////
            goral = new actor();
            goral.x = 10;
            goral.y = 0;
            Bitmap img;
            for (int i = 0; i < 5; i++)
            {
                img = new Bitmap(i + 1 + ".bmp");
                img.MakeTransparent(img.GetPixel(0, 0));
                goral.lim.Add(img);
            }
            goral.frame = 0;
            g.DrawImage(goral.lim[goral.frame], goral.x, goral.y);
            ////////////////////////////////////////////
            skalla = new actor();
            skalla.x = 0;
            skalla.y = 45;
            Bitmap img2;
            img2 = new Bitmap("skalla.bmp");
            img2.MakeTransparent(img2.GetPixel(0, 0));
            skalla.lim.Add(img2);
            /////////////////////////////////
            skalla2 = new actor();
            skalla2.x = 0;
            skalla2.y = 200;
            Bitmap img3;
            img3 = new Bitmap("8.bmp");
            img3.MakeTransparent(img3.GetPixel(0, 0));
            skalla2.lim.Add(img3);
            ////////////////////////////
            skalla3 = new actor();
            skalla3.x = 0;
            skalla3.y = 400;
            Bitmap img4;
            img4 = new Bitmap("8.bmp");
            img4.MakeTransparent(img4.GetPixel(0, 0));
            skalla3.lim.Add(img4);
            /////////////////////////////
            skalla4 = new actor();
            skalla4.x = 0;
            skalla4.y = 600;
            Bitmap img7;
            img7 = new Bitmap("8.bmp");
            img7.MakeTransparent(img7.GetPixel(0, 0));
            skalla4.lim.Add(img7);
            //////////////////////////////
            climb = new actor();
            climb.x = 1500;
            climb.y = 200;
            Bitmap img5;
            img5 = new Bitmap("10.bmp");
            img5.MakeTransparent(img5.GetPixel(0, 0));
            climb.lim.Add(img5);
            /////////////////////////////////
            climb2 = new actor();
            climb2.x = 0;
            climb2.y = 400;
            Bitmap img8;
            img8 = new Bitmap("10.bmp");
            img8.MakeTransparent(img8.GetPixel(0, 0));
            climb2.lim.Add(img8);
            ///////////////////////////////////
            
            human = new actor();
            human.x = 1500;
            human.y = 550;
            //human.y = 150;
            Bitmap img9;
            img9 = new Bitmap("c1flip.bmp");//0//left
            img9.MakeTransparent(img9.GetPixel(0, 0));
            human.lim.Add(img9);
            img9 = new Bitmap("c2flip.bmp");//1//left
            img9.MakeTransparent(img9.GetPixel(0, 0));
            human.lim.Add(img9);
            img9 = new Bitmap("c1.bmp");//2//right
            img9.MakeTransparent(img9.GetPixel(0, 0));
            human.lim.Add(img9);
            img9 = new Bitmap("c3.bmp");//3//dead
            img9.MakeTransparent(img9.GetPixel(0, 0));
            human.lim.Add(img9);
            img9 = new Bitmap("c2.bmp");//4//right
            img9.MakeTransparent(img9.GetPixel(0, 0));
            human.lim.Add(img9);
            img9 = new Bitmap("c100.bmp");//5//multi
            img9.MakeTransparent(img9.GetPixel(0, 0));
            human.lim.Add(img9);
            human.frame = 0;
            //////////////////////////////
            gate = new actor();
            gate.x = 0;
            gate.y = 80;
            Bitmap img10;
            img10 = new Bitmap("index.bmp");
            img10.MakeTransparent(img10.GetPixel(0, 0));
            gate.lim.Add(img10);
            //////////////////////////////////
            enime = new actor();
            enime.x = 0;
            enime.y = -70;
            Bitmap img11;
            img11 = new Bitmap("bad.bmp");
            img11.MakeTransparent(img11.GetPixel(0, 0));
            enime.lim.Add(img11);
            Bitmap img12;
            img12 = new Bitmap("bad1.bmp");
            img12.MakeTransparent(img12.GetPixel(0, 0));
            enime.lim.Add(img12);
            /////////////////////////////////////

            //////////////////////////////////////
            //   bad = new actor();
            //   bad.x = 0;
            //   bad.y = 10;
            //   Bitmap img4;
            //   img4 = new Bitmap("images.bmp");
            //   img4.MakeTransparent(img4.GetPixel(0, 0));
            //   bad.lim.Add(img4);
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            drawdubb(g);
        }
        void createbullet()
        {
            Graphics g = CreateGraphics();
            pnn = new actor();
            pnn.x = goral.x;
            pnn.y = goral.y;
            Bitmap img;
            img = new Bitmap("bullet.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            pnn.lim.Add(img);
            bad.Add(pnn);

        }
        void createbullet2()
        {
            Graphics g = CreateGraphics();
            bullet2 = new actor();
            bullet2.x = human.x;
            bullet2.y = human.y + 20;
            Bitmap img;
            img = new Bitmap("6.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            bullet2.lim.Add(img);
            bullett.Add(bullet2);

        }
        void createbullet3()
        {
            Graphics g = CreateGraphics();
            bullet2 = new actor();
            bullet2.x = human.x+human.lim[0].Width;
            bullet2.y = human.y + 20;
            Bitmap img;
            img = new Bitmap("6.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            bullet2.lim.Add(img);
            bullett2.Add(bullet2);

        }
        void createbulletup()
        {
            Graphics g = CreateGraphics();
            bullett3 = new actor();
            bullett3.x = human.x + human.lim[0].Width/2;
            bullett3.y = human.y + 20;
            Bitmap img;
            img = new Bitmap("6.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            bullett3.lim.Add(img);
            bullett5.Add(bullett3);

        }
        void createbullet10()
        {
            Graphics g = CreateGraphics();
            b10 = new actor();
            b10.x = eni.x+eni.lim[0].Width;
            b10.y = eni.y;
            Bitmap img;
            img = new Bitmap("testflip.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            b10.lim.Add(img);
            bullett10.Add(b10);
        }
        void moveb10()
        {
            for (int i = 0; i < bullett10.Count; i++)
            {
                for (int k = 0; k < bullett10[i].lim.Count; k++)
                {
                    bullett10[i].x-= 10;
                }
            }
        }
        void check()
        {
            for (int i = 0; i < bad.Count; i++)
            {
                for (int k = 0; k < bad[i].lim.Count; k++)
                {
                    for (int m = 0; m < bullett.Count; m++)
                    {
                        for (int n = 0; n < bullett[m].lim.Count; n++)
                        {
                          // if (bad[i].x+bad[i].lim[k].Width==bullett[m].x && bad[i].y == bullett[m].y)//bad[i].x <= bullett[m].x && bad[i].x >= bullett[m].x + bullett[m].lim[k].Width && bad[i].y <= bullett[m].y && bad[i].y>=bullett[m].lim[n].Height
                          // {
                          //     bad[i].lim.Remove(bad[i].lim[k]);
                          //     bullett[m].lim.Remove(bullett[m].lim[n]);
                          //     MessageBox.Show("okai");
                          // }
                               
                           // if(bad[i].x <= bullett[m].x && bad[i].x+bad[i].lim[k].Width >= bullett[m].x)
                           
                            if(bullett[m].x>=bad[i].x-15 && bullett[m].x<=bad[i].x+15)
                               {
                                   if (bad[i].y == bullett[m].y)
                                   {
                                    if (bad[i].lim.Count !=0)
                                    {
                                        bad[i].lim.Remove(bad[i].lim[k]);
                                        bullett[m].lim.Remove(bullett[m].lim[n]);
                                    }
                                   // MessageBox.Show("okai");
                                }
                                   else if(bad[i].y>=380 && bad[i].y<=420)
                                   {
                                    if (bad[i].lim.Count != 0)
                                    {
                                        bad[i].lim.Remove(bad[i].lim[k]);
                                        bullett[m].lim.Remove(bullett[m].lim[n]);
                                    }
                                   // MessageBox.Show("okai");
                                }
                                   else if(bad[i].y>=580 && bad[i].y<=620)
                                   {
                                    if (bad[i].lim.Count != 0)
                                    {
                                        bad[i].lim.Remove(bad[i].lim[k]);
                                        bullett[m].lim.Remove(bullett[m].lim[n]);
                                    }
                                   // MessageBox.Show("okai");
                                }
                            
                               }
                        }
                    }
                }
            }
        }
        void check2()
        {
            for (int i = 0; i < bad.Count; i++)
            {
                for (int k = 0; k < bad[i].lim.Count; k++)
                {
                    for (int m = 0; m < bullett2.Count; m++)
                    {
                        for (int n = 0; n < bullett2[m].lim.Count; n++)
                        {
                            // if (bad[i].x+bad[i].lim[k].Width==bullett[m].x && bad[i].y == bullett[m].y)//bad[i].x <= bullett[m].x && bad[i].x >= bullett[m].x + bullett[m].lim[k].Width && bad[i].y <= bullett[m].y && bad[i].y>=bullett[m].lim[n].Height
                            // {
                            //     bad[i].lim.Remove(bad[i].lim[k]);
                            //     bullett[m].lim.Remove(bullett[m].lim[n]);
                            //     MessageBox.Show("okai");
                            // }

                            // if(bad[i].x <= bullett[m].x && bad[i].x+bad[i].lim[k].Width >= bullett[m].x)

                            if (bullett2[m].x >= bad[i].x-15 && bullett2[m].x <= bad[i].x + 15)
                            {
                                if (bad[i].y == bullett2[m].y)
                                {
                                    if (bad[i].lim.Count != 0)
                                    {
                                        bad[i].lim.Remove(bad[i].lim[k]);
                                        bullett2[m].lim.Remove(bullett2[m].lim[n]);
                                    }
                                    // MessageBox.Show("okai");
                                }
                                else if (bad[i].y >= 380 && bad[i].y <= 420)
                                {   
                                    if (bad[i].lim.Count != 0)
                                    {
                                        bad[i].lim.Remove(bad[i].lim[k]);
                                        bullett2[m].lim.Remove(bullett2[m].lim[n]);
                                    }
                                    // MessageBox.Show("okai");
                                }
                                else if (bad[i].y >= 580 && bad[i].y <= 620)
                                {
                                    if (bad[i].lim.Count != 0)
                                    {
                                        bad[i].lim.Remove(bad[i].lim[k]);
                                        bullett2[m].lim.Remove(bullett2[m].lim[n]);
                                    }
                                    // MessageBox.Show("okai");
                                }

                            }
                        }
                    }
                }
            }
        }
        void check3()
        {
            for (int i = 0; i < bad.Count; i++)
            {
                for (int k = 0; k < bad[i].lim.Count; k++)
                {
                    for (int m = 0; m < bullett5.Count; m++)
                    {
                        for (int n = 0; n < bullett5[m].lim.Count; n++)
                        {
                            // if (bad[i].x+bad[i].lim[k].Width==bullett[m].x && bad[i].y == bullett[m].y)//bad[i].x <= bullett[m].x && bad[i].x >= bullett[m].x + bullett[m].lim[k].Width && bad[i].y <= bullett[m].y && bad[i].y>=bullett[m].lim[n].Height
                            // {
                            //     bad[i].lim.Remove(bad[i].lim[k]);
                            //     bullett[m].lim.Remove(bullett[m].lim[n]);
                            //     MessageBox.Show("okai");
                            // }

                            // if(bad[i].x <= bullett[m].x && bad[i].x+bad[i].lim[k].Width >= bullett[m].x)

                            if (bullett5[m].x >= bad[i].x-15 && bullett5[m].x <= bad[i].x + 15)
                            {
                                if (bad[i].y == bullett5[m].y)
                                {
                                    if (bad[i].lim.Count != 0)
                                    {
                                        bad[i].lim.Remove(bad[i].lim[k]);
                                        bullett5[m].lim.Remove(bullett5[m].lim[n]);
                                    }
                                    // MessageBox.Show("okai");
                                }
                                else if (bad[i].y >= 380 && bad[i].y <= 420)
                                {
                                    if (bad[i].lim.Count != 0)
                                    {
                                        bad[i].lim.Remove(bad[i].lim[k]);
                                        bullett5[m].lim.Remove(bullett5[m].lim[n]);
                                    }
                                    // MessageBox.Show("okai");
                                }
                                else if (bad[i].y >= 580 && bad[i].y <= 620)
                                {
                                    if (bad[i].lim.Count != 0)
                                    {
                                        bad[i].lim.Remove(bad[i].lim[k]);
                                        bullett5[m].lim.Remove(bullett5[m].lim[n]);
                                    }
                                    // MessageBox.Show("okai");
                                }

                            }
                        }
                    }
                }
            }
        }

        void kill()
        {
            for (int i = 0; i < bad.Count; i++)
            {
                for (int k = 0; k < bad[i].lim.Count; k++)
                {
                    if (human.x <= bad[i].x && human.x + human.lim[0].Width >= bad[i].x && human.y == bad[i].y - 20)
                    {
                        ct++;
                        bad[i].lim.Remove(bad[i].lim[k]);
                        if (ct == 3)
                        {
                            //  b++;
                            human.frame = 3;
                            if (human.y == 150)
                            {
                                human.y = 175;
                            }
                            else if (human.y == 350)
                            {
                                human.y = 375;
                            }
                            else if (human.y == 550)
                            {
                                human.y = 575;
                            }
                            w = 1;
                        }
                    }

                }
            }
            ///////////////////////////////////////
            for (int i = 0; i < bullett10.Count; i++)
            {
                for (int k = 0; k < bullett10[i].lim.Count; k++)
                {
                    if (human.x <= bullett10[i].x && human.x + human.lim[0].Width >= bullett10[i].x && human.y == bullett10[i].y - 20)
                    {
                        ct++;
                        bullett10[i].lim.Remove(bullett10[i].lim[k]);
                        if (ct == 3)
                        {
                            //  b++;
                            human.frame = 3;
                            if (human.y == 350)
                            {
                                human.y = 375;
                            }
                            w = 1;
                        }
                    }
                }
            }
            ///////////////////////////////////////
        }
        void killsk()
        {
            for (int i = 0; i < bullett.Count; i++)
            {
                for (int k = 0; k < bullett[i].lim.Count; k++)
                {
                      if (eni.x == bullett[i].x && human.y==350)
                      {
                          bullett[i].lim.Remove(bullett[i].lim[k]);
                          MessageBox.Show("first");
                          eni.frame = 4;
                          tttick7 = 10;
                          ga = 1;
                      }
                }
            }
        }

        void killhuman()
        {
            for (int i = 0; i < beggg.Count; i++)
            {
                for (int k = 0; k < beggg[i].lim.Count; k++)
                {
                    if (human.x <= beggg[i].x && human.x + human.lim[0].Width >= beggg[i].x && human.y == beggg[i].y - 20)
                    {
                        killbegg = 1;
                        beggg[i].lim.Remove(beggg[i].lim[k]);
                        if (killbegg == 1)
                        {
                            c = 1;
                            human.frame = 3;
                        }
                    }

                }
            }
            for (int i = 0; i < ss1.Count; i++)
            {
                for (int k = 0; k < ss1[i].lim.Count; k++)
                {
                    if (human.x <= ss1[i].x && human.x + human.lim[0].Width >= ss1[i].x && human.y == ss1[i].y - 20)
                    {
                        killsegg++;
                        ss1[i].lim.Remove(ss1[i].lim[k]);
                        if (killsegg >= 3)
                        {
                            c = 1;
                            human.frame = 3;
                        }
                    }

                }
            }
            ///////////////////////////////////////////////////////////
            for (int i = 0; i < ss2.Count; i++)
            {
                for (int k = 0; k < ss2[i].lim.Count; k++)
                {
                    if (human.x <= ss2[i].x && human.x + human.lim[0].Width >= ss2[i].x && human.y == ss2[i].y - 20)
                    {
                        killsegg++;
                        ss2[i].lim.Remove(ss2[i].lim[k]);
                        if (killsegg >= 3)
                        {
                            c = 1;
                            human.frame = 3;
                        }
                    }

                }
            }
            ////////////////////////////////////////////////////
            for (int i = 0; i < ss3.Count; i++)
            {
                for (int k = 0; k < ss3[i].lim.Count; k++)
                {
                    if (human.x <= ss3[i].x && human.x + human.lim[0].Width >= ss3[i].x && human.y == ss3[i].y - 20)
                    {
                        killsegg++;
                        ss3[i].lim.Remove(ss3[i].lim[k]);
                        if (killsegg >= 3)
                        {
                            c = 1;
                            human.frame = 3;
                        }
                    }

                }
            }
            //////////////////////////////////////////////////////
            for (int i = 0; i < ss4.Count; i++)
            {
                for (int k = 0; k < ss4[i].lim.Count; k++)
                {
                    if (human.x <= ss4[i].x && human.x + human.lim[0].Width >= ss4[i].x && human.y == ss4[i].y - 20)
                    {
                        killsegg++;
                        ss4[i].lim.Remove(ss4[i].lim[k]);
                        if (killsegg >= 3)
                        {
                            c = 1;
                            human.frame = 3;
                        }
                    }

                }
            }
            ///////////////////////////////////////
            ///

        }
        void killg()
        {
            for (int i = 0; i < bullett5.Count; i++)
            {
                for (int k = 0; k < bullett5[i].lim.Count; k++)
                {
                    if (goral.x <= bullett5[i].x && goral.x + goral.lim[0].Width >= bullett5[i].x && goral.y >= bullett5[i].y && goral.y<= bullett5[i].y+10)
                    {
                        ct++;
                        bullett5[i].lim.Remove(bullett5[i].lim[k]);
                        //MessageBox.Show("first");
                        if (ct == 3)
                        {
                            //  b++;
                            goral.frame = 4;
                            y = 1;
                        }
                    }

                }
            }
        }
        void killenimeb1()
        {
            for (int i = 0; i < herob1.Count; i++)
            {
                for (int k = 0; k < herob1[i].lim.Count; k++)
                {
                    if (enime.x <= herob1[i].x && enime.x + enime.lim[0].Width >= herob1[i].x && enime.y <= herob1[i].y && enime.y+enime.lim[0].Height/2 >= herob1[i].y)
                    {
                        if (ct2 == 20)
                        {
                            //  b++;
                            h = 1;
                            enime.frame = 1;
                            enime.y = 0;

                        }
                        ct2++;
                        herob1[i].lim.Remove(herob1[i].lim[k]);
                       // MessageBox.Show("1");
                    }

                }
            }
            for (int i = 0; i < herob1.Count; i++)
            {
                for (int k = 0; k < herob1[i].lim.Count; k++)
                {
                    for(int m=0;m<beggg.Count;m++)
                    {
                        for(int n=0;n<beggg[m].lim.Count;n++)
                        {
                            if (beggg[m].x <= herob1[i].x && beggg[m].x + beggg[m].lim[n].Width >= herob1[i].x && beggg[m].y <= herob1[i].y && beggg[m].y + beggg[m].lim[n].Height >= herob1[i].y)
                            {
                                createsegg(m,n);
                                if (herob1[i].lim.Count != 0)
                                {
                                    herob1[i].lim.Remove(herob1[i].lim[k]);
                                }
                                beggg[m].lim.Remove(beggg[m].lim[n]);
                               // MessageBox.Show("1");
                            }
                        }
                    }
                }
            }
            ///////////////////////////////////////////////////////////////////
            for (int i = 0; i < herob1.Count; i++)
            {
                for (int k = 0; k < herob1[i].lim.Count; k++)
                {
                    for (int m = 0; m < ss1.Count; m++)
                    {
                        for (int n = 0; n < ss1[m].lim.Count; n++)
                        {
                            if (ss1[m].x <= herob1[i].x && ss1[m].x + ss1[m].lim[n].Width >= herob1[i].x && ss1[m].y <= herob1[i].y && ss1[m].y + ss1[m].lim[n].Height >= herob1[i].y)
                            {
                                herob1[i].lim.Remove(herob1[i].lim[k]);
                                ss1[m].lim.Remove(ss1[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    ///////////////////////////////////////////////
                    for (int m = 0; m < ss2.Count; m++)
                    {
                        for (int n = 0; n < ss2[m].lim.Count; n++)
                        {
                            if (ss2[m].x <= herob1[i].x && ss2[m].x + ss2[m].lim[n].Width >= herob1[i].x && ss2[m].y <= herob1[i].y && ss2[m].y + ss2[m].lim[n].Height >= herob1[i].y)
                            {
                                herob1[i].lim.Remove(herob1[i].lim[k]);
                                ss2[m].lim.Remove(ss2[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    /////////////////////////////////////////////////
                    for (int m = 0; m < ss3.Count; m++)
                    {
                        for (int n = 0; n < ss3[m].lim.Count; n++)
                        {
                            if (ss3[m].x <= herob1[i].x && ss3[m].x + ss3[m].lim[n].Width >= herob1[i].x && ss3[m].y <= herob1[i].y && ss3[m].y + ss3[m].lim[n].Height >= herob1[i].y)
                            {
                                herob1[i].lim.Remove(herob1[i].lim[k]);
                                ss3[m].lim.Remove(ss3[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    ////////////////////////////////////////////
                    for (int m = 0; m < ss4.Count; m++)
                    {
                        for (int n = 0; n < ss4[m].lim.Count; n++)
                        {
                            if (ss4[m].x <= herob1[i].x && ss4[m].x + ss4[m].lim[n].Width >= herob1[i].x && ss4[m].y <= herob1[i].y && ss4[m].y + ss4[m].lim[n].Height >= herob1[i].y)
                            {
                                herob1[i].lim.Remove(herob1[i].lim[k]);
                                ss4[m].lim.Remove(ss4[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    ///////////////////////////////////////////////////////
                }
            }
        }
        void killenimeb2()
        {
            for (int i = 0; i < herob2.Count; i++)
            {
                for (int k = 0; k < herob2[i].lim.Count; k++)
                {
                    if (enime.x <= herob2[i].x && enime.x + enime.lim[0].Width >= herob2[i].x && enime.y <= herob2[i].y && enime.y + enime.lim[0].Width/2 >= herob2[i].y)
                    {
                        if (ct2 == 20)
                        {
                            //  b++;
                            h = 1;
                            enime.frame = 1;
                            enime.y = 0;

                        }
                        ct2++;
                        herob2[i].lim.Remove(herob2[i].lim[k]);
                       // MessageBox.Show("2");

                    }

                }
            }
            for (int i = 0; i < herob2.Count; i++)
            {
                for (int k = 0; k < herob2[i].lim.Count; k++)
                {
                    for (int m = 0; m < beggg.Count; m++)
                    {
                        for (int n = 0; n < beggg[m].lim.Count; n++)
                        {
                            if (beggg[m].x <= herob2[i].x && beggg[m].x + beggg[m].lim[n].Width >= herob2[i].x && beggg[m].y <= herob2[i].y && beggg[m].y + beggg[m].lim[n].Height >= herob2[i].y)
                            {
                                createsegg(m,n);
                                if (herob2[i].lim.Count != 0)
                                {
                                    herob2[i].lim.Remove(herob2[i].lim[k]);
                                }
                                beggg[m].lim.Remove(beggg[m].lim[n]);

                                //MessageBox.Show("2");
                            }
                        }
                    }
                }
            }
            ///////////////////////////////////////////////////////////////////
            for (int i = 0; i < herob2.Count; i++)
            {
                for (int k = 0; k < herob2[i].lim.Count; k++)
                {
                    for (int m = 0; m < ss1.Count; m++)
                    {
                        for (int n = 0; n < ss1[m].lim.Count; n++)
                        {
                            if (ss1[m].x <= herob2[i].x && ss1[m].x + ss1[m].lim[n].Width >= herob2[i].x && ss1[m].y <= herob2[i].y && ss1[m].y + ss1[m].lim[n].Height >= herob2[i].y)
                            {
                                herob2[i].lim.Remove(herob2[i].lim[k]);
                                ss1[m].lim.Remove(ss1[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    ///////////////////////////////////////////////
                    for (int m = 0; m < ss2.Count; m++)
                    {
                        for (int n = 0; n < ss2[m].lim.Count; n++)
                        {
                            if (ss2[m].x <= herob2[i].x && ss2[m].x + ss2[m].lim[n].Width >= herob2[i].x && ss2[m].y <= herob2[i].y && ss2[m].y + ss2[m].lim[n].Height >= herob2[i].y)
                            {
                                herob2[i].lim.Remove(herob2[i].lim[k]);
                                ss2[m].lim.Remove(ss2[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    /////////////////////////////////////////////////
                    for (int m = 0; m < ss3.Count; m++)
                    {
                        for (int n = 0; n < ss3[m].lim.Count; n++)
                        {
                            if (ss3[m].x <= herob2[i].x && ss3[m].x + ss3[m].lim[n].Width >= herob2[i].x && ss3[m].y <= herob2[i].y && ss3[m].y + ss3[m].lim[n].Height >= herob2[i].y)
                            {
                                herob2[i].lim.Remove(herob2[i].lim[k]);
                                ss3[m].lim.Remove(ss3[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    ////////////////////////////////////////////
                    for (int m = 0; m < ss4.Count; m++)
                    {
                        for (int n = 0; n < ss4[m].lim.Count; n++)
                        {
                            if (ss4[m].x <= herob2[i].x && ss4[m].x + ss4[m].lim[n].Width >= herob2[i].x && ss4[m].y <= herob2[i].y && ss4[m].y + ss4[m].lim[n].Height >= herob2[i].y)
                            {
                                herob2[i].lim.Remove(herob2[i].lim[k]);
                                ss4[m].lim.Remove(ss4[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    ///////////////////////////////////////////////////////
                }
            }
        }
        void killenimeb3()
        {
            for (int i = 0; i < herob3.Count; i++)
            {
                for (int k = 0; k < herob3[i].lim.Count; k++)
                {
                    if (enime.x <= herob3[i].x && enime.x + enime.lim[0].Width >= herob3[i].x && enime.y <= herob3[i].y && enime.y + enime.lim[0].Width/2 >= herob3[i].y)
                    {
                        if (ct2 == 20)
                        {
                            //  b++;
                            h = 1;
                            enime.frame = 1;
                            enime.y = 0;

                        }
                        ct2++;
                        herob3[i].lim.Remove(herob3[i].lim[k]);
                        //MessageBox.Show("3");

                    }

                }
            }
            for (int i = 0; i < herob3.Count; i++)
            {
                for (int k = 0; k < herob3[i].lim.Count; k++)
                {
                    for (int m = 0; m < beggg.Count; m++)
                    {
                        for (int n = 0; n < beggg[m].lim.Count; n++)
                        {
                            if (beggg[m].x <= herob3[i].x && beggg[m].x + beggg[m].lim[n].Width >= herob3[i].x && beggg[m].y <= herob3[i].y && beggg[m].y + beggg[m].lim[n].Height >= herob3[i].y)
                            {
                                createsegg(m,n);
                                if (herob3[i].lim.Count != 0)
                                {
                                    herob3[i].lim.Remove(herob3[i].lim[k]);
                                }
                                beggg[m].lim.Remove(beggg[m].lim[n]);

                               // MessageBox.Show("3");
                            }
                        }
                    }
                }
            }
            ///////////////////////////////////////////////////////////////////
            for (int i = 0; i < herob3.Count; i++)
            {
                for (int k = 0; k < herob3[i].lim.Count; k++)
                {
                    for (int m = 0; m < ss1.Count; m++)
                    {
                        for (int n = 0; n < ss1[m].lim.Count; n++)
                        {
                            if (ss1[m].x <= herob3[i].x && ss1[m].x + ss1[m].lim[n].Width >= herob3[i].x && ss1[m].y <= herob3[i].y && ss1[m].y + ss1[m].lim[n].Height >= herob3[i].y)
                            {
                                herob3[i].lim.Remove(herob3[i].lim[k]);
                                ss1[m].lim.Remove(ss1[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    ///////////////////////////////////////////////
                    for (int m = 0; m < ss2.Count; m++)
                    {
                        for (int n = 0; n < ss2[m].lim.Count; n++)
                        {
                            if (ss2[m].x <= herob3[i].x && ss2[m].x + ss2[m].lim[n].Width >= herob3[i].x && ss2[m].y <= herob3[i].y && ss2[m].y + ss2[m].lim[n].Height >= herob3[i].y)
                            {
                                herob3[i].lim.Remove(herob3[i].lim[k]);
                                ss2[m].lim.Remove(ss2[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    /////////////////////////////////////////////////
                    for (int m = 0; m < ss3.Count; m++)
                    {
                        for (int n = 0; n < ss3[m].lim.Count; n++)
                        {
                            if (ss3[m].x <= herob3[i].x && ss3[m].x + ss3[m].lim[n].Width >= herob3[i].x && ss3[m].y <= herob3[i].y && ss3[m].y + ss3[m].lim[n].Height >= herob3[i].y)
                            {
                                herob3[i].lim.Remove(herob3[i].lim[k]);
                                ss3[m].lim.Remove(ss3[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    ////////////////////////////////////////////
                    for (int m = 0; m < ss4.Count; m++)
                    {
                        for (int n = 0; n < ss4[m].lim.Count; n++)
                        {
                            if (ss4[m].x <= herob3[i].x && ss4[m].x + ss4[m].lim[n].Width >= herob3[i].x && ss4[m].y <= herob3[i].y && ss4[m].y + ss4[m].lim[n].Height >= herob3[i].y)
                            {
                                herob3[i].lim.Remove(herob3[i].lim[k]);
                                ss4[m].lim.Remove(ss4[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    ///////////////////////////////////////////////////////
                }
            }
        }
        void killenimeb4()
        {
            for (int i = 0; i < herob4.Count; i++)
            {
                for (int k = 0; k < herob4[i].lim.Count; k++)
                {
                    if (enime.x <= herob4[i].x && enime.x + enime.lim[0].Width >= herob4[i].x && enime.y <= herob4[i].y && enime.y + enime.lim[0].Width/2 >= herob4[i].y)
                    {
                        if (ct2 == 20)
                        {
                            //  b++;
                            h = 1;
                            enime.frame = 1;
                            enime.y = 0;

                        }
                        ct2++;
                        herob4[i].lim.Remove(herob4[i].lim[k]);
                       // MessageBox.Show("4");

                    }

                }
            }
            for (int i = 0; i < herob4.Count; i++)
            {
                for (int k = 0; k < herob4[i].lim.Count; k++)
                {
                    for (int m = 0; m < beggg.Count; m++)
                    {
                        for (int n = 0; n < beggg[m].lim.Count; n++)
                        {
                            if (beggg[m].x <= herob4[i].x && beggg[m].x + beggg[m].lim[n].Width >= herob4[i].x && beggg[m].y <= herob4[i].y && beggg[m].y + beggg[m].lim[n].Height >= herob4[i].y)
                            {
                                createsegg(m,n);
                                if (herob4[i].lim.Count != 0)
                                {
                                    herob4[i].lim.Remove(herob4[i].lim[k]);
                                }
                                beggg[m].lim.Remove(beggg[m].lim[n]);

                              //  MessageBox.Show("4");
                            }
                        }
                    }
                }
            }
            ///////////////////////////////////////////////////////////////////
            for (int i = 0; i < herob4.Count; i++)
            {
                for (int k = 0; k < herob4[i].lim.Count; k++)
                {
                    for (int m = 0; m < ss1.Count; m++)
                    {
                        for (int n = 0; n < ss1[m].lim.Count; n++)
                        {
                            if (ss1[m].x <= herob4[i].x && ss1[m].x + ss1[m].lim[n].Width >= herob4[i].x && ss1[m].y <= herob4[i].y && ss1[m].y + ss1[m].lim[n].Height >= herob4[i].y)
                            {
                                herob4[i].lim.Remove(herob4[i].lim[k]);
                                ss1[m].lim.Remove(ss1[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    ///////////////////////////////////////////////
                    for (int m = 0; m < ss2.Count; m++)
                    {
                        for (int n = 0; n < ss2[m].lim.Count; n++)
                        {
                            if (ss2[m].x <= herob4[i].x && ss2[m].x + ss2[m].lim[n].Width >= herob4[i].x && ss2[m].y <= herob4[i].y && ss2[m].y + ss2[m].lim[n].Height >= herob4[i].y)
                            {
                                herob4[i].lim.Remove(herob4[i].lim[k]);
                                ss2[m].lim.Remove(ss2[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    /////////////////////////////////////////////////
                    for (int m = 0; m < ss3.Count; m++)
                    {
                        for (int n = 0; n < ss3[m].lim.Count; n++)
                        {
                            if (ss3[m].x <= herob4[i].x && ss3[m].x + ss3[m].lim[n].Width >= herob4[i].x && ss3[m].y <= herob4[i].y && ss3[m].y + ss3[m].lim[n].Height >= herob4[i].y)
                            {
                                herob4[i].lim.Remove(herob4[i].lim[k]);
                                ss3[m].lim.Remove(ss3[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    ////////////////////////////////////////////
                    for (int m = 0; m < ss4.Count; m++)
                    {
                        for (int n = 0; n < ss4[m].lim.Count; n++)
                        {
                            if (ss4[m].x <= herob4[i].x && ss4[m].x + ss4[m].lim[n].Width >= herob4[i].x && ss4[m].y <= herob4[i].y && ss4[m].y + ss4[m].lim[n].Height >= herob4[i].y)
                            {
                                herob4[i].lim.Remove(herob4[i].lim[k]);
                                ss4[m].lim.Remove(ss4[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    ///////////////////////////////////////////////////////
                }
            }
        }
        void killenimeb5()
        {
            for (int i = 0; i < herob5.Count; i++)
            {
                for (int k = 0; k < herob5[i].lim.Count; k++)
                {
                    if (enime.x <= herob5[i].x && enime.x + enime.lim[0].Width >= herob5[i].x && enime.y <= herob5[i].y && enime.y + enime.lim[0].Width/2 >= herob5[i].y)
                    {
                        if (ct2 == 20)
                        {
                            //  b++;
                            h = 1;
                            enime.frame = 1;
                            enime.y = 0;

                        }
                        ct2++;
                        herob5[i].lim.Remove(herob5[i].lim[k]);
                       // MessageBox.Show("5");

                    }

                }
            }
            for (int i = 0; i < herob5.Count; i++)
            {
                for (int k = 0; k < herob5[i].lim.Count; k++)
                {
                    for (int m = 0; m < beggg.Count; m++)
                    {
                        for (int n = 0; n < beggg[m].lim.Count; n++)
                        {
                            if (beggg[m].x <= herob5[i].x && beggg[m].x + beggg[m].lim[n].Width >= herob5[i].x && beggg[m].y <= herob5[i].y && beggg[m].y + beggg[m].lim[n].Height >= herob5[i].y)
                            {
                                createsegg(m,n);
                                if (herob5[i].lim.Count != 0)
                                {
                                    herob5[i].lim.Remove(herob5[i].lim[k]);
                                }
                                beggg[m].lim.Remove(beggg[m].lim[n]);

                               // MessageBox.Show("5");
                            }
                        }
                    }
                }
            }
            ///////////////////////////////////////////////////////////////////
            for (int i = 0; i < herob5.Count; i++)
            {
                for (int k = 0; k < herob5[i].lim.Count; k++)
                {
                    for (int m = 0; m < ss1.Count; m++)
                    {
                        for (int n = 0; n < ss1[m].lim.Count; n++)
                        {
                            if (ss1[m].x <= herob5[i].x && ss1[m].x + ss1[m].lim[n].Width >= herob5[i].x && ss1[m].y <= herob5[i].y && ss1[m].y + ss1[m].lim[n].Height >= herob5[i].y)
                            {
                                herob5[i].lim.Remove(herob5[i].lim[k]);
                                ss1[m].lim.Remove(ss1[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    ///////////////////////////////////////////////
                    for (int m = 0; m < ss2.Count; m++)
                    {
                        for (int n = 0; n < ss2[m].lim.Count; n++)
                        {
                            if (ss2[m].x <= herob5[i].x && ss2[m].x + ss2[m].lim[n].Width >= herob5[i].x && ss2[m].y <= herob5[i].y && ss2[m].y + ss2[m].lim[n].Height >= herob5[i].y)
                            {
                                herob5[i].lim.Remove(herob5[i].lim[k]);
                                ss2[m].lim.Remove(ss2[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    /////////////////////////////////////////////////
                    for (int m = 0; m < ss3.Count; m++)
                    {
                        for (int n = 0; n < ss3[m].lim.Count; n++)
                        {
                            if (ss3[m].x <= herob5[i].x && ss3[m].x + ss3[m].lim[n].Width >= herob5[i].x && ss3[m].y <= herob5[i].y && ss3[m].y + ss3[m].lim[n].Height >= herob5[i].y)
                            {
                                herob5[i].lim.Remove(herob5[i].lim[k]);
                                ss3[m].lim.Remove(ss3[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    ////////////////////////////////////////////
                    for (int m = 0; m < ss4.Count; m++)
                    {
                        for (int n = 0; n < ss4[m].lim.Count; n++)
                        {
                            if (ss4[m].x <= herob5[i].x && ss4[m].x + ss4[m].lim[n].Width >= herob5[i].x && ss4[m].y <= herob5[i].y && ss4[m].y + ss4[m].lim[n].Height >= herob5[i].y)
                            {
                                herob5[i].lim.Remove(herob5[i].lim[k]);
                                ss4[m].lim.Remove(ss4[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    ///////////////////////////////////////////////////////
                }
            }
        }
        void killenimeb6()
        {
            for (int i = 0; i < herob6.Count; i++)
            {
                for (int k = 0; k < herob6[i].lim.Count; k++)
                {
                    if (enime.x <= herob6[i].x && enime.x + enime.lim[0].Width >= herob6[i].x && enime.y <= herob6[i].y && enime.y + enime.lim[0].Width/2 >= herob6[i].y)
                    {
                        if (ct2 == 20)
                        {
                            //  b++;
                            h = 1;
                            enime.frame = 1;
                            enime.y = 0;

                        }
                        ct2++;
                        herob6[i].lim.Remove(herob6[i].lim[k]);
                       // MessageBox.Show("6");

                    }

                }
            }
            for (int i = 0; i < herob6.Count; i++)
            {
                for (int k = 0; k < herob6[i].lim.Count; k++)
                {
                    for (int m = 0; m < beggg.Count; m++)
                    {
                        for (int n = 0; n < beggg[m].lim.Count; n++)
                        {
                            if (beggg[m].x <= herob6[i].x && beggg[m].x + beggg[m].lim[n].Width >= herob6[i].x && beggg[m].y <= herob6[i].y && beggg[m].y + beggg[m].lim[n].Height >= herob6[i].y)
                            {
                                createsegg(m,n);
                                if (herob6[i].lim.Count != 0)
                                {
                                    herob6[i].lim.Remove(herob6[i].lim[k]);
                                }
                                beggg[m].lim.Remove(beggg[m].lim[n]);

                               // MessageBox.Show("6");
                            }
                        }
                    }
                }
            }
            ///////////////////////////////////////////////////////////////////
            for (int i = 0; i < herob6.Count; i++)
            {
                for (int k = 0; k < herob6[i].lim.Count; k++)
                {
                    for (int m = 0; m < ss1.Count; m++)
                    {
                        for (int n = 0; n < ss1[m].lim.Count; n++)
                        {
                            if (ss1[m].x <= herob6[i].x && ss1[m].x + ss1[m].lim[n].Width >= herob6[i].x && ss1[m].y <= herob6[i].y && ss1[m].y + ss1[m].lim[n].Height >= herob6[i].y)
                            {
                                herob6[i].lim.Remove(herob6[i].lim[k]);
                                ss1[m].lim.Remove(ss1[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    ///////////////////////////////////////////////
                    for (int m = 0; m < ss2.Count; m++)
                    {
                        for (int n = 0; n < ss2[m].lim.Count; n++)
                        {
                            if (ss2[m].x <= herob6[i].x && ss2[m].x + ss2[m].lim[n].Width >= herob6[i].x && ss2[m].y <= herob6[i].y && ss2[m].y + ss2[m].lim[n].Height >= herob6[i].y)
                            {
                                herob6[i].lim.Remove(herob6[i].lim[k]);
                                ss2[m].lim.Remove(ss2[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    /////////////////////////////////////////////////
                    for (int m = 0; m < ss3.Count; m++)
                    {
                        for (int n = 0; n < ss3[m].lim.Count; n++)
                        {
                            if (ss3[m].x <= herob6[i].x && ss3[m].x + ss3[m].lim[n].Width >= herob6[i].x && ss3[m].y <= herob6[i].y && ss3[m].y + ss3[m].lim[n].Height >= herob6[i].y)
                            {
                                herob6[i].lim.Remove(herob6[i].lim[k]);
                                ss3[m].lim.Remove(ss3[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    ////////////////////////////////////////////
                    for (int m = 0; m < ss4.Count; m++)
                    {
                        for (int n = 0; n < ss4[m].lim.Count; n++)
                        {
                            if (ss4[m].x <= herob6[i].x && ss4[m].x + ss4[m].lim[n].Width >= herob6[i].x && ss4[m].y <= herob6[i].y && ss4[m].y + ss4[m].lim[n].Height >= herob6[i].y)
                            {
                                herob6[i].lim.Remove(herob6[i].lim[k]);
                                ss4[m].lim.Remove(ss4[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    ///////////////////////////////////////////////////////
                }
            }
        }
        void killenimeb7()
        {
            for (int i = 0; i < herob7.Count; i++)
            {
                for (int k = 0; k < herob7[i].lim.Count; k++)
                {
                    if (enime.x <= herob7[i].x && enime.x + enime.lim[0].Width >= herob7[i].x && enime.y <= herob7[i].y && enime.y + enime.lim[0].Width/2 >= herob7[i].y)
                    {
                        if (ct2 == 20)
                        {
                            //  b++;
                            h = 1;
                            enime.frame = 1;
                            enime.y = 0;

                        }
                        ct2++;
                        herob7[i].lim.Remove(herob7[i].lim[k]);
                        //MessageBox.Show("7");

                    }

                }
            }
            for (int i = 0; i < herob7.Count; i++)
            {
                for (int k = 0; k < herob7[i].lim.Count; k++)
                {
                    for (int m = 0; m < beggg.Count; m++)
                    {
                        for (int n = 0; n < beggg[m].lim.Count; n++)
                        {
                            if (beggg[m].x <= herob7[i].x && beggg[m].x + beggg[m].lim[n].Width >= herob7[i].x && beggg[m].y >= herob7[i].y && beggg[m].y + beggg[m].lim[n].Height <= herob7[i].y)
                            {
                                createsegg(m,n);
                                if (herob7[i].lim.Count != 0)
                                {
                                    herob7[i].lim.Remove(herob7[i].lim[k]);
                                }
                                beggg[m].lim.Remove(beggg[m].lim[n]);

                                //MessageBox.Show("1");
                            }
                        }
                    }
                }
            }
            ///////////////////////////////////////////////////////////////////
            for (int i = 0; i < herob7.Count; i++)
            {
                for (int k = 0; k < herob7[i].lim.Count; k++)
                {
                    for (int m = 0; m < ss1.Count; m++)
                    {
                        for (int n = 0; n < ss1[m].lim.Count; n++)
                        {
                            if (ss1[m].x <= herob7[i].x && ss1[m].x + ss1[m].lim[n].Width >= herob7[i].x && ss1[m].y <= herob7[i].y && ss1[m].y + ss1[m].lim[n].Height >= herob7[i].y)
                            {
                                herob7[i].lim.Remove(herob7[i].lim[k]);
                                ss1[m].lim.Remove(ss1[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    ///////////////////////////////////////////////
                    for (int m = 0; m < ss2.Count; m++)
                    {
                        for (int n = 0; n < ss2[m].lim.Count; n++)
                        {
                            if (ss2[m].x <= herob7[i].x && ss2[m].x + ss2[m].lim[n].Width >= herob7[i].x && ss2[m].y <= herob7[i].y && ss2[m].y + ss2[m].lim[n].Height >= herob7[i].y)
                            {
                                herob7[i].lim.Remove(herob7[i].lim[k]);
                                ss2[m].lim.Remove(ss2[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    /////////////////////////////////////////////////
                    for (int m = 0; m < ss3.Count; m++)
                    {
                        for (int n = 0; n < ss3[m].lim.Count; n++)
                        {
                            if (ss3[m].x <= herob7[i].x && ss3[m].x + ss3[m].lim[n].Width >= herob7[i].x && ss3[m].y <= herob7[i].y && ss3[m].y + ss3[m].lim[n].Height >= herob7[i].y)
                            {
                                herob7[i].lim.Remove(herob7[i].lim[k]);
                                ss3[m].lim.Remove(ss3[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    ////////////////////////////////////////////
                    for (int m = 0; m < ss4.Count; m++)
                    {
                        for (int n = 0; n < ss4[m].lim.Count; n++)
                        {
                            if (ss4[m].x <= herob7[i].x && ss4[m].x + ss4[m].lim[n].Width >= herob7[i].x && ss4[m].y <= herob7[i].y && ss4[m].y + ss4[m].lim[n].Height >= herob7[i].y)
                            {
                                herob7[i].lim.Remove(herob7[i].lim[k]);
                                ss4[m].lim.Remove(ss4[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    ///////////////////////////////////////////////////////
                }
            }
        }
        void killenimeb8()
        {
            for (int i = 0; i < herob8.Count; i++)
            {
                for (int k = 0; k < herob8[i].lim.Count; k++)
                {
                    if (enime.x <= herob8[i].x && enime.x + enime.lim[0].Width >= herob8[i].x && enime.y <= herob8[i].y && enime.y+enime.lim[0].Width/2 >= herob8[i].y)
                    {
                        if (ct2 == 20)
                        {
                            //  b++;
                            h = 1;
                            enime.frame =1;
                        }
                        ct2++;
                        herob8[i].lim.Remove(herob8[i].lim[k]);

                        //MessageBox.Show("8");

                    }

                }
            }
            for (int i = 0; i < herob8.Count; i++)
            {
                for (int k = 0; k < herob8[i].lim.Count; k++)
                {
                    for (int m = 0; m < beggg.Count; m++)
                    {
                        for (int n = 0; n < beggg[m].lim.Count; n++)
                        {
                            if (beggg[m].x <= herob8[i].x && beggg[m].x + beggg[m].lim[n].Width >= herob8[i].x && beggg[m].y <= herob8[i].y && beggg[m].y + beggg[m].lim[n].Height >= herob8[i].y)
                            {
                                createsegg(m, n);
                                if (herob8[i].lim.Count != 0)
                                {
                                    herob8[i].lim.Remove(herob8[i].lim[k]);
                                }
                                beggg[m].lim.Remove(beggg[m].lim[n]);

                                // MessageBox.Show("3");
                            }
                        }
                    }
                }
            }
            ///////////////////////////////////////////////////////////////////
            for (int i = 0; i < herob8.Count; i++)
            {
                for (int k = 0; k < herob8[i].lim.Count; k++)
                {
                    for (int m = 0; m < ss1.Count; m++)
                    {
                        for (int n = 0; n < ss1[m].lim.Count; n++)
                        {
                            if (ss1[m].x <= herob8[i].x && ss1[m].x + ss1[m].lim[n].Width >= herob8[i].x && ss1[m].y <= herob8[i].y && ss1[m].y + ss1[m].lim[n].Height >= herob8[i].y)
                            {
                                herob8[i].lim.Remove(herob8[i].lim[k]);
                                ss1[m].lim.Remove(ss1[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    ///////////////////////////////////////////////
                    for (int m = 0; m < ss2.Count; m++)
                    {
                        for (int n = 0; n < ss2[m].lim.Count; n++)
                        {
                            if (ss2[m].x <= herob8[i].x && ss2[m].x + ss2[m].lim[n].Width >= herob8[i].x && ss2[m].y <= herob8[i].y && ss2[m].y + ss2[m].lim[n].Height >= herob8[i].y)
                            {
                                herob8[i].lim.Remove(herob8[i].lim[k]);
                                ss2[m].lim.Remove(ss2[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    /////////////////////////////////////////////////
                    for (int m = 0; m < ss3.Count; m++)
                    {
                        for (int n = 0; n < ss3[m].lim.Count; n++)
                        {
                            if (ss3[m].x <= herob8[i].x && ss3[m].x + ss3[m].lim[n].Width >= herob8[i].x && ss3[m].y <= herob8[i].y && ss3[m].y + ss3[m].lim[n].Height >= herob8[i].y)
                            {
                                herob8[i].lim.Remove(herob8[i].lim[k]);
                                ss3[m].lim.Remove(ss3[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    ////////////////////////////////////////////
                    for (int m = 0; m < ss4.Count; m++)
                    {
                        for (int n = 0; n < ss4[m].lim.Count; n++)
                        {
                            if (ss4[m].x <= herob8[i].x && ss4[m].x + ss4[m].lim[n].Width >= herob8[i].x && ss4[m].y <= herob8[i].y && ss4[m].y + ss4[m].lim[n].Height >= herob8[i].y)
                            {
                                herob8[i].lim.Remove(herob8[i].lim[k]);
                                ss4[m].lim.Remove(ss4[m].lim[n]);
                                // MessageBox.Show("1");
                            }
                        }
                    }
                    ///////////////////////////////////////////////////////
                }
            }
        }
      
        private void Tt_Tick(object sender, EventArgs e)
        {
            
            if (level == 0)
            {
                Random rr = new Random();

                if (tttick3 == rr.Next(0, 10))
                {
                    if (y == 0)
                    {
                        createbullet();
                    }
                    tttick3 = 0;
                }
                
                if (y == 0)
                {
                    moveg();
                    if (eni.frame < 4)
                    {
                        movesk();
                    }
                }
                movebullet();
                movebullet2();
                movebullet3();
                movebullet5();
                moveb10();
                check();
                check2();
                check3();
                kill();
                killg();
                killsk();
                level2();
            }
            if (level == 2 && c==0 )
            {
                Random rr2 = new Random();
                if (tttick4 == rr2.Next(0, 5))
                {
                    if (h == 0)
                    {
                        createbegg();
                    }
                    tttick4 = 0;
                }
                moveenime();
                movebegg();
                moveherob1();
                moveherob2();
                moveherob3();
                moveherob4();
                moveherob5();
                moveherob6();
                moveherob7();
                moveherob8();
                killenimeb1();
                killenimeb2();
                killenimeb3();
                killenimeb4();
                killenimeb5();
                killenimeb6();
                killenimeb7();
                killenimeb8();
                movesegg();
                killhuman();

            }
            if (human.frame==3)
            {
                if (sec == 10)
                {
                    level = 1;
                    LActs[0].XS += 5;
                }
                if(sec<10)
                {
                    sec++;
                }
            }
            if(enime.frame==1)
            {
                if(sec1==10)
                {
                    level = 4;
                    LActs1[0].XS += 5;
                }
                if (sec1 < 10)
                {
                    sec1++;
                }
            }
            drawdubb(CreateGraphics());
        }
        void moveg()
        {

            if (tttick == 0)
            {
                goral.x += 25;
                l++;
                if (l == 58)
                {
                    tttick = 1;
                }
            }
            else
            {
                goral.x -= 25;
                l--;
                if (l == 0)
                {
                    tttick = 0;
                }
            }
            goral.frame++;
            if (goral.frame == 4)
            { goral.frame = 0; }

        }
        void movesk()
        {
            if(human.y==350)
            {
                tttick7 = 2;
            }
            if (tttick7 == 0)
            {
                eni.x += 15;
                if (eni.frame == 0)
                { eni.frame = 1; }
                else
                {
                    eni.frame = 0;
                }
                l5++;
                if (l5 == 100)
                {
                    tttick7 = 1;
                }
            }
            if(tttick7==1)
            {
                eni.x -= 15;
                if (eni.frame == 2)
                { eni.frame = 3; }
                else
                {
                    eni.frame = 2;
                }
                l5--;
                if (l5 == 0)
                {
                    tttick7 = 0;
                }
            }
            if(tttick7==2)
            {
                if (l6 >= 5)
                {
                    tttick8++;
                    if (tttick8<10)
                    {
                        eni.frame = 3;
                    }
                    if (tttick8 > 11)
                    {
                        eni.frame = 5;
                    }
                }
                if(l6<5)
                {
                    l6++;
                }
            }

        }
        void movebegg()
        {
            for (int i = 0; i < beggg.Count; i++)
            {
                beggg[i].y += 10;
            }
        }
        void moveenime()
        {
            if (h == 0)
            {
                if (tttick2 == 0)
                {
                    enime.x += 25;
                    l3++;
                    if (l3 == 58)
                    {
                        tttick2 = 1;
                    }
                }
                else
                {
                    enime.x -= 25;
                    l3--;
                    if (l3 == 0)
                    {
                        tttick2 = 0;
                    }
                }
            }
        }
        void movesegg()
        {
            for (int i = 0; i < ss1.Count; i++)
            {
                ss1[i].y += 10;
            }
            for (int i = 0; i < ss2.Count; i++)
            {
                ss2[i].y += 10;
            }
            for (int i = 0; i < ss3.Count; i++)
            {
                ss3[i].y += 10;
            }
            for (int i = 0; i < ss4.Count; i++)
            {
                ss4[i].y += 10;
            }
        }
        void drawskalla(Graphics g)
        {
            g.DrawImage(skalla.lim[0], skalla.x, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 24, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 48, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 72, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 96, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 120, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 144, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 168, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 192, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 216, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 240, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 264, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 288, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 312, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 336, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 360, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 384, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 408, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 432, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 456, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 480, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 504, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 528, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 552, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 576, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 600, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 624, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 648, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 672, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 696, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 720, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 744, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 768, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 792, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 816, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 840, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 864, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 888, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 912, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 936, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 960, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 984, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 1008, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 1032, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 1056, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 1080, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 1104, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 1128, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 1152, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 1176, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 1200, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 1224, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 1248, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 1272, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 1296, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 1320, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 1344, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 1368, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 1392, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 1416, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 1440, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 1464, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 1488, skalla.y);
            g.DrawImage(skalla.lim[0], skalla.x + 1512, skalla.y);
        }
        void drawskalla2(Graphics g)
        {
            g.DrawImage(skalla2.lim[0], skalla2.x, skalla2.y);
            g.DrawImage(skalla2.lim[0], skalla2.x + 76, skalla2.y);
            g.DrawImage(skalla2.lim[0], skalla2.x + 152, skalla2.y);
            g.DrawImage(skalla2.lim[0], skalla2.x + 228, skalla2.y);
            g.DrawImage(skalla2.lim[0], skalla2.x + 304, skalla2.y);
            g.DrawImage(skalla2.lim[0], skalla2.x + 380, skalla2.y);
            g.DrawImage(skalla2.lim[0], skalla2.x + 456, skalla2.y);
            g.DrawImage(skalla2.lim[0], skalla2.x + 532, skalla2.y);
            g.DrawImage(skalla2.lim[0], skalla2.x + 608, skalla2.y);
            g.DrawImage(skalla2.lim[0], skalla2.x + 684, skalla2.y);
            g.DrawImage(skalla2.lim[0], skalla2.x + 760, skalla2.y);
            g.DrawImage(skalla2.lim[0], skalla2.x + 836, skalla2.y);
            g.DrawImage(skalla2.lim[0], skalla2.x + 912, skalla2.y);
            g.DrawImage(skalla2.lim[0], skalla2.x + 988, skalla2.y);
            g.DrawImage(skalla2.lim[0], skalla2.x + 1064, skalla2.y);
            g.DrawImage(skalla2.lim[0], skalla2.x + 1140, skalla2.y);
            g.DrawImage(skalla2.lim[0], skalla2.x + 1216, skalla2.y);
            g.DrawImage(skalla2.lim[0], skalla2.x + 1292, skalla2.y);
            g.DrawImage(skalla2.lim[0], skalla2.x + 1368, skalla2.y);
            g.DrawImage(skalla2.lim[0], skalla2.x + 1444, skalla2.y);
            g.DrawImage(skalla2.lim[0], skalla2.x + 1520, skalla2.y);
        }
        void drawskalla3(Graphics g)
        {
            g.DrawImage(skalla3.lim[0], skalla3.x, skalla3.y);
            g.DrawImage(skalla3.lim[0], skalla3.x + 76, skalla3.y);
            g.DrawImage(skalla3.lim[0], skalla3.x + 152, skalla3.y);
            g.DrawImage(skalla3.lim[0], skalla3.x + 228, skalla3.y);
            g.DrawImage(skalla3.lim[0], skalla3.x + 304, skalla3.y);
            g.DrawImage(skalla3.lim[0], skalla3.x + 380, skalla3.y);
            g.DrawImage(skalla3.lim[0], skalla3.x + 456, skalla3.y);
            g.DrawImage(skalla3.lim[0], skalla3.x + 532, skalla3.y);
            g.DrawImage(skalla3.lim[0], skalla3.x + 608, skalla3.y);
            g.DrawImage(skalla3.lim[0], skalla3.x + 684, skalla3.y);
            g.DrawImage(skalla3.lim[0], skalla3.x + 760, skalla3.y);
            g.DrawImage(skalla3.lim[0], skalla3.x + 836, skalla3.y);
            g.DrawImage(skalla3.lim[0], skalla3.x + 912, skalla3.y);
            g.DrawImage(skalla3.lim[0], skalla3.x + 988, skalla3.y);
            g.DrawImage(skalla3.lim[0], skalla3.x + 1064, skalla3.y);
            g.DrawImage(skalla3.lim[0], skalla3.x + 1140, skalla3.y);
            g.DrawImage(skalla3.lim[0], skalla3.x + 1216, skalla3.y);
            g.DrawImage(skalla3.lim[0], skalla3.x + 1292, skalla3.y);
            g.DrawImage(skalla3.lim[0], skalla3.x + 1368, skalla3.y);
            g.DrawImage(skalla3.lim[0], skalla3.x + 1444, skalla3.y);
            g.DrawImage(skalla3.lim[0], skalla3.x + 1520, skalla3.y);
        }
        void drawskalla4(Graphics g)
        {
            g.DrawImage(skalla4.lim[0], skalla4.x, skalla4.y);
            g.DrawImage(skalla4.lim[0], skalla4.x + 76, skalla4.y);
            g.DrawImage(skalla4.lim[0], skalla4.x + 152, skalla4.y);
            g.DrawImage(skalla4.lim[0], skalla4.x + 228, skalla4.y);
            g.DrawImage(skalla4.lim[0], skalla4.x + 304, skalla4.y);
            g.DrawImage(skalla4.lim[0], skalla4.x + 380, skalla4.y);
            g.DrawImage(skalla4.lim[0], skalla4.x + 456, skalla4.y);
            g.DrawImage(skalla4.lim[0], skalla4.x + 532, skalla4.y);
            g.DrawImage(skalla4.lim[0], skalla4.x + 608, skalla4.y);
            g.DrawImage(skalla4.lim[0], skalla4.x + 684, skalla4.y);
            g.DrawImage(skalla4.lim[0], skalla4.x + 760, skalla4.y);
            g.DrawImage(skalla4.lim[0], skalla4.x + 836, skalla4.y);
            g.DrawImage(skalla4.lim[0], skalla4.x + 912, skalla4.y);
            g.DrawImage(skalla4.lim[0], skalla4.x + 988, skalla4.y);
            g.DrawImage(skalla4.lim[0], skalla4.x + 1064, skalla4.y);
            g.DrawImage(skalla4.lim[0], skalla4.x + 1140, skalla4.y);
            g.DrawImage(skalla4.lim[0], skalla4.x + 1216, skalla4.y);
            g.DrawImage(skalla4.lim[0], skalla4.x + 1292, skalla4.y);
            g.DrawImage(skalla4.lim[0], skalla4.x + 1368, skalla4.y);
            g.DrawImage(skalla4.lim[0], skalla4.x + 1444, skalla4.y);
            g.DrawImage(skalla4.lim[0], skalla4.x + 1520, skalla4.y);
        }
        void drawclimb2(Graphics g)
        {
            g.DrawImage(climb2.lim[0], climb2.x, climb2.y);
            g.DrawImage(climb2.lim[0], climb2.x, climb2.y + 36);
            g.DrawImage(climb2.lim[0], climb2.x, climb2.y + 72);
            g.DrawImage(climb2.lim[0], climb2.x, climb2.y + 108);
            g.DrawImage(climb2.lim[0], climb2.x, climb2.y + 144);
            // g.DrawImage(climb.lim[0], climb.x, climb.y + 180);
            // g.DrawImage(climb.lim[0], climb.x, climb.y + 216);

        }
        void createbegg()
        {
            begg = new actor();
            begg.x = enime.x;
            begg.y = enime.y+enime.lim[0].Height-150;
            Bitmap img12;
            img12 = new Bitmap("bigegg.bmp");
            img12.MakeTransparent(img12.GetPixel(0, 0));
            begg.lim.Add(img12);
            beggg.Add(begg);
        }
        void createsegg(int i,int k)
        {
            s1 = new actor();
            s1.x = beggg[i].x;
            s1.y = beggg[i].y;
            Bitmap img12;
            img12 = new Bitmap("e1.bmp");
            img12.MakeTransparent(img12.GetPixel(0, 0));
            s1.lim.Add(img12);
            ss1.Add(s1);
            ////////////////////////////////
            s2 = new actor();
            s2.x = beggg[i].x+50;
            s2.y = beggg[i].y;
            Bitmap img13;
            img13 = new Bitmap("e1.bmp");
            img13.MakeTransparent(img13.GetPixel(0, 0));
            s2.lim.Add(img13);
            ss2.Add(s2);
            //////////////////////////////////
            s3 = new actor();
            s3.x = beggg[i].x-50;
            s3.y = beggg[i].y;
            Bitmap img14;
            img14 = new Bitmap("e1.bmp");
            img14.MakeTransparent(img14.GetPixel(0, 0));
            s3.lim.Add(img14);
            ss3.Add(s3);
            ///////////////////////////////////
            s4= new actor();
            s4.x = beggg[i].x+100;
            s4.y = beggg[i].y;
            Bitmap img20;
            img20 = new Bitmap("e1.bmp");
            img20.MakeTransparent(img20.GetPixel(0, 0));
            s4.lim.Add(img20);
            ss4.Add(s4);
            //////////////////////////////////

            ///////////////////////////////////

            //////////////////////////////////
        }
        void drawclimb(Graphics g)
        {
            g.DrawImage(climb.lim[0], climb.x, climb.y);
            g.DrawImage(climb.lim[0], climb.x, climb.y + 36);
            g.DrawImage(climb.lim[0], climb.x, climb.y + 72);
            g.DrawImage(climb.lim[0], climb.x, climb.y + 108);
            g.DrawImage(climb.lim[0], climb.x, climb.y + 144);
            // g.DrawImage(climb.lim[0], climb.x, climb.y + 180);
            // g.DrawImage(climb.lim[0], climb.x, climb.y + 216);

        }
        void drawscene(Graphics g)
        {
            if (level == 0)
            {
                g.Clear(Color.Gray);
                ///////////////////////////////////////
                ////////////////////////////////////////
                drawclimb(g);
                ///////////////////////////////
                drawclimb2(g);
                /////////////////////////////////////////////////
                g.DrawImage(human.lim[human.frame], human.x, human.y);
                //////////////////////////////////////////
                for (int i = 0; i < bad.Count; i++)
                {
                    for (int k = 0; k < bad[i].lim.Count; k++)
                    {
                        g.DrawImage(bad[i].lim[k], bad[i].x, bad[i].y);
                    }
                }
                /////////////////////////////////
                g.DrawImage(eni.lim[eni.frame], eni.x, eni.y);
                ////////////////////////////////////
              //  for (int i = 0; i < bullett10.Count; i++)
              //  {
              //      for (int k = 0; k < bullett10[i].lim.Count; k++)
              //      {
              //          g.DrawImage(bullett10[i].lim[k], bullett10[i].x, bullett10[i].y);
              //      }
              //  }
                /////////////////////////////////////
                for (int i = 0; i < bullett.Count; i++)
                {
                    for (int k = 0; k < bullett[i].lim.Count; k++)
                    {
                        g.DrawImage(bullett[i].lim[k], bullett[i].x, bullett[i].y);
                    }
                }
                /////////////////////////////////////
                for (int i = 0; i < bullett2.Count; i++)
                {
                    for (int k = 0; k < bullett2[i].lim.Count; k++)
                    {
                        g.DrawImage(bullett2[i].lim[k], bullett2[i].x, bullett2[i].y);
                    }
                }
                ////////////////////////////////////////////
                for (int i = 0; i < bullett5.Count; i++)
                {
                    for (int k = 0; k < bullett5[i].lim.Count; k++)
                    {
                        g.DrawImage(bullett5[i].lim[k], bullett5[i].x, bullett5[i].y);
                    }
                }
                /////////////////////////////////////////////////////////
                g.DrawImage(goral.lim[goral.frame], goral.x, goral.y);
                //////////////////////////////////////
                g.DrawImage(gate.lim[0], gate.x, gate.y);
                ////////////////////////////////////////////////
                drawskalla(g);
                drawskalla2(g);
                drawskalla3(g);
                drawskalla4(g);
            }
            if (level == 1)
            {
                g.Clear(Color.Black);

                for (int i = 0; i < LActs.Count; i++)
                {
                    Rectangle rcDest = new Rectangle(LActs[i].XD, LActs[i].YD,
                                                        //(int)(LActs[i].im.Width*ratio) , 
                                                        //(int)(LActs[i].im.Height* ratio));
                                                        LActs[i].im.Width,
                                                        LActs[i].im.Height);

                    Rectangle rcSrc = new Rectangle(LActs[i].XS, LActs[i].YS,
                                                    LActs[i].im.Width, LActs[i].im.Height);
                    //LActs[i].im.Width, LActs[i].im.Height);
                    g.DrawImage(LActs[i].im,
                                rcDest, rcSrc,
                                GraphicsUnit.Pixel
                                );
                }
            }
            if (level==2)
            {
                g.Clear(Color.Gray);

                g.DrawImage(human.lim[human.frame], human.x, human.y);
                //////////////////////////////////////////////////
                g.DrawImage(enime.lim[enime.frame], enime.x, enime.y);
                ///////////////////////////////////////////////
                for (int i = 0; i < beggg.Count; i++)
                {
                    for (int k = 0; k < beggg[i].lim.Count; k++)
                    {
                        g.DrawImage(beggg[i].lim[k], beggg[i].x, beggg[i].y);
                    }
                }
                ////////////////////////////////////////////////////
                for (int i = 0; i < ss1.Count; i++)
                {
                    for (int k = 0; k < ss1[i].lim.Count; k++)
                    {
                        g.DrawImage(ss1[i].lim[k], ss1[i].x, ss1[i].y);
                    }
                }
                //////////////////////////////////////////////////
                for (int i = 0; i < ss2.Count; i++)
                {
                    for (int k = 0; k < ss2[i].lim.Count; k++)
                    {
                        g.DrawImage(ss2[i].lim[k], ss2[i].x, ss2[i].y);
                    }
                }
                //////////////////////////////////////////////////
                for (int i = 0; i < ss3.Count; i++)
                {
                    for (int k = 0; k < ss3[i].lim.Count; k++)
                    {
                        g.DrawImage(ss3[i].lim[k], ss3[i].x, ss3[i].y);
                    }
                }
                ////////////////////////////////////////////////////////
                for (int i = 0; i < ss4.Count; i++)
                {
                    for (int k = 0; k < ss4[i].lim.Count; k++)
                    {
                        g.DrawImage(ss4[i].lim[k], ss4[i].x, ss4[i].y);
                    }
                }
                ////////////////////////////////////////////////////////
                for (int i = 0; i < herob1.Count; i++)
                {
                    for (int k = 0; k < herob1[i].lim.Count; k++)
                    {
                        g.DrawImage(herob1[i].lim[k], herob1[i].x, herob1[i].y);
                    }
                }
                /////////////////////////////////////////////////////////
                for (int i = 0; i < herob2.Count; i++)
                {
                    for (int k = 0; k < herob2[i].lim.Count; k++)
                    {
                        g.DrawImage(herob2[i].lim[k], herob2[i].x, herob2[i].y);
                    }
                }
                /////////////////////////////////////////////////////
                for (int i = 0; i < herob3.Count; i++)
                {
                    for (int k = 0; k < herob3[i].lim.Count; k++)
                    {
                        g.DrawImage(herob3[i].lim[k], herob3[i].x, herob3[i].y);
                    }
                }
                ////////////////////////////////////////////////////////
                for (int i = 0; i < herob4.Count; i++)
                {
                    for (int k = 0; k < herob4[i].lim.Count; k++)
                    {
                        g.DrawImage(herob4[i].lim[k], herob4[i].x, herob4[i].y);
                    }
                }
                ////////////////////////////////////////////////////
                for (int i = 0; i < herob5.Count; i++)
                {
                    for (int k = 0; k < herob5[i].lim.Count; k++)
                    {
                        g.DrawImage(herob5[i].lim[k], herob5[i].x, herob5[i].y);
                    }
                }
                ////////////////////////////////////////////////////////////////////
                for (int i = 0; i < herob6.Count; i++)
                {
                    for (int k = 0; k < herob6[i].lim.Count; k++)
                    {
                        g.DrawImage(herob6[i].lim[k], herob6[i].x, herob6[i].y);
                    }
                }
                ////////////////////////////////////////////////////////////////
                for (int i = 0; i < herob7.Count; i++)
                {
                    for (int k = 0; k < herob7[i].lim.Count; k++)
                    {
                        g.DrawImage(herob7[i].lim[k], herob7[i].x, herob7[i].y);
                    }
                }
                ////////////////////////////////////////////////////////////////
                for (int i = 0; i < herob8.Count; i++)
                {
                    for (int k = 0; k < herob8[i].lim.Count; k++)
                    {
                        g.DrawImage(herob8[i].lim[k], herob8[i].x, herob8[i].y);
                    }
                }
                ///////////////////////////////////////////////////////////////
            }
            if(level==4)
            {
                g.Clear(Color.Black);

                for (int i = 0; i < LActs1.Count; i++)
                {
                    Rectangle rcDest = new Rectangle(LActs1[i].XD, LActs1[i].YD,
                                                        //(int)(LActs1[i].im.Width*ratio) , 
                                                        //(int)(LActs1[i].im.Height* ratio));
                                                        LActs1[i].im.Width,
                                                        LActs1[i].im.Height);

                    Rectangle rcSrc = new Rectangle(LActs1[i].XS, LActs1[i].YS,
                                                    LActs1[i].im.Width, LActs1[i].im.Height);
                    //LActs1[i].im.Width, LActs1[i].im.Height);
                    g.DrawImage(LActs1[i].im,
                                rcDest, rcSrc,
                                GraphicsUnit.Pixel
                                );
                }
            }
        }
        void level2()
        {
            if(human.x<=80 && human.x>=0 && human.y==150)
            {
                level = 2;
            }
        }
        void drawdubb(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            drawscene(g2);
            g.DrawImage(off, 0, 0);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            drawdubb(e.Graphics);
        }
    }
}