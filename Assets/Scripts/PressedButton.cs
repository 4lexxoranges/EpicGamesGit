using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PressedButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField]
    PlayerController playerController;
    bool isPressed;
    public enum Movement
    {
        Jump
    }

    public Movement movementDirection;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!isPressed)
            return;
        if (movementDirection == Movement.Jump)
            playerController.Jump(isPressed);

    }
    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
}
