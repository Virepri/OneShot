﻿using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {
    // Update is called once per frame
    public GameObject camera;

    public override void OnStartLocalPlayer() {
        camera.SetActive(true);
    }


    void Update () {
        if (!isLocalPlayer)
            return;

        gameObject.transform.Rotate(new Vector3(0, 1, 0), Input.GetAxis("Mouse X"));
        gameObject.transform.position += gameObject.transform.forward * (Input.GetAxis("Vertical") * 0.1f);
        gameObject.transform.position += gameObject.transform.right * (Input.GetAxis("Horizontal") * 0.1f);
        
        if (Input.GetKeyDown(KeyCode.Q)) {
            gameObject.transform.position += Vector3.up;
            gameObject.GetComponent<Rigidbody>().AddForce(transform.right * -10);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            gameObject.transform.position += Vector3.up;
            gameObject.GetComponent<Rigidbody>().AddForce(transform.right * 10);
        }
        //gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(Input.GetAxis("Horizontal") * 10, 0, Input.GetAxis("Vertical") * 10));
    }
}





