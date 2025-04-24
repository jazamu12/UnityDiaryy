using UnityEngine;
using UnityEngine.SceneManagement;

public class Ccambinfo : MonoBehaviour
{
    public void CambiarAEscena(string Info)
    {
        SceneManager.LoadScene(Info);
    }
}