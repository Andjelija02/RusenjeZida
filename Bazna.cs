using System;

public abstract class Bazna
{
    abstract int x, y;
    abstract int visina;
    abstract int zdravlje;
    abstract int napad;
    abstract int ranjivost;
	public abstract Bazna()
	{
	}
    public abstract void Crtaj();
    public abstract void Napadni();
    public abstract void Pomeri();
}
