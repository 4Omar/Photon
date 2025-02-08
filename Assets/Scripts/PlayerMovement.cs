using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMovement : MonoBehaviourPun
{
    public float speed = 5f;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (photonView.IsMine)
        {
          float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
          float moveZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
          
            Vector3 movement = new Vector3(moveX, 0, moveZ) * speed;
            rb.velocity = movement;

        }
    }
}
