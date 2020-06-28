
using Photon.Pun;
using TMPro;
using UnityEngine;

public class PlayerNameTag : MonoBehaviourPun {

    [SerializeField] private TextMeshProUGUI NickName;

    void Start() {
        if (photonView.IsMine) {
            NickName.text = PhotonNetwork.NickName;
        } else {
            NickName.text = photonView.Owner.NickName;
        }
    }
}
