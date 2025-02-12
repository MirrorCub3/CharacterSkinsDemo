using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabGroup : MonoBehaviour
{
    [Header("Tab Buttons")]
    [SerializeField] private List<UITabButton> tabButtons = new List<UITabButton>();

    [SerializeField] private ColorBlock colors;
    public ColorBlock Colors { get { return colors; } }

    [Header("Pages")]
    [SerializeField] private List<GameObject> tabPages;

    private UITabButton selectedTab;

    private void Awake()
    {
        foreach (UITabButton button in tabButtons)
        {
            button.SetUp();
        }

        OnTabSelected(tabButtons[0]);
    }

    public void OnTabSelected(UITabButton button)
    {
        if (selectedTab)
        {
            selectedTab.SetButtonIdleColor(colors.normalColor);
        }

        selectedTab = button;
        selectedTab.SetButtonIdleColor(colors.selectedColor);

        int index = tabButtons.IndexOf(button);
        for (int i = 0; i < tabPages.Count; i++)
        {
            if (i == index)
            {
                tabPages[i].SetActive(true);
            }
            else
            {
                tabPages[i].SetActive(false);
            }
        }
    }
}
