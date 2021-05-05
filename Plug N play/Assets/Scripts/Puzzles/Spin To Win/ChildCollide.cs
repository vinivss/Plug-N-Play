using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Squid {

    public class ChildCollide : MonoBehaviour
    {

        // Start is called before the first frame update
        [HideInInspector]public UnityEvent ChildTouch;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            ChildTouch.Invoke();
        }


    }
}
