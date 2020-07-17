﻿using System;
using UnityEngine.AI;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class PlayerController : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;

    public ThirdPersonCharacter character;
    
    private void Start()
    {
        agent.updateRotation = false;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
           Ray ray = cam.ScreenPointToRay(Input.mousePosition);
           RaycastHit hit;

           if (Physics.Raycast(ray, out hit))
           {
               agent.SetDestination(hit.point);
           }

           if (agent.remainingDistance > agent.stoppingDistance)
           {
               character.Move(agent.desiredVelocity, false, false); 
           }
           else
           {
               character.Move(Vector3.zero, false, false);
           }
        }
    }


}

