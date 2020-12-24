using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speedMove = 10;
    public float jumpPower = 8;
    public float healthSize = 100;
    private float gravityForce;
    private Vector3 moveVector;
    public float currentHealth;
    public GameObject healthBar;

    [SerializeField] public GameObject coin;
    [SerializeField] public Text coins;
    [SerializeField] public int coinsCount;

    private CharacterController characterController;
    private MobileController mobileController;
    private Timer timer;
    private Animator animator;


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

        if (timer.timerStart <= 0)
        {
            Application.LoadLevel("Lobby");
        }

        if (currentHealth <= 0)
        {
            Invoke("Lose", 0.5f);
        }

        if (moveVector.x == 0 || moveVector.y == 0)
        {
            animator.SetBool("Move", false);
            animator.SetBool("Walk", false);
        }

        if (moveVector.x >= 0.1 || moveVector.z >= 0.1)
        {
            animator.SetBool("Move", false);
            animator.SetBool("Walk", true);
        }

        if (moveVector.x >= 3 || moveVector.z >= 3)
        {
            animator.SetBool("Move", true);
            animator.SetBool("Walk", false);
        }

        if (characterController.isGrounded)
        {
            animator.ResetTrigger("Jump");
            animator.SetBool("Failing", false);
        }
        else
        {
            if (gravityForce < -3f)
            {
                animator.SetBool("Failing", true);
            }
        }

        

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
                coinsCount += 50;
                coins.text = "Coins:" + coinsCount.ToString();
                Destroy(coin);

                SavePlayer();
                break;
            case "Finis":
                coinsCount += 200;
                coins.text = "Coins:" + coinsCount.ToString();

                SavePlayer();
                Application.LoadLevel("Lobby");
                break;
            case "Jungle":
                Application.LoadLevel("Jungle");
                break;
        }
    }

    public void SavePlayer()
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
