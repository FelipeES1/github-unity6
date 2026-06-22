using UnityEngine;
using TMPro;

public class UIResultado : MonoBehaviour
{
    public SistemaEvaluacion evaluacion;

    public TextMeshProUGUI textoResultado;
    public TextMeshProUGUI textoPuntaje;
    public TextMeshProUGUI textoDetalle;

    public GameObject panel;

    public void MostrarResultado()
    {
        evaluacion.Evaluar();

        panel.SetActive(true);

        textoResultado.text = evaluacion.resultadoFinal;
        textoPuntaje.text = "Puntaje: " + evaluacion.puntaje;

        textoDetalle.text =
            "Riesgo final: " + evaluacion.sistemaRiesgo.riesgoActual + "\n" +
            "Casco: " + (evaluacion.sistemaEPP.casco ? "OK" : "FALTA") + "\n" +
            "Guantes: " + (evaluacion.sistemaEPP.guantes ? "OK" : "FALTA");
    }
}