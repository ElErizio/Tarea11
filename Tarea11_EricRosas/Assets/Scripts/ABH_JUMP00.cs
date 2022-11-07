using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABH_JUMP00 : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        AudioManager.Instance.PlaySoundEffect();
    }
}
