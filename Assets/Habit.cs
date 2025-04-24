[System.Serializable]
public class Habit
{
    public string name;
    public bool isCompleted;
    public int timesCompleted;

    public Habit(string name)
    {
        this.name = name;
        this.isCompleted = false;
        this.timesCompleted = 0;
    }

    public void Complete()
    {
        isCompleted = true;
        timesCompleted++;
    }

    public void ResetDaily()
    {
        isCompleted = false;
    }
}
