using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

public static class ExtensionIEnumerable
{
    public static void Shuffle<T>(this List<T> list)
    {
        System.Random random = new System.Random();

        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    public static void Shuffle<T>(this T[] _array)
    {
        System.Random random = new System.Random();

        int n = _array.Length;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            T value = _array[k];
            _array[k] = _array[n];
            _array[n] = value;
        }
    }

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

    public static List<T> RemoveAndGetRange<T>(this List<T> list, int origin, int count)
    {
        List<T> removedList = new List<T>();

        for (int i = 0; i < count; i++)
        {
            T removed = RemoveAndGetItem(list, origin);
            removedList.Add(removed);
        }
        return removedList;
    }

    public static T RemoveAndGetItem<T>(this IList<T> list, int iIndexToRemove)
    {
        var item = list[iIndexToRemove];
        list.RemoveAt(iIndexToRemove);
        return item;
    }
}
