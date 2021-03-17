using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jupiter
{
    public class warping : MonoBehaviour
    {
        public GameObject WarpPoint;
        public GameObject Player;
        public GameObject USB;


       public void Warp()
        {
            USB.SetActive(true);
            Debug.LogError("IN");
            Vector3 warpPos = WarpPoint.transform.position;
            Debug.Log(warpPos);
            Player.transform.position = warpPos;
        }

    

    }
}
