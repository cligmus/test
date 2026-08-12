using System.Collections;
using UnityEngine;

public class cltn : MonoBehaviour
{
    public float cd;
    private float timer;
    public Rigidbody rb;
    public bool isOnCooldown;
    public int minCd, maxCd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.isKinematic = false;
        isOnCooldown = false;
        cd = Random.Range(5, 10);
    }

    // Update is called once per frame
    void Update()
    {
        cd -= Time.deltaTime;
        if ((cd <= 0))
        {
            rb.isKinematic = true;
            rb.isKinematic = false;
            cd = Random.Range(minCd, maxCd);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if ((other.CompareTag("unit")||other.CompareTag("Player")) && isOnCooldown)
        {          
            StartCoroutine(DisableKinematics());
        }
    }
    IEnumerator DisableKinematics()
    {
        yield return new WaitForSeconds(2);

    }
}
