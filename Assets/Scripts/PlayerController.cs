using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speedMove = 10;
    public float jumpPower = 8;
    public Button buttonJump;

    private float gravityForce;
    private Vector3 moveVector;

    Rigidbody player;

    private CharacterController characterController;
    private MobileController mobileController;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        mobileController = GameObject.FindGameObjectWithTag("Joystick").GetComponent<MobileController>();
    }

    // Update is called once per frame
    void Update()
    {
        CharacterMove();
        //GamingGravity();
    }
    private void OnCollisionEnter(Collision collision)
    {

    }
    void CharacterMove()
    {

        moveVector = Vector3.zero;
        moveVector.x = mobileController.Horizontal() * speedMove;
        moveVector.z = mobileController.Vertical() * speedMove;

        if (Vector3.Angle(Vector3.forward, moveVector) > 1f || Vector3.Angle(Vector3.forward, moveVector) == 0)
        {
            Vector3 direct = Vector3.RotateTowards(transform.forward, moveVector, speedMove, 0.0f);
            transform.rotation = Quaternion.LookRotation(direct);
        }
        //moveVector.y = gravityForce;
        characterController.Move(moveVector * Time.deltaTime);
    }

    //public void GamingGravity()
    //{
    //    if (!characterController.isGrounded)
    //    {
    //        gravityForce -= 20f * Time.deltaTime;
    //    }
    //    else
    //    {
    //        gravityForce = -1f;
    //    }
    //    if (characterController.isGrounded)
    //    {
    //        gravityForce = jumpPower;
    //    }
    //}
}
