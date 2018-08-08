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

    delegate int Resources(PRODUCE type);

    public void UpdateBar()
    {
        Resources playerResources = gm._CurrentPlayer.GetResourceAmount;

        wood.text = playerResources(PRODUCE.WOOD).ToString();
        brick.text = playerResources(PRODUCE.BRICK).ToString();
        rock.text = playerResources(PRODUCE.ROCK).ToString();
        glass.text = playerResources(PRODUCE.GLASS).ToString();
        papyrus.text = playerResources(PRODUCE.PAPYRUS).ToString();
    }
}
