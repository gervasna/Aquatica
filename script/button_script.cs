using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xButton : MonoBehaviour {
    int x_value = 0;
    int xmin = 0;

    int xmax = 1035;

    public UnityEngine.UI.Text TextObject = null;

   
    public void Start()
    {
    }
    
    public void Update()
    {

    TextObject.text = x_value.ToString();
        if (x_value > xmax) x_value = xmax;
        if (x_value < xmin) x_value = xmin;
    }

    public void increment_x()
    {
            x_value++;
        
    }
    public void decrement_x()
    {
            x_value--;
    }

}
