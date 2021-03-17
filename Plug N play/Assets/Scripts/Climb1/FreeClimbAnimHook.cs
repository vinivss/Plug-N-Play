using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jupiter
{


    public class FreeClimbAnimHook : MonoBehaviour
    {

        Animator anim;
        IKSnap iKB;
        IKSnap current = new IKSnap();
        IKSnap next = new IKSnap();
        IKGoals goals = new IKGoals();

        public float w_rh;

        public float w_lh;

        public float w_lf;

        public float w_rf;

        public float wallOffset = 0;

        Vector3 rh, lh, rf, lf;
        Vector3 prevMovDir;
        Transform h;

        bool isMirror;
        bool isLeft;
        float delta;
        public float lerpSpeed = 5;
        public void Init(FreeClimb c, Transform helper)
        {
            anim = c.anim;

            iKB = c.baseiKSnap;

            h = helper;
        }
        public void CreatePos(Vector3 origin, Vector3 moveDir, bool isMid)
        {
          
            delta = Time.deltaTime;
            HandleAnim(moveDir, isMid);
           

            if (!isMid)
            {
                UpdateGoals(moveDir);
                prevMovDir = moveDir;
            }
            else
            {
                UpdateGoals(prevMovDir);
            }
            IKSnap ik = CreateSnap(origin);
            CopySnapshot(ref current, ik);

          
            //UpdateIKPosition(AvatarIKGoal.LeftFoot, current.lf);
            //UpdateIKPosition(AvatarIKGoal.RightFoot, current.rf);
            //UpdateIKPosition(AvatarIKGoal.LeftHand, current.lh);
            //UpdateIKPosition(AvatarIKGoal.RightHand, current.rh);


            SetIKPosition(isMid, goals.lf, current.lf, AvatarIKGoal.LeftFoot);
            SetIKPosition(isMid, goals.rf, current.rf, AvatarIKGoal.RightFoot);
            SetIKPosition(isMid, goals.lh, current.lh, AvatarIKGoal.LeftHand);
            SetIKPosition(isMid, goals.rh, current.rh, AvatarIKGoal.RightHand);

            UpdateIKWeight(AvatarIKGoal.LeftFoot, 1);
            UpdateIKWeight(AvatarIKGoal.RightFoot, 1);
            UpdateIKWeight(AvatarIKGoal.LeftHand, 1);
            UpdateIKWeight(AvatarIKGoal.RightHand, 1);


        }
         void UpdateGoals(Vector3 moveDir)
        {
            isLeft = (moveDir.x <= 0);

            if (moveDir.x != 0)
            {
                goals.lh = isLeft;
                goals.rf = !isLeft;
                goals.lf = isLeft;
                goals.rh = !isLeft;
            }
            else
            {
                bool isEnabled = isMirror;
                if(moveDir.y < 0)
                {
                    isEnabled =!isEnabled;
                }
                goals.lh = isEnabled;
                goals.rf = !isEnabled;
                goals.lf = isEnabled;
                goals.rh = !isEnabled;
            }



        }

        void HandleAnim(Vector3 moveDir,  bool isMid)
        {
            if(isMid)
            {
                if(moveDir.y !=0)
                {
                    if (moveDir.x == 0)
                    {
                        isMirror = !isMirror;
                        anim.SetBool("ismirror", isMirror);
                    }
                    else
                    {


                        if (moveDir.y < 0)
                        {
                            isMirror = (moveDir.x > 0);
                            anim.SetBool("ismirror", isMirror);
                        }
                        else
                        {
                            isMirror = (moveDir.x<0) ;
                            anim.SetBool("ismirror", isMirror);
                        }
                    }
                    anim.CrossFade("climb_up", 0.2f);

                }

            }
            else
            {
                anim.CrossFade("climb_idle", 0.2f);
            }
        }
        public IKSnap CreateSnap(Vector3 o)
        {
            IKSnap r = new IKSnap();

            //r.lh = LocalToWorld(iKB.lh);

            Vector3 _lh = LocalToWorld(iKB.lh);
            r.lh = GetPosActual(_lh, AvatarIKGoal.LeftHand);

            Vector3 _rh = LocalToWorld(iKB.rh);
            //r.rh = LocalToWorld(iKB.rh);
            r.rh = GetPosActual(_rh, AvatarIKGoal.RightHand);

            //r.lf = LocalToWorld(iKB.lf);

            Vector3 _lf = LocalToWorld(iKB.lf);

            r.lf = GetPosActual(_lf, AvatarIKGoal.LeftFoot);

            //r.rf = LocalToWorld(iKB.rf);

            Vector3 _rf = LocalToWorld(iKB.rf);

            r.rf = GetPosActual(_rf, AvatarIKGoal.RightFoot);

            return r;
        }

        Vector3 GetPosActual(Vector3 o,AvatarIKGoal goal)
        {
            Vector3 r = o;
            Vector3 origin = o;
            Vector3 dir = h.forward;

            origin += -(dir * 0.2f);
            RaycastHit hit;
            bool ishit = false;
            if(Physics.Raycast(origin,dir, out hit, 1.5f))
            {
                Vector3 _r = hit.point + (hit.normal * wallOffset);

                r = _r;

                ishit = true;

                if(goal == AvatarIKGoal.LeftFoot ||goal == AvatarIKGoal.RightFoot)
                {
                    if (hit.point.y > transform.position.y - 0.1f)
                    {
                        ishit = false;
                    }
                }
            }

            if(!ishit)
            {
                switch(goal)
                {
                    case AvatarIKGoal.LeftFoot:
                        r = LocalToWorld(iKB.lf);
                        break;
                    case AvatarIKGoal.RightFoot:
                        r = LocalToWorld(iKB.rf);
                        break;
                    case AvatarIKGoal.LeftHand:
                        r = LocalToWorld(iKB.lh);
                        break;
                    case AvatarIKGoal.RightHand:
                        r = LocalToWorld(iKB.rh);
                        break;

                    default:
                        break;

                }
               
            }
            return r;

        }

        Vector3 LocalToWorld(Vector3 p)
        {
            Vector3 r = h.position;

            r += h.right * p.x;

            r += h.forward * p.z;

            r += h.up * p.y;

            return r;
        }

        public void CopySnapshot(ref IKSnap to, IKSnap from)
        {
            to.rh = from.rh;
            to.lh = from.lh;
            to.lf = from.lf;
            to.rf = from.rf;
            
        }
      
        void SetIKPosition(bool isMid, bool isTrue, Vector3 pos, AvatarIKGoal goal)
        {
            if (isMid)
            {
                Vector3 p = GetPosActual(pos, goal);
                if (isTrue)
                {

                    UpdateIKPosition(goal, p);

                }
                else
                {
                    if(goal == AvatarIKGoal.LeftFoot || goal == AvatarIKGoal.RightFoot)
                    {
                        if(p.y > transform.position.y -0.25f)
                        {
                            UpdateIKPosition(goal, p);
                        }
                    }
                }
            }
            else
            {
                if (!isTrue)
                {
                    Vector3 p = GetPosActual(pos, goal);
                    UpdateIKPosition(goal, p);

                }
            }
            
        }
        public void UpdateIKPosition(AvatarIKGoal goal, Vector3 pos)
        {
            switch(goal)
            {
                case AvatarIKGoal.LeftFoot:
                    lf = pos;
                    break;

                case AvatarIKGoal.RightFoot:
                    rf = pos;
                    break;

                case AvatarIKGoal.LeftHand:
                    lh = pos;
                    break;
                case AvatarIKGoal.RightHand:
                    rh = pos;
                    break;

                default:
                    break;
            }
        }

        public void UpdateIKWeight(AvatarIKGoal goal, float w)
        {
            switch (goal)
            {
                case AvatarIKGoal.LeftFoot:
                    w_lf = w;
                    break;

                case AvatarIKGoal.RightFoot:
                    w_rf = w;
                    break;

                case AvatarIKGoal.LeftHand:
                    w_lh = w;
                    break;
                case AvatarIKGoal.RightHand:
                    w_rh = w;
                    break;

                default: 
                    break;
            }
        }
         void OnAnimatorIK()
        {
            delta = Time.deltaTime;
            SetIKpos(AvatarIKGoal.LeftHand, lh, w_lh);
            SetIKpos(AvatarIKGoal.RightHand, rh, w_rh);
            SetIKpos(AvatarIKGoal.LeftFoot, lf, w_lf);
            SetIKpos(AvatarIKGoal.RightFoot, rf, w_rf);
        }

        void SetIKpos(AvatarIKGoal goal, Vector3 tp, float w )
        {
            IKStates ikState = GetIKState(goal);
            if(ikState == null)
            {
                ikState = new IKStates();
                ikState.goal = goal;
                ikstates.Add(ikState);
            }
            if (w == 0)
            {
                ikState.isSet = false;

            }
            if(!ikState.isSet)
            {
                ikState.position = GoalToBodyBones(goal).position;
                ikState.isSet = true;
            }

            ikState.positionWeight = w;
            ikState.position = Vector3.Lerp(ikState.position, tp, delta * lerpSpeed);
            anim.SetIKPositionWeight(goal, ikState.positionWeight);
            anim.SetIKPosition(goal, ikState.position);
        }
 
        Transform GoalToBodyBones(AvatarIKGoal goal)
        {
            switch (goal)
            {
                case AvatarIKGoal.LeftFoot:
                    return anim.GetBoneTransform(HumanBodyBones.LeftFoot);

                case AvatarIKGoal.RightFoot:
                    return anim.GetBoneTransform(HumanBodyBones.RightFoot);
                 
                case AvatarIKGoal.LeftHand:
                    return anim.GetBoneTransform(HumanBodyBones.LeftHand);

                default:
                case AvatarIKGoal.RightHand:
                    return anim.GetBoneTransform(HumanBodyBones.RightHand);    


            }
        }
       
        IKStates GetIKState(AvatarIKGoal goal)
        {
            IKStates r = null;
            foreach(IKStates i in ikstates)
            {
                if(i.goal == goal)
                {
                    r = i;
                    break;
                }
            }
            return r;
        }
        List<IKStates> ikstates = new List<IKStates>();

        class IKStates
        {
            public AvatarIKGoal goal;
            public Vector3 position;
            public float positionWeight;
            public bool isSet = false;
        }
    }
    public class IKGoals
    {
        public bool rh;
        public bool lh;
        public bool rf;
        public bool lf;
    }
}
