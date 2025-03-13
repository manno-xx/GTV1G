using UnityEngine;
using UnityEngine.AI;

public class Wanderer : MonoBehaviour
{
    private NavMeshAgent agent;
    private Vector3 targetPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending)
        {
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                GenerateRandomTarget();
            }
        }
    }
    
    void GenerateRandomTarget()
    {
        targetPosition = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
        agent.destination = targetPosition;
    }
}
