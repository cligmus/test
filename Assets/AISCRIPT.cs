using UnityEngine;
using UnityEngine.AI;
public class AISCRIPT : MonoBehaviour
{
    public Transform player;
    public float avoidRadius;
    public float patrolRadius;
    public float patrolWaitTime;

    private NavMeshAgent agent;
    public float waitTimer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        GameObject platerObject = GameObject.FindGameObjectWithTag("Player");
        player = platerObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
