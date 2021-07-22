using System;
using System.Drawing;
public abstract class Bazna
{
    int x, y;
    int visina;
    int zdravlje;
    int napad;
    int ranjivost;
    //public abstract Bazna();
    public abstract void Crtaj(Graphics g);
    public abstract void Napadni();
    public abstract void Pomeri();
    public abstract int Ivica();
    
}
