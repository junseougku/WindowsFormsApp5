using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class MainForm : Form
    {
        OpenFileDialog m_openImageDialog;
        Graphics m_g;
        Graphics m_cursorPicture;


        bool m_click;

        int m_mouseX;
        int m_mouseY;
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
            m_mouseX = 0;
            m_mouseY = 0;
            ImageInit();
        }

        private void ImageInit()
        {
            pictureBox1.Image = imageList.Images[0];
            pictureBox2.Image = imageList.Images[1];
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
           e.Graphics.DrawImage(imageList.Images[0], m_mouseX-40,m_mouseY-40);
        }

        private void MainPicture_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            m_cursorPicture = CreateGraphics();
          //  m_cursorPicture.DrawImage(imageList.Images[0],Point.Empty);

            m_click = true;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void MainPicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_click == true)
            {
                m_mouseX = e.X;
                m_mouseY = e.Y;
                MainPicture.Invalidate();
            }
        
        }

        private void MainPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
