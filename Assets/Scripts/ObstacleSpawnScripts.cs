using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnScripts : MonoBehaviour
{
    public float maxTime = 2; //kaç saniyede bir engel çýkacaðýný belirlediðimiz kod.
    public float Timer = 0; //zamanlayýcý tutarak yeni objenin oluþacaðý aný belirliyoruz.
    public GameObject Obstacle; //oluþturacaðýmýz nesneyi seçiyoruz.
    public float width; //oluþan engellerin aralarýnýn rastgele oluþmasý için geniþlik belirliyoruz.

    void Start()
    {
        GameObject NewObstacle = Instantiate(Obstacle); //yeni bir engel oluþturuyoruz.
        NewObstacle.transform.position = transform.position + new Vector3(Random.Range(-width, width), 0, 0); //oluþturduðumuz nesnenin rastgele aralýkta olmasýný saðlýyoruz.
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
