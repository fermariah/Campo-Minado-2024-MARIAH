using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ManagerUI : MonoBehaviour
{
    [SerializeField]
    Image barraDeDificuldade;

    [SerializeField] Gradient corDaBarra;

    [SerializeField] TextMeshProUGUI gameOverText;

    public void AtualizarBarra(float value)
    {
        barraDeDificuldade.fillAmount = value;
        barraDeDificuldade.color = corDaBarra.Evaluate(value);
    }

    public void AtualizarTexto(bool venceu)
    {
        if (venceu)
        {
            gameOverText.text = "Vitoria";
        }
        else
        {
            gameOverText.text = "Derrota";
        }
    }
}
