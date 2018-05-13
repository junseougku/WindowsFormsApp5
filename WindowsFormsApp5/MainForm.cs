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
        public MainForm()
        {
            InitializeComponent();
            m_openImageDialog = new OpenFileDialog();
            m_openImageDialog.InitialDirectory = @"C:\";
            Init();
        }
        private void Init()
        {
            pictureBox1.Image = imageList.Images[0];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void imageAddButton_Click(object sender, EventArgs e)
        {
            //m_openImageDialog.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
           // m_openImageDialog.FilterIndex = 1;
           // m_openImageDialog.ShowDialog();


            //Image flag = new Bitmap("ground_1.png");
            Graphics flagGraphics =CreateGraphics();

           // flag = m_openImageDialog.
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
