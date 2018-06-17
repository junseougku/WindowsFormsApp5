using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.IO.FileStream;

public struct mapTile
{
    public int x, y;
    public bool no;
    public int number;
   
}

namespace WindowsFormsApp5
{
    public partial class MainForm : Form
    {
        OpenFileDialog m_openImageDialog;
        int m_number;
        Graphics m_cursorPicture;


        bool m_click;
        bool m_clickDown;
        int m_mouseX;
        int m_mouseY;

        mapTile[,] m_mapTile = new mapTile [16,10];

        Player player;
        public MainForm()
        {
            InitializeComponent();
            m_openImageDialog = new OpenFileDialog();
            m_openImageDialog.InitialDirectory = @"C:\";

            MainPicture.Focus();
            Init();
        }

        private void Init()
        {
            m_click = false;
            m_clickDown = false;
            m_mouseX = 0;
            m_mouseY = 0;
            ImageInit();
            player = new Player();

            player.Init(imageList.Images[5]);
          // saveButton.fo
        }

        private void ImageInit()
        {
            pictureBox1.Image = imageList.Images[0];
            pictureBox2.Image = imageList.Images[1];
            pictureBox3.Image = imageList.Images[2];
            pictureBox4.Image = imageList.Images[3];
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        bool testButton = false;
        private void MainPicture_Paint(object sender, PaintEventArgs e)
        {
            LineEnable(e);
            if (m_click == true || m_clickDown == true)
            {
               // TilePaint(e);
                m_clickDown = false;
            }
            TilePaint(e);
       

            if (testButton == true)
            {
 
                for (int i = 0; i < 16; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (m_mapTile[i, j].no == true)
                        {
                            
                            player.setPosition(player.x*80,player.y*80);
                            player.Draw(e);
                            return;
                        }
                    }
                }
            }
        }
        private void TilePaint(PaintEventArgs e )
        {
            e.Graphics.DrawImage(imageList.Images[m_number], m_mouseX - 40, m_mouseY - 40);
            
            for (int i = 0; i < 16; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                   
                    if (m_mapTile[i, j].no == true)
                        e.Graphics.DrawImage(imageList.Images[m_mapTile[i,j].number], i*80, j*80);
                }
               
            }
            //Invalidate();
        }

        private void MainPicture_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void CommonButton(int _num)
        {
            m_cursorPicture = CreateGraphics();

            m_click = true;

            m_number = _num;

            m_deleteClick = false;
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            CommonButton(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CommonButton(1);
        }
        
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void MainPicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_click == true )
            {
                m_mouseX = e.X;
                m_mouseY = e.Y;
                MainPicture.Invalidate();
            }
           


        }

        private void MainPicture_Click(object sender, EventArgs e)
        {

        }

        private void MainPicture_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void MainPicture_MouseDown(object sender, MouseEventArgs e)
        {
            if(m_click == true)
            {
                m_mouseX = e.X / 80;
                m_mouseY = e.Y / 80;
                // m_click = false;
                if (m_mapTile[m_mouseX, m_mouseY].no == true) return;
                m_clickDown = true;

                m_mapTile[m_mouseX, m_mouseY].x = m_mouseX;
                m_mapTile[m_mouseX, m_mouseY].y = m_mouseY;
                m_mapTile[m_mouseX, m_mouseY].no = true;
                m_mapTile[m_mouseX, m_mouseY].number = m_number;
                m_mouseX++;
                m_mouseY++;
       
                m_mouseX = 80 * m_mouseX - 40;//?왜있는거지
                m_mouseY = 80 * m_mouseY - 40;
                
                MainPicture.Invalidate();
                //m_number = 0;
            }
            if(m_deleteClick == true)
            {
                m_mouseX = e.X / 80;
                m_mouseY = e.Y / 80;
                m_mapTile[m_mouseX, m_mouseY].no = false;
                m_mapTile[m_mouseX, m_mouseY].x = 0;
                m_mapTile[m_mouseX, m_mouseY].y = 0;
                m_mapTile[m_mouseX, m_mouseY].number = 0;
                MainPicture.Invalidate();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("textt.txt");
                foreach (mapTile b in m_mapTile )
                {
                    string str = "";
                    str += b.x + ",";
                    str += b.y + ",";
                    str += b.number + ",";
                    if (b.no == false)
                        str += 0 + ",";
                    else
                        str += 1 + ",";
                    sw.WriteLine(str);
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("저장할 수 없습니다");
            }
        
        }

       

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CommonButton(2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CommonButton(3);
        }

        private void PlayerTest()
        {

        }




        private void TestButton_Click(object sender, EventArgs e)
        {
            if (testButton == false)
                testButton = true;
            else testButton = false;
            MainPicture.Invalidate();
            //MainPicture.Focus;
        }

        bool m_islineEnable = true;

        private void lineEnable_Click(object sender, EventArgs e)
        {
            if (m_islineEnable == true)
                m_islineEnable = false;
            else m_islineEnable = true;
            MainPicture.Invalidate();

        }

        private void LineEnable(PaintEventArgs e)
        {
            if (m_islineEnable == false) return;
            Pen p = new Pen(Color.White);
            Point mapLineStart = new Point(0, 0);
            Point mapLineEnd = new Point(0, 0);
            int x = 80, y = 0;
            for (int i = 0; i < 16; i++)
            {
                mapLineStart = new Point(x * i, y);
                mapLineEnd = new Point(x * i, y + 800);
                e.Graphics.DrawLine(p, mapLineStart, mapLineEnd);
            }

            mapLineStart = new Point(0, 0);
            mapLineEnd = new Point(0, 0);
            x = 0;
            y = 80;
            for (int i = 0; i < 10; i++)
            {
                mapLineStart = new Point(x, y * i);
                mapLineEnd = new Point(x + 1280, y * i);
                e.Graphics.DrawLine(p, mapLineStart, mapLineEnd);
            }
            p.Dispose();
        }

        private void stopImage_Click(object sender, EventArgs e)
        {
            m_click = false;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("textt.txt");
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] numbers = line.Split(',');
                    
                    int tx = int.Parse(numbers[0]);
                    int ty = int.Parse(numbers[1]);
                    int tt = int.Parse(numbers[2]);
                    int tb = int.Parse(numbers[3]);
                    m_mapTile[tx, ty].x = tx;
                    m_mapTile[tx, ty].y = ty;
                    m_mapTile[tx, ty].number = tt;
                    if (tb == 0)
                    m_mapTile[tx, ty].no = false;
                    else m_mapTile[tx, ty].no = true;
                }
                MainPicture.Invalidate();
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("읽어올 수 없습니다");
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            m_click = false;
            DeleteMode();

        }
        bool m_deleteClick = false;
        private void DeleteMode()
        {
            if (m_deleteClick == false)
                m_deleteClick = true;
            else m_deleteClick = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }

        private void handleKeyDownEvent()
        {

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                player.update(MOVE.DOWN);
            }
        }
        private int millisecondsElapsed;
        private int frameIndex;
       
        private void updateFrame(int msec)
        {
            millisecondsElapsed += msec;
            //var msecPerFrame = 1000 / framesPerSecond;
            //index = (int)(millisecondsElapsed / msecPerFrame);
        }

        private void upButton_Click(object sender, EventArgs e)
        {

        }

        private void downButton_Click(object sender, EventArgs e)
        {

        }

        private void leftButton_Click(object sender, EventArgs e)
        {

        }

        private void rightButton_Click(object sender, EventArgs e)
        {

        }
    }
}
