using UnityEngine;

public class DetectorInteractable : MonoBehaviour
{
    public float distancia = 3f;
    public LayerMask capaInteractuable;

    public Transform camara;

    public bool detectando { get; private set; }
    public RaycastHit hitActual ;

    void Update()
    {
        Ray ray = new Ray(camara.position, camara.forward);

        detectando = Physics.Raycast(ray, out hitActual, distancia, capaInteractuable);

        Debug.DrawRay(ray.origin, ray.direction * distancia, Color.red);
    }
}