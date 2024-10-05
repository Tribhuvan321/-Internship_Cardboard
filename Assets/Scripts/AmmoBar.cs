using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AmmoBar : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public Gradient grad;
    public Image fill;
    //public TMP_Text text;

    public int current;
    public int max;

    public void SetMaxAmmo()
    {
        slider.maxValue = 3;
        slider.value = 3;

        fill.color = grad.Evaluate(1f);

        max = 3;
        //text.text = maxAmmo.ToString();
    }

    public void Failed()
    {
        slider.value = 1;
        fill.color = grad.Evaluate(slider.normalizedValue);

        current = 1;
        //text.text = currentAmmo.ToString();

    }
    public void InProgress()
    {
        slider.value = 2;
        fill.color = grad.Evaluate(slider.normalizedValue);

        current = 2;
        //text.text = currentAmmo.ToString();

    }
    public void Done()
    {
        slider.value = 3;
        fill.color = grad.Evaluate(slider.normalizedValue);

        current = 3;
        //text.text = currentAmmo.ToString();

    }

}
