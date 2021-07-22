using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int zid = 4000;
        List<Prasinar> prasinari = new List<Prasinar>();
        List<Bugar> bugari = new List<Bugar>();
        List<Gmaz> gmazovi = new List<Gmaz>();

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        int sirina;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grafika = e.Graphics;
            Pen olovka = new Pen(Color.Black);
            SolidBrush bojica = new SolidBrush(Color.Maroon);
            int visina = ClientRectangle.Height;
            sirina = ClientRectangle.Width/10;
            int d = visina / 20;
            //zid
            grafika.FillRectangle(bojica, ClientRectangle.Width - sirina, 0, sirina, visina);
            grafika.DrawRectangle(olovka, ClientRectangle.Width - sirina, 0, sirina, visina);
            int x = ClientRectangle.Width - (sirina / 2);
            for (int i = 0; i <= 20; i++)
            {
                grafika.DrawLine(olovka, x, 2 * i * d, x, 2 * i * d + d);
                grafika.DrawLine(olovka, ClientRectangle.Width - sirina, i * d, ClientRectangle.Width, i * d);
            }
            //kula
            bojica = new SolidBrush(Color.DarkOliveGreen);
            grafika.FillRectangle(bojica, 0, 5 * d, 2 * sirina, visina - 5 * d);
            grafika.DrawRectangle(olovka, 0, 5 * d, 2 * sirina, visina - 5 * d);
            int delta =sirina *2 /9;
            int r = 0;
            for (int i = 0; i < 5; i++)
            {
                if (i == 4)
                    r = sirina * 2 % 9;
                grafika.FillRectangle(bojica, 2 * i * delta, 4 * d, delta + r, d);
                grafika.DrawRectangle(olovka, 2 * i * delta, 4 * d, delta + r, d);
            }
            //za prasinare
            Prasinar p;
            for (int i = 0; i < prasinari.Count; i++)
            {
                p = prasinari.ElementAt(i);
                if (p.Zdravlje() <= 0)
                    prasinari.RemoveAt(i); //brisemo ako su mrtvi
                else if (p.Ivica() >= 9 * sirina)
                {
                    p.Napadni();
                    zid -= p.Napad(); //napada ako je dodirnuo zid
                }
            }
            //za bugare
            Bugar b;
            for (int i = 0; i < bugari.Count; i++)
            {
                b = bugari.ElementAt(i);
                if (b.Zdravlje() <= 0)
                    bugari.RemoveAt(i); //brisemo ako su mrtvi
                else if (b.Ivica() >= 9 * sirina)
                {
                    b.Napadni();
                    zid -= b.Napad(); //napada ako je dodirnuo zid
                }
            }
            //za gmazove
            Gmaz g;
            for (int i = 0; i < gmazovi.Count; i++)
            {
                g = gmazovi.ElementAt(i);
                if (g.Zdravlje() <= 0)
                    gmazovi.RemoveAt(i); //brisemo ako su mrtvi
                if (g.Ivica() >= 9 * sirina)
                {
                    g.Napadni();
                    zid -= g.Napad(); //napada ako je dodirnuo zid
                }
            }
            foreach (var prasinar in prasinari)
            {
                prasinar.Crtaj(grafika);
            }
            foreach (var bugar in bugari)
            {
                bugar.Crtaj(grafika);
            }
            foreach (var gmaz in gmazovi)
            {
                gmaz.Crtaj(grafika);
            }

            lbZid.Text = zid.ToString();
            //tbZid.Text = zid.ToString();
            if (zid <= 0)
            {
                prasinari.Clear();
                bugari.Clear();
                gmazovi.Clear();
                zid = 4000;
                lbZid.Text = zid.ToString();

                MessageBox.Show("Pobedio si! Zid je srusen");
                
            }
        }

        private void btnKreni_Click(object sender, EventArgs e)
        {
            if (rbPrasinar.Checked)
                prasinari.Add(new Prasinar());
            else if (rbBugar.Checked)
                bugari.Add(new Bugar());
            else if (rbGmaz.Checked)
                gmazovi.Add(new Gmaz());
            Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var prasinar in prasinari)
            {
                prasinar.Pomeri();
            }
            foreach (var bugar in bugari)
            {
                bugar.Pomeri();
            }
            foreach (var gmaz in gmazovi)
            {
                gmaz.Pomeri();
            }
            Refresh();
        }

    }
}
