using UnityEngine;
using UnityEngine.UI;

public class CrosshairUI : MonoBehaviour
{
    public Image crosshair;
    public Color normal = Color.white;
    public Color interactivo = Color.green;

    public DetectorInteractable detector;

    bool estadoInteractivo = false;

    void Update()
    {
        if (detector.detectando && !estadoInteractivo)
        {
            estadoInteractivo = true;
            crosshair.color = interactivo;
        }
        else if (!detector.detectando && estadoInteractivo)
        {
            estadoInteractivo = false;
            crosshair.color = normal;
        }
    }
}
