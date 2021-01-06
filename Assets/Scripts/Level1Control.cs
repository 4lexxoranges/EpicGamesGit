using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Control : MonoBehaviour
{
    public GameObject rotationPlatform1;
    public GameObject rotationPlatform2;
    public GameObject rotationPlatform3;
    public GameObject rotationPlatform4;

    public float speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotationPlatform1.transform.Rotate(0, -0.2f, 0 * speed * Time.deltaTime);
        rotationPlatform2.transform.Rotate(0, 0.2f, 0 * speed * Time.deltaTime);
        rotationPlatform3.transform.Rotate(0, -0.2f, 0 * speed * Time.deltaTime);
        rotationPlatform4.transform.Rotate(0, 0.2f, 0 * speed * Time.deltaTime);
    }
}
