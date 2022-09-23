using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int id;
    private int place;
    private int lapsDone;
    private float speed;
    private string time;

    private int ActualCheckpoint, NextCheckpoint;
    private bool almostFinishedRace;
    //private bool isUpsideDown = false;

    public Rigidbody vehicleBody;


    void start() {
        this.id = Multiplayer_PlayerCounter.getPlayerID();
        this.lapsDone = 0;
        this.speed = 0;

        this.ActualCheckpoint = 0;
        this.NextCheckpoint = 1;

        this.almostFinishedRace = false;
    }


    public void setPlace (int place) {
        this.place = place;
    }

    public void setLapsDone (int lapsDone) {
        this.lapsDone = lapsDone;
    }

    public void setSpeed (float speed) {
        this.speed = speed;
    }

    public void setTime (string time) {
        this.time = time;
    }

    public int getPlayerID() {
        return this.id;
    }

    public int getPlace() {
        return this.place;
    }

    public int getLapsDone() {
        return this.lapsDone;
    }

    public float getSpeed() {
        return this.speed;
    }

    public string getTime() {
        return this.time;
    }

    public void setActualCheckpoint (int ac) {
        this.ActualCheckpoint = ac;
    }

    public int getActualCheckpoint() {
        return this.ActualCheckpoint;
    }

    public void setNextCheckpoint (int nc) {
        this.NextCheckpoint = nc;
    }

    public int getNextCheckpoint() {
        return this.NextCheckpoint;
    }

    public void setAlmostFinishedRace(bool status) {
        this.almostFinishedRace = status;
    }

    public bool getAlmostFinishedRace() {
        return this.almostFinishedRace;
    }


    void Update() {
        this.setSpeed((vehicleBody.velocity.magnitude*60*60)/1000);
        //this.setTime(Indicator_Timer.getTime());
    }
}
