using UnityEngine;

[System.Serializable]
public class Round
{
    [SerializeField] Age[] ages = new Age[3];
    int roundNr = 0;

    void SetRandomCardsOnSlots(int nr)
    {
        ages[nr].slots.ForEach(t => t.Card = ages[nr].cards.ReturnAndRemoveRandom());
        Debug.Log(roundNr); ;
    }

    public void StartNextRound()
    {
        SetRandomCardsOnSlots(roundNr);
        roundNr++;
    }
}
