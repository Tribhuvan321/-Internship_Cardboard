using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HeightScript : MonoBehaviour
{
    public TMP_Text heightText;
    public int height =0;
    

    public void IncreaseHeight()
    {
        height++;
        heightText.text = height.ToString();
    }
    public void DecreaseHeight()
    {
        height--;
        heightText.text = height.ToString();
    }
}
