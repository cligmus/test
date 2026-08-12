using UnityEngine;

public class objstats : MonoBehaviour
{
    public int objCH;
    public int objMH;
    public float speed;
    public float damage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objCH = objMH;
    }

    // Update is called once per frame
    void Update()
    {
        objCH = Mathf.Clamp(objCH, 0, objMH);
    }
}
