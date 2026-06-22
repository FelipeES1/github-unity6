using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class FPSController : MonoBehaviour
{
    public float velocidad = 5f;
    public float gravedad = -9.8f;
    public float sensibilidadMouse = 2f;
    public float sensibilidadRotacion = 100f;

    public Transform camara;

    float velocidadY;
    float rotacionVertical = 0f;

    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        
        if (controller == null)
        {
            Debug.LogError("CharacterController no encontrado en el GameObject");
            enabled = false;
            return;
        }

        if (camara == null)
        {
            Debug.LogError("Cámara no asignada en FPSController");
            enabled = false;
            return;
        }

        // Bloquear cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Desbloquear cursor con ESC
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Cursor.lockState == CursorLockMode.Locked)
                Cursor.lockState = CursorLockMode.None;
            else
                Cursor.lockState = CursorLockMode.Locked;
        }

        Movimiento();
        RotacionMouse();
    }

    void Movimiento()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movimiento = transform.right * x + transform.forward * z;

        if (controller.isGrounded)
        {
            if (velocidadY < 0)
                velocidadY = -2f;
        }

        velocidadY += gravedad * Time.deltaTime;

        Vector3 movimientoFinal = movimiento * velocidad;
        movimientoFinal.y = velocidadY;

        controller.Move(movimientoFinal * Time.deltaTime);
    }

    void RotacionMouse()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensibilidadMouse * sensibilidadRotacion * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidadMouse * sensibilidadRotacion * Time.deltaTime;

        rotacionVertical -= mouseY;
        rotacionVertical = Mathf.Clamp(rotacionVertical, -80f, 80f);

        camara.localRotation = Quaternion.Euler(rotacionVertical, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }
}
