using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jupiter
{
    public class WarpActivate : MonoBehaviour
    {
        public  warping Warping;
        public GameObject USB;
        public GameObject Sound;

        void OnTriggerEnter(Collider other)
        {
            Destroy(Sound);
            USB.SetActive(false);
            Warping.Warp();

        }
    }
}
