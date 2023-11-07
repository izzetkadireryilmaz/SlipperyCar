using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnScripts : MonoBehaviour
{
    public float maxTime = 2; //ka� saniyede bir engel ��kaca��n� belirledi�imiz kod.
    public float Timer = 0; //zamanlay�c� tutarak yeni objenin olu�aca�� an� belirliyoruz.
    public GameObject Obstacle; //olu�turaca��m�z nesneyi se�iyoruz.
    public float width; //olu�an engellerin aralar�n�n rastgele olu�mas� i�in geni�lik belirliyoruz.

    void Start()
    {
        GameObject NewObstacle = Instantiate(Obstacle); //yeni bir engel olu�turuyoruz.
        NewObstacle.transform.position = transform.position + new Vector3(Random.Range(-width, width), 0, 0); //olu�turdu�umuz nesnenin rastgele aral�kta olmas�n� sa�l�yoruz.
    }

    void Update()
    {
       if (Timer > maxTime)
        {
            GameObject NewObstacle = Instantiate(Obstacle);
            NewObstacle.transform.position = transform.position + new Vector3(Random.Range(-width, width), 0, 0);
            Destroy(NewObstacle,10);
            Timer = 0;
        }

       Timer += Time.deltaTime;
    }
}
