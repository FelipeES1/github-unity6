using UnityEngine;
using UnityEngine.UI;

public class UIRiesgo : MonoBehaviour
{
    public SistemaRiesgo sistemaRiesgo;
    public Image barraFill;

    void Update()
    {
        float valor = sistemaRiesgo.ObtenerRiesgoNormalizado();

        barraFill.fillAmount = valor;

        // Cambio de color
        if (valor < 0.3f)
            barraFill.color = Color.green;
        else if (valor < 0.7f)
            barraFill.color = Color.yellow;
        else
            barraFill.color = Color.red;
    }
}