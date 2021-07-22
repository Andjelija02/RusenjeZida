using System;

public class Gmaz:Bazna
{
	public Gmaz()
	{
        x = 190;
        y = 435;
        visina = 180;
        a = visina / 9;
        zdravlje = 300;
        napad = 30;
        ranjivost = 15;
	}
    public override void Crtaj (Graphics g)
    {
        Pen p = new Pen(Color.Black, 3);
        g.DrawLine(p, x + a, y, x + 3 * a / 2, y - 3 * a); //leva noga
        g.DrawLine(p, x + 3*a, y, x + 5 * a / 2, y - 3 * a); //desna noga
        g.DrawLine(p, x, y - 4 * a, x, y - 7 * a); //leva ruka
        g.DrawLine(p, x + 4 * a, y - 4 * a, x + 4 * a, y - 7 * a); //desna ruka
        g.DrawElipse(p, x + a, y - 9 * a, 2 * a, 2 * a); // glava
        SolidBrush b = new SolidBrush(Color.DarkOliveGreen);
        g.FillPolygon(b, new Point[]{new Point{X=x,Y=y-7*a}, new Point{X=x + 4*a,Y=y-7*a},
                new Point{X=x+3*a,Y=y-3*a}, new Point{X=x+a,Y=y-3*a}}); //trup boja
        g.DrawPolygon(p, new Point[]{new Point{X=x,Y=y-7*a}, new Point{X=x + 4*a,Y=y-7*a},
                new Point{X=x+3*a,Y=y-3*a}, new Point{X=x+a,Y=y-3*a}}); //trup ivice
        g.FillPolygon(b, new Point[]{new Point{X=x + 2*a,Y=y - 9*a - a/2},
                new Point{X=x+a,Y=y-8*a - a/2}, new Point{X=x + 3*a,Y=y - 8*a - a/2}}); //sesir
    }
    public override void Napadni(){
        zdravlje -= ranjivost;
        x -= 69;
    }
    public override void Pomeri()
    {
        x += 23;
    }
}
