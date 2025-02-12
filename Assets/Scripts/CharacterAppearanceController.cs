using UnityEngine;
using UnityEngine.U2D.Animation;

public enum FeatureType { Hat, Face, Top, Bottoms, Weapon}

public class CharacterAppearanceController : MonoBehaviour
{
    [SerializeField] private SpriteResolver hatResolver;
    [SerializeField] private SpriteResolver faceResolver;
    [SerializeField] private SpriteResolver topResolver;
    [SerializeField] private SpriteResolver bottomsResolver;
    [SerializeField] private SpriteResolver weaponResolver;

    public void SetResolverType(FeatureType type, string category, string label)
    {
        switch (type)
        {
            case FeatureType.Hat:
                hatResolver.SetCategoryAndLabel(category, label);
                break;
            case FeatureType.Face:
                faceResolver.SetCategoryAndLabel(category, label);
                break;
            case FeatureType.Top:
                topResolver.SetCategoryAndLabel(category, label);
                break;
            case FeatureType.Bottoms:
                bottomsResolver.SetCategoryAndLabel(category, label);
                break;
            case FeatureType.Weapon:
                weaponResolver.SetCategoryAndLabel(category, label);
                break;
            default:
                break;
        }
    }
}
