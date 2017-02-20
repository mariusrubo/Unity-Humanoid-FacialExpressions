using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacialExpressionsInterface : MonoBehaviour {

    // Character
    [Tooltip("Manually drag your character here.")]
    public Transform Character;
    private FacialExpressions CharacterFacialExpressions = null;
    int expression = 0;

    // Use this for initialization
    void Start () {
        CharacterFacialExpressions = Character.GetComponent<FacialExpressions>();
    }

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(10, 10, 100, 200)); // You can change position of Interface here. This is designed so that all my interface scripts can run together. 
        if (GUILayout.Button("Neutral")) { expression = 0; }
        if (GUILayout.Button("Happy")) { expression = 1; }
        if (GUILayout.Button("Sad")) { expression = 2; }
        if (GUILayout.Button("Angry")) { expression = 3; }
        if (GUILayout.Button("Fearful")) { expression = 4; }
        if (GUILayout.Button("Surprised")) { expression = 5; }
        GUILayout.EndArea();
    }

    // Update is called once per frame
    void Update () {
        //Expression(int expression, float intensity, float lerpSpeed, int blinkmin, int blinkmax)
        CharacterFacialExpressions.Expression(expression, 1, 0.12f, 40, 200);
    }
}
