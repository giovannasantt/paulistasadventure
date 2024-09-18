using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movimentacao : MonoBehaviour
{
    Vector3 movimento;
    [SerializeField] private string nomeDoLevelDejogo;

    public Animator anim;
    public Animator anim2;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;  // Definindo o timescale para 1
        movimento = new Vector3(-496f, 3.5f, 0f); // definindo valores do vector 3
        transform.position = movimento; // definindo a posição de acordo com vector 3
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1f) // Apenas funcionara se o timeScale do jogo for 1, ou seja, quando o jogo estiver rodando
        {
            if (transform.position.x < -201f) //faz com que o personagem ande até chegar no limite
            {
                movimento.x = 0.05f;
                movimento.y = 0f;
                movimento.z = 0f;
                transform.Translate(movimento);
            }
            if (transform.position.x > -201f) // Quando chegar no limite muda a cena
            {
                SceneManager.LoadScene(nomeDoLevelDejogo);
            }

            if (Input.GetKey(KeyCode.Space)) // fazer o personagem pular
            {
                if (transform.position.y < 5f)
                {
                    movimento.x = 0f;
                    movimento.y = 0.03f;
                    movimento.z = 0f;
                    transform.Translate(movimento);
                    anim.SetBool("Pulo", true); // mudar a animação quando pular
                    anim2.SetBool("Pulo", true); // mudar a animação quando pular
                }
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                anim.SetBool("Pulo", false); // mudar a animação quando deixar de pular
                anim2.SetBool("Pulo", false); // mudar a animação quando deixar de pular
            }
            else // quando timescale for 0, pausar o personagem
            {
                movimento.x = 0;
                movimento.y = 0;
                movimento.z = 0;
                transform.Translate(movimento);
            }

        }
    }
}
