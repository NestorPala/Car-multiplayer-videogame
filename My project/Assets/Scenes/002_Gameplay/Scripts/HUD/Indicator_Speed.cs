using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using System;

public class Indicator_Speed : MonoBehaviour
{
    public GameObject player;
    Player playerController;

    public Text m_SpeedText;
    public Sprite s000, s040, s080, s120, s160, s200;
    public GameObject SpeedIndicator;
    public float Speed;
    

    void Start () {
        playerController = player.GetComponent<Player>();
    }


    void Update()
    {
        Speed = playerController.getSpeed();
        m_SpeedText.text = string.Format("{0:0}", Speed);

        if (Speed >= 0){
            SpeedIndicator.GetComponent<Image>().overrideSprite = s000;
        }

        if (Speed >= 40){
            SpeedIndicator.GetComponent<Image>().overrideSprite = s040;
        }

        if (Speed >= 80){
            SpeedIndicator.GetComponent<Image>().overrideSprite = s080;
        }

        if (Speed >= 120){
            SpeedIndicator.GetComponent<Image>().overrideSprite = s120;
        }

        if (Speed >= 160){
            SpeedIndicator.GetComponent<Image>().overrideSprite = s160;
        }

        if (Speed >= 200){
            SpeedIndicator.GetComponent<Image>().overrideSprite = s200;
        }
    }
}
