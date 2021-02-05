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

        Vector3 rh, lh, rf, lf;

        Transform h;
        public void Init(FreeClimb c, Transform helper)
        {
            anim = c.anim;

            iKB = c.baseiKSnap;

            h = helper;
        }

        public IKSnap CreateSnap(Vector3 o)
        {
            IKSnap r = new IKSnap();
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
         void OnAnimatorIK()
        {
            
        }
    }
}
