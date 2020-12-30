using UnityEngine;

public class PlayerLoad : MonoBehaviour
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

    // Start is called before the first frame update
    void Start()
    {
        skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        numberColors = PlayerPrefs.GetInt("Color");
    }

    // Update is called once per frame
    void Update()
    {
        if (numberColors == 1)
        {
            skinnedMeshRenderer.material.SetTexture("_MainTex", whiteTexture);
        }
        if (numberColors == 2)
        {
            skinnedMeshRenderer.material.SetTexture("_MainTex", blackTexture);
        }
        if (numberColors == 3)
        {
            skinnedMeshRenderer.material.SetTexture("_MainTex", blueTexture);
        }
        if (numberColors == 4)
        {
            skinnedMeshRenderer.material.SetTexture("_MainTex", grayTexture);
        }
        if (numberColors == 5)
        {
            skinnedMeshRenderer.material.SetTexture("_MainTex", greenTexture);
        }
        if (numberColors == 6)
        {
            skinnedMeshRenderer.material.SetTexture("_MainTex", orangeTexture);
        }
        if (numberColors == 7)
        {
            skinnedMeshRenderer.material.SetTexture("_MainTex", pinkTexture);
        }
        if (numberColors == 8)
        {
            skinnedMeshRenderer.material.SetTexture("_MainTex", yellowTexture);
        }
        if (numberColors == 9)
        {
            skinnedMeshRenderer.material.SetTexture("_MainTex", purpleTexture);
        }
        if (numberColors == 10)
        {
            skinnedMeshRenderer.material.SetTexture("_MainTex", brownTexture);
        }
        if (numberColors == 11)
        {
            skinnedMeshRenderer.material.SetTexture("_MainTex", redTexture);
        }
        if (numberColors == 12)
        {
            skinnedMeshRenderer.material.SetTexture("_MainTex", lightGreenTexture);
        }
        if (numberColors == 13)
        {
            skinnedMeshRenderer.material.SetTexture("_MainTex", birchTexture);
        }
    }
}
