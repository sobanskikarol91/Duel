using System;
using UnityEngine;


public static class ExtensionMethods
{
    public static Vector2 ClampMagnitudeMinMax(this Vector2 vec, float minLength, float maxLength)
    {
        float sm = vec.sqrMagnitude;
        if (sm < minLength * minLength) return vec.normalized * minLength;
        else if (sm > maxLength * maxLength) return vec.normalized * maxLength;

        return vec;
    }
}

[System.Serializable]
public class MinMax
{
    public float min;
    public float max;

    public MinMax(float min, float max)
    {
        this.min = min;
        this.max = max;
    }
}
