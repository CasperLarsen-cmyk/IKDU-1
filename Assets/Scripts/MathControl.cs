using UnityEngine;
using TMPro;

public class MathControl : MonoBehaviour
{
    public TextMeshProUGUI TextGUI;
    public int Starting_Value;
    public int Current_Value;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Current_Value = Starting_Value;
        updateNumber();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateNumber()
    {
        TextGUI.text = Current_Value.ToString();
    }

    public void subtractNumber(int difference)
    {
        Current_Value -= difference;
        updateNumber();
    }

    public void addNumber(int difference)
    {
        Current_Value += difference;
        updateNumber();
    }
}
