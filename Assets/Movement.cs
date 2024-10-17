using UnityEngine;
using System.Collections;
using Unity.VisualScripting;
using System;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{

    public float speed = 5f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            speed = 7.5f;
        }
        else
        {
            speed = 5f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(speed * Time.deltaTime * Vector2.up);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(speed * Time.deltaTime * Vector2.left);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(speed * Time.deltaTime * Vector2.down);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime * Vector2.right);
        }
    }

    void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Deadly"))
        {
            Die();
        }
    }

    private void Die()
    {
        Timer.TimeSinceStart = 0;
        SceneManager.LoadScene("SampleScene");
    }

}