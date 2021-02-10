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

        public float w_rh;

        public float w_lh;

        public float w_lf;

        public float w_rf;

        public float wallOffset = 0;

        Vector3 rh, lh, rf, lf;

        Transform h;

        bool isMirror;
        bool isLeft;

        public void Init(FreeClimb c, Transform helper)
        {
            anim = c.anim;

            iKB = c.baseiKSnap;

            h = helper;
        }
        public void CreatePos(Vector3 origin, Vector3 moveDir, bool isMid)
        {
            HandleAnim(moveDir, isMid);
            IKSnap ik = CreateSnap(origin);
            CopySnapshot(ref current, ik);

            UpdateIKPosition(AvatarIKGoal.LeftFoot, current.lf);
            UpdateIKPosition(AvatarIKGoal.RightFoot, current.rf);
            UpdateIKPosition(AvatarIKGoal.LeftHand, current.lh);
            UpdateIKPosition(AvatarIKGoal.RightHand, current.rh);

            UpdateIKWeight(AvatarIKGoal.LeftFoot, 1);
            UpdateIKWeight(AvatarIKGoal.RightFoot, 1);
            UpdateIKWeight(AvatarIKGoal.LeftHand, 1);
            UpdateIKWeight(AvatarIKGoal.RightHand, 1);


        }
         void UpdateGoals(Vector3 moveDir)
        {
            isLeft = (moveDir.x <= 0);

            if(moveDir.x != 0)
            {

            }

        }

        void HandleAnim(Vector3 moveDir,  bool isMid)
        {
            if(isMid)
            {
                if(moveDir.y !=0)
                {
                    if(moveDir.y < 0)
                    {

                    }
                    else
                    {

                    }
                    isMirror = !isMirror;
                    anim.SetBool("mirror", isMirror);
                    anim.CrossFade("climb_up", 0.2f);

                }

            }
            else
            {
                anim.CrossFade("Ledge_Idle_Together", 0.2f);
            }
        }
        public IKSnap CreateSnap(Vector3 o)
        {
            IKSnap r = new IKSnap();
            //r.lh = LocalToWorld(iKB.lh);

            Vector3 _lh = LocalToWorld(iKB.lh);
            r.lh = GetPosActual(_lh);

            Vector3 _rh = LocalToWorld(iKB.rh);
            //r.rh = LocalToWorld(iKB.rh);
            r.rh = GetPosActual(_rh);

            //r.lf = LocalToWorld(iKB.lf);
            Vector3 _lf = LocalToWorld(iKB.lf);

            r.lf = GetPosActual(_lf);

            //r.rf = LocalToWorld(iKB.rf);

            Vector3 _rf = LocalToWorld(iKB.rf);

            r.rf = GetPosActual(_rf);

            return r;
        }

        Vector3 GetPosActual(Vector3 o)
        {
            Vector3 r = o;
            Vector3 origin = o;
            Vector3 dir = h.forward;

            origin += -(dir * 0.2f);
            RaycastHit hit;
            if(Physics.Raycast(origin,dir, out hit, 1.5f))
            {
                Vector3 _r = hit.point + (hit.normal * wallOffset);

                r = _r;
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
            SetIKpos(AvatarIKGoal.LeftHand, lh, w_lh);
            SetIKpos(AvatarIKGoal.RightHand, rh, w_rh);
            SetIKpos(AvatarIKGoal.LeftFoot, lf, w_lf);
            SetIKpos(AvatarIKGoal.RightFoot, rf, w_rf);
        }

        void SetIKpos(AvatarIKGoal goal, Vector3 tp, float w )
        {
            anim.SetIKPositionWeight(goal, w);
            anim.SetIKPosition(goal, tp);
        }
    }
}
