﻿using UnityEngine;

public class PlayerLoad : MonoBehaviour
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

    public int numberColors;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        numberColors = PlayerPrefs.GetInt("Color");
    }

    // Update is called once per frame
    void Update()
    {
        if (numberColors == 1)
        {
            meshRenderer.material.SetTexture("_MainTex", whiteTexture);
        }
        if (numberColors == 2)
        {
            meshRenderer.material.SetTexture("_MainTex", blackTexture);
        }
        if (numberColors == 3)
        {
            meshRenderer.material.SetTexture("_MainTex", blueTexture);
        }
        if (numberColors == 4)
        {
            meshRenderer.material.SetTexture("_MainTex", grayTexture);
        }
        if (numberColors == 5)
        {
            meshRenderer.material.SetTexture("_MainTex", greenTexture);
        }
        if (numberColors == 6)
        {
            meshRenderer.material.SetTexture("_MainTex", orangeTexture);
        }
        if (numberColors == 7)
        {
            meshRenderer.material.SetTexture("_MainTex", pinkTexture);
        }
        if (numberColors == 8)
        {
            meshRenderer.material.SetTexture("_MainTex", yellowTexture);
        }
        if (numberColors == 9)
        {
            meshRenderer.material.SetTexture("_MainTex", purpleTexture);
        }
        if (numberColors == 10)
        {
            meshRenderer.material.SetTexture("_MainTex", brownTexture);
        }
        if (numberColors == 11)
        {
            meshRenderer.material.SetTexture("_MainTex", redTexture);
        }
        if (numberColors == 12)
        {
            meshRenderer.material.SetTexture("_MainTex", lightGreenTexture);
        }
        if (numberColors == 13)
        {
            meshRenderer.material.SetTexture("_MainTex", birchTexture);
        }
    }
}