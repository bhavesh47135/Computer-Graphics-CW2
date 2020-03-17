using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCorridor : MonoBehaviour {

    public GameObject Corridor;
    public float xPos = 4.186f;
    public float yPos = 0.26f;
    public float zPos = 39.577f;
    public int objQuantity = 0;

    void Start() {
        StartCoroutine(GenerateCorridor());
    }

    IEnumerator GenerateCorridor() {

        while (objQuantity <= 5) {
            yield return new WaitForSeconds(1);
            objQuantity += 1;
        }

        while (objQuantity > 5) {

            Corridor = Instantiate(Corridor, new Vector3(xPos, yPos, zPos), Quaternion.identity) as GameObject;
            Corridor.transform.eulerAngles = new Vector3(0f, 90f, 0f);

            yield return new WaitForSeconds(0.5f);
            objQuantity += 1;
            zPos += 3.996f;
        }
    }
}
