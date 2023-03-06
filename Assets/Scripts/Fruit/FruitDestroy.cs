using UnityEngine;

public class FruitDestroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            FruitsScore.fruitScore++;
            Destroy(gameObject);
            FindObjectOfType<AudioManager>().PlaySound("Coins");
        }
    }
}
