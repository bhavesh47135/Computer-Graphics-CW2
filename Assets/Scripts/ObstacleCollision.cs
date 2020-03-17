using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleCollision : MonoBehaviour {
    void OnTriggerEnter(Collider col) {
        
        if (col.gameObject.name == "AcquireChan") {
            SceneManager.LoadScene("Win");
        }
    }
}
