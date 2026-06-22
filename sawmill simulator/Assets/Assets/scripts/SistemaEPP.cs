using UnityEngine;

public class SistemaEPP : MonoBehaviour
{
    public bool casco;
    public bool guantes;

    public void ToggleCasco()
    {
        casco = !casco;
        Debug.Log("Casco activo: " + casco);
    }
}