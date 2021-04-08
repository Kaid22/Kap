using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace kap
{
    class Kap
    {
        
        
            int x, y, a;
            public void Postavi(int x, int y, int a)
            {
                this.x = x;
                this.y = y;
                this.a = a;
            }
            public void Crtaj(Graphics g)
            {
                
                Pen pen = new Pen(Color.Blue, 3);
                SolidBrush brush = new SolidBrush(Color.Blue);
                Point A = new Point(x, y - 2 * a);
                Point B = new Point(x - a, y);
                Point C = new Point(x + a, y);

                g.DrawLine(pen,A,B);
                g.DrawLine(pen, A,C);
                PointF[] pointF = { A, B, C };
                g.FillPolygon(brush,pointF );
                g.DrawArc(pen, x-a, y-a, a*2, a*2, 0, 180);
                g.FillPie(brush, x - a, y - a, a * 2, a * 2, 0, 180);

            }
            public void Pomeri(int dy)
            {
                y += dy;
            }
        }
    }

