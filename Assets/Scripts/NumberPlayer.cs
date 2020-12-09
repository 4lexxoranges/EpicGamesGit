using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberPlayer : MonoBehaviour
{
    public GameObject playerWhite;
    public GameObject playerBlack;
    public GameObject playerBlue;
    public GameObject playerGray;
    public GameObject playerGreen;
    public GameObject playerOrange;
    public GameObject playerPink;
    public GameObject playerYellow;
    public GameObject playerPurple;
    public GameObject playerBrown;
    public GameObject playerRed;
    public GameObject playerLightGreen;
    public GameObject playerBirch;

    public int numberEquip;
    // Start is called before the first frame update
    void Start()
    {
        numberEquip = PlayerPrefs.GetInt("NumberPlayer");
    }

    // Update is called once per frame
    void Update()
    {
        if (numberEquip == 1)
        {
            playerWhite.SetActive(true);
            playerBlack.SetActive(false);
            playerBlue.SetActive(false);
            playerGray.SetActive(false);
            playerGreen.SetActive(false);
            playerOrange.SetActive(false);
            playerPink.SetActive(false);
            playerYellow.SetActive(false);
            playerPurple.SetActive(false);
            playerBrown.SetActive(false);
            playerRed.SetActive(false);
            playerLightGreen.SetActive(false);
            playerBirch.SetActive(false);
        }
        if (numberEquip == 2)
        {
            playerWhite.SetActive(false);
            playerBlack.SetActive(true);
            playerBlue.SetActive(false);
            playerGray.SetActive(false);
            playerGreen.SetActive(false);
            playerOrange.SetActive(false);
            playerPink.SetActive(false);
            playerYellow.SetActive(false);
            playerPurple.SetActive(false);
            playerBrown.SetActive(false);
            playerRed.SetActive(false);
            playerLightGreen.SetActive(false);
            playerBirch.SetActive(false);
        }
        if (numberEquip == 3)
        {
            playerWhite.SetActive(false);
            playerBlack.SetActive(false);
            playerBlue.SetActive(true);
            playerGray.SetActive(false);
            playerGreen.SetActive(false);
            playerOrange.SetActive(false);
            playerPink.SetActive(false);
            playerYellow.SetActive(false);
            playerPurple.SetActive(false);
            playerBrown.SetActive(false);
            playerRed.SetActive(false);
            playerLightGreen.SetActive(false);
            playerBirch.SetActive(false);
        }
        if (numberEquip == 4)
        {
            playerWhite.SetActive(false);
            playerBlack.SetActive(false);
            playerBlue.SetActive(false);
            playerGray.SetActive(true);
            playerGreen.SetActive(false);
            playerOrange.SetActive(false);
            playerPink.SetActive(false);
            playerYellow.SetActive(false);
            playerPurple.SetActive(false);
            playerBrown.SetActive(false);
            playerRed.SetActive(false);
            playerLightGreen.SetActive(false);
            playerBirch.SetActive(false);
        }
        if (numberEquip == 5)
        {
            playerWhite.SetActive(false);
            playerBlack.SetActive(false);
            playerBlue.SetActive(false);
            playerGray.SetActive(false);
            playerGreen.SetActive(true);
            playerOrange.SetActive(false);
            playerPink.SetActive(false);
            playerYellow.SetActive(false);
            playerPurple.SetActive(false);
            playerBrown.SetActive(false);
            playerRed.SetActive(false);
            playerLightGreen.SetActive(false);
            playerBirch.SetActive(false);
        }
        if (numberEquip == 6)
        {
            playerWhite.SetActive(false);
            playerBlack.SetActive(false);
            playerBlue.SetActive(false);
            playerGray.SetActive(false);
            playerGreen.SetActive(false);
            playerOrange.SetActive(true);
            playerPink.SetActive(false);
            playerYellow.SetActive(false);
            playerPurple.SetActive(false);
            playerBrown.SetActive(false);
            playerRed.SetActive(false);
            playerLightGreen.SetActive(false);
            playerBirch.SetActive(false);
        }
        if (numberEquip == 7)
        {
            playerWhite.SetActive(false);
            playerBlack.SetActive(false);
            playerBlue.SetActive(false);
            playerGray.SetActive(false);
            playerGreen.SetActive(false);
            playerOrange.SetActive(false);
            playerPink.SetActive(true);
            playerYellow.SetActive(false);
            playerPurple.SetActive(false);
            playerBrown.SetActive(false);
            playerRed.SetActive(false);
            playerLightGreen.SetActive(false);
            playerBirch.SetActive(false);
        }
        if (numberEquip == 8)
        {
            playerWhite.SetActive(false);
            playerBlack.SetActive(false);
            playerBlue.SetActive(false);
            playerGray.SetActive(false);
            playerGreen.SetActive(false);
            playerOrange.SetActive(false);
            playerPink.SetActive(false);
            playerYellow.SetActive(true);
            playerPurple.SetActive(false);
            playerBrown.SetActive(false);
            playerRed.SetActive(false);
            playerLightGreen.SetActive(false);
            playerBirch.SetActive(false);
        }
        if (numberEquip == 9)
        {
            playerWhite.SetActive(false);
            playerBlack.SetActive(false);
            playerBlue.SetActive(false);
            playerGray.SetActive(false);
            playerGreen.SetActive(false);
            playerOrange.SetActive(false);
            playerPink.SetActive(false);
            playerYellow.SetActive(false);
            playerPurple.SetActive(true);
            playerBrown.SetActive(false);
            playerRed.SetActive(false);
            playerLightGreen.SetActive(false);
            playerBirch.SetActive(false);
        }
        if (numberEquip == 10)
        {
            playerWhite.SetActive(false);
            playerBlack.SetActive(false);
            playerBlue.SetActive(false);
            playerGray.SetActive(false);
            playerGreen.SetActive(false);
            playerOrange.SetActive(false);
            playerPink.SetActive(false);
            playerYellow.SetActive(false);
            playerPurple.SetActive(false);
            playerBrown.SetActive(true);
            playerRed.SetActive(false);
            playerLightGreen.SetActive(false);
            playerBirch.SetActive(false);
        }
        if (numberEquip == 11)
        {
            playerWhite.SetActive(false);
            playerBlack.SetActive(false);
            playerBlue.SetActive(false);
            playerGray.SetActive(false);
            playerGreen.SetActive(false);
            playerOrange.SetActive(false);
            playerPink.SetActive(false);
            playerYellow.SetActive(false);
            playerPurple.SetActive(false);
            playerBrown.SetActive(false);
            playerRed.SetActive(true);
            playerLightGreen.SetActive(false);
            playerBirch.SetActive(false);
        }
        if (numberEquip == 12)
        {
            playerWhite.SetActive(false);
            playerBlack.SetActive(false);
            playerBlue.SetActive(false);
            playerGray.SetActive(false);
            playerGreen.SetActive(false);
            playerOrange.SetActive(false);
            playerPink.SetActive(false);
            playerYellow.SetActive(false);
            playerPurple.SetActive(false);
            playerBrown.SetActive(false);
            playerRed.SetActive(false);
            playerLightGreen.SetActive(true);
            playerBirch.SetActive(false);
        }
        if (numberEquip == 13)
        {
            playerWhite.SetActive(false);
            playerBlack.SetActive(false);
            playerBlue.SetActive(false);
            playerGray.SetActive(false);
            playerGreen.SetActive(false);
            playerOrange.SetActive(false);
            playerPink.SetActive(false);
            playerYellow.SetActive(false);
            playerPurple.SetActive(false);
            playerBrown.SetActive(false);
            playerRed.SetActive(false);
            playerLightGreen.SetActive(false);
            playerBirch.SetActive(true);
        }
    }
}
