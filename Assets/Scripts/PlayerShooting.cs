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
        if (photonView.IsMine && Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    [PunRPC]

    void Shoot()
    {
        GameObject bullet = PhotonNetwork.Instantiate(bulletPrefab.name, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Bullet>().Initialize(bulletSpeed, photonView.Owner);
    }
}
