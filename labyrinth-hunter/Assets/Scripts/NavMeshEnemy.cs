using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class NavMeshEnemy : MonoBehaviour {

    [SerializeField]
    Transform _destination;

    //public Animator anim;
    NavMeshAgent _navMeshAgent;

    // Use this for initialization
    void Start ()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        
        if(_navMeshAgent == null)
        {
            Debug.LogError("The nav mesh agent component is not attached to " + gameObject.name);
        }	
        else
        {
            SetDestination();
        }
	}

    void Update()
    {
        SetDestination();
    }

    private void SetDestination()
    {
        if(_destination != null)
        {
            Vector3 targetVector = _destination.transform.position;
            _navMeshAgent.SetDestination(targetVector);
        }
    }
}﻿