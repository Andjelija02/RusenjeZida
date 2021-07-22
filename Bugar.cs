using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Bugar:Prasinar
{
    public Bugar()
    {
            x = 190;
            y = 435;
            visina = 140;
            a = visina / 7;
            zdravlje = 100;
            napad = 20;
            ranjivost = 20;
    }
    public override void Crtaj(Graphics g){
        //drska noza
        g.DrawLine(p, x + 2 * a + a / 2, y - 4 * a - a / 2, x + 2 * a + a / 2, y - 4 * a - a / 4);
        g.DrawLine(p, x + 2 * a + a / 2, y - 4 * a - a / 4, x + 3 * a, y - 5 * a);
        //glava noza
        SolidBrush b = new SolidBrush(Color.Gray);
        g.FillPolygon(b, new Point[]{new Point{X=x+11*a/4,Y=y-5*a-3*a/4},new Point{X=x+13*a/4,Y=y-3*a-3*a/4},
                                     new Point{X=x+4*a,Y=y-6*a}});
        g.DrawPolygon(p, new Point[]{new Point{X=x+11*a/4,Y=y-5*a-3*a/4},new Point{X=x+13*a/4,Y=y-3*a-3*a/4},
                                     new Point{X=x+4*a,Y=y-6*a}});
    }
}
