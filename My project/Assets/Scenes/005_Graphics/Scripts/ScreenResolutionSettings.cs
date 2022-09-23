using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScreenResolutionSettings : MonoBehaviour
{
    public Button LessScreenResolution, MoreScreenResolution;
    public Text SRIndicator;
    private Resolution ScreenResolution;
    private Resolution[] Resolutions;
    private String[] ResolutionNames;
    private int SR;
    private bool IsFullScreen;


    void Start()
    {
        IsFullScreen = Screen.fullScreen;

        ScreenResolution = Screen.currentResolution;
        Resolutions = Screen.resolutions;
        ResolutionNames = new String[Resolutions.Length];

        for (int i=0; i<Resolutions.Length; i++) {
            ResolutionNames[i] = Resolutions[i].width + " X " + Resolutions[i].height;

            if (Resolutions[i].width == ScreenResolution.width && Resolutions[i].height == ScreenResolution.height) {
                SR = i;
            }
        }

        SRIndicator.text = ResolutionNames[SR];

        LessScreenResolution.onClick.AddListener(Minus);
        MoreScreenResolution.onClick.AddListener(Plus);
    }

    void Minus()
    {
        SR--;
        Screen.SetResolution(Resolutions[SR].width, Resolutions[SR].height, true);
        if (!IsFullScreen) Screen.fullScreen = false;
        SRIndicator.text = ResolutionNames[SR];
    }

    void Plus()
    {
        SR++;
        Screen.SetResolution(Resolutions[SR].width, Resolutions[SR].height, true);
        if (!IsFullScreen) Screen.fullScreen = false;
        SRIndicator.text = ResolutionNames[SR];
    }
}
