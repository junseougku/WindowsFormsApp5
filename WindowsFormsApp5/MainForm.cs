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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void imageAddButton_Click(object sender, EventArgs e)
        {
            m_openImageDialog.InitialDirectory = @"C:\";
            m_openImageDialog.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            m_openImageDialog.FilterIndex = 1;
            m_openImageDialog.RestoreDirectory = true;
            m_openImageDialog.ShowDialog();

        }
    }
}
