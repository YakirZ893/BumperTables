using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AgentControl : MonoBehaviour
{

    public Transform home;
    private NavMeshAgent agentER;

    void Start()
    {
        agentER = this.GetComponent<NavMeshAgent>();
        agentER.SetDestination(home.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            agentER.enabled = false;
        }
    }
}
