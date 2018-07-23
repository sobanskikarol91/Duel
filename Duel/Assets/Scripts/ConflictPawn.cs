using UnityEngine;
using System.Collections;

public class ConflictPawn : MonoBehaviour
{
    public int StangingPoint { get; private set; }
    Vector3 offset = new Vector3(0, 1.106f, 0);
    public Vector3 Position { get { return transform.position; } }

    public void Move(int value)
    {
        StangingPoint = value;
        transform.localPosition += value * offset;
    }
}
