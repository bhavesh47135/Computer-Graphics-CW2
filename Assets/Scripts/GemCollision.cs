using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GemCollision : MonoBehaviour {
    
    protected static int score = 0;

    void OnTriggerEnter(Collider col) {
        
        if (col.gameObject.name == "AcquireChan") {
            score += 100;
            Destroy(this.gameObject);
        }
    }

    private GUIStyle guiStyle = new GUIStyle();

    void OnGUI() {

        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        guiStyle.fontSize = 20;
        guiStyle.normal.textColor = Color.green;
        
        if ((sceneName == "HardLevel") || (sceneName == "EasyLevel") || (sceneName == "VeryHardLevel")) {
            //GUILayout.Label("Your score is: " + score);
            GUI.Label(new Rect(5, 30, 80, 20), "Your Score Is:", guiStyle);
            GUI.Label(new Rect(135, 30, 80, 20), score.ToString(), guiStyle);

            if (sceneName == "EasyLevel") {
                GUI.Label(new Rect(5, 60, 80, 20), "Current Difficulty is Easy", guiStyle);
            }
            if (sceneName == "HardLevel") {
                GUI.Label(new Rect(5, 60, 80, 20), "Current Difficulty is Hard", guiStyle);
            }
            if (sceneName == "VeryHardLevel") {
                GUI.Label(new Rect(5, 60, 80, 20), "Current Difficulty is Very Hard", guiStyle);
            }
        }
    }
}
