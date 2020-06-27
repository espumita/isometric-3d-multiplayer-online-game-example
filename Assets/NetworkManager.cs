﻿using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks {
    void Start() {
        Connect();
    }

    public void Connect() {
        PhotonNetwork.ConnectUsingSettings();
    }

    public void Play() {
        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinRandomFailed(short returnCode, string message) {
        Debug.Log($"OnJoinRandomFailed, returnCode:{returnCode} message:{message}");

        PhotonNetwork.CreateRoom(null, new RoomOptions {
            MaxPlayers = 4
        });
    }

    public override void OnJoinedRoom() {
        Debug.Log($"Connected to Room InRoom:{PhotonNetwork.InRoom}, {PhotonNetwork.CurrentRoom}");
        if (PhotonNetwork.IsMasterClient) {
            PhotonNetwork.LoadLevel(1);
    
        }
    }

    private void Awake() {
        PhotonNetwork.AutomaticallySyncScene = true;
    }


    void Update() {

    }




}
