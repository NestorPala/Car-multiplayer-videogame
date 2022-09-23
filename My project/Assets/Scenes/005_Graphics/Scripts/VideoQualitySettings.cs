using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class VideoQualitySettings : MonoBehaviour
{
    public Button LessVideoQuality, MoreVideoQuality;
    public Text VQIndicator;
    private int VideoQuality;

    private string[] names;

    // Start is called before the first frame update
    void Start()
    {
        VideoQuality = QualitySettings.GetQualityLevel();

        names = QualitySettings.names;
        VQIndicator.text = ConvertToUpper(names[VideoQuality]);

        LessVideoQuality.onClick.AddListener(Minus);
        MoreVideoQuality.onClick.AddListener(Plus);
    }

    // Update is called once per frame
    void Minus()
    {
        //Debug.Log("BAJAR CALIDAD");
        VideoQuality--;
        QualitySettings.SetQualityLevel(VideoQuality, true);
        VQIndicator.text = ConvertToUpper(names[VideoQuality]);
    }

    void Plus()
    {
        //Debug.Log("SUBIR CALIDAD");
        VideoQuality++;
        QualitySettings.SetQualityLevel(VideoQuality, true);
        VQIndicator.text = ConvertToUpper(names[VideoQuality]);
    }

    String ConvertToUpper (String a) {
        string word1 = a;
        string word2 = word1.ToUpper();
        return word2;
    }
}
