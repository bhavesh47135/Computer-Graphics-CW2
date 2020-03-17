using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleSpawn : MonoBehaviour {

    public GameObject Obstacle;
    public int xPos1;
    public int xPos2;
    public int zPos = 4;
    public int objQuantity;

    void Start() {
        StartCoroutine(GenerateObjects());
    }

    IEnumerator GenerateObjects() {

        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        

        while (objQuantity <= 15) {

            xPos1 = Random.Range(3, 6);
            xPos2 = Random.Range(3, 6);

            if ((sceneName == "HardLevel") || (sceneName == "EasyLevel")) {
                Instantiate(Obstacle, new Vector3(xPos1, -0.4f, zPos), Quaternion.identity);
            }
            if (sceneName == "VeryHardLevel") {
                Instantiate(Obstacle, new Vector3(xPos1, -0.4f, zPos), Quaternion.identity);
                Instantiate(Obstacle, new Vector3(xPos2, -0.4f, zPos), Quaternion.identity);
            }

            yield return new WaitForSeconds(0.1f);
            objQuantity += 1;
            zPos += 3;
        }

        while (objQuantity > 15) {
            
            xPos1 = Random.Range(3, 6);
            xPos2 = Random.Range(3, 6);

            if ((sceneName == "HardLevel") || (sceneName == "EasyLevel")) {
                Instantiate(Obstacle, new Vector3(xPos1, -0.4f, zPos), Quaternion.identity);
            }
            if (sceneName == "VeryHardLevel") {
                Instantiate(Obstacle, new Vector3(xPos1, -0.4f, zPos), Quaternion.identity);
                Instantiate(Obstacle, new Vector3(xPos2, -0.4f, zPos), Quaternion.identity);
            }

            yield return new WaitForSeconds(1);
            objQuantity += 1;
            zPos += 3;
        }
    }
}
