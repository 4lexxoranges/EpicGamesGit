using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speedMove = 10;
    public float jumpPower = 8;
    public float healthSize = 100;
    private float gravityForce;
    private Vector3 moveVector;
    public GameObject healthBar;
    public GameObject deathMenu;

    [SerializeField] public GameObject coin;
    [SerializeField] public Text coins;
    [SerializeField] public int coinsCount;

    private CharacterController characterController;
    private MobileController mobileController;
    private Animator animator;
    public float currentHealth;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = healthSize;
        characterController = GetComponent<CharacterController>();
        mobileController = GameObject.FindGameObjectWithTag("Joystick").GetComponent<MobileController>();
        animator = GetComponent<Animator>();

        if (PlayerPrefs.HasKey("coinsFinal"))
        {
            coinsCount = PlayerPrefs.GetInt("coinsFinal");
        }
        else
        {
            coinsCount = 0;
        }
        coins.text = "Coins: " + coinsCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        CharacterMove();
        GamingGravity();
        if (moveVector.x != 0 || moveVector.z != 0)
        {
            animator.SetBool("Move", true);
        }
        else
        {
            animator.SetBool("Move", false);
        }

        if (currentHealth <= 0)
        {
            Invoke("Lose", 0.5f);
        }


    }


    void CharacterMove()
    {
        animator.ResetTrigger("Jump");
        animator.SetBool("Failing", false);

        moveVector = Vector3.zero;
        moveVector.x = mobileController.Horizontal() * speedMove;
        moveVector.z = mobileController.Vertical() * speedMove;

        if (Vector3.Angle(Vector3.forward, moveVector) > 1f || Vector3.Angle(Vector3.forward, moveVector) == 0)
        {
            Vector3 direct = Vector3.RotateTowards(transform.forward, moveVector, speedMove, 0.0f);
            transform.rotation = Quaternion.LookRotation(direct);
        }

        moveVector.y = gravityForce;
        characterController.Move(moveVector * Time.deltaTime);


    }

    public void GamingGravity()
    {
        if (!characterController.isGrounded)
        {
            gravityForce -= 20f * Time.deltaTime;
        }
        else
        {
            gravityForce = -1f;
        }

        if (gravityForce <= -3f)
        {
            animator.SetBool("Failing", true);
        }
    }

    public void Jump(bool isPressed)
    {
        if (characterController.isGrounded)
        {
            gravityForce = jumpPower;
            animator.SetTrigger("Jump");
        }
    }

    void Lose()
    {
        Application.LoadLevel("Lobby");
    }

    public void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Enemy":
                currentHealth -= 100;
                break;
            case "Coin":
                coinsCount += 100;
                coins.text = "Coins:" + coinsCount.ToString();
                Destroy(coin);

                SavePlayer();
                break;
            case "FloorIsLava":
                Application.LoadLevel("Floor Is Lava");
                break;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {

        }

    }
    void SavePlayer()
    {
        PlayerPrefs.SetInt("coinsFinal", coinsCount);
    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    switch (collision.gameObject.tag)
    //    {
    //        //case "Enemy":
    //        //    break;
    //    }
    //}
}
