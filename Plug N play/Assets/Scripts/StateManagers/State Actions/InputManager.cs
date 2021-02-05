using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace PP
{
    public class InputManager : StateAction
    {
        _3Dcontrols input;

        PlayerStateManager s;
        Vector2 currentMove;
        bool movementPressed;
        bool runPressed;
        public InputManager(PlayerStateManager states)
        {
            s = states;
        }

        public override bool Execute()
        {

            input = new _3Dcontrols();

            input.CharacterControls.Movement.performed += ctx =>
            {
                currentMove = ctx.ReadValue<Vector2>();
                Debug.Log(currentMove);
                movementPressed = currentMove.x != 0 || currentMove.y != 0;

                //Cam.TransformCam();


            };

            s.moveAmount = currentMove;
           
            return false;

        }
    }
}
