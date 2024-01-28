using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class ConnectionButtons : MonoBehaviour
{
    public void Join()
    {
        NetworkManager.Singleton.StartClient();
    }

    public void StartClient()
    {
        NetworkManager.Singleton.StartHost();
    }
}
