using UnityEngine;
using UnityEngine.UI;

public class FruitsScore : MonoBehaviour
{
    [SerializeField] private Text hightFruitText;
    [SerializeField] private Text fruitTextScore;

    public static int fruitScore;
    int hightScore;

    void Start()
    {
        fruitScore = 0;
    }


    void Update()
    {
        hightScore = (int)fruitScore;
        fruitTextScore.text = "" + hightScore.ToString();

        if(PlayerPrefs.GetInt("fruitScore") <= hightScore)
        {
            PlayerPrefs.SetInt("fruitScore", hightScore);
        }

        hightFruitText.text = "" + PlayerPrefs.GetInt("fruitScore").ToString();
    }
}
