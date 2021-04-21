using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jupiter
{
    public class CheckFloor : MonoBehaviour
    {
        public PlayerControl player;
        bool Floor;
        private void Start()
        {
      
        }
        private void Update()
        {
            if(Floor == true)
            {
               
                player.rigid.useGravity = false;
            }

            else
            {
                player.rigid.useGravity = true;
            }

        }
        private void OnTriggerEnter(Collider other)
        {
            if (!(other.tag == "Player"))
            {
                Floor = true;
            }
        }

        private void OnTriggerStay(Collider other)
        {
            if (!(other.tag == "Player"))
            {
                Floor = true;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (!(other.tag == "Player"))
            {
                Floor = false;
            }
        }


    }
}
