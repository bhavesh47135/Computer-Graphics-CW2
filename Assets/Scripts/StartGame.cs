using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class StartGame : GemCollision {

	public void changeScene(string Game) {

        SceneManager.LoadScene(Game);
        score = 0;
    }
}