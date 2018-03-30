using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

/*public enum AnimationStates{
	WALK,
	RUN,
	IDDLE,
    SHOUT,
    ATTACK,
}*/

public class AnimationMinos : MonoBehaviour {


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


    /*public void PlayAnimationIddle()
    {
        StopAnimations();
        anim.SetBool("inIdle", true);
    }

    public void PlayAnimationWalk()
    {
        StopAnimations();
        anim.SetBool("inWalk", true);
    }

    public void PlayAnimationRun()
    {
        StopAnimations();
        anim.SetBool("inRun", true);
    }

    public void PlayAnimationShout()
    {
        StopAnimations();
        anim.SetBool("inShout", true);
    }

    public void PlayAnimationAttack()
    {
        StopAnimations();
        anim.SetBool("inAttack", true);
    }

    private void StopAnimations()
    {
        anim.SetBool("inRun", false);
        anim.SetBool("inWalk", false);
        anim.SetBool("inIdle", false);
        anim.SetBool("inShout", false);
        anim.SetBool("inAttack", false);
    }*/


    
}﻿