using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public float speed;
    public float newSpeedTime;
    public float Timer;
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;

        Timer += Time.deltaTime;
        if (Timer > newSpeedTime)
        {
            speed ++;
            newSpeedTime++;
            Timer = 0;
        }

    }
}
