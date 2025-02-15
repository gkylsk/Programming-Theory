using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Shape : MonoBehaviour
{
    public Text displayText;
    public Text shapeText;
    public string shape { get; protected set; }
    public Color color { get; protected set; }
    public int weight { get; protected set; }

    private void OnMouseDown()
    {
        Display();
    }

    void Display()
    {
        displayText.gameObject.SetActive(true);
        shapeText.gameObject.SetActive(true);
        DisplayText();
        DisplayColor();
        DisplayProperties();
    }
    protected void DisplayColor()
    {
        displayText.color = color;
    }

    protected void DisplayProperties()
    {
        shapeText.text = "Weight: "+weight.ToString();
    }

    protected abstract void DisplayText();
}
