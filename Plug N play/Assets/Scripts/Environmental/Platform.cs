using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject Player;

    private void OnTriggerStay(Collider other)
    {
        Debug.LogError("Hell");
        other.transform.parent = gameObject.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.LogError("Hell");
        other.transform.parent = transform;
    }
}
