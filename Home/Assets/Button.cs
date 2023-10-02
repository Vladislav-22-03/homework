using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject cube;
    public void ButtonPress()
    {
        if (cube.active == false)
        {
            Debug.Log("Object is deactiv");
        }
        if (cube.active == true)
        {
            Debug.Log("Object is activ");
        }
    }
    void Start()
    {
        
    }
    public void onclick()
    {
        if (cube.activeInHierarchy == true)
        {
            cube.SetActive(false);
        }
        else
        {
            cube.SetActive(true);
        }
    }
    
    void FixedUpdate()
    {
       
    }
}
