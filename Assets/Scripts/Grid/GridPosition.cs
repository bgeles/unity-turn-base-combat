using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct GridPosition 
{
    public int x;
    public int z;

    public GridPosition(int x, int z)
    {
        this.x = x;
        this.z = z;
    }

    public override string ToString()
    {
        return $"x: {x}; z: {z}";
    }
    public override int GetHashCode()
    {
        return x.GetHashCode() ^ z.GetHashCode();
    }
    public override bool Equals(object obj)
    {
        if (obj is GridPosition)
        {
            return Equals((GridPosition)obj);
        }
        return false;
    }

    public static bool operator ==(GridPosition a, GridPosition b)
    {
        return a.x == b.x && a.z == b.z;
    }

    public static bool operator !=(GridPosition a, GridPosition b)
    {
        return !(a == b);
    }

    public static GridPosition operator +(GridPosition a, GridPosition b)
    {
        return new GridPosition(a.x + b.x, a.z + b.z);
    }

    public static GridPosition operator -(GridPosition a, GridPosition b)
    {
        return new GridPosition(a.x - b.x, a.z - b.z);
    }
}
