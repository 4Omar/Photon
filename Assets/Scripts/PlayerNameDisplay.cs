using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class PlayerNameDisplay : MonoBehaviourPun
{
    public GameObject nameLabelPrefab;
    public GameObject nameLabel;

    // Start is called before the first frame update
    void Start()
    {
        if (photonView.IsMine)
        {
            nameLabel = Instantiate(nameLabelPrefab, Vector3.zero, Quaternion.identity);
            nameLabel.transform.SetParent(GameObject.Find("Canva").transform, false);

            TextMeshProUGUI nameText = nameLabel.GetComponent<TextMeshProUGUI>();
            nameText.text = photonView.Owner.NickName;

            nameText.color = Color.green;
        }
        else
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
