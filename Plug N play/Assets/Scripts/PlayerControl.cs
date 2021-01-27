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
            Debug.Log(currentMove);
            movementPressed = currentMove.x != 0 || currentMove.y != 0;


        };


        input.CharacterControls.Run.performed += ctx => runPressed = ctx.ReadValueAsButton();
    }
    void Start()
    {
        anim = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        
    }

    // Update is called once per frame
    void Update()
    {
        handleMovement();
        //handleRotation();
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
        if ((movementPressed && runPressed)&& !isRunning)
        {
            anim.SetBool(isRunningHash, true);
        }
        if ((!movementPressed || !runPressed) && isRunning)
        {
            anim.SetBool(isRunningHash, false);
        }
    }

    //void handleRotation()
    //{
    //    Vector3 currentPosition = transform.localPosition;

    //    Vector3 newPosition = new Vector3(currentMove.x, 0, currentMove.y);

    //    Vector3 positionToLookAt = currentPosition + newPosition;

    //    transform.LookAt(positionToLookAt);
    //}
    void OnEnable()
    {
        input.CharacterControls.Enable();
    }

     void OnDisable()
    {
        input.CharacterControls.Disable();
    }

}
