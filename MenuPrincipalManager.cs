using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDejogo;

    public void Jogar() //quando apertar o bot�o jogar, iniciar� o jogo
    {
        SceneManager.LoadScene(nomeDoLevelDejogo);
    }

    public void SairJogo() // quando apertar o bot�o sair, sair� do jogo
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
