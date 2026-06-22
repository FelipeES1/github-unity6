using UnityEngine;

public class ObjetoInteractivo : MonoBehaviour
{
    public string mensaje = "Objeto interactuado";

    public virtual void Interactuar()
    {
        Debug.Log(mensaje);
    }
}