using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
namespace PP
{
    public class PlayerStateManager : CharacterStateManager
    { 
        [Header("inputs")]
        _3Dcontrols input;
        public Vector2 moveAmount;
        //public float moveAmount;
        public Vector3 rotateDirection;
        public override void Init()
        {
            base.Init();

            State locomotion = new State(
                new List<StateAction>() // fixed up
                {
                    new InputManager(this),
                },

                new List<StateAction>()// up
                {

                },
                new List<StateAction>()//late up
                {

                }

                                        );


            RegisterState("locomotion", locomotion);

            ChangeState("locomotion");


        }

       private void FixedUpdate()
        {
            base.FixedTick();
        }

        private void Update()
        {
            base.Tick();
        }
        private void LateUpdate()
        {
            base.LateTick();
        }
    }
}
