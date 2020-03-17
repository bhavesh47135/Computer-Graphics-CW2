using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnd : MonoBehaviour {

    public float zPos = 3.996f;
    public int objQuantity = 0;

    void Start() {
        StartCoroutine(Move());
    }

    IEnumerator Move() {

        while (objQuantity <= 5) {
            
            yield return new WaitForSeconds(1);
            objQuantity += 1;
        }

        while (objQuantity > 5) {

            gameObject.transform.Translate(0, 0, zPos);

            yield return new WaitForSeconds(0.5f);
            objQuantity += 1;
        }
    }
}
