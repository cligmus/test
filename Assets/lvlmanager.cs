using UnityEngine;

public class lvlmanager : MonoBehaviour
{
    public GameObject LevelSelectButton;
    public GameObject RosterMenuButton;
    public GameObject [] StageMenuButton;
    public GameObject [] RosterElementsButton;
    public void LevelSelectBTN()
    {
        //logic1
        LevelSelectButton.gameObject.SetActive(false);
        RosterMenuButton.gameObject.SetActive(false);
        //logic2
        for (int i = 0; i < StageMenuButton.Length; i++)
        {

            StageMenuButton[i].gameObject.SetActive(true);
        }
        //logic3
    }
    public void RosterSelectBTN()
    {
        //logic1
        LevelSelectButton.gameObject.SetActive(false);
        RosterMenuButton.gameObject.SetActive(false);
        //logic2
        for (int i = 0; i < RosterElementsButton.Length; i++)
        {

            RosterElementsButton[i].gameObject.SetActive(true);
        }
    }
}
