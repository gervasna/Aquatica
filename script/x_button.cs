using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class x_button : MonoBehaviour
{
    public float x_value =0 ;
    public int xmin = -517;
    public int xmax = 517;
    public UnityEngine.UI.Text textX = null;

    public void Update()
    {
        textX.text = x_value.ToString();
        if (x_value > xmax) x_value = xmax;
        if (x_value < xmin) x_value = xmin;
    }
    public void increment_x()
    {

		if(x_value == -1 && x_value < 0 || x_value == -0.5f && x_value < 0 || x_value == 0 || (x_value == 0.5f && x_value > 0)) {
			x_value = x_value + 0.5f;
		} else {
			x_value++;
		}
    }
    public void decrement_x()
    {

		if((x_value == 1 && x_value > 0) || (x_value == 0.5f && x_value > 0) || x_value == 0 || x_value == -0.5f && x_value < 0) {
			x_value = x_value - 0.5f;
		} else {
			x_value--;
		}
    }

}
