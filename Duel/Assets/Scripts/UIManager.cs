using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] Text scoreTxt;
    [SerializeField] Text woodTxt;
    [SerializeField] Text brickTxt;
    [SerializeField] Text rockTxt;
    [SerializeField] Text papyrusTxt;
    [SerializeField] Text glassTxt;
    [SerializeField] Text moneyTxt;

    public void UpdateStats(Resources resources)
    {
        /*
        scoreTxt.text = "0";
        woodTxt.text = resources.wood.ToString();
        brickTxt.text = resources.brick.ToString();
        rockTxt.text = resources.rock.ToString();
        papyrusTxt.text = resources.papyrus.ToString();
        glassTxt.text = resources.glass.ToString();
        moneyTxt.text = resources.money.ToString();
        */
    }
}
