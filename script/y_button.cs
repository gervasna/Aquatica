using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class y_button : MonoBehaviour
{
    public int y_value = 0;
    public int ymin = 0;
    public int ymax = 535;
    public UnityEngine.UI.Text TextY = null;
    

    public void Update()
    {
        TextY.text = y_value.ToString();
        if (y_value > ymax) y_value = ymax;
        if (y_value < ymin) y_value = ymin;
    }
    public void Increment_y()
    {
        y_value++;
    }
    public void Decrement_y()
    {
        y_value--;
    }
}
