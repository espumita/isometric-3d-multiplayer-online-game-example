using Photon.Pun;
using UnityEngine;

public class WorldNetworkManager : MonoBehaviourPunCallbacks {

    public GameObject PlayerPrefab;

    void Start() {
        PhotonNetwork.Instantiate(PlayerPrefab.name, new Vector3(0, 5, 0), Quaternion.identity);
    }

    void Update() {

    }
}
