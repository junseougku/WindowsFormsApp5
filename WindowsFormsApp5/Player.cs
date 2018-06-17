using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

enum MOVE{  DOWN , UP, RIGHT, LEFT}

namespace WindowsFormsApp5
{
    class Player
    {
        Image m_image;
        public int x, y;
        public void Init(Image _image)
        {
            m_image = _image;
            x = 0; ;
            y = 0;
        }

        public void Draw(PaintEventArgs e)
        {
            e.Graphics.DrawImage(m_image, x, y);
        }
        public void setPosition(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public void update(MOVE _move)
        {
            if(_move == MOVE.DOWN)
            {
                y++;
            }
        }
    }
}
