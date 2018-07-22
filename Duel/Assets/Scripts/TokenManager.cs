using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TokenManager : MonoBehaviour
{
    [SerializeField]  Sprite[] tokens;
    [SerializeField] SpriteRenderer[] tokenPositions;


    public void Init()
    {
        tokens.Shuffle();
        int i = 0;
        tokenPositions.ForEach(t => t.sprite = tokens[i++]);
    }

    void SetRandomTokens()
    {
        //  tokensPrefabs
    }
}
