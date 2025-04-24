using UnityEngine;
using UnityEngine.UI;
using TMPro;

[ExecuteInEditMode()]
public class Experiencia : MonoBehaviour
{
    public Image mask;
    public Habitos habitManager;
    public TextMeshProUGUI textoExperiencia;
    public GameObject LogroPopup;
    public TMP_Text popupText;

    public void CompletarHábitoDesdeUI(string nombre)
    {
        habitManager.marcar(nombre);
    }

    public int maximo = 100;
   
    int nivel = 0;
    int experiencia = 10;

    private void Update()
    {
        relleno();
    }
    
    public void Addexp(int cantidad)
    {
        experiencia = experiencia + cantidad;
    }

    public void Subirlvl()
    {
        if (experiencia >= maximo)
        {
            nivel = nivel + 1;
            experiencia = 0;
        }
    }

    void relleno()
    {

        float fillAmount = (float)experiencia / (float)maximo;
        mask.fillAmount = fillAmount;

        if (textoExperiencia != null)
        {
            textoExperiencia.text = experiencia + " / " + maximo;
        }
    }
    public void Checknivel(int level)
    {
        if (level == 5)
            Logros("¡Nivel 5 alcanzado!");

    }
    void Logros(string message)
    {
        popupText.text = message;
        LogroPopup.SetActive(true);
        CancelInvoke("HidePopup");
        Invoke("HidePopup", 3f); 
    }

}


