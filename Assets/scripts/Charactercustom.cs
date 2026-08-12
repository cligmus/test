using UnityEngine;
using System.Collections.Generic;
using System;
using UnityEngine.Events;
using UnityEngine.UI;
public class Charactercustom : MonoBehaviour
{


    [Header("Hair)")]
    public List<GameObject> hairObjects;
    public Button HLbtn;
    public Button HRbtn;
    [Header("Face)")]
    public List<GameObject> faceObjects;
    public Button FLbtn;
    public Button FRbtn;
    [Header("Body)")]
    public List<GameObject> bodyObjects;
    public Button BLbtn;
    public Button BRbtn;


    private int hairIndex;
    private int faceIndex;
    private int bodyIndex;

    private void Start()
    {
        ShowSelected(hairObjects, hairIndex);
        ShowSelected(faceObjects, faceIndex);
        ShowSelected(bodyObjects, bodyIndex);
    }
    private void OnEnable()
    {
        HLbtn?.onClick.AddListener(NextHair);
        HRbtn?.onClick.AddListener(PreviousHair);

        FLbtn?.onClick.AddListener(NextFace);
        FRbtn?.onClick.AddListener(PreviousFace);

        BLbtn?.onClick.AddListener(NextBody);
        BRbtn?.onClick.AddListener(PreviousBody);

    }
    public void NextHair()
    {
        ChangePart(hairObjects, ref hairIndex, 1);
    }
    public void PreviousHair()
    {
        ChangePart(hairObjects, ref hairIndex, -1);
    }
    public void NextFace()
    {
        ChangePart(faceObjects, ref faceIndex, 1);
    }
    public void PreviousFace()
    {
        ChangePart(faceObjects, ref faceIndex, -1);
    }
    public void NextBody()
    {
        ChangePart(bodyObjects, ref bodyIndex, 1);
    }
    public void PreviousBody()
    {
        ChangePart(bodyObjects, ref bodyIndex, -1);
    }
    private void ChangePart(List<GameObject> objects, ref int index, int direction)
    {
        index = (index + direction + objects.Count) % objects.Count;
        ShowSelected(objects, index);
    }
    private void ShowSelected(List<GameObject> objects, int selectedIndex)
    {
        for (int i = 0; 1 < objects.Count; i++)
        {
            objects[i].SetActive(i == selectedIndex);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }



}
