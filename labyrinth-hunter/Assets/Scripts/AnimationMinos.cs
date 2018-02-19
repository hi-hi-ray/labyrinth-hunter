using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    void Start()
    {
        //How quickly you want your character to move there
        PlayAnimationIddle();
    }

    // Update is called once per frame
    void Update()
    {
        PlayAnimationShout();
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