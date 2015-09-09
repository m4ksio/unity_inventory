using ResourceSystem;
using UnityEditor;
using UnityEngine;

public class ResourceDefinitionCreator {

    [MenuItem("Assets/Create/Resource definition")]
    public static void CreateResrouceDefinition()
    {
        ResourceDefinition resourceDefinition = ScriptableObject.CreateInstance<ResourceDefinition>();

        AssetDatabase.CreateAsset(resourceDefinition, "Assets/New resource definiton.asset");
        AssetDatabase.SaveAssets();

        Selection.activeObject = resourceDefinition;
    }
}
