using UnityEngine;
using UnityEngine.UI;

public class FeatureButton : MonoBehaviour
{
    [SerializeField] private Image featureImage;
    private Button button;
    private string category, label;
    private FeatureType featureType;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    public void InitButton(FeatureType _type, Sprite _image, string _category, string _label)
    {
        featureType = _type;
        featureImage.sprite = _image;
        category = _category; 
        label = _label;
    }

    public void OnClick()
    {
        CharacterCustomizerController.instance.OnFeatureClicked(featureType, category, label);
    }
}
