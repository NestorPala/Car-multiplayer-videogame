using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint_ID : MonoBehaviour
{
    static int TotalCheckpoints = LevelSettings.TotalCheckpoints;
    
    public GameObject[] Checkpoints = new GameObject[TotalCheckpoints];
    Checkpoint[] n = new Checkpoint[TotalCheckpoints];

    ////REVERSE AVOIDER
    public static bool[] CheckpointControl;


    void Start()
    {
        CheckpointControl = new bool[TotalCheckpoints];

        for (int i=0; i<CheckpointControl.Length; i++){
            CheckpointControl[i] = true; 
        }

        for (int i=0; i<TotalCheckpoints; i++) {
            n[i] = Checkpoints[i].GetComponent<Checkpoint>();
            n[i].ID = i+1;
            Checkpoints[i].tag = "Checkpoint";
        }
    }

    void Update() {
        ////REVERSE AVOIDER
        for (int i=0; i<TotalCheckpoints; i++) {
            Checkpoints[i].SetActive(CheckpointControl[i]);
        }
    }
}