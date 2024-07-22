using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPaddleControler : MonoBehaviour
{
    private Rigidbody2D rb;
    public float Speed = 3f;

    private GameObject ball;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ball = GameObject.Find("Ball"); //Encontra o objeto da bola na cena
    }

     void Update()
    {
     if (ball != null)
        {
            float targetY = Mathf.Clamp(ball.transform.position.y, -4.5f, 4.5f);
            Vector2 TargetPosition = new Vector2(transform.position.x, targetY);
            transform.position = Vector2.MoveTowards(transform.position, TargetPosition, Time.deltaTime * Speed);
        }
    }
}