using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResourcesBar : MonoBehaviour
{
    GameManager gm;

    public void Init()
    {
        gm = GameManager.instance;
    }

    public Text wood;
    public Text brick;
    public Text rock;
    public Text glass;
    public Text papyrus;
    public Text gold;

    public void UpdateBar()
    {
        Price r = gm._CurrentPlayer.Resources;

        wood.text = r.wood.ToString();
        brick.text = r.brick.ToString();
        rock.text = r.rock.ToString();
        glass.text = r.glass.ToString();
        papyrus.text = r.papyrus.ToString();
        gold.text = r.gold.ToString();
    }
}
