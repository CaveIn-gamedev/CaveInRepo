using UnityEngine;
using UnityEngine.AI;

public class NavMeshFollow : MonoBehaviour
{
    public Transform target; // Drag your target object here in the Inspector
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>(); // Get the NavMeshAgent component
        if (navMeshAgent == null)
        {
            Debug.LogError("NavMeshAgent component not found on this GameObject.");
            enabled = false; // Stop the script from running if NavMeshAgent is missing
            return;
        }
    }

    void Update()
    {
        if (navMeshAgent != null && target != null)
        {
            navMeshAgent.SetDestination(target.position); // Set the NavMeshAgent's destination to the target's position
        }
    }
}