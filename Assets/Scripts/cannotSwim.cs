using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannotSwim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // DROWN
    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Water")
        {
            print("You can't fucking swim.");
            Destroy(gameObject);
        }
    }

}
