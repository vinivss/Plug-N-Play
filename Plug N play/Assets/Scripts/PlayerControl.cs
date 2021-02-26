using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    public float gravVal = -9.81f;
    public CharacterCamera Cam;
    public Animator anim;
    int isWalkingHash;
    int isRunningHash;
    Transform cameraMain;
    public CharacterController controller;
 
    _3Dcontrols input;
    
    Vector2 currentMove;
    bool movementPressed;
    bool runPressed;
    Vector3 playerVelocity;
    void Awake()
    {
        input = new _3Dcontrols();

        input.CharacterControls.Movement.performed += ctx =>
        {
            currentMove = ctx.ReadValue<Vector2>();
            Debug.Log(currentMove);
            movementPressed = currentMove.x != 0 || currentMove.y != 0;
           
            //Cam.TransformCam();


        };

       
        

        input.CharacterControls.Run.performed += ctx => runPressed = ctx.ReadValueAsButton();
      
    }
    void Start()
    {
        anim = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        cameraMain = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        handleMovement();
        handleRotation();
        handleGrav();
    }
    void handleGrav()
    {
        playerVelocity.y += gravVal * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
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

    void handleRotation()
    {
        
        
        Vector3 currentPosition = transform.position;

        Vector3 newPosition = new Vector3(currentMove.x, 0, currentMove.y);

        Vector3 totmove = cameraMain.forward * newPosition.z + cameraMain.right * newPosition.y;
        totmove.y = 0;
        Vector3 positionToLookAt = (currentPosition + totmove);

        transform.LookAt(positionToLookAt);
    }
    void OnEnable()
    {
        input.CharacterControls.Enable();
        input.CameraControls.Enable();
    }

     void OnDisable()
    {
        input.CharacterControls.Disable();
        input.CameraControls.Disable();
    }

}
