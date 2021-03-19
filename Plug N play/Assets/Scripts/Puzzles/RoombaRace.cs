using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoombaRace : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    GameManager manager;
 



    void Awake()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    public void Update()
    {
        if (manager.RoombaReady)
        {

            anim.Play("roomba pushing shoebox");
            //if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 10f)
            //{
            //    Debug.LogError("YES");
            //}
        }


    }
}

