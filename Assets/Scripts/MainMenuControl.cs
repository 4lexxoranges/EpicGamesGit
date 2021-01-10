using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuControl : MonoBehaviour
{
    public GameObject player;
    public GameObject platform;

    public GameObject lobby;
    public GameObject customizations;
    public GameObject seasons;
    public GameObject shop;
    public GameObject settings;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Lobby()
    {
        lobby.SetActive(true);
        customizations.SetActive(false);
        seasons.SetActive(false);
        shop.SetActive(false);
        settings.SetActive(false);
        player.transform.Translate(-90, 0, 0 * Time.deltaTime);
        platform.transform.Translate(90, 0, 0 * Time.deltaTime);
    }

    public void Customizations()
    {
        lobby.SetActive(false);
        customizations.SetActive(true);
        seasons.SetActive(false);
        shop.SetActive(false);
        settings.SetActive(false);
        player.transform.Translate(90, 0, 0 * Time.deltaTime);
        platform.transform.Translate(-90, 0, 0 * Time.deltaTime);
    }

    public void Seasons()
    {
        lobby.SetActive(false);
        customizations.SetActive(false);
        seasons.SetActive(true);
        shop.SetActive(false);
        settings.SetActive(false);
    }

    public void Shop()
    {
        lobby.SetActive(false);
        customizations.SetActive(false);
        seasons.SetActive(false);
        shop.SetActive(true);
        settings.SetActive(false);
    }

    public void Settings()
    {
        lobby.SetActive(false);
        customizations.SetActive(false);
        seasons.SetActive(false);
        shop.SetActive(false);
        settings.SetActive(true);
    }
}
