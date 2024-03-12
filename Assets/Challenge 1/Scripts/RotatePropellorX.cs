using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropellorX : MonoBehaviour
{
    public GameObject propellor;
    public float rotationSpeed = 15.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, rotationSpeed);
    }
}
