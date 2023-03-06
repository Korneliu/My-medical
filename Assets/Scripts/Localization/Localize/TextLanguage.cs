using UnityEngine;
using UnityEngine.UI;

public class TextLanguage : MonoBehaviour
{
    [SerializeField] private string language;
    [SerializeField] private string textRo;
    [SerializeField] private string textRu;
    [SerializeField] private string textEng;

    Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
        LocalizationManager.OnSwitch += OnSwitch;
        OnSwitch(PlayerPrefs.GetString("Language", language));
    }

    public void OnSwitch(string obj)
    {
        language = obj;
        if (language == "" || language == "Ro")
        {
            text.text = textRo;
        }
        else if (language == "Ru")
        {
            text.text = textRu;
        }
        else if (language == "Eng")
        {
            text.text = textEng;
        }
    }
}
