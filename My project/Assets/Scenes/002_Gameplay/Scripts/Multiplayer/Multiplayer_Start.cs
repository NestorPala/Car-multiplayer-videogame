using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiplayer_Start : MonoBehaviour
{
    Rigidbody m_Rigidbody;

    void Start() {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.constraints = RigidbodyConstraints.FreezePosition;
        Multiplayer_PlayerCounter.playersInGame++;
    }

    void Update()
    {
        if (Multiplayer_PlayerCounter.readyToStart) {
            m_Rigidbody.constraints = RigidbodyConstraints.None;
        }
    }
}
