using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private float yAxis;
    private float xAxis;
    public float rotationVelocity = 8f;

    public Transform target;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yAxis += Input.GetAxis("Mouse X") * rotationVelocity;
        xAxis -= Input.GetAxis("Mouse Y") * rotationVelocity;

        Vector3 targetRotation = new Vector3(xAxis, yAxis);
        transform.eulerAngles = targetRotation;

        transform.position = target.position - transform.forward * 6f;
    }
}
