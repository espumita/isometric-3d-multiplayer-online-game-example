
using Photon.Pun;
using TMPro;
using UnityEngine;

public class PlayerNameTag : MonoBehaviourPun {

    [SerializeField] private TextMeshProUGUI NickName;

    void Start() {
        NickName.text = photonView.IsMine 
            ? PhotonNetwork.NickName 
            : photonView.Owner.NickName;
    }
}
