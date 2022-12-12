using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BirdScript : MonoBehaviour
{
    public float ziplama_aralýðý;
    Rigidbody2D rb;
    public Text skor_text;
    public float skor;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        skor = 0;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            rb.velocity = Vector2.up * ziplama_aralýðý;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * ziplama_aralýðý;
        }

        skor_text.text = skor.ToString();
    }

    void OnTriggerEnter2D(Collider2D temas)
    {
    if(temas.gameObject.tag == "Scorer")
        {
            skor++;
        }
    }
    void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag == "ölüm")
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(2);

        }

    }
}
