using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

public static class ExtensionIEnumerable
{

    public static void Randomize<T>(this IEnumerable<T> source, Action<T> action)
    {
        foreach (var item in source)
            action(item);
    }

    public static T Random<T>(this IEnumerable<T> source)
    {
        if (source.Count() == 0) Debug.LogError("Array is empty! ");

        int index = UnityEngine.Random.Range(0, source.Count());
        return source.ElementAt(index);
    }
    /*
    public static T ReturnAndRemoveRandom<T>(this IEnumerable<T> source)
    {
        if (source.Count() == 0) Debug.LogError("List is empty! ");

        int index = UnityEngine.Random.Range(0, source.Count());
        T safe = source.ElementAt(index);
        source. (safe);
        return safe;
    }
    */
    public static T ReturnAndRemoveRandom<T>(this List<T> list)
    {
        if (list.Count == 0) Debug.LogError("List is empty! ");

        int index = UnityEngine.Random.Range(0, list.Count);
        T safe = list[index];
        list.Remove(safe);
        return safe;
    }

    public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
    {
        foreach (var item in source)
            action(item);
    }
}
