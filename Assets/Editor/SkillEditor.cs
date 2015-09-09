using System;
using UnityEngine;
using System.Collections;
using ResourceSystem;
using UnityEditor;
using UnityEngine.Assertions.Comparers;

[CustomEditor(typeof(Container))]
public class ContainerEditor : Editor {

    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        Container character = (Container) target;

        EditorGUILayout.ObjectField(null, typeof (ResourceDefinition), false);

//        character.TreeTag = EditorGUILayout.TagField("Tree tag", character.TreeTag);
//        character.BaseChoppingTimeout = EditorGUILayout.FloatField("Base chopping time", character.BaseChoppingTimeout);
//
//        character.DistanceThreshold = EditorGUILayout.Slider("Chopping distance", character.DistanceThreshold, 4f, 100f);
//        character.WalkDistanceThreshold = EditorGUILayout.Slider("Walking distance", character.WalkDistanceThreshold, character.DistanceThreshold, 100f);
//
//
//        character.Skill = EditorGUILayout.Slider("Skill", character.Skill, 1f, 5f);
//
//        EditorGUILayout.LabelField("Target distance: " + character.TargetDistance.ToString("F2"));

    }

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
