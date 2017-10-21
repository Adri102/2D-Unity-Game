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

        GUIStyle myStyle2 = EditorStyles.boldLabel;
        if(newCollision.wasGroundedLastFrame) myStyle2.normal.textColor = Color.green;
        else myStyle2.normal.textColor = Color.red;
        EditorGUILayout.LabelField("WasGroundedLastFrame", myStyle2);

        GUIStyle myStyle3 = EditorStyles.boldLabel;
        if(newCollision.justGrounded) myStyle3.normal.textColor = Color.green;
        else myStyle3.normal.textColor = Color.red;
        EditorGUILayout.LabelField("JustGrounded", myStyle3);

        GUIStyle myStyle4 = EditorStyles.boldLabel;
        if(newCollision.justNotGrounded) myStyle4.normal.textColor = Color.green;
        else myStyle4.normal.textColor = Color.red;
        EditorGUILayout.LabelField("JustNotGrounded", myStyle4);

        GUIStyle myStyle5 = EditorStyles.boldLabel;
        if(newCollision.isFalling) myStyle5.normal.textColor = Color.green;
        else myStyle4.normal.textColor = Color.red;
        EditorGUILayout.LabelField("IsFalling", myStyle5);


        GUIStyle myStyle6 = EditorStyles.boldLabel;
        if(newCollision.isWalled) myStyle6.normal.textColor = Color.green;
        else myStyle6.normal.textColor = Color.red;
        EditorGUILayout.LabelField("IsWalled", myStyle6);

        GUIStyle myStyle7 = EditorStyles.boldLabel;
        if(newCollision.wasWalledLastFrame) myStyle7.normal.textColor = Color.green;
        else myStyle7.normal.textColor = Color.red;
        EditorGUILayout.LabelField("WasWalledLastFrame", myStyle7);

        GUIStyle myStyle8 = EditorStyles.boldLabel;
        if(newCollision.justWalled) myStyle8.normal.textColor = Color.green;
        else myStyle8.normal.textColor = Color.red;
        EditorGUILayout.LabelField("JustWall", myStyle8);

        GUIStyle myStyle9 = EditorStyles.boldLabel;
        if(newCollision.justNotWalled) myStyle9.normal.textColor = Color.green;
        else myStyle9.normal.textColor = Color.red;
        EditorGUILayout.LabelField("JustNotWalled", myStyle9);

        GUIStyle myStyle10 = EditorStyles.boldLabel;
        if(newCollision.isCeiling) myStyle10.normal.textColor = Color.green;
        else myStyle10.normal.textColor = Color.red;
        EditorGUILayout.LabelField("isCeiling", myStyle10);

        GUIStyle myStyle11 = EditorStyles.boldLabel;
        if(newCollision.wasCeilingLastFrame) myStyle11.normal.textColor = Color.green;
        else myStyle11.normal.textColor = Color.red;
        EditorGUILayout.LabelField("WasCeilingLastFrame", myStyle11);

        GUIStyle myStyle12 = EditorStyles.boldLabel;
        if(newCollision.justCeiled) myStyle12.normal.textColor = Color.green;
        else myStyle12.normal.textColor = Color.red;
        EditorGUILayout.LabelField("JusCeiled", myStyle12);

        GUIStyle myStyle13 = EditorStyles.boldLabel;
        if(newCollision.justNotCeiled) myStyle13.normal.textColor = Color.green;
        else myStyle13.normal.textColor = Color.red;
        EditorGUILayout.LabelField("JustNotCeiled", myStyle13);

        showBase = EditorGUILayout.Foldout(showBase, "BaseInspector", true, EditorStyles.toolbarDropDown);
        if(showBase) base.OnInspectorGUI();
    }

}
