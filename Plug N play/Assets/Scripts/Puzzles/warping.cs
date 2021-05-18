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
        public GameObject CamUSB;
        public GameObject CamCar;
        public GameObject Warpingdetection;


        public void Warp()
        {
            
            //Debug.LogError("IN");
            Vector3 warpPos = WarpPoint.transform.position;
            
            USB.transform.position = WarpPoint.transform.position;
            USB.SetActive(true);
            CamCar.SetActive(false);
            CamUSB.SetActive(true);
            Destroy(Warpingdetection);
            
        }

    

    }
}
