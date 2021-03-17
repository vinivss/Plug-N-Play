using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

namespace Jupiter
{
    public class Racered : MonoBehaviour
    {
        public PathCreator Redcar;
        public EndOfPathInstruction end;
        public float speed;
        float dstTravelled;
        bool Move;

        GameManager gameManager;
        // Start is called before the first frame update

        private void Start()
        {
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); 
        }
        private void Update()
        {
            if (gameManager.CarReady)
            {
               
                dstTravelled += speed * Time.deltaTime;
                transform.position = Redcar.path.GetPointAtDistance(dstTravelled, end);
                transform.rotation = Redcar.path.GetRotationAtDistance(dstTravelled, end);
            }

        }
    }
}
