using UnityEngine;

public class RotateControl : MonoBehaviour
{
    public GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coin.transform.Rotate(new Vector3(90, 0, 0) * Time.deltaTime);
    }
}
