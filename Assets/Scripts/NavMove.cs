using UnityEngine;
using UnityEngine.AI;


public class NavMove : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent agent;
    public GameObject waypoint;

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(waypoint.transform.position);
    }
}
