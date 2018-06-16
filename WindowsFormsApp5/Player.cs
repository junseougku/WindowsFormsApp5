using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp5
{
    class Player
    {
        Image m_image;
        protected RectangleF m_rect;
        public void Init(Image _image)
        {
            m_image = _image;
        }

        public void Draw(PaintEventArgs e)
        {
           
        }
    }
}
