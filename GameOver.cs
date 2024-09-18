using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    public Transform gameOverMenu;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0f) //quando o jogador estiver abaixo do limite, aparecer menu  game over e indicar que o jogador perdeu
        {
                gameOverMenu.gameObject.SetActive(true);
                Time.timeScale = 0f;
        }

    }
    public void VoltarMenu() // quando apertado, voltar ao menu principal
    {
        SceneManager.LoadScene("Menu");
    }



    private void OnCollisionEnter(Collision collision) // chama a classe collision
    {
        switch (collision.gameObject.tag) //faz que só ative quando o jogador encostar no collider com essa tega, ativa o menu gameover
        {
            case "Barreira":
                gameOverMenu.gameObject.SetActive(true);
                Time.timeScale = 0f;
                break;

        }
    }
}
