using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication15;

namespace WindowsFormsApplication15
{
    public class Prasinar:Bazna
    {
        int x, y, visina,zdravlje,napad,ranjivost;
        int a;
        public Prasinar()
        {
            x = 190;
            y = 435;
            visina = 140;
            a = visina / 7;
            zdravlje = 100;
            napad = 10;
            ranjivost = 20;
        }
        public override void Crtaj(Graphics g)
        {
            Pen p = new Pen(Color.Black, 3);
            g.DrawLine(p, x, y, x + a, y - 2 * a); //leva noga
            g.DrawLine(p, x + 2 * a, y, x + a, y - 2 * a); //desna noga
            g.DrawLine(p, x + a, y - 2 * a, x + a, y - 5 * a); //trup
            g.DrawLine(p, x, y - 2 * a, x + a, y - 4 * a); //leva ruka
            g.DrawLine(p, x + a, y - 4 * a, x + 3 * a, y - 5 * a); //desna ruka
            g.DrawEllipse(p, x, y - 7 * a, 2 * a, 2 * a); //glava
            SolidBrush b = new SolidBrush(Color.DarkOliveGreen);
            g.FillPolygon(b, new Point[]{new Point{X=x,Y=y-6*a - a/2},
                new Point{X=x+a,Y=y-7*a - a/2}, new Point{X=x+2*a,Y=y-6*a - a/2}}); //sesir
            
        }
        public override void Napadni(){
            zdravlje -= ranjivost;
            x = x - 143;
        }
        public override void Pomeri()
        {
            x += 11;
        }
        public override int Ivica()
        {
            return x + 3 * a;
        }
        public int Zdravlje()
        {
            return zdravlje;
        }
        public int Napad()
        {
            return napad;
        }
    }
}
