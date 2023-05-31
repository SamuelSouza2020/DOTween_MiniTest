using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int pontosAdquiridos = 0;
    public TextMeshProUGUI textPontos;
    public GameObject ButtonFim;
    void Start()
    {
        pontosAdquiridos = 0;
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector2(-5 * Time.deltaTime,0));
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector2(5 * Time.deltaTime,0));
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Pontos"))
        {
            pontosAdquiridos++;
            textPontos.text = pontosAdquiridos.ToString();
        }
        if(collision.gameObject.CompareTag("Enemy"))
        {
            ButtonFim.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
