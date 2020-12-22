using System.Collections;
using UnityEngine;

public class TransformControl : MonoBehaviour
{
    public GameObject coin;
    public GameObject enemyGround;

    public float transformSpeed;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        enemyGround.transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * transformSpeed);
        coin.transform.Rotate(new Vector3(90, 0, 0) * Time.deltaTime);
    }
}
