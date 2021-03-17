using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jupiter
{
    public class WarpActivate : MonoBehaviour
    {
        public  warping Warping;
        public GameObject USB;

        void OnTriggerEnter(Collider other)
        {
            USB.SetActive(false);
            Warping.Warp();

        }
    }
}
