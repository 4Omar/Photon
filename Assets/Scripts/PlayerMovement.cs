using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMovement : MonoBehaviourPun
{
    public float speed = 5f;

    public GameObject bulletPrefab;

    public Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (photonView.IsMine)
        {
          float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
          float moveZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
          transform.Translate(new Vector3 (moveX, 0, moveZ));

          if (Input.GetButtonDown("Fire1"))
           {
              photonView.RPC("Shoot", RpcTarget.All);
           }
        }
    }

    [PunRPC]

    void Shoot()
    {
        GameObject bullet = PhotonNetwork.Instantiate("Bullet", firePoint.position, firePoint.rotation);
        bullet.GetComponent<Bullet>().photonView.TransferOwnership(photonView.Owner);
    }
}
