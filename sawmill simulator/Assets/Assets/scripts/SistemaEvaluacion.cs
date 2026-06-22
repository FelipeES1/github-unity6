using UnityEngine;

public class SistemaEvaluacion : MonoBehaviour
{
    [Header("Referencias")]
    public SistemaRiesgo sistemaRiesgo;
    public SistemaEPP sistemaEPP;

    [Header("Puntaje")]
    public int puntaje = 0;
    public int puntajeMax = 100;

    public string resultadoFinal;

    public void Evaluar()
    {
        puntaje = 100;

        // Penalización por riesgo
        float riesgo = sistemaRiesgo.riesgoActual;
        puntaje -= (int)riesgo;

        // Penalización por falta de EPP
        if (!sistemaEPP.casco) puntaje -= 20;
        if (!sistemaEPP.guantes) puntaje -= 20;

        puntaje = Mathf.Clamp(puntaje, 0, puntajeMax);

        DeterminarResultado();
    }

    void DeterminarResultado()
    {
        if (puntaje >= 70)
            resultadoFinal = "APROBADO";
        else
            resultadoFinal = "REPROBADO";
    }
}
