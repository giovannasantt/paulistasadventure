using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public Transform pauseMenu;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // quando a tecla for apertada, pausará o jogo
        {
            if (pauseMenu.gameObject.activeSelf) //quando a tecla não for apertada, não ativará o menu e deixará o jogo continuar
            {
                pauseMenu.gameObject.SetActive(false);
                Time.timeScale = 1f;
            }
            else // quando for apertada, ativará menu e pausará o jogo
            {
                pauseMenu.gameObject.SetActive(true);
                Time.timeScale = 0f;
            }
        }

    }
    public void ContinuarJogo() // quando o botão do menu for apertado, irá fazer o jogo voltar/continuar
    {
        pauseMenu.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
}
