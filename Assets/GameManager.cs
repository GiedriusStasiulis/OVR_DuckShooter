using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject rightHand;
    public OVRGrabber ovrScript;
    public Transform ballSpawnPoint;
    public GameObject gameBall;

    public bool spawnBall;

    void Start()
    {   
        spawnBall = true;

        Instantiate(gameBall, ballSpawnPoint.transform.position, Quaternion.identity);

        rightHand = GameObject.Find("DistanceGrabHandRight");
        ovrScript = rightHand.GetComponent<OVRGrabber>();
    }

    void Update()
    {
        if(spawnBall && ovrScript.BallReleased)
        {
            //Spawn ball on table
            Instantiate(gameBall, ballSpawnPoint.transform.position, Quaternion.identity);

            //Reset bool value to false
            ovrScript.BallReleased = false;
        }
    }
    
}
