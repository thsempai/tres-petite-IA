using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Toby : MonoBehaviour
{
    public List<Transform> targets = new List<Transform>();
    protected int index = -1;

    protected NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        NextDestination();
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance <= agent.stoppingDistance) {
            NextDestination();
        } 
    }

    protected virtual void NextDestination() {
        index = (index + 1)  % targets.Count;
        agent.SetDestination(targets[index].position);
    }
}
