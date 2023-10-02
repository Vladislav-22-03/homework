using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class on : MonoBehaviour
{
    public GameObject cube;
    void Start()
    {
        
    }


    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("Object is activ");
            cube.SetActive(true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Object is deactiv");
            cube.SetActive(false);
        }
    }
}
