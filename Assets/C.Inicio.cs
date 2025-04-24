using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public void CambiarAEscena(string Inicio)
    {
        SceneManager.LoadScene(Inicio);
        Debug.Log("funciona puto");
    }
}
