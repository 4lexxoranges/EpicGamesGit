﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Control : MonoBehaviour
{
    public GameObject rotationObject;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotationObject.transform.Rotate(0, 1, 0 * speed * Time.deltaTime);
    }
}
