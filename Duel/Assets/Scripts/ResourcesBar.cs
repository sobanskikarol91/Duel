using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResourcesBar : MonoBehaviour
{
    public Text wood;
    public Text brick;
    public Text rock;
    public Text glass;
    public Text papyrus;
    public Text gold;

    public void UpdateBar()
    {
        Resources _res = GameManager.instance._CurrentPlayer.GetResources();

        wood.text = _res.wood.ToString();
        brick.text = _res.brick.ToString();
        rock.text = _res.rock.ToString();
        glass.text = _res.glass.ToString();
        papyrus.text = _res.papyrus.ToString();
        gold.text = _res.gold.ToString();
    }
}
