using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FerrisWheelPlay : MonoBehaviour
{
    GameManager manager;
    public Animator anim;
    // Start is called before the first frame update
    void Awake()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {   if (manager.FerrisWheel)
        {
            anim.Play("ferris wheel spin_dipped carriages");
        }
    }
}
