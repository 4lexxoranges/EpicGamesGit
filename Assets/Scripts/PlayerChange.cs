using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChange : MonoBehaviour
{
    MeshRenderer meshRenderer;
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

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent <MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlayerWhite()
    {
        meshRenderer.material.SetTexture("_MainTex", whiteTexture);
    }
    public void PlayerBlack()
    {
        meshRenderer.material.SetTexture("_MainTex", blackTexture);
    }
    public void PlayerBlue()
    {
        meshRenderer.material.SetTexture("_MainTex", blueTexture);
    }
    public void PlayerGray()
    {
        meshRenderer.material.SetTexture("_MainTex", grayTexture);
    }
    public void PlayerGreen()
    {
        meshRenderer.material.SetTexture("_MainTex", greenTexture);
    }
    public void PlayerOrange()
    {
        meshRenderer.material.SetTexture("_MainTex", orangeTexture);
    }
    public void PlayerPink()
    {
        meshRenderer.material.SetTexture("_MainTex", pinkTexture);
    }
    public void PlayerYellow()
    {
        meshRenderer.material.SetTexture("_MainTex", yellowTexture);
    }
    public void PlayerPurple()
    {
        meshRenderer.material.SetTexture("_MainTex", purpleTexture);
    }
    public void PlayerBrown()
    {
        meshRenderer.material.SetTexture("_MainTex", brownTexture);
    }
    public void PlayerRed()
    {
        meshRenderer.material.SetTexture("_MainTex", redTexture);
    }
    public void PlayerLightGreen()
    {
        meshRenderer.material.SetTexture("_MainTex", lightGreenTexture);
    }
    public void PlayerBirch()
    {
        meshRenderer.material.SetTexture("_MainTex", birchTexture);
    }
}
