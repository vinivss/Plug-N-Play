using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCamera : MonoBehaviour
{
    float yawCamera;
    //public CharacterController controller;

    public float turnspeed = 15;
        Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
         yawCamera = mainCamera.transform.rotation.eulerAngles.y;
        //Vector3 Velo = controller.velocity;

        //Velo = new Vector3(controller.velocity.x, controller.velocity.y, controller.velocity.z);

        //float speed = Velo.magnitude;

        //if(speed >= 0f)
        //{

        //    Debug.Log("isread");

        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, yawCamera, 0), turnspeed * Time.fixedDeltaTime);

        //}

    }

     void Awake()
    {

        
    }
}
