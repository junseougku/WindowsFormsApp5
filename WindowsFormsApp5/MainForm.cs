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
using System.Drawing.Drawing2D;

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

        public mapTile[,] m_mapTile = new mapTile[16, 10];

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
            previousTime = DateTime.Now;
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

                            player.setPosition(player.x, player.y);
                            player.Draw(e, 5);
                            return;
                        }
                    }
                }
            }
        }
        private void TilePaint(PaintEventArgs e)
        {
            e.Graphics.DrawImage(imageList.Images[m_number], m_mouseX - 40, m_mouseY - 40);

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    if (m_mapTile[i, j].no == true)
                        e.Graphics.DrawImage(imageList.Images[m_mapTile[i, j].number], i * 80, j * 80);
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

        private void MainPicture_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void MainPicture_MouseDown(object sender, MouseEventArgs e)
        {
            if (m_click == true)
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
            if (m_deleteClick == true)
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
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = ".txt";
            var ret = dlg.ShowDialog();
            if (ret != DialogResult.OK)
            {
                return;
            }
            try
            {
                StreamWriter sw = new StreamWriter(dlg.FileName);
                foreach (mapTile b in m_mapTile)
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
            OpenFileDialog dlg = new OpenFileDialog();
            var ret = dlg.ShowDialog();
            if (ret != DialogResult.OK)
            {
                return;
            }
     
            try
            {
                StreamReader sr = new StreamReader(dlg.FileName);
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
        DateTime previousTime;

        int m_call = 0;
        bool m_moveEnable = true;
        int x_ = 0;
        int y_ = 0;
        private void timer_Tick(object sender, EventArgs e)
        {

            if (testButton == false) return;


            if (m_moveEnable == true)
            {

                player.update();
            }

            if (player.m_move == MOVE.IDLE)
            {
                x_ = (int)player.x;
                y_ = (int)player.y;
                if (player.preimage == MOVE.DOWN)
                    player.setImage(imageList.Images[5]);
                else if (player.preimage == MOVE.UP)
                    player.setImage(imageList.Images[8]);
                else if (player.preimage == MOVE.LEFT)
                    player.setImage(imageList.Images[11]);
                else if (player.preimage == MOVE.RIGHT)
                {

                    player.setImage(imageList.Images[14]);

                }

                m_call = 0;
                m_moveEnable = true;
            }
            else if (player.m_move == MOVE.DOWN)
            {
                if (y_ < 10)
                {
                    if (m_mapTile[x_, y_ + 1].number == 2)
                    {
                        m_moveEnable = false;
                    }
                }
                player.preimage = MOVE.DOWN;
                m_call++;
                if (m_call < 12)
                    player.setImage(imageList.Images[6]);
                else
                {
                    player.setImage(imageList.Images[7]);
                    if (m_moveEnable == false)
                    {
                        player.m_move = MOVE.IDLE;
                        player.y = player.y - 0.05f;
                    }
                }

            }
            else if (player.m_move == MOVE.UP)
            {
                if (y_ > 0)
                {
                    if (m_mapTile[x_, y_ - 1].number == 2)
                    {
                        m_moveEnable = false;
                    }
                }
                player.preimage = MOVE.UP;
                m_call++;
                if (m_call < 12)
                    player.setImage(imageList.Images[9]);
                else
                {
                    player.setImage(imageList.Images[10]);
                    if (m_moveEnable == false)
                    {
                        player.m_move = MOVE.IDLE;
                        player.y = player.y + 0.05f;
                    }
                }
            }
            else if (player.m_move == MOVE.LEFT)
            {
                if (x_ > 0)
                {
                    if (m_mapTile[x_ - 1, y_].number == 2)
                    {
                        m_moveEnable = false;
                    }
                }
                player.preimage = MOVE.LEFT;
                m_call++;
                if (m_call < 12)
                    player.setImage(imageList.Images[12]);
                else
                {
                    player.setImage(imageList.Images[13]);
                    if (m_moveEnable == false)
                    {
                        player.m_move = MOVE.IDLE;
                        player.x = player.x + 0.05f;
                    }
                }
            }
            else if (player.m_move == MOVE.RIGHT)
            {
                if (x_ < 10)
                {
                    if (m_mapTile[x_ + 1, y_].number == 2)
                    {
                        m_moveEnable = false;
                    }
                }
                player.preimage = MOVE.RIGHT;
                m_call++;
                if (m_call < 12)
                {
                    player.setImage(imageList.Images[15]);

                }
                else
                {

                    player.setImage(imageList.Images[16]);
                    if (m_moveEnable == false)
                    {
                        player.m_move = MOVE.IDLE;
                        player.x = player.x - 0.05f;
                    }
                }
            }


            MainPicture.Invalidate();
        }

        private void handleKeyDownEvent()
        {

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                //   player.update(MOVE.DOWN);
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
            if (player.m_move != MOVE.IDLE) return;
            player.m_move = MOVE.UP;
            MainPicture.Invalidate();
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            if (player.m_move != MOVE.IDLE) return;
            player.m_move = MOVE.DOWN;
            MainPicture.Invalidate();
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            if (player.m_move != MOVE.IDLE) return;
            player.m_move = MOVE.LEFT;
            MainPicture.Invalidate();
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            if (player.m_move != MOVE.IDLE) return;
            player.m_move = MOVE.RIGHT;
            MainPicture.Invalidate();
        }

        private void TestButton_Enter(object sender, EventArgs e)
        {
            upButton.Focus();
        }

        private void saveButton_Enter(object sender, EventArgs e)
        {
            upButton.Focus();
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    m_mapTile[i, j].no = false;
                    m_mapTile[i, j].x = 0;
                    m_mapTile[i, j].y = 0;
                    m_mapTile[i, j].number = 0;
                }
            }
            MainPicture.Invalidate();
        }
    }
}
