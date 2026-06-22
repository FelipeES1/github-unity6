using UnityEngine;

public class InteraccionAvanzada : MonoBehaviour
{
    public DetectorInteractable detector;
    public GameObject indicadorUI;

    bool estadoUI = false;

    void Update()
    {
        if (detector.detectando)
        {
            if (!estadoUI)
            {
                estadoUI = true;
                if (indicadorUI != null)
                    indicadorUI.SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                detector.hitActual.collider.SendMessage("Interactuar", SendMessageOptions.DontRequireReceiver);
            }
        }
        else
        {
            if (estadoUI)
            {
                estadoUI = false;
                if (indicadorUI != null)
                    indicadorUI.SetActive(false);
            }
        }
    }
}
