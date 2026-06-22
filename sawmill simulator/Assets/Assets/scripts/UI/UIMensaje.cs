using UnityEngine;
using TMPro;
using System.Collections;

public class UIMensaje : MonoBehaviour
{
    public TextMeshProUGUI texto;
    public float duracion = 2f;

    public void MostrarMensaje(string mensaje)
    {
        StopAllCoroutines();
        StartCoroutine(Mostrar(mensaje));
    }

    IEnumerator Mostrar(string mensaje)
    {
        texto.text = mensaje;
        texto.gameObject.SetActive(true);

        yield return new WaitForSeconds(duracion);

        texto.gameObject.SetActive(false);
    }
}