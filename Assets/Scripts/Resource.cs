﻿using UnityEngine;
using System.Collections;

public class Resource
{

    private int amount = 0;
    private string type;

    public Resource(string type, int amount)
    {
        this.amount = amount;
        this.type = type;
    }

    public void setAmount(int newAmount)
    {
        this.amount = newAmount;
    }

    public int getAmount()
    {
        return this.amount;
    }

    public void substractAmount(int substraction)
    {
        this.amount -= substraction;
    }

    public void addAmount(int addition)
    {
        this.amount += addition;
    }

    public string getName()
    {
        return this.type;
    }

    public void setName(string name)
    {
        this.type = name;
    }
    override public string ToString()
    {
        return amount.ToString("0000");
    }
}
