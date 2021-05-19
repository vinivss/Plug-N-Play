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
       public GameObject Totem2;
       Vector3 Playerlocation;
       public bool totem0 = true;
       public bool totem1 = false;
       public bool totem2 = false;

       public PlayerControl player;
       public FreeClimb FC;


        // Start is called before the first frame update
        void Start()
        {
            Manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }

        // Update is called once per frame
        void Update()
        {
          
        }

        public void ChangeStateClimb()
        {

            totem1 = true;
            Totem1.SetActive(true);
            player.StartCoroutine(player.FreezeMovement(3));
          
        }
      

            public void ChangeStateUSBC()
        {
            totem2 = true;
            Totem2.SetActive(true);
            player.StartCoroutine(player.FreezeMovement(3));

        }
    }
}
