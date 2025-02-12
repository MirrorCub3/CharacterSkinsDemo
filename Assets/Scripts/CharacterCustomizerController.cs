using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCustomizerController : MonoBehaviour
{
    public static CharacterCustomizerController instance;

    [SerializeField] private CharacterAppearanceController playerAppearanceController;
    [SerializeField] private CharacterAppearanceController previewAppearanceController;

    [SerializeField] private Button startButton;
    [SerializeField] private Button editButton;

    [SerializeField] private GameObject editScreen;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject level;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

        startButton.onClick.AddListener(OnStart);
        editButton.onClick.AddListener(OnEdit);

        editScreen.SetActive(true);
        player.SetActive(false);
        level.SetActive(false);
        editButton.gameObject.SetActive(false);
    }

    public void OnFeatureClicked(FeatureType type, string category, string label)
    {
        playerAppearanceController.SetResolverType(type, category, label);
        previewAppearanceController.SetResolverType(type, category, label);
    }

    private void OnStart()
    {
        editScreen.SetActive(false);
        player.SetActive(true);
        level.SetActive(true);
        editButton.gameObject.SetActive(true);
    }

    private void OnEdit()
    {
        editScreen.SetActive(true);
        player.SetActive(false);
        level.SetActive(false);
        editButton.gameObject.SetActive(false);
    }
}
