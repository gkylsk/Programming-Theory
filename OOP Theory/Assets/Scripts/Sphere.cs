using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    private void Awake()
    {
        shape = "Sphere";
        color = Color.green;
        weight = 15;
    }
    protected override void DisplayText()
    {
        displayText.text = "Green Sphere is clicked";
    }
}
