using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Edgar : Toby
{
    protected override void NextDestination() {
        int oldIndex = index;
        while(oldIndex == index) {
            index = Random.Range(0, targets.Count);
        }
        agent.SetDestination(targets[index].position);
    }
}
