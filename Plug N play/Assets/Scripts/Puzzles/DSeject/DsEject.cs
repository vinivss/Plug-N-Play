using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DsEject : MonoBehaviour
{
    public Animator anim;
    GameManager manager;
    public GameObject coin;
    BoxCollider trigger;
    public bool Boolamitai;
    public GameObject Canvasimg;

    private void Awake()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        trigger = coin.GetComponent<BoxCollider>();
    }
  

    // Update is called once per frame
    void Update()
    {
        if (manager.DSEject)
        {
            DestroyImmediate(Canvasimg);
            if (!Boolamitai)
            {
                Boolamitai = true;
                trigger.enabled = true;
            }
            anim.Play("coin popping out of ds");
            
           
            //if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 10f)
            //{
            //    Debug.LogError("YES");
            //}
        }

    }
}
