using UnityEngine;
using System.Collections;

public class ConflictPawn : MonoBehaviour
{
    Vector3 offset = new Vector3(0, 1.106f, 0);

    public void MovePawn(int PlayerNr, int value)
    {
        Vector3 pos = value * offset;
        transform.localPosition += PlayerNr == 1 ? pos : -pos;
    }
}
