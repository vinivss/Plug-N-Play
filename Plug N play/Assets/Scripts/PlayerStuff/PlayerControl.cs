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
        bool canClimb;
        public bool isClimbing;
        public FreeClimb freeClimb;
        public _3Dcontrols input;
        GameManager manager;
        Vector2 currentMove;
        bool movementPressed;
        bool runPressed;
        Vector3 playerVelocity;
        float savedTime;
        bool climbOff;
        float climbTimer;
        public Rigidbody rigid;
        public float acceleration = 1.0f;
        float velocityZ = 0.0f;
        float velocityX = 0.0f;
        int VelocityHash;
        public float deceleration = 1.0f;
        public float maximumVelocity = 0.5f;

        int VelocityZHash;
        int VelocityXHash;
        void Awake()
        {
            Cursor.lockState = CursorLockMode.Locked;
            input = new _3Dcontrols();

            input.CharacterControls.Movement.performed += ctx =>
            {
                currentMove = ctx.ReadValue<Vector2>();
                //Debug.Log(currentMove);
                movementPressed = currentMove.x != 0 || currentMove.y != 0;

                //Cam.TransformCam();


            };

            //freeClimb = GetComponent<FreeClimb>();
            //rigid = GetComponent<Rigidbody>();
            anim = GetComponent<Animator>();
            isWalkingHash = Animator.StringToHash("isWalking");
            isRunningHash = Animator.StringToHash("isRunning");
            cameraMain = Camera.main.transform;
            manager = GameObject.Find("GameManager").GetComponent<GameManager>();
            input.CharacterControls.Run.performed += ctx => runPressed = ctx.ReadValueAsButton();
            VelocityZHash = Animator.StringToHash("VelocityZ");
            VelocityXHash = Animator.StringToHash("VelocityX");

            canClimb = manager.Climber;
            
        }


        // Update is called once per frame
        void Update()
        {
            //Debug.LogError(currentMove);
          
           


            //input.CharacterControls.Movement.performed += ctx =>
            //{
            //    currentMove = ctx.ReadValue<Vector2>();
            //    Debug.Log(currentMove);
            //    movementPressed = currentMove.x != 0 || currentMove.y != 0;

            //    Cam.TransformCam();


            //};
            //anim.SetFloat(VelocityHash, velocity);
            if (canClimb)
            {
                if (isClimbing)
                {
                    freeClimb.Tick(Time.deltaTime);
                    return;
                }

                //if (!controller.isGrounded)
                //{
                    if (!climbOff)
                    {
                        isClimbing = freeClimb.CheckforClimb();

                        if (isClimbing)
                        {

                            CloseController();
                        }
                    //}
                }
            }
                if (climbOff)
                {
                    if (Time.realtimeSinceStartup - climbTimer > 1)
                    {
                        climbOff = false;
                    }
                }
                handleMovement();
                LockorResetVelocity();
                //handleRotation();
                //if (!controller.isGrounded)
                //{
                    if (!isClimbing)
                    {
                    handleGrav();
                //}
                }
            }
        
        void handleGrav()
        {
            Debug.Log("called");
            playerVelocity.y += gravVal * Time.deltaTime;
            controller.Move(playerVelocity * Time.deltaTime);
        }
        void handleMovement()
        {

            //bool isRunning = anim.GetBool(isRunningHash);
            //bool isWalking = anim.GetBool(isWalkingHash);
            //if (movementPressed && !isWalking)
            //{

            //    anim.SetBool(isWalkingHash, true);

            //}
            //if (!movementPressed && isWalking)
            //{
            //    anim.SetBool(isWalkingHash, false);
            //}
            if (currentMove.y > 0.0f && velocityZ < maximumVelocity)
            {
                //Debug.LogError("CallForward");
                
                velocityZ += Time.deltaTime * acceleration;
                if (velocityZ < 0.05f)
                    handleRotation();
                
            }

            if(currentMove.y < 0.0f && velocityZ > -maximumVelocity)
            {
                //Debug.LogError("CallBackward");
                velocityZ -= Time.deltaTime * acceleration;
            }

            if(currentMove.x < 0.0f && velocityX > -maximumVelocity)
            {
                //Debug.LogError("CallLeft");
                velocityX -= Time.deltaTime * acceleration;

            }


            anim.SetFloat(VelocityZHash, velocityZ);
            anim.SetFloat(VelocityXHash, velocityX);


            //if ((movementPressed && runPressed) && !isRunning)
            //{
            //    anim.SetBool(isRunningHash, true);
            //}
            //if ((!movementPressed || !runPressed) && isRunning)
            //{
            //    anim.SetBool(isRunningHash, false);
            //}
           
        }

        void LockorResetVelocity() 
        {
            if (currentMove.x > 0.0f && velocityX < maximumVelocity)
            {
                velocityX += Time.deltaTime * acceleration;
            }
            if (currentMove.y == 0.0f)
            {
                //Debug.LogError("called");
                if (velocityZ < 0.0f)
                    velocityZ += Time.deltaTime * deceleration;

                if (velocityZ > 0.0f)
                    velocityZ -= Time.deltaTime * deceleration;
            }
            if (currentMove.x == 0.0f)
            {
                if (velocityX < 0.0f)
                    velocityX += Time.deltaTime * deceleration;

                if (velocityX > 0.0f)
                    velocityX -= Time.deltaTime * deceleration;
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


        public void CloseController()
        {
            OnDisable();


            controller.enabled = false;
            anim.enabled = false;
            //anim.applyRootMotion = false;
        }

        public void OpenController()
        {
            
            OnEnable();
            anim.CrossFade("Idle",0.2f);
            rigid.isKinematic = false;
            controller.enabled = true;
            isClimbing = false;
            anim.enabled = true;
            //anim.applyRootMotion = true;
            climbOff = true;
            climbTimer = Time.realtimeSinceStartup;
        }

      public IEnumerator FreezeMovement(float time)
        {
            yield return new WaitForSeconds(time);
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
}