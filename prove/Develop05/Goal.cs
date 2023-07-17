using System;
using System.Collections.Generic;

public abstract class Goal
{
    public string description;
    public int value;

    public Goal(string description, int value)
    {
        this.description = description;
        this.value = value;
    }

    public abstract void Complete();
    public abstract string Progress();
}