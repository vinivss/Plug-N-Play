using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Jupiter
{
    public class FreeClimb : MonoBehaviour
    {
        _3Dcontrols input;
        public Animator anim;
        public bool isClimbing;

        bool inPosition;

        bool isLerping;

        float posT;

        Vector3 startPos;

        Vector3 targetPos;

        Quaternion startRot;

        Quaternion targetRot;

        public float possitionOffset;

        public float offsetfromwall = 0.3f;

        public float speed_multiplier = 0.2f;

        public float climbSpeed = 3;

        public float angledist = 1;
        public float raytomovedir = 0.7f;
        public float rotateSpeed = 5;

        Transform helper;

        float delta;

        Vector2 currentMove;

        bool movementPressed;

        float hor;

        float vert;

        public IKSnap baseiKSnap;

        public FreeClimbAnimHook a_hook;

        PlayerControl control; 

        public bool isMid;

        LayerMask ignorelayer;


        void Awake()
        {
            input = new _3Dcontrols();

            input.CharacterControls.Movement.performed += ctx =>
            {
                currentMove = ctx.ReadValue<Vector2>();
                    //Debug.Log(currentMove);
                    movementPressed = currentMove.x != 0 || currentMove.y != 0;




            };
        }
        void Start()
        {
            control = GetComponent<PlayerControl>();
            Init();
        }

        void Init()
        {
           
            helper = new GameObject().transform;
            helper.name = "climb helper";
            a_hook.Init(this, helper);
            //CheckforClimb();
            ignorelayer =~(1 <<8);
        }

        public bool CheckforClimb()
        {
           
            Vector3 origin = transform.position;

            origin.y += 0.2f;

            Vector3 dir = transform.forward;

            RaycastHit hit;
            //Debugline.singleton.SetLine(origin, dir+ origin, 5);
            if (Physics.Raycast(origin, dir, out hit, 0.3f, ignorelayer))
            {
               
                helper.position = PosWithOffset(origin, hit.point);
                InitForclimb(hit);
                return true;
            }
            return false;
        }

        void InitForclimb(RaycastHit hit)
        {


            OnEnable();
            isClimbing = true;
            a_hook.enabled = true;

            helper.transform.rotation = Quaternion.LookRotation(-hit.normal);

            startPos = transform.position;

            targetPos = hit.point + (hit.normal * offsetfromwall);

            posT = 0;

            inPosition = false;

            anim.CrossFade("climb_idle", 2);



        }

    

        public void Tick(float d_time)
        {
            this.delta = d_time;
            if (!inPosition)
            {
                GetInPosition();
                return;
            }

            if (!isLerping)
            {
                hor = currentMove.x;

                vert = currentMove.y;


                float m = Mathf.Abs(hor) + Mathf.Abs(vert);

                Vector3 h = helper.right * hor;

                Vector3 v = helper.up * vert;

                Vector3 moveDir = (h + v).normalized;
                //Debug.Log(moveDir);
                if (isMid)
                {
                    if (moveDir == Vector3.zero)
                    {
                        return;
                    }
                }

                else
                {
                    bool canMove = CanMove(moveDir);
                    //Debug.Log(canMove);
                    if (!canMove || moveDir == Vector3.zero)
                    {
                        //Debug.Log("Fuck");
                        return;
                    }
                }

                isMid = !isMid;

                posT = 0;
                isLerping = true;

                startPos = transform.position;

                Vector3 tp = helper.position - transform.position;
                float d = Vector3.Distance(helper.position, startPos) / 2;

                tp *= possitionOffset;
                tp += transform.position;
                targetPos = (isMid) ? tp : helper.position;          

                a_hook.CreatePos(targetPos, moveDir,isMid);
            }
            else
            {
                posT += delta * 3;

                if (posT > 1)
                {
                    posT = 1;

                    isLerping = false;
                }

                Vector3 clp = Vector3.Lerp(startPos, targetPos, posT);

                transform.position = clp;

                transform.rotation = Quaternion.Slerp(transform.rotation, helper.rotation, delta * rotateSpeed);

                LookForGround();
            }
        }

        void GetInPosition()
        {
            posT += delta * 3;

            if (posT > 1)
            {
                //Debug.Log("climb");
                posT = 1;
                inPosition = true;
                hor = 0;
                vert = 0;
                a_hook.CreatePos(targetPos, Vector3.zero, false);
            }

            Vector3 tarPos = Vector3.Lerp(startPos, targetPos, posT);

            transform.position = tarPos;

            transform.rotation = Quaternion.Slerp(transform.rotation, helper.rotation, delta * rotateSpeed);
        }

        Vector3 PosWithOffset(Vector3 origin, Vector3 target)
        {
            Vector3 direction = origin - target;

            direction.Normalize();

            Vector3 offset = direction * offsetfromwall;

            return target + offset;

        }

        bool CanMove(Vector3 moveDir)
        {
            Vector3 origin = transform.position;
            float dis = raytomovedir;
            Vector3 dir = moveDir;

            Debugline.singleton.SetLine(origin, origin + (dir * dis), 0);
           // Debug.DrawRay(origin, dir * dis, Color.red);

            //Raycast towards the direction you want to move
            RaycastHit hit;

            if (Physics.Raycast(origin, dir, out hit, dis))
            {
                // check if its a corner
                //Debug.LogError("Shit");
                return false;
            }

            origin += moveDir * dis;

            dir = helper.forward;

            float dis2 = angledist;

            //cast towards wall
            Debugline.singleton.SetLine(origin, origin + (dir * dis2), 1);
            Debug.DrawRay(origin, dir * dis2, Color.green);

            if (Physics.Raycast(origin, dir, out hit, dis2))
            {
                //Debug.Log("Hit");
                helper.position = PosWithOffset(origin, hit.point);
                helper.rotation = Quaternion.LookRotation(-hit.normal);
                return true;
            }
            origin = origin + (dir * dis2);
            dir = -moveDir;
            Debugline.singleton.SetLine(origin, origin + dir , 1);
            if (Physics.Raycast(origin,dir,out hit, angledist ))
            {
                helper.position = PosWithOffset(origin, hit.point);
                helper.rotation = Quaternion.LookRotation(-hit.normal);
                return true;
            }
         
           
            origin += dir * dis2;

            dir = -Vector3.up;
            Debugline.singleton.SetLine(origin, origin + dir , 2);
            Debug.DrawRay(origin, dir, Color.blue);

            if (Physics.Raycast(origin, dir, out hit, dis2))
            {
                float angle = Vector3.Angle(-helper.forward, hit.normal);
                if (angle < 40)
                {
                    helper.position = PosWithOffset(origin, hit.point);
                    helper.rotation = Quaternion.LookRotation(-hit.normal);
                    return true;
                }
            }
            return false;
        }

        void LookForGround()
        {
            Vector3 Origin = transform.position;
            Vector3 Dir = -Vector3.up;
            RaycastHit hit;

            Debugline.singleton.SetLine(Origin, Dir, 1);
            if(Physics.Raycast(Origin,Dir,out hit, raytomovedir , ignorelayer))
            {
                Debug.LogWarning("Touch ass");
                a_hook.enabled = false;
                isClimbing = false;
                currentMove.x = 0f;
                currentMove.y = 0f;
                //control.isClimbing = false;
               

                OnDisable();

                control.OpenController();
             

            }
        }
        void OnEnable()
        {
            input.CharacterControls.Enable();
        }

        void OnDisable()
        {
            input.CharacterControls.Disable();
        }

    }
    [System.Serializable]
    public class IKSnap
    {
        public Vector3 rh, lh, lf, rf;
    }
}