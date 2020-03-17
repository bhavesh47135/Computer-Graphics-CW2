using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSpawn : MonoBehaviour {

    public GameObject aDiamond;
    public GameObject aRuby;
    public GameObject aEmerald;
    public GameObject aStar;
    public int xPos;
    public int zPos = 4;
    public int objToGen;
    public int objQuantity;

    void Start() {
        StartCoroutine(GenerateObjects());
    }

    IEnumerator GenerateObjects() {

        while (objQuantity <= 5) {

            objToGen = Random.Range(1, 5);
            xPos = Random.Range(3, 6);

            if (objToGen == 1) {
                aDiamond = Instantiate(aDiamond, new Vector3(xPos, 1.7f, zPos), Quaternion.identity) as GameObject;
                aDiamond.transform.eulerAngles = new Vector3(-90f, 0f, 0f);
            }
            if (objToGen == 2) {
                aRuby = Instantiate(aRuby, new Vector3(xPos, 1.7f, zPos), Quaternion.identity) as GameObject;
                aRuby.transform.eulerAngles = new Vector3(-90f, 0f, 0f);
            }
            if (objToGen == 3) {
                aEmerald = Instantiate(aEmerald, new Vector3(xPos, 1.7f, zPos), Quaternion.identity) as GameObject;
                aEmerald.transform.eulerAngles = new Vector3(-90f, 0f, 0f);
            }
            if (objToGen == 4) {
                aStar = Instantiate(aStar, new Vector3(xPos, 1.7f, zPos), Quaternion.identity) as GameObject;
                aStar.transform.eulerAngles = new Vector3(-90f, 0f, 0f);
            }

            yield return new WaitForSeconds(0.1f);
            objQuantity += 1;
            zPos += 7;
        }

        while (objQuantity > 5) {

            objToGen = Random.Range(1, 5);
            xPos = Random.Range(3, 6);

            if (objToGen == 1) {
                aDiamond = Instantiate(aDiamond, new Vector3(xPos, 1.7f, zPos), Quaternion.identity) as GameObject;
                aDiamond.transform.eulerAngles = new Vector3(-90f, 0f, 0f);
            }
            if (objToGen == 2) {
                aRuby = Instantiate(aRuby, new Vector3(xPos, 1.7f, zPos), Quaternion.identity) as GameObject;
                aRuby.transform.eulerAngles = new Vector3(-90f, 0f, 0f);
            }
            if (objToGen == 3) {
                aEmerald = Instantiate(aEmerald, new Vector3(xPos, 1.7f, zPos), Quaternion.identity) as GameObject;
                aEmerald.transform.eulerAngles = new Vector3(-90f, 0f, 0f);
            }
            if (objToGen == 4) {
                aStar = Instantiate(aStar, new Vector3(xPos, 1.7f, zPos), Quaternion.identity) as GameObject;
                aStar.transform.eulerAngles = new Vector3(-90f, 0f, 0f);
            }

            yield return new WaitForSeconds(1);
            objQuantity += 1;
            zPos += 7;
        }
    }
}
