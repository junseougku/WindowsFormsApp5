using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

enum MOVE{IDLE,  DOWN , UP, RIGHT, LEFT}

namespace WindowsFormsApp5
{
    class Player
    {
        public MOVE m_move;
        Image m_image;
        public float x, y;
        public float destx;
        public float desty;
        public void Init(Image _image)
        {
            m_image = _image;
            x = 0.0f; ;
            y = 0.0f;
            m_move = MOVE.IDLE;
        }

        public void Draw(PaintEventArgs e)
        {
            e.Graphics.DrawImage(m_image, x*80.0f, y*80.0f);
        }
        public void setPosition(float _x, float _y)
        {
            x = _x;
            y = _y;
        }
        public void update()
        {
            if (m_move == MOVE.IDLE)
            {
                destx = x;
                desty = y;
            }
            else if(m_move == MOVE.DOWN)
            {
                y += 0.05f;
                if (desty +1.0f >= y)
                    m_move = MOVE.DOWN;
                else
                    m_move = MOVE.IDLE;
            }
            else if(m_move == MOVE.LEFT)
            {
                x = x - 1.0f;
            }
            else if(m_move == MOVE.RIGHT)
            {
                x = x + 1.0f;
            }
            else if(m_move == MOVE.UP)
            {
                y = y - 1.0f;
            }
            
        }
    }
}
