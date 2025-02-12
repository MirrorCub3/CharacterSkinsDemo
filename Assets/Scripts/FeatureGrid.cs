using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class FeatureGrid : MonoBehaviour
{
    [SerializeField] private SpriteLibraryAsset library;
    [SerializeField] private FeatureType category;

    [SerializeField] private GameObject featureButtonPrefab;
    [SerializeField] private Transform layoutGroupTransform;

    private void Awake()
    {
        IEnumerable<string> labels= library.GetCategoryLabelNames(category.ToString());
        foreach (string label in labels)
        {
            FeatureButton featureButton = Instantiate(featureButtonPrefab, transform).GetComponent<FeatureButton>();
            print(label);
            featureButton.InitButton(category, library.GetSprite(category.ToString(), label), category.ToString(), label);
        }
    }
}
