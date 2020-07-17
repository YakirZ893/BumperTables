using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AgentControlTest : MonoBehaviour
{

    public Vector3 home = new Vector3(4.77f,3.005f, 13.5f);
    private NavMeshAgent agentER;
    
    [SerializeField] float delay = 15.5f;

    void Start()
    {
        agentER = this.GetComponent<NavMeshAgent>();
        agentER.SetDestination(home);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            agentER.enabled = false;
            
            GameObject.Find("EnemySpawn").GetComponent<GenarteEnemies>().enemyCount -= 1;
            
            Object.Destroy(gameObject, delay);
        }
    }
}
