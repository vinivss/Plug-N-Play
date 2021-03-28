using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject Player;
    //public GameObject platform;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            Debug.LogWarning("Hell");
        other.transform.parent = transform;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.LogWarning("Hell no");
            Player.transform.parent = null;
        }
    }
}
