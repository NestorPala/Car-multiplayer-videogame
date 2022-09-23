using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Multiplayer_HUD : NetworkBehaviour
{
    public Canvas HUD;

    void Start()
    {
        if (isLocalPlayer) return;
 
        HUD.enabled = false;
    }
}
