using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowScore : GemCollision {

    void Update() {
        
        GetComponent<TextMesh>().text = "You Scored: " + score.ToString();
    }
}
