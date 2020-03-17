using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    float speed = 4;
    float rotSpeed = 400;
    float rot = 0f;
    float gravity = 8;

    Vector3 moveDir = Vector3.zero;
    CharacterController controller;
    Animator anim;

    void Start() {
        controller = GetComponent<CharacterController> ();
        anim = GetComponent<Animator> ();
    }

    void Update() {
        Movement();
        Jumping();
    }
    
    void Movement() {

        if (Input.GetKey (KeyCode.W)) {
            anim.SetInteger("Condition", 1);
            moveDir = new Vector3(0 , 0, 1);
            moveDir *= speed;
            moveDir = transform.TransformDirection(moveDir);
        }
        if (Input.GetKeyUp(KeyCode.W)) {
            anim.SetInteger("Condition", 0);
            moveDir = new Vector3(0, 0, 0);
        }   
        
        rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);
        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);
    }

    void Jumping() {
        if (Input.GetKey(KeyCode.Space)) {
            anim.SetInteger("Condition", 2);
        }
        if (Input.GetKeyUp(KeyCode.Space)) {
            anim.SetInteger("Condition", 0);
            moveDir = new Vector3(0, 0, 0);
        }  
    }
}
