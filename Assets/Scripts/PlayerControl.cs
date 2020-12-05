using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    float playerVert;
    float playerHor;
    float jump;
    public float playerSpeed = 7;
    public float jumpSpeed = 20;
    public bool isGround;
    public float sensHor = 9.0f;
    public void Start()
    {
        Cursor.visible = false;
    }
    public void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGround = true;
        }
    }
    public void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGround = false;
        }
    }
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * sensHor, 0);
        if (isGround)
        {
            playerVert = Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed;
            playerHor = Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed;
            jump = Input.GetAxis("Jump") * Time.deltaTime * jumpSpeed;
            GetComponent<Rigidbody>().AddForce(transform.up * jump, ForceMode.Impulse);
        }
        transform.Translate(new Vector3(playerHor, 0, playerVert));
    }
}
