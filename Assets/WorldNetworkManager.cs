using Photon.Pun;
using UnityEngine;

public class WorldNetworkManager : MonoBehaviourPunCallbacks {

    public GameObject PlayerPrefab;

    void Start() {
        var playerNickName = PhotonNetwork.NickName;
        Debug.Log($"Player: {playerNickName} Join to:{PhotonNetwork.CurrentRoom.Name}");
        SpawnPlayer();
    }

    private void SpawnPlayer() {
        PhotonNetwork.Instantiate(PlayerPrefab.name, new Vector3(0, 5, 0), Quaternion.identity);
    }

}
