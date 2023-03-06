using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public static int coinsCount;
    [SerializeField] private Text coinsConter;

    void Start()
    {
        coinsConter = GetComponent<Text>();
        coinsCount = PlayerPrefs.GetInt("Medi", coinsCount);
    }


    void Update()
    {
        coinsConter.text = coinsCount.ToString();
    }
}
