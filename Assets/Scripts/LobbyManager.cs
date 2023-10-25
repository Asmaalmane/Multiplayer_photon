using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;


public class LobbyManager : MonoBehaviourPunCallbacks
{
    [SerializeField] TMP_InputField playerInput;

    public void Join()
    {
        PhotonNetwork.JoinRoom(playerInput.text);
        
    }

    public void Create()
    {
        PhotonNetwork.CreateRoom(playerInput.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel(2);
    }


}
