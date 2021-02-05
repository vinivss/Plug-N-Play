using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
namespace PP
{
    public abstract class CharacterStateManager : StateManager
    {
        [Header ("References")]
        public Animator anim;
        public new Rigidbody rigidbody;
       
       
        public override void Init()
        {
            anim = GetComponentInChildren<Animator>();
            rigidbody = GetComponentInChildren<Rigidbody>();

        }

        public void PlayTargetAnimation(string targetAnim)
        {
            anim.CrossFade(targetAnim, 0.2f);
        }

    }
}
