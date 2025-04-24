using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioOpc : MonoBehaviour
{
    public void CambiarAEscena(string Opciones)
    {
        SceneManager.LoadScene(Opciones);
    }
}