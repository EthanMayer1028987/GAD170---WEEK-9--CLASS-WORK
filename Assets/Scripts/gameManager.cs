using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject WaterBall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(WaterBall, Vector3(-0.543567657,12.6800003,-10.9148951) Quaternion.identity);
    }
}
