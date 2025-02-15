using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    private void Awake()
    {
        shape = "Cube";
        color = Color.red;
        weight = 10;
    }
    protected override void DisplayText()
    {
        displayText.text = "Cube is Red color";
    }
}
