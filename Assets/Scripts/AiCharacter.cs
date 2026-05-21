using UnityEngine;
using UnityEngine.AI;

public class AiCharacter : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Transform goal;

    private void Start()
    {
        InvokeRepeating("UpdateDestination", 0.5f, 0.5f);
    }

    void UpdateDestination()
    {
        agent.SetDestination(goal.position);
    }

    private void Update()
    {
        if (Vector3.Distance(goal.position, transform.position) < 1f)
        {
            //attaack player?
        }
    }
}
