using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AnimationStates{
	WALK,
	RUN,
	IDDLE,
}

public class chaseMinotaur : MonoBehaviour {

	public Animator animator;

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
		}


	}

	void StopAnimations(){
		animator.SetBool ("inRun", false);
		animator.SetBool ("inWalk", false);
		animator.SetBool ("inIdle", false);
	}

}﻿