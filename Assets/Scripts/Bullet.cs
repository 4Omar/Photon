using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviourPun
{
    private float speed = 10f;
    public float lifetime = 2f;
    private Photon.Realtime.Player owner;

    public void Initialize(float bulletspeed, Photon.Realtime.Player bulletOwner)
    {
        speed = bulletspeed;
        owner = bulletOwner;
    }
    // Start is called before the first frame update
    void Start()
    {
        if (photonView.IsMine)
        {
            Destroy(gameObject, 1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (photonView.IsMine && other.CompareTag("Player"))
        {
            Debug.Log("Jugador golpeado");
            PhotonNetwork.Destroy(gameObject);
        }
    }

}
