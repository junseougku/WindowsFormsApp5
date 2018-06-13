using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.IO.st
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
        public MainForm()
        {
            InitializeComponent();
            m_openImageDialog = new OpenFileDialog();
            m_openImageDialog.InitialDirectory = @"C:\";
            Init();
        }

        private void Init()
        {
            m_click = false;
            m_clickDown = false;
            m_mouseX = 0;
            m_mouseY = 0;
            ImageInit();
            
        }

        private void ImageInit()
        {
            pictureBox1.Image = imageList.Images[0];
            pictureBox2.Image = imageList.Images[1];
            pictureBox3.Image = imageList.Images[2];
        }

        private void imageAddButton_Click(object sender, EventArgs e)
        {
            //m_openImageDialog.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            // m_openImageDialog.FilterIndex = 1;
            // m_openImageDialog.ShowDialog();


            //Image flag = new Bitmap("ground_1.png");
            Graphics flagGraphics = CreateGraphics();

            // flag = m_openImageDialog.
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainPicture_Paint(object sender, PaintEventArgs e)
        {
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
            if (m_click == true || m_clickDown == true)
            {
                TilePaint(e);
                m_clickDown = false;
            }
          
        }

        private void TilePaint(PaintEventArgs e )
        {
            e.Graphics.DrawImage(imageList.Images[0], m_mouseX - 40, m_mouseY - 40);
            for (int i = 0; i < 16; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if (m_mapTile[i,j].no == true)
                        e.Graphics.DrawImage(imageList.Images[m_mapTile[i, j].number], i*80 , j*80 );
                }
               
            }
        }

        private void MainPicture_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void CommonButton(int _num)
        {
            m_cursorPicture = CreateGraphics();

            m_click = true;

            m_number = _num;
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
                m_click = false;
                m_clickDown = true;
                m_mouseX = e.X / 80;
                m_mouseY = e.Y / 80;

                m_mapTile[m_mouseX, m_mouseY].no = true;
                m_mapTile[m_mouseX, m_mouseY].number = m_number;
                m_mouseX++;
                m_mouseY++;
       
                m_mouseX = 80 * m_mouseX - 40;
                m_mouseY = 80 * m_mouseY - 40;
                
                MainPicture.Invalidate();
                m_number = 0;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void TestButton_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CommonButton(2);
        }
    }
}
