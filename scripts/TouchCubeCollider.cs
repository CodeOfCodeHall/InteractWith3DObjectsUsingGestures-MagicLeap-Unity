using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchCubeCollider : MonoBehaviour
{
    // Use this for initialization
    void Start() { }

    // Update is called once per frame
    void Update() { }

    void OnCollisionEnter(Collision collision)
    {
        //change the colour of the cube
        GetComponent<Renderer>().material.color = Color.blue;
    }
}