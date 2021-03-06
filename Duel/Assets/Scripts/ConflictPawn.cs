﻿using UnityEngine;
using System.Collections;

public class ConflictPawn : MonoBehaviour
{
    public int StandingPoint { get; private set; }
    Vector3 offset = new Vector3(0, 1.106f, 0);
    public Vector3 Position { get { return transform.position; } }

    public void Move(int value)
    {
        StandingPoint = value;
        transform.localPosition += value * offset;
        GetComponent<AudioSource>().Play();
    }
}
