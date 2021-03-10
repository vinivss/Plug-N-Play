 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Jupiter
{
    public class TotemState : MonoBehaviour
    {
        GameManager Manager;
       public GameObject playerManager;
       public GameObject Totem0;
       public GameObject Totem1;
       public GameObject Cam0;
       public GameObject Cam1;
       Vector3 Playerlocation;
       public bool totem0 = true;
       public bool totem1 = false;


        // Start is called before the first frame update
        void Start()
        {
            Manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }

        // Update is called once per frame
        void Update()
        {
           if(totem0)
            {

               Playerlocation = Totem0.transform.position;
            }


           if(totem1)
            {
               Playerlocation = Totem1.transform.position;
            }

            playerManager.transform.position = Playerlocation;

            if (Manager.Climber)
            {
                Vector3 Getlocation = Totem0.transform.position;

                Totem1.transform.position = Getlocation;

                totem1 = true;
                Cam0.SetActive(false);
                Cam1.SetActive(true);
                Totem0.SetActive(false);
                Totem1.SetActive(true);

            }


        }
    }
}
