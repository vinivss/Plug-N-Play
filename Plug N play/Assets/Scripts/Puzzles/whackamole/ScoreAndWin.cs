using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class ScoreAndWin : MonoBehaviour
    {
        
        private int Scre = 0;
        // Start is called before the first frame update
        void Start()
        {
          
        }
        public void Score()
        {
            Scre += 1;
            
            Destroy(gameObject);



        }
    }

