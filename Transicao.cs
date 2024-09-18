using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transicao : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDejogo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown) //quando qualquer tecla for apertada, trocar� a cena
        {
            SceneManager.LoadScene(nomeDoLevelDejogo);
        }
    }
}
