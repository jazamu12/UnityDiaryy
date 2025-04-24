using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;


public class HabitUIManager : MonoBehaviour
{
    public Habitos habitSystem;
    public GameObject habitItemPrefab;
    public Transform habitListContainer;
    public TMP_InputField HabitosInput;
    void Start()
    {
        RefreshHabitList();
    }

    public void OnAddHabitButton()
    {
        string name = HabitosInput.text;
        if (!string.IsNullOrEmpty(name))
        {
            habitSystem.Add(name);
            habitSystem.Guardar();
            HabitosInput.text = "";
            RefreshHabitList();
        }
    }

    void RefreshHabitList()
    {
        foreach (Transform child in habitListContainer)
        {
            Destroy(child.gameObject);
        }

        List<string> habits = habitSystem.Habitlist();

        foreach (var habit in habits)
        {
            GameObject item = Instantiate(habitItemPrefab, habitListContainer);
            item.transform.Find("HabitNameText").GetComponent<TMPro.TextMeshProUGUI>().text = habit;

            item.transform.Find("CompleteButton").GetComponent<Button>().onClick
                .AddListener(() => habitSystem.marcar(habit));

            item.transform.Find("DeleteButton").GetComponent<Button>().onClick
                .AddListener(() =>
                {
                    habitSystem.borrar(habit);
                    RefreshHabitList();
                });

            item.transform.Find("EditButton").GetComponent<Button>().onClick
                .AddListener(() => EditHabit(habit));
        }

        void EditHabit(string oldName)
        {
            string newName = HabitosInput.text;
            if (!string.IsNullOrEmpty(newName))
            {
                habitSystem.borrar(oldName);
                habitSystem.Add(newName);
                habitSystem.Guardar();
                RefreshHabitList();
            }
        }
    }
}
