using System;
using UnityEngine;

public class LocalizationManager : MonoBehaviour
{
    public static event Action<string> OnSwitch;


    public void Ro()
    {
        string language = "Ro";
        PlayerPrefs.SetString("Language", language);
        OnSwitch?.Invoke(language);
    }

    public void Ru()
    {
        string language = "Ru";
        PlayerPrefs.SetString("Language", language);
        OnSwitch?.Invoke(language);
    }

    public void Eng()
    {
        string language = "Eng";
        PlayerPrefs.SetString("Language", language);
        OnSwitch?.Invoke(language);
    }
}
