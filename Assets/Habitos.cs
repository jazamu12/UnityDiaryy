using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Habitos : MonoBehaviour
{
    private List<string> Habito = new List<string>();

    private const string HabitListKey = "HabitList";

    void Start()
    {
        LoadHabits();   
    }

    public void Add(string Nombre)
    {
        if (!Habito.Contains(Nombre))
        {
            Habito.Add(Nombre);
            Guardar();
        }
    }
    public void Guardar()
    {
        string joined = string.Join(",", Habito);
        PlayerPrefs.SetString(HabitListKey, joined);
        PlayerPrefs.Save();
    }

    public void borrar(string Nombres)
    {
        if (Habito.Contains(Nombres))
        {
            Habito.Remove(Nombres);
            Guardar();
        }
    }
    private void LoadHabits()
    {
        string saved = PlayerPrefs.GetString(HabitListKey, "");
        if (!string.IsNullOrEmpty(saved))
        {
            Habito = new List<string>(saved.Split(','));
        }
    }

    public List<string> Habitlist()
    {
        return Habito;
    }

    public void marcar(string Nombres)
    {  
        string today = DateTime.Now.ToString("yyyy-MM-dd");
        string key = Nombres + "_" + today;
        if (PlayerPrefs.GetInt(key, 0) == 0)
        {
            PlayerPrefs.SetInt(key, 1);
            PlayerPrefs.Save();

        }

    }
}

