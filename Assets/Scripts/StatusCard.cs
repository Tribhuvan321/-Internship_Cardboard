using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Card", menuName = "Card")]
public class StatusCard : ScriptableObject
{
    public string cardName;
    public string bodyType;
    public string Height;
    public string Gender;
}
