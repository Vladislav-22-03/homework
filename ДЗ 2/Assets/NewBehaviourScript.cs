using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviou : MonoBehaviour
{

    public Text x;
    public int life = 6;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        x.text = life.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        life--;
        x.text = life.ToString();
    }
}
