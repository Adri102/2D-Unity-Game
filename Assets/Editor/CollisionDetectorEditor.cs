using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CollisionDetector))]
public class CollisionDetectorEditor : Editor
{
    static bool showBase;
    static bool showProperties = true;

    public override void OnInspectorGUI()
    {
        CollisionDetector newCollision = (CollisionDetector)target;

        showProperties = EditorGUILayout.Foldout(showProperties, "Properties", true, EditorStyles.toolbarDropDown);

        GUIStyle myStyle = EditorStyles.boldLabel;
        if(newCollision.isGrounded) myStyle.normal.textColor = Color.green;
        else myStyle.normal.textColor = Color.red;
        EditorGUILayout.LabelField("IsGrounded", myStyle);

        if(newCollision.wasGroundedLastFrame) myStyle.normal.textColor = Color.green;
        else myStyle.normal.textColor = Color.red;
        EditorGUILayout.LabelField("WasGroundedLastFrame", myStyle);

        if(newCollision.justGrounded) myStyle.normal.textColor = Color.green;
        else myStyle.normal.textColor = Color.red;
        EditorGUILayout.LabelField("JustGrounded", myStyle);

        if(newCollision.justNotGrounded) myStyle.normal.textColor = Color.green;
        else myStyle.normal.textColor = Color.red;
        EditorGUILayout.LabelField("JustNotGrounded", myStyle);

        if(newCollision.isFalling) myStyle.normal.textColor = Color.green;
        else myStyle.normal.textColor = Color.red;
        EditorGUILayout.LabelField("IsFalling", myStyle);

        EditorGUILayout.Space();


        if (newCollision.isTouchingWall) myStyle.normal.textColor = Color.green;
        else myStyle.normal.textColor = Color.red;
        EditorGUILayout.LabelField("isTouchingWall", myStyle);

        if(newCollision.wasTouchingWallLastFrame) myStyle.normal.textColor = Color.green;
        else myStyle.normal.textColor = Color.red;
        EditorGUILayout.LabelField("WasTouchingWallLastFrame", myStyle);

        if(newCollision.justTouchedWall) myStyle.normal.textColor = Color.green;
        else myStyle.normal.textColor = Color.red;
        EditorGUILayout.LabelField("JustTouchedWall", myStyle);

        if(newCollision.justNotTouchedWall) myStyle.normal.textColor = Color.green;
        else myStyle.normal.textColor = Color.red;
        EditorGUILayout.LabelField("JustNotTouchedWalled", myStyle);

        EditorGUILayout.Space();

        if(newCollision.isTouchingCeiling) myStyle.normal.textColor = Color.green;
        else myStyle.normal.textColor = Color.red;
        EditorGUILayout.LabelField("isTouchingCeiling", myStyle);

        if(newCollision.WasTouchingCeilingLastFrame) myStyle.normal.textColor = Color.green;
        else myStyle.normal.textColor = Color.red;
        EditorGUILayout.LabelField("WasTouchingCeilingLastFrame", myStyle);

        if(newCollision.JusTouchedCeiling) myStyle.normal.textColor = Color.green;
        else myStyle.normal.textColor = Color.red;
        EditorGUILayout.LabelField("JusTouchedCeiling", myStyle);

        if(newCollision.JustNotTouchedCeiling) myStyle.normal.textColor = Color.green;
        else myStyle.normal.textColor = Color.red;
        EditorGUILayout.LabelField("JustNotTouchedCeiling", myStyle);

        showBase = EditorGUILayout.Foldout(showBase, "BaseInspector", true, EditorStyles.toolbarDropDown);
        if(showBase) base.OnInspectorGUI();
    }

}
