using UnityEngine;

public class cltn : MonoBehaviour
{
    public int pntvalue;
    public bool isnegative;
    public bool ispositive;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMove pm = other.GetComponent<PlayerMove>();
            
            if (isnegative)
            {
                pm.Health -= 1;
            }
            else if (ispositive)
            {
                pm.score += 1;
            }
                Destroy(this.gameObject);
        }
    }
}
