using UnityEngine;

public class CoinsDestroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            Coins.coinsCount++;
            PlayerPrefs.SetInt("Coins", Coins.coinsCount);
            Destroy(gameObject);
            FindObjectOfType<AudioManager>().PlaySound("Coins");
        }
    }
}
