using UnityEngine;

public class lvlmanager : MonoBehaviour
{
    public GameObject LevelSelectButton;
    public GameObject RosterMenuButton;

    public GameObject MainMenuButtons;

    public GameObject Backbutton_rosteredit;
    public GameObject Backbutton_levelselect;
    public GameObject characterEdit;

    public GameObject Stagelevelmenu;
    public GameObject [] StageMenuButton;
    public GameObject [] RosterElementsButton;
    public void LevelSelectBTN()
    {
        //logic1
        MainMenuButtons.gameObject.SetActive(false);
        //logic2
        for (int i = 0; i < StageMenuButton.Length; i++)
        {

            StageMenuButton[i].gameObject.SetActive(true);
        }
        //logic3
        Backbutton_levelselect.gameObject.SetActive(true);
    }
    public void RosterSelectBTN()
    {
        //logic1
        characterEdit.SetActive(true);
        MainMenuButtons.gameObject.SetActive(false);
        //logic2
        for (int i = 0; i < RosterElementsButton.Length; i++)
        {

            RosterElementsButton[i].gameObject.SetActive(true);
        }
    }
    public void Backbtn_Rosteredit()
    {
        //logic1
        characterEdit.gameObject.SetActive(false);
        //locic2
        MainMenuButtons.gameObject.SetActive(true);
        //logic3
        Backbutton_levelselect.gameObject .SetActive(false);
    }
    public void Backbtn_levelselect()
    {
        Stagelevelmenu.SetActive(false);
        MainMenuButtons.gameObject.SetActive(true);
    }
    
}
