using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jupiter
{

    public class RaceBlue : MonoBehaviour
    {
        public Animator anim;
        GameManager manager;
        GameObject Brain;



        void Awake()
        {
            manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }
        public void Update()
        {
            if (manager.BlueCarMove)
            {
                anim.Play("CarMove");
                //if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 10f)
                //{
                //    Debug.LogError("YES");
                //}
            }

         
        }
    }
}
