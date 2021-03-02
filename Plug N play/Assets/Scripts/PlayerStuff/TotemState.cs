 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Jupiter
{
    public class TotemState : MonoBehaviour
    {
        GameManager Manager;
       public GameObject Totem0;
       public GameObject Totem1;
       public GameObject Cam0;
       public GameObject Cam1;


        // Start is called before the first frame update
        void Start()
        {
            Manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Manager.Climber)
            {
                Cam0.SetActive(false);
                Cam1.SetActive(true);
                Totem0.SetActive(false);
                Totem1.SetActive(true);
                Totem1.transform.position = Totem0.transform.position;
            }
        }
    }
}
