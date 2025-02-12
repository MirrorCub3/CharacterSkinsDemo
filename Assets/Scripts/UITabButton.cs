using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.UI;
#endif

public class UITabButton : Selectable, IPointerClickHandler
{
    [SerializeField] private TabGroup tabGroup;
    [SerializeField] private TMP_Text tabLabel;
    public void SetUp()
    {
        colors = tabGroup.Colors;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        tabGroup.OnTabSelected(this);
    }

    public override void OnSelect(BaseEventData eventData)
    {
        base.OnSelect(eventData);
        tabGroup.OnTabSelected(this);
    }

    public override void OnDeselect(BaseEventData eventData)
    {
        base.OnDeselect(eventData);
    }

    public void SetButtonIdleColor(Color color)
    {
        ColorBlock colors = base.colors;
        colors.normalColor = color;
        base.colors = colors;
    }
}

#if UNITY_EDITOR
[CustomEditor(typeof(UITabButton)), CanEditMultipleObjects]
public class UITabButtonEditor: SelectableEditor
{
    private SerializedProperty tabGroupProperty;
    private SerializedProperty tabLabelProperty;

    protected override void OnEnable()
    {
        base.OnEnable();

        tabGroupProperty = serializedObject.FindProperty("tabGroup");
        tabLabelProperty = serializedObject.FindProperty("tabLabel");
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        EditorGUILayout.ObjectField(tabGroupProperty);
        EditorGUILayout.ObjectField(tabLabelProperty);

        serializedObject.ApplyModifiedProperties();
    }
}
#endif