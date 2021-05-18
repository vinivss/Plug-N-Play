using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pianomitai : MonoBehaviour
{
    public GameManager manager;
    public GameObject monkemitai;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(manager.PianoDone)
        {
            monkemitai.SetActive(true);
        }
    }
}
