using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatPlay : MonoBehaviour
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
        if (manager.FireTruck)
        {
            anim.Play("firetruck ladder extend");
            //if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 10f)
            //{
            //    Debug.LogError("YES");
            //}
        }


    }
}
