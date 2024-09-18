using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controladorSom : MonoBehaviour
{
    private bool estadoSom = true;
    [SerializeField] private AudioSource fundoMusical;

    [SerializeField] private Sprite somLigadoSprite;
    [SerializeField] private Sprite somDeslisgadoSprite;

    [SerializeField] private Image muteImage;

    public void LigarDesligarSom() // faz que o som mude de verdadeiro para falso. e mudará a imagem dele e desativar/ativar ele
    {
        estadoSom = !estadoSom;
        fundoMusical.enabled = estadoSom;

        if (estadoSom)
        {
            muteImage.sprite = somLigadoSprite;
        }
        else
        {
            muteImage.sprite = somDeslisgadoSprite;
        }
    }

    public void VolumeMusica(float value) // faz que o valor do slider para o audiosource
    {
        fundoMusical.volume = value;
    }
}
