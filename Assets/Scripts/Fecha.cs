using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Fecha
{
    int segundo;
    int minuto;
    int hora;
    int año;
    public Fecha(int segundo, int minuto, int hora, int año)
    {
        while (segundo >= 60) {
            segundo -= 60;
            minuto++;
        }
        this.segundo = segundo;
        while (minuto >= 60)
        {
            minuto -= 60;
            hora++;
        }
        this.minuto = minuto;
        while (hora >= 365*24)
        {
            hora -= 365*24;
            año++;
        }
        this.hora = hora;
        this.año = año;
    }
    public int ToSeconds()
    {
        return segundo + 60 * (minuto + 60 * (hora + año * 365 * 24));
    }
    public static Fecha operator -(Fecha c1, Fecha c2)
    {
        return new Fecha(c1.segundo - c2.segundo, c1.minuto - c2.minuto, c1.hora - c2.hora, c1.año - c2.año);
    }
    public static Fecha operator +(Fecha c1, Fecha c2)
    {
        return new Fecha(c1.segundo + c2.segundo, c1.minuto + c2.minuto, c1.hora + c2.hora, c1.año + c2.año);
    }
    public static Fecha operator +(Fecha c1, int c2)
    {
        return new Fecha(c1.segundo + 1, c1.minuto, c1.hora, c1.año);
    }
    public static int operator /(Fecha c1, Fecha c2)
    {
        return c1.ToSeconds() / c2.ToSeconds();
    }
    public static bool operator >(Fecha c1, Fecha c2)
    {
        return c1.ToSeconds() > c2.ToSeconds();
    }
    public static bool operator <(Fecha c1, Fecha c2)
    {
        return c1.ToSeconds() < c2.ToSeconds();
    }
    public static bool operator ==(Fecha c1, Fecha c2)
    {
        return c1.ToSeconds() == c2.ToSeconds();
    }
    public static bool operator !=(Fecha c1, Fecha c2)
    {
        return c1.ToSeconds() != c2.ToSeconds();
    }
    public override bool Equals(object obj)
    {
        return this == (Fecha)obj;
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}

