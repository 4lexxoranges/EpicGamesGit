using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
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
    public Button jump;
    public bool jumpIsPressed;
    private CharacterController characterController;
    private MobileController mobileController;
    public float currentHealth;

    enum State { Playing, Dead }

    State state = State.Playing;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = healthSize;
        characterController = GetComponent<CharacterController>();
        mobileController = GameObject.FindGameObjectWithTag("Joystick").GetComponent<MobileController>();
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
        if (state == State.Playing)
        {
            CharacterMove();
            GamingGravity();
            //Jump();

            if (currentHealth <= 0)
            {
                Lose();
            }

        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        jumpIsPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        jumpIsPressed = false;
    }

    void CharacterMove()
    {
        if (state == State.Playing)
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
    }

    public void GamingGravity()
    {
        if (state == State.Playing)
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
    }

    public void Jump(bool isPressed)
    {
        if (characterController.isGrounded)
            gravityForce = jumpPower;
    }

    void Lose()
    {
        state = State.Dead;
        Time.timeScale = 0;
        deathMenu.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
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
