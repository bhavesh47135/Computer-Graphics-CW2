using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountTime : MonoBehaviour {
    
    float currentTime = 0f;

    void Start() {
        currentTime = 0f;
    }
    
    void Update() {
        currentTime += Time.deltaTime;
    }

    private GUIStyle guiStyle = new GUIStyle();

    void OnGUI() {
        guiStyle.fontSize = 20;
        guiStyle.normal.textColor = Color.green;
        GUI.Label(new Rect(5, 0, 80, 20), "Time Elapsed:", guiStyle);
        GUI.Label(new Rect(140, 0, 80, 20), currentTime.ToString(), guiStyle);
    }
}
