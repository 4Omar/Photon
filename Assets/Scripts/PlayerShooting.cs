using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Chat;
using Photon.Pun;

public class PlayerShooting : MonoBehaviourPun
{
    public GameObject bulletPrefab;

    public Transform firePoint;

    public float bulletSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        if (photonView.IsMine)
        {
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
