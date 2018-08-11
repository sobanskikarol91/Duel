using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Guild", menuName = "Card/Guild")]
public class Guild : Card
{
    Guild()
    {
        Type = CARD_TYPE.GUILD;
    }
}
