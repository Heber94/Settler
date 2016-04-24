using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;




/// <summary>
/// Se utiliza para guardar la fecha del juego
/// </summary>
public class Fecha
{
    public int segundo;
    public int minuto;
    public int hora;
    public int dia;
    public int año;
    public Fecha(int segundo, int minuto, int hora, int año)
    {
        int dia = 0;
        while (segundo >= 60)
        {
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
        while (hora >= 24)
        {
            hora -= 24;
            dia++;
        }
        this.hora = hora;
        while (dia >= 365)
        {
            dia -= 365;
            año++;
        }
        this.dia = dia;
        this.año = año;
    }
    public Fecha(int segundo, int minuto, int hora, int dia, int año)
    {
        while (segundo >= 60)
        {
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
        while (hora >= 24)
        {
            hora -= 24;
            dia++;
        }
        this.hora = hora;
        while (dia >= 365)
        {
            dia -= 365;
            año++;
        }
        this.dia = dia;
        this.año = año;
    }
    public ulong ToSeconds()
    {
        return (ulong)(segundo + 60 * (minuto + 60 * (hora + año * 365 * 24)));
    }
    override public String ToString()
    {
        return año.ToString("0000") + " - " + dia.ToString("000") + "\n" + hora.ToString("00") + ":" + minuto.ToString("00") + ":" + segundo.ToString("00");
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
        return new Fecha(c1.segundo + 1, c1.minuto, c1.hora, c1.dia, c1.año);
    }
    public static int operator /(Fecha c1, Fecha c2)
    {
        return (int)(c1.ToSeconds() / c2.ToSeconds());
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

