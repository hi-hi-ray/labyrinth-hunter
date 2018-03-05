using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public enum AnimationStates{
	WALK,
	RUN,
	IDDLE,
    SHOUT,
    ATTACK,
}

public class AnimationMinos : MonoBehaviour {

    public Animator anim;
    public Transform player;
    public Vector3 destination;
    public NavMeshAgent agent;

    void Start()
    {
        PlayAnimationIddle();
        agent = GetComponent<NavMeshAgent>();
        destination = agent.destination;
    }

    void Update()
    {
        if (Vector3.Distance(destination, player.position) > 1.0f)
        {
            destination = player.position;
            agent.destination = destination;
            PlayAnimationWalk();
        }
    }

    public void PlayAnimationIddle()
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
    }


    
}﻿