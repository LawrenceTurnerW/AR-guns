using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public GameObject goal;

    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.transform.position;
    }
}