using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopControl : MonoBehaviour
{
    public GameObject playerWhite;
    public GameObject playerBlack;
    public GameObject playerBlue;
    public GameObject playerGray;
    public GameObject playerGreen;
    public GameObject playerOrange;
    public GameObject playerPink;
    public GameObject playerPurple;
    public GameObject playerRed;
    public GameObject playerYellow;
    public GameObject playerBrown;
    public GameObject playerLightGreen;
    public GameObject playerBirch;
    public GameObject equip;
    public GameObject equip2;
    public GameObject equip3;
    public GameObject equip4;
    public GameObject equip5;
    public GameObject equip6;
    public GameObject equip7;
    public GameObject equip8;
    public GameObject equip9;
    public GameObject equip10;
    public GameObject equip11;
    public GameObject equip12;
    public GameObject equip13;
    public int NumberEquip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayerWhite()
    {
        equip.SetActive(true);
        equip2.SetActive(false);
        equip3.SetActive(false);
        equip4.SetActive(false);
        equip5.SetActive(false);
        equip6.SetActive(false);
        equip7.SetActive(false);
        equip8.SetActive(false);
        equip9.SetActive(false);
        equip10.SetActive(false);
        equip11.SetActive(false);
        equip12.SetActive(false);
        equip13.SetActive(false);
        playerWhite.SetActive(true);
        playerBlack.SetActive(false);
        playerBlue.SetActive(false);
        playerGray.SetActive(false);
        playerGreen.SetActive(false);
        playerOrange.SetActive(false);
        playerPink.SetActive(false);
        playerPurple.SetActive(false);
        playerRed.SetActive(false);
        playerYellow.SetActive(false);
        playerBrown.SetActive(false);
        playerLightGreen.SetActive(false);
        playerBirch.SetActive(false);

    }
    public void PlayerBlack()
    {
        equip.SetActive(false);
        equip2.SetActive(true);
        equip3.SetActive(false);
        equip4.SetActive(false);
        equip5.SetActive(false);
        equip6.SetActive(false);
        equip7.SetActive(false);
        equip8.SetActive(false);
        equip9.SetActive(false);
        equip10.SetActive(false);
        equip11.SetActive(false);
        equip12.SetActive(false);
        equip13.SetActive(false);
        playerWhite.SetActive(false);
        playerBlack.SetActive(true);
        playerBlue.SetActive(false);
        playerGray.SetActive(false);
        playerGreen.SetActive(false);
        playerOrange.SetActive(false);
        playerPink.SetActive(false);
        playerPurple.SetActive(false);
        playerRed.SetActive(false);
        playerYellow.SetActive(false);
        playerBrown.SetActive(false);
        playerLightGreen.SetActive(false);
        playerBirch.SetActive(false);
    }
    public void PlayerBlue()
    {
        equip.SetActive(false);
        equip2.SetActive(false);
        equip3.SetActive(true);
        equip4.SetActive(false);
        equip5.SetActive(false);
        equip6.SetActive(false);
        equip7.SetActive(false);
        equip8.SetActive(false);
        equip9.SetActive(false);
        equip10.SetActive(false);
        equip11.SetActive(false);
        equip12.SetActive(false);
        equip13.SetActive(false);
        playerWhite.SetActive(false);
        playerBlack.SetActive(false);
        playerBlue.SetActive(true);
        playerGray.SetActive(false);
        playerGreen.SetActive(false);
        playerOrange.SetActive(false);
        playerPink.SetActive(false);
        playerPurple.SetActive(false);
        playerRed.SetActive(false);
        playerYellow.SetActive(false);
        playerBrown.SetActive(false);
        playerLightGreen.SetActive(false);
        playerBirch.SetActive(false);
    }
    public void PlayerGray()
    {
        equip.SetActive(false);
        equip2.SetActive(false);
        equip3.SetActive(false);
        equip4.SetActive(true);
        equip5.SetActive(false);
        equip6.SetActive(false);
        equip7.SetActive(false);
        equip8.SetActive(false);
        equip9.SetActive(false);
        equip10.SetActive(false);
        equip11.SetActive(false);
        equip12.SetActive(false);
        equip13.SetActive(false);
        playerWhite.SetActive(false);
        playerBlack.SetActive(false);
        playerBlue.SetActive(false);
        playerGray.SetActive(true);
        playerGreen.SetActive(false);
        playerOrange.SetActive(false);
        playerPink.SetActive(false);
        playerPurple.SetActive(false);
        playerRed.SetActive(false);
        playerYellow.SetActive(false);
        playerBrown.SetActive(false);
        playerLightGreen.SetActive(false);
        playerBirch.SetActive(false);
    }
    public void PlayerGreen()
    {
        equip.SetActive(false);
        equip2.SetActive(false);
        equip3.SetActive(false);
        equip4.SetActive(false);
        equip5.SetActive(true);
        equip6.SetActive(false);
        equip7.SetActive(false);
        equip8.SetActive(false);
        equip9.SetActive(false);
        equip10.SetActive(false);
        equip11.SetActive(false);
        equip12.SetActive(false);
        equip13.SetActive(false);
        playerWhite.SetActive(false);
        playerBlack.SetActive(false);
        playerBlue.SetActive(false);
        playerGray.SetActive(false);
        playerGreen.SetActive(true);
        playerOrange.SetActive(false);
        playerPink.SetActive(false);
        playerPurple.SetActive(false);
        playerRed.SetActive(false);
        playerYellow.SetActive(false);
        playerBrown.SetActive(false);
        playerLightGreen.SetActive(false);
        playerBirch.SetActive(false);
    }
    public void PlayerOrange()
    {
        equip.SetActive(false);
        equip2.SetActive(false);
        equip3.SetActive(false);
        equip3.SetActive(false);
        equip5.SetActive(false);
        equip6.SetActive(true);
        equip7.SetActive(false);
        equip8.SetActive(false);
        equip9.SetActive(false);
        equip10.SetActive(false);
        equip11.SetActive(false);
        equip12.SetActive(false);
        equip13.SetActive(false);
        playerWhite.SetActive(false);
        playerBlack.SetActive(false);
        playerBlue.SetActive(false);
        playerGray.SetActive(false);
        playerGreen.SetActive(false);
        playerOrange.SetActive(true);
        playerPink.SetActive(false);
        playerPurple.SetActive(false);
        playerRed.SetActive(false);
        playerYellow.SetActive(false);
        playerBrown.SetActive(false);
        playerLightGreen.SetActive(false);
        playerBirch.SetActive(false);
    }
    public void PlayerPink()
    {
        equip.SetActive(false);
        equip2.SetActive(false);
        equip3.SetActive(false);
        equip3.SetActive(false);
        equip5.SetActive(false);
        equip6.SetActive(false);
        equip7.SetActive(true);
        equip8.SetActive(false);
        equip9.SetActive(false);
        equip10.SetActive(false);
        equip11.SetActive(false);
        equip12.SetActive(false);
        equip13.SetActive(false);
        playerWhite.SetActive(false);
        playerBlack.SetActive(false);
        playerBlue.SetActive(false);
        playerGray.SetActive(false);
        playerGreen.SetActive(false);
        playerOrange.SetActive(false);
        playerPink.SetActive(true);
        playerPurple.SetActive(false);
        playerRed.SetActive(false);
        playerYellow.SetActive(false);
        playerBrown.SetActive(false);
        playerLightGreen.SetActive(false);
        playerBirch.SetActive(false);
    }
    public void PlayerPurple()
    {
        equip.SetActive(false);
        equip2.SetActive(false);
        equip3.SetActive(false);
        equip3.SetActive(false);
        equip5.SetActive(false);
        equip6.SetActive(false);
        equip7.SetActive(false);
        equip8.SetActive(true);
        equip9.SetActive(false);
        equip10.SetActive(false);
        equip11.SetActive(false);
        equip12.SetActive(false);
        equip13.SetActive(false);
        playerWhite.SetActive(false);
        playerBlack.SetActive(false);
        playerBlue.SetActive(false);
        playerGray.SetActive(false);
        playerGreen.SetActive(false);
        playerOrange.SetActive(false);
        playerPink.SetActive(false);
        playerPurple.SetActive(true);
        playerRed.SetActive(false);
        playerYellow.SetActive(false);
        playerBrown.SetActive(false);
        playerLightGreen.SetActive(false);
        playerBirch.SetActive(false);
    }
    public void PlayerRed()
    {
        equip.SetActive(false);
        equip2.SetActive(false);
        equip3.SetActive(false);
        equip3.SetActive(false);
        equip5.SetActive(false);
        equip6.SetActive(false);
        equip7.SetActive(false);
        equip8.SetActive(false);
        equip9.SetActive(true);
        equip10.SetActive(false);
        equip11.SetActive(false);
        equip12.SetActive(false);
        equip13.SetActive(false);
        playerWhite.SetActive(false);
        playerBlack.SetActive(false);
        playerBlue.SetActive(false);
        playerGray.SetActive(false);
        playerGreen.SetActive(false);
        playerOrange.SetActive(false);
        playerPink.SetActive(false);
        playerPurple.SetActive(false);
        playerRed.SetActive(true);
        playerYellow.SetActive(false);
        playerBrown.SetActive(false);
        playerLightGreen.SetActive(false);
        playerBirch.SetActive(false);
    }
    public void PlayerYellow()
    {
        equip.SetActive(false);
        equip2.SetActive(false);
        equip3.SetActive(false);
        equip3.SetActive(false);
        equip5.SetActive(false);
        equip6.SetActive(false);
        equip7.SetActive(false);
        equip8.SetActive(false);
        equip9.SetActive(false);
        equip10.SetActive(true);
        equip11.SetActive(false);
        equip12.SetActive(false);
        equip13.SetActive(false);
        playerWhite.SetActive(false);
        playerBlack.SetActive(false);
        playerBlue.SetActive(false);
        playerGray.SetActive(false);
        playerGreen.SetActive(false);
        playerOrange.SetActive(false);
        playerPink.SetActive(false);
        playerPurple.SetActive(false);
        playerRed.SetActive(false);
        playerYellow.SetActive(true);
        playerBrown.SetActive(false);
        playerLightGreen.SetActive(false);
        playerBirch.SetActive(false);
    }
    public void PlayerBrown()
    {
        equip.SetActive(false);
        equip2.SetActive(false);
        equip3.SetActive(false);
        equip3.SetActive(false);
        equip5.SetActive(false);
        equip6.SetActive(false);
        equip7.SetActive(false);
        equip8.SetActive(false);
        equip9.SetActive(false);
        equip10.SetActive(false);
        equip11.SetActive(true);
        equip12.SetActive(false);
        equip13.SetActive(false);
        playerWhite.SetActive(false);
        playerBlack.SetActive(false);
        playerBlue.SetActive(false);
        playerGray.SetActive(false);
        playerGreen.SetActive(false);
        playerOrange.SetActive(false);
        playerPink.SetActive(false);
        playerPurple.SetActive(false);
        playerRed.SetActive(false);
        playerYellow.SetActive(false);
        playerBrown.SetActive(true);
        playerLightGreen.SetActive(false);
        playerBirch.SetActive(false);
    }
    public void PlayerLightGreen()
    {
        equip.SetActive(false);
        equip2.SetActive(false);
        equip3.SetActive(false);
        equip3.SetActive(false);
        equip5.SetActive(false);
        equip6.SetActive(false);
        equip7.SetActive(false);
        equip8.SetActive(false);
        equip9.SetActive(false);
        equip10.SetActive(false);
        equip11.SetActive(false);
        equip12.SetActive(true);
        equip13.SetActive(false);
        playerWhite.SetActive(false);
        playerBlack.SetActive(false);
        playerBlue.SetActive(false);
        playerGray.SetActive(false);
        playerGreen.SetActive(false);
        playerOrange.SetActive(false);
        playerPink.SetActive(false);
        playerPurple.SetActive(false);
        playerRed.SetActive(false);
        playerYellow.SetActive(false);
        playerBrown.SetActive(false);
        playerLightGreen.SetActive(true);
        playerBirch.SetActive(false);
    }
    public void PlayerBirch()
    {
        equip.SetActive(false);
        equip2.SetActive(false);
        equip3.SetActive(false);
        equip3.SetActive(false);
        equip5.SetActive(false);
        equip6.SetActive(false);
        equip7.SetActive(false);
        equip8.SetActive(false);
        equip9.SetActive(false);
        equip10.SetActive(false);
        equip11.SetActive(false);
        equip12.SetActive(false);
        equip13.SetActive(true);
        playerWhite.SetActive(false);
        playerBlack.SetActive(false);
        playerBlue.SetActive(false);
        playerGray.SetActive(false);
        playerGreen.SetActive(false);
        playerOrange.SetActive(false);
        playerPink.SetActive(false);
        playerPurple.SetActive(false);
        playerRed.SetActive(false);
        playerYellow.SetActive(false);
        playerBrown.SetActive(false);
        playerLightGreen.SetActive(false);
        playerBirch.SetActive(true);
    }
}
