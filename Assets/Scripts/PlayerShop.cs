using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShop : MonoBehaviour
{
    SkinnedMeshRenderer skinnedMeshRenderer;
    public int numberColors;
    public Texture whiteTexture;
    public Texture blackTexture;
    public Texture blueTexture;
    public Texture grayTexture;
    public Texture greenTexture;
    public Texture orangeTexture;
    public Texture pinkTexture;
    public Texture yellowTexture;
    public Texture purpleTexture;
    public Texture brownTexture;
    public Texture redTexture;
    public Texture lightGreenTexture;
    public Texture birchTexture;

    public GameObject equipWhite;
    public GameObject equipBlack;
    public GameObject equipBlue;
    public GameObject equipGray;
    public GameObject equipGreen;
    public GameObject equipOrange;
    public GameObject equipPink;
    public GameObject equipYellow;
    public GameObject equipPurple;
    public GameObject equipBrown;
    public GameObject equipRed;
    public GameObject equipLightGreen;
    public GameObject equipBirch;

    // Start is called before the first frame update
    void Start()
    {
        numberColors = PlayerPrefs.GetInt("Color");
        skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlayerWhite()
    {
        skinnedMeshRenderer.material.SetTexture("_MainTex", whiteTexture);
        equipWhite.SetActive(true);
        equipBlack.SetActive(false);
        equipBlue.SetActive(false);
        equipGray.SetActive(false);
        equipGreen.SetActive(false);
        equipOrange.SetActive(false);
        equipPink.SetActive(false);
        equipYellow.SetActive(false);
        equipPurple.SetActive(false);
        equipBrown.SetActive(false);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(false);
    }
    public void PlayerBlack()
    {
        skinnedMeshRenderer.material.SetTexture("_MainTex", blackTexture);
        equipWhite.SetActive(false);
        equipBlack.SetActive(true);
        equipBlue.SetActive(false);
        equipGray.SetActive(false);
        equipGreen.SetActive(false);
        equipOrange.SetActive(false);
        equipPink.SetActive(false);
        equipYellow.SetActive(false);
        equipPurple.SetActive(false);
        equipBrown.SetActive(false);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(false);
    }
    public void PlayerBlue()
    {
        skinnedMeshRenderer.material.SetTexture("_MainTex", blueTexture);
        equipWhite.SetActive(false);
        equipBlack.SetActive(false);
        equipBlue.SetActive(true);
        equipGray.SetActive(false);
        equipGreen.SetActive(false);
        equipOrange.SetActive(false);
        equipPink.SetActive(false);
        equipYellow.SetActive(false);
        equipPurple.SetActive(false);
        equipBrown.SetActive(false);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(false);
    }
    public void PlayerGray()
    {
        skinnedMeshRenderer.material.SetTexture("_MainTex", grayTexture);
        equipWhite.SetActive(false);
        equipBlack.SetActive(false);
        equipBlue.SetActive(false);
        equipGray.SetActive(true);
        equipGreen.SetActive(false);
        equipOrange.SetActive(false);
        equipPink.SetActive(false);
        equipYellow.SetActive(false);
        equipPurple.SetActive(false);
        equipBrown.SetActive(false);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(false);
    }
    public void PlayerGreen()
    {
        skinnedMeshRenderer.material.SetTexture("_MainTex", greenTexture);
        equipWhite.SetActive(false);
        equipBlack.SetActive(false);
        equipBlue.SetActive(false);
        equipGray.SetActive(false);
        equipGreen.SetActive(true);
        equipOrange.SetActive(false);
        equipPink.SetActive(false);
        equipYellow.SetActive(false);
        equipPurple.SetActive(false);
        equipBrown.SetActive(false);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(false);
    }
    public void PlayerOrange()
    {
        skinnedMeshRenderer.material.SetTexture("_MainTex", orangeTexture);
        equipWhite.SetActive(false);
        equipBlack.SetActive(false);
        equipBlue.SetActive(false);
        equipGray.SetActive(false);
        equipGreen.SetActive(false);
        equipOrange.SetActive(true);
        equipPink.SetActive(false);
        equipYellow.SetActive(false);
        equipPurple.SetActive(false);
        equipBrown.SetActive(false);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(false);
    }
    public void PlayerPink()
    {
        skinnedMeshRenderer.material.SetTexture("_MainTex", pinkTexture);
        equipWhite.SetActive(false);
        equipBlack.SetActive(false);
        equipBlue.SetActive(false);
        equipGray.SetActive(false);
        equipGreen.SetActive(false);
        equipOrange.SetActive(false);
        equipPink.SetActive(true);
        equipYellow.SetActive(false);
        equipPurple.SetActive(false);
        equipBrown.SetActive(false);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(false);
    }
    public void PlayerYellow()
    {
        skinnedMeshRenderer.material.SetTexture("_MainTex", yellowTexture);
        equipWhite.SetActive(false);
        equipBlack.SetActive(false);
        equipBlue.SetActive(false);
        equipGray.SetActive(false);
        equipGreen.SetActive(false);
        equipOrange.SetActive(false);
        equipPink.SetActive(false);
        equipYellow.SetActive(true);
        equipPurple.SetActive(false);
        equipBrown.SetActive(false);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(false);
    }
    public void PlayerPurple()
    {
        skinnedMeshRenderer.material.SetTexture("_MainTex", purpleTexture);
        equipWhite.SetActive(false);
        equipBlack.SetActive(false);
        equipBlue.SetActive(false);
        equipGray.SetActive(false);
        equipGreen.SetActive(false);
        equipOrange.SetActive(false);
        equipPink.SetActive(false);
        equipYellow.SetActive(false);
        equipPurple.SetActive(true);
        equipBrown.SetActive(false);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(false);
    }
    public void PlayerBrown()
    {
        skinnedMeshRenderer.material.SetTexture("_MainTex", brownTexture);
        equipWhite.SetActive(false);
        equipBlack.SetActive(false);
        equipBlue.SetActive(false);
        equipGray.SetActive(false);
        equipGreen.SetActive(false);
        equipOrange.SetActive(false);
        equipPink.SetActive(false);
        equipYellow.SetActive(false);
        equipPurple.SetActive(false);
        equipBrown.SetActive(true);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(false);
    }
    public void PlayerRed()
    {
        skinnedMeshRenderer.material.SetTexture("_MainTex", redTexture);
        equipWhite.SetActive(false);
        equipBlack.SetActive(false);
        equipBlue.SetActive(false);
        equipGray.SetActive(false);
        equipGreen.SetActive(false);
        equipOrange.SetActive(false);
        equipPink.SetActive(false);
        equipYellow.SetActive(false);
        equipPurple.SetActive(false);
        equipBrown.SetActive(false);
        equipRed.SetActive(true);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(false);
    }
    public void PlayerLightGreen()
    {
        skinnedMeshRenderer.material.SetTexture("_MainTex", lightGreenTexture);
        equipWhite.SetActive(false);
        equipBlack.SetActive(false);
        equipBlue.SetActive(false);
        equipGray.SetActive(false);
        equipGreen.SetActive(false);
        equipOrange.SetActive(false);
        equipPink.SetActive(false);
        equipYellow.SetActive(false);
        equipPurple.SetActive(false);
        equipBrown.SetActive(false);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(true);
        equipBirch.SetActive(false);
    }
    public void PlayerBirch()
    {
        skinnedMeshRenderer.material.SetTexture("_MainTex", birchTexture);
        equipWhite.SetActive(false);
        equipBlack.SetActive(false);
        equipBlue.SetActive(false);
        equipGray.SetActive(false);
        equipGreen.SetActive(false);
        equipOrange.SetActive(false);
        equipPink.SetActive(false);
        equipYellow.SetActive(false);
        equipPurple.SetActive(false);
        equipBrown.SetActive(false);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(true);
    }
    public void EquipWhite()
    {
        numberColors = 1;
        PlayerPrefs.SetInt("Color", numberColors);
        equipWhite.SetActive(false);
        equipBlack.SetActive(false);
        equipBlue.SetActive(false);
        equipGray.SetActive(false);
        equipGreen.SetActive(false);
        equipOrange.SetActive(false);
        equipPink.SetActive(false);
        equipYellow.SetActive(false);
        equipPurple.SetActive(false);
        equipBrown.SetActive(false);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(false);
    }
    public void EquipBlack()
    {
        numberColors = 2;
        PlayerPrefs.SetInt("Color", numberColors);
        equipWhite.SetActive(false);
        equipBlack.SetActive(false);
        equipBlue.SetActive(false);
        equipGray.SetActive(false);
        equipGreen.SetActive(false);
        equipOrange.SetActive(false);
        equipPink.SetActive(false);
        equipYellow.SetActive(false);
        equipPurple.SetActive(false);
        equipBrown.SetActive(false);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(false);
    }
    public void EquipBlue()
    {
        numberColors = 3;
        PlayerPrefs.SetInt("Color", numberColors);
        equipWhite.SetActive(false);
        equipBlack.SetActive(false);
        equipBlue.SetActive(false);
        equipGray.SetActive(false);
        equipGreen.SetActive(false);
        equipOrange.SetActive(false);
        equipPink.SetActive(false);
        equipYellow.SetActive(false);
        equipPurple.SetActive(false);
        equipBrown.SetActive(false);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(false);
    }
    public void EquipGray()
    {
        numberColors = 4;
        PlayerPrefs.SetInt("Color", numberColors);
        equipWhite.SetActive(false);
        equipBlack.SetActive(false);
        equipBlue.SetActive(false);
        equipGray.SetActive(false);
        equipGreen.SetActive(false);
        equipOrange.SetActive(false);
        equipPink.SetActive(false);
        equipYellow.SetActive(false);
        equipPurple.SetActive(false);
        equipBrown.SetActive(false);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(false);
    }
    public void EquipGreen()
    {
        numberColors = 5;
        PlayerPrefs.SetInt("Color", numberColors);
        equipWhite.SetActive(false);
        equipBlack.SetActive(false);
        equipBlue.SetActive(false);
        equipGray.SetActive(false);
        equipGreen.SetActive(false);
        equipOrange.SetActive(false);
        equipPink.SetActive(false);
        equipYellow.SetActive(false);
        equipPurple.SetActive(false);
        equipBrown.SetActive(false);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(false);
    }
    public void EquipOrange()
    {
        numberColors = 6;
        PlayerPrefs.SetInt("Color", numberColors);
        equipWhite.SetActive(false);
        equipBlack.SetActive(false);
        equipBlue.SetActive(false);
        equipGray.SetActive(false);
        equipGreen.SetActive(false);
        equipOrange.SetActive(false);
        equipPink.SetActive(false);
        equipYellow.SetActive(false);
        equipPurple.SetActive(false);
        equipBrown.SetActive(false);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(false);
    }
    public void EquipPink()
    {
        numberColors = 7;
        PlayerPrefs.SetInt("Color", numberColors);
        equipWhite.SetActive(false);
        equipBlack.SetActive(false);
        equipBlue.SetActive(false);
        equipGray.SetActive(false);
        equipGreen.SetActive(false);
        equipOrange.SetActive(false);
        equipPink.SetActive(false);
        equipYellow.SetActive(false);
        equipPurple.SetActive(false);
        equipBrown.SetActive(false);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(false);
    }
    public void EquipYellow()
    {
        numberColors = 8;
        PlayerPrefs.SetInt("Color", numberColors);
        equipWhite.SetActive(false);
        equipBlack.SetActive(false);
        equipBlue.SetActive(false);
        equipGray.SetActive(false);
        equipGreen.SetActive(false);
        equipOrange.SetActive(false);
        equipPink.SetActive(false);
        equipYellow.SetActive(false);
        equipPurple.SetActive(false);
        equipBrown.SetActive(false);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(false);
    }
    public void EquipPurple()
    {
        numberColors = 9;
        PlayerPrefs.SetInt("Color", numberColors);
        equipWhite.SetActive(false);
        equipBlack.SetActive(false);
        equipBlue.SetActive(false);
        equipGray.SetActive(false);
        equipGreen.SetActive(false);
        equipOrange.SetActive(false);
        equipPink.SetActive(false);
        equipYellow.SetActive(false);
        equipPurple.SetActive(false);
        equipBrown.SetActive(false);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(false);
    }
    public void EquipBrown()
    {
        numberColors = 10;
        PlayerPrefs.SetInt("Color", numberColors);
        equipWhite.SetActive(false);
        equipBlack.SetActive(false);
        equipBlue.SetActive(false);
        equipGray.SetActive(false);
        equipGreen.SetActive(false);
        equipOrange.SetActive(false);
        equipPink.SetActive(false);
        equipYellow.SetActive(false);
        equipPurple.SetActive(false);
        equipBrown.SetActive(false);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(false);
    }
    public void EquipRed()
    {
        numberColors = 11;
        PlayerPrefs.SetInt("Color", numberColors);
        equipWhite.SetActive(false);
        equipBlack.SetActive(false);
        equipBlue.SetActive(false);
        equipGray.SetActive(false);
        equipGreen.SetActive(false);
        equipOrange.SetActive(false);
        equipPink.SetActive(false);
        equipYellow.SetActive(false);
        equipPurple.SetActive(false);
        equipBrown.SetActive(false);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(false);
    }
    public void EquipLightGreen()
    {
        numberColors = 12;
        PlayerPrefs.SetInt("Color", numberColors);
        equipWhite.SetActive(false);
        equipBlack.SetActive(false);
        equipBlue.SetActive(false);
        equipGray.SetActive(false);
        equipGreen.SetActive(false);
        equipOrange.SetActive(false);
        equipPink.SetActive(false);
        equipYellow.SetActive(false);
        equipPurple.SetActive(false);
        equipBrown.SetActive(false);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(false);
    }
    public void EquipBirch()
    {
        numberColors = 13;
        PlayerPrefs.SetInt("Color", numberColors);
        equipWhite.SetActive(false);
        equipBlack.SetActive(false);
        equipBlue.SetActive(false);
        equipGray.SetActive(false);
        equipGreen.SetActive(false);
        equipOrange.SetActive(false);
        equipPink.SetActive(false);
        equipYellow.SetActive(false);
        equipPurple.SetActive(false);
        equipBrown.SetActive(false);
        equipRed.SetActive(false);
        equipLightGreen.SetActive(false);
        equipBirch.SetActive(false);
    }

}
