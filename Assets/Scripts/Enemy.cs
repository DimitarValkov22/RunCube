using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3f;

    float startingYPosition;
    public static int score;
    public static int highScore;

    void Start()
    {
        startingYPosition = transform.position.y;
        score = 0;
    }

    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * moveSpeed;

        if(transform.position.x <= -15)
        {
            transform.position += Vector3.right * 30f;
            float newY = startingYPosition + UnityEngine.Random.Range(-1f, 1f);
            transform.position = new Vector3(transform.position.x, newY, 0f);
            score++;
            if(score > highScore)
            {
                highScore = score;
            }
        }
    }
}
