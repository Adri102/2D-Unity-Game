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


        if(newCollision.isWalled) myStyle.normal.textColor = Color.green;
        else myStyle.normal.textColor = Color.red;
        EditorGUILayout.LabelField("IsWalled", myStyle);

        if(newCollision.wasWalledLastFrame) myStyle.normal.textColor = Color.green;
        else myStyle.normal.textColor = Color.red;
        EditorGUILayout.LabelField("WasWalledLastFrame", myStyle);

        if(newCollision.justWalled) myStyle.normal.textColor = Color.green;
        else myStyle.normal.textColor = Color.red;
        EditorGUILayout.LabelField("JustWall", myStyle);

        if(newCollision.justNotWalled) myStyle.normal.textColor = Color.green;
        else myStyle.normal.textColor = Color.red;
        EditorGUILayout.LabelField("JustNotWalled", myStyle);

        if(newCollision.isCeiling) myStyle.normal.textColor = Color.green;
        else myStyle.normal.textColor = Color.red;
        EditorGUILayout.LabelField("isCeiling", myStyle);

        if(newCollision.wasCeilingLastFrame) myStyle.normal.textColor = Color.green;
        else myStyle.normal.textColor = Color.red;
        EditorGUILayout.LabelField("WasCeilingLastFrame", myStyle);

        if(newCollision.justCeiled) myStyle.normal.textColor = Color.green;
        else myStyle.normal.textColor = Color.red;
        EditorGUILayout.LabelField("JusCeiled", myStyle);

        if(newCollision.justNotCeiled) myStyle.normal.textColor = Color.green;
        else myStyle.normal.textColor = Color.red;
        EditorGUILayout.LabelField("JustNotCeiled", myStyle);

        showBase = EditorGUILayout.Foldout(showBase, "BaseInspector", true, EditorStyles.toolbarDropDown);
        if(showBase) base.OnInspectorGUI();
    }

}
