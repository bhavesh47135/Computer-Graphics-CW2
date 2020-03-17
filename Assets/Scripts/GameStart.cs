using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour {
    
    public float delay;

    void Start() {
        StartCoroutine(LoadLevelAfterDelay(delay));
    }

    IEnumerator LoadLevelAfterDelay(float delay) {

        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        yield return new WaitForSeconds(delay);

        if (sceneName == "EasyStart") {
            SceneManager.LoadScene("EasyLevel");
        }
        if (sceneName == "HardStart") {
            SceneManager.LoadScene("HardLevel");
        }
        if (sceneName == "VeryHardStart") {
            SceneManager.LoadScene("VeryHardLevel");
        }
    }
}
