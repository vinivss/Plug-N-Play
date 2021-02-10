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
        public float rotateSpeed = 5;

        Transform helper;

        float delta;

        Vector2 currentMove;

        bool movementPressed;

        float hor;

        float vert;

        public IKSnap baseiKSnap;

        public FreeClimbAnimHook a_hook;


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
            Init();
        }

        void Init()
        {
            helper = new GameObject().transform;
            helper.name = "climb helper";
            a_hook.Init(this, helper);
            CheckforClimb();
        }

        public void CheckforClimb()
        {
            Vector3 origin = transform.position;

            origin.y += 1.4f;

            Vector3 dir = transform.forward;

            RaycastHit hit;

            if (Physics.Raycast(origin, dir, out hit, 5))
            {
                helper.position = PosWithOffset(origin, hit.point);
                InitForclimb(hit);
            }
        }

        void InitForclimb(RaycastHit hit)
        {
            isClimbing = true;



            helper.transform.rotation = Quaternion.LookRotation(-hit.normal);

            startPos = transform.position;

            targetPos = hit.point + (hit.normal * offsetfromwall);

            posT = 0;

            inPosition = false;

            anim.CrossFade("climb_idle", 2);



        }

        void Update()
        {
            delta = Time.deltaTime;

            Tick(delta);
        }

        public void Tick(float delta)
        {
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

                bool canMove = CanMove(moveDir);
                //Debug.Log(canMove);
                if (!canMove || moveDir == Vector3.zero)
                {
                    //Debug.Log("Fuck");
                    return;
                }

                posT = 0;
                isLerping = true;

                startPos = transform.position;

                //Vector3 tp = helper.position - transform.position;

                targetPos = helper.position;

                a_hook.CreatePos(targetPos);
            }
            else
            {
                posT += delta * climbSpeed;

                if (posT > 1)
                {
                    posT = 1;

                    isLerping = false;
                }

                Vector3 clp = Vector3.Lerp(startPos, targetPos, posT);

                transform.position = clp;

                transform.rotation = Quaternion.Slerp(transform.rotation, helper.rotation, delta * rotateSpeed);
            }
        }

        void GetInPosition()
        {
            posT += delta;

            if (posT > 1)
            {
                //Debug.Log("climb");
                posT = 1;
                inPosition = true;

                a_hook.CreatePos(targetPos);



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
            float dis = possitionOffset;
            Vector3 dir = moveDir;

            Debug.DrawRay(origin, dir * dis, Color.red);

            RaycastHit hit;

            if (Physics.Raycast(origin, dir, out hit, dis))
            {
                //Debug.LogError("Shit");
                return false;
            }

            origin += moveDir * dis;

            dir = helper.forward;

            float dis2 = angledist;

            Debug.DrawRay(origin, dir * dis2, Color.green);

            if (Physics.Raycast(origin, dir, out hit, dis))
            {
                //Debug.Log("Hit");
                helper.position = PosWithOffset(origin, hit.point);
                helper.rotation = Quaternion.LookRotation(-hit.normal);
                return true;
            }

            origin += dir * dis2;

            dir = -Vector3.up;

            Debug.DrawRay(origin, dir, Color.blue);

            if (Physics.Raycast(origin, dir, out hit, dis2))
            {
                float angle = Vector3.Angle(helper.up, hit.normal);
                if (angle < 40)
                {
                    helper.position = PosWithOffset(origin, hit.point);
                    helper.rotation = Quaternion.LookRotation(-hit.normal);
                    return true;
                }
            }
            return false;
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