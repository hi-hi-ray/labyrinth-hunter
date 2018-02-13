using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AnimationStates{
	WALK,
	RUN,
	IDDLE,
    SHOUT,
    ATTACK,
}

public class AnimationMinos : MonoBehaviour {

	public Animator animator;
    private AudioScript audioMino = new AudioScript();

    public void PlayAnimation (AnimationStates statesAnimation) {

		switch (statesAnimation) {
		    case AnimationStates.IDDLE:
			    {
				    StopAnimations ();
				    animator.SetBool ("inIdle", true);
			    }
			    break;
		    case AnimationStates.WALK:
			    {
				    StopAnimations ();
				    animator.SetBool ("inWalk", true);
			    }
			    break;
		    case AnimationStates.RUN:
			    {
				    StopAnimations ();
				    animator.SetBool ("inRun", true);
			    }
			    break;
            case AnimationStates.SHOUT:
			    {
                    StopAnimations();
                    animator.SetBool("inShout", true);
                    audioMino.PlayMinoSFX4();
                }
                break;
            case AnimationStates.ATTACK:
			    {
                    StopAnimations();
                    animator.SetBool("inAttack", true);
                }
			    break;
		}
    }

	void StopAnimations(){
		animator.SetBool ("inRun", false);
		animator.SetBool ("inWalk", false);
		animator.SetBool ("inIdle", false);
        animator.SetBool("inShout", false);
        animator.SetBool("inAttack", false);
    }

}﻿