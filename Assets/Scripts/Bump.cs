using System;
using UnityEngine;
using UnityEngine.AI;

public class Bump : MonoBehaviour
{
    [SerializeField] private float force = 50f;
    public CameraShake cameraShake;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            this.gameObject.GetComponent<NavMeshAgent>().enabled = false;
            Vector3 dir = (collision.gameObject.transform.position - transform.position).normalized;
            collision.gameObject.GetComponent<Rigidbody>().AddForceAtPosition(dir * force, collision.contacts[0].point);
        }
        
        StartCoroutine(cameraShake.Shake(cameraShake.magnitude, 6f));
    }

    private void Update()
    {
       
    }
}
