using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class CarManager : MonoBehaviour
{
    int score;
    Vector2 direction;
    public float speed;
    private Rigidbody2D rb;
    public GameObject DeadScene;
    public GameObject Player;
    public Text ScoreText;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, rb.velocity.y);
        DeadScene.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 touch = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (touch.x < transform.position.x)
            {
                rb.velocity = new Vector2(-speed, rb.velocity.y);
            }
            else
            {
                rb.velocity = new Vector2(speed, rb.velocity.y);
            }
        }

        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstancle")
        {
            DeadScene.SetActive(true);
            Player.transform.position = new Vector3(0, -3.7f, 0);
            Player.SetActive(false);
        }

        if (collision.gameObject.tag == "Collider")
        {
            DeadScene.SetActive(true);
            Player.transform.position = new Vector3 (0,-3.7f, 0);
            Player.SetActive(false);
        }

        if (collision.gameObject.tag == "Scorer")
        {
            score++;
            ScoreText.text = score.ToString();
        }
    }

}
