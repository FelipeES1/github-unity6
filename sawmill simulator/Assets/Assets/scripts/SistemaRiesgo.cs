using UnityEngine;

public class SistemaRiesgo : MonoBehaviour
{
    [Header("Referencias")]
    public SistemaEPP epp; // referencia al sistema de equipamiento

    [Header("Valores de riesgo")]
    public float riesgoActual = 0f;
    public float riesgoMax = 100f;

    void Update()
    {
        CalcularRiesgo();
    }

    void CalcularRiesgo()
    {
        riesgoActual = 0f;

        // ✅ Penalización por falta de EPP
        if (!epp.casco) riesgoActual += 30f;
        if (!epp.guantes) riesgoActual += 30f;

        // ✅ Limitar valores
        riesgoActual = Mathf.Clamp(riesgoActual, 0f, riesgoMax);
    }

    // ✅ Valor normalizado (0 a 1) para UI
    public float ObtenerRiesgoNormalizado()
    {
        return riesgoActual / riesgoMax;
    }
}
