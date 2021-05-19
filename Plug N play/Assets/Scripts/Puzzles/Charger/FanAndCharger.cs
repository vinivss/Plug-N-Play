using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanAndCharger : MonoBehaviour
{
    public GameObject Walk;
    public GameObject WalkCam;
    public GameObject usbChan;
    public GameObject ChargerSit;
    public GameManager manager;
    public Animator animfan;
    public Animator botFan;
 
    // Start is called before the first frame update
    private void Awake()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void OnTriggerEnter(Collider other)
    {
        //Debug.LogWarning("CHARGER IN");
        Walk.SetActive(false);
        WalkCam.SetActive(false);
        usbChan.SetActive(true);
        ChargerSit.SetActive(true);
        animfan.Play("fan blades spinning");
        botFan.Play("paper boat floating forward");
        manager.Fan = true;

        

    }


}
