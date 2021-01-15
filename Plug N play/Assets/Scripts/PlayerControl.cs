using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    Animator anim;
    int isWalkingHash;
    int isRunningHash;

    _3Dcontrols input;

    Vector2 currentMove;
    bool movementPressed;
    bool runPressed;
    void Awake()
    {
        input = new _3Dcontrols();

        input.CharacterControls.Movement.performed += ctx =>
        {
            currentMove = ctx.ReadValue<Vector2>();
            movementPressed = currentMove.x != 0 || currentMove.y != 0;
        };
        input.CharacterControls.Movement.performed += ctx => runPressed = ctx.ReadValueAsButton();
    }
    void Start()
    {
        anim = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunningHash");
        
    }

    // Update is called once per frame
    void Update()
    {
        handleMovement();
    }
   void handleMovement()
    {
        bool isRunning = anim.GetBool(isRunningHash);
        bool isWalking = anim.GetBool(isWalkingHash);
        if  (movementPressed && !isWalking)
        {
            anim.SetBool(isWalkingHash, true);
        }
        if(!movementPressed && isWalking)
        {
            anim.SetBool(isWalkingHash, false);
        }
    }

    void OnEnable()
    {
        input.CharacterControls.Enable();
    }

    private void OnDisable()
    {
        input.CharacterControls.Disable();
    }

}
