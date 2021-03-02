using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
namespace Jupiter
{
    public class PlayerControl : MonoBehaviour
    {
        public float gravVal = -9.81f;
        public CharacterCamera Cam;
        public Animator anim;
        int isWalkingHash;
        int isRunningHash;
        Transform cameraMain;
        public CharacterController controller;

        public bool isClimbing;
        public  FreeClimb freeClimb;
        _3Dcontrols input;

        Vector2 currentMove;
        bool movementPressed;
        bool runPressed;
        Vector3 playerVelocity;
        //bool climbOff;
        float climbTimer;
        Rigidbody rigid;
      
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
            rigid = GetComponent<Rigidbody>();
            anim = GetComponent<Animator>();
            isWalkingHash = Animator.StringToHash("isWalking");
            isRunningHash = Animator.StringToHash("isRunning");
            cameraMain = Camera.main.transform;
        }

        // Update is called once per frame
        void Update()
        {
            //if (isClimbing)
            //{
            //    freeClimb.Tick(Time.deltaTime);
            //    return; 
            //}

            //if(controller.isGrounded)
            //{
            //    if (!climbOff)
            //    {
            //        isClimbing = freeClimb.CheckforClimb();

            //        if (isClimbing)
            //        {

            //            CloseController();
            //        }
            //    }
            //}
            //if(climbOff)
            //{
            //    if(Time.realtimeSinceStartup-climbTimer>1)
            //    {
            //        climbOff = false;
            //    }
            //}
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

            //bool isRunning = anim.GetBool(isRunningHash);
            bool isWalking = anim.GetBool(isWalkingHash);
            if (movementPressed && !isWalking)
            {

                anim.SetBool(isWalkingHash, true);

            }
            if (!movementPressed && isWalking)
            {
                anim.SetBool(isWalkingHash, false);
            }
            //if ((movementPressed && runPressed) && !isRunning)
            //{
            //    anim.SetBool(isRunningHash, true);
            //}
            //if ((!movementPressed || !runPressed) && isRunning)
            //{
            //    anim.SetBool(isRunningHash, false);
            //}
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

        public void CloseController()
        {
            OnDisable();
            rigid.isKinematic = true;
            controller.enabled = false;
            //anim.enabled = false;
        }

        public void OpenController()
        {
            
            OnEnable();
            rigid.isKinematic = false;
            controller.enabled = true;
            //anim.enabled = true;
            //climbOff = true;
            climbTimer = Time.realtimeSinceStartup;
        }
        void OnEnable()
        {
            input.CharacterControls.Enable();
            //input.CameraControls.Enable();
        }

        void OnDisable()
        {
            input.CharacterControls.Disable();
            input.CameraControls.Disable();
        }

    }
}