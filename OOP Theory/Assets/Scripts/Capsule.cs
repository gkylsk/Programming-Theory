using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
    private void Awake()
    {
        shape = "Capsule";
        color = Color.blue;
        weight = 5;
    }

    protected override void DisplayText()
    {
        displayText.text = "Blue Capsule";
    }
}
