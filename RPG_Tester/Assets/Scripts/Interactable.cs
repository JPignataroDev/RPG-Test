using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Interactable : MonoBehaviour
{
    [HideInInspector]
    public NavMeshAgent playerAgent;
    private bool hasInteracted;

    /// <summary>
    /// Take Player to Interactable Object, Before Interacting.
    /// </summary>
    public virtual void MoveToInteraction(NavMeshAgent playerAgent)
    {
        hasInteracted = false;
        this.playerAgent = playerAgent;

        playerAgent.stoppingDistance = 2.5f;
        playerAgent.destination = this.transform.position;


        Interact();
       
    }


    private void Update()
    {
        if(playerAgent != null && !playerAgent.pathPending)
        {
            if(!hasInteracted && playerAgent.remainingDistance <= playerAgent.stoppingDistance)
            {
                Interact();
                hasInteracted = true;
            }
        }
    }

    /// <summary>
    /// Base Interaction Function.
    /// </summary>
    public virtual void Interact()
    {
        Debug.Log("Interacting with Base Class");
    }

}
