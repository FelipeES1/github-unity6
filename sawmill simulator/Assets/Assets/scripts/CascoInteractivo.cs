using UnityEngine;

public class CascoInteractivo : ObjetoInteractivo
{
    public SistemaEPP sistemaEPP;
    public UIMensaje uiMensaje;

    public override void Interactuar()
    {
        if (sistemaEPP != null)
        {
            sistemaEPP.ToggleCasco();

            // ✅ Desaparece objeto
            gameObject.SetActive(false);

            // ✅ Mensaje UI
            if (uiMensaje != null)
                uiMensaje.MostrarMensaje("Casco equipado");

            Debug.Log("Casco equipado correctamente");
        }
    }
}