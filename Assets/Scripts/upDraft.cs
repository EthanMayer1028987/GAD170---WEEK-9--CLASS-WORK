using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upDraft : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        private void OnTriggerStay(Collider other)
        {
            if(collision.gameObject.tag == "UpDraft")
        
        other.gameObject.GetComponent<Rigidbody>().AddForce(other.gameObject.transform.up * 100);
        }

    }
}
