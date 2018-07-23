using UnityEngine;
using System.Collections;

public class ConflictPawn : MonoBehaviour
{
    public int Point { get; private set; }
    Vector3 offset = new Vector3(0, 1.106f, 0);
    public Vector3 Position { get { return transform.position; } }

    public void MovePawn(int PlayerNr, int value)
    {
        int direction = PlayerNr == 1 ? -1 : 1;
        Point += value * direction;

        transform.localPosition += value * offset * direction;
    }
}
