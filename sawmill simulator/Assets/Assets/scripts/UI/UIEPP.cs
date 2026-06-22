using UnityEngine;
using UnityEngine.UI;

public class UIEPP : MonoBehaviour
{
    public SistemaEPP epp;

    public Image iconoCasco;
    public Image iconoGuantes;

    public Color activo = Color.white;
    public Color inactivo = Color.gray;

    void Update()
    {
        iconoCasco.color = epp.casco ? activo : inactivo;
        iconoGuantes.color = epp.guantes ? activo : inactivo;
    }
}