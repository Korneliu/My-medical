using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    [SerializeField] private GameObject[] tilePrefabs;
    [SerializeField] private float zSpawn = 0;
    [SerializeField] private float tileLenght = 152;
    [SerializeField] private int numberofTiles;
    [SerializeField] private Transform playerTransform;

    private List<GameObject> activeTiles = new List<GameObject>();

    private void Start()
    {
        for (int i = 0; i < numberofTiles; i++)
        {
            if (i == 0)
                SpawnTile(0);
            else
                SpawnTile(Random.Range(0, tilePrefabs.Length));
        }
    }

    private void FixedUpdate()
    {
        if (playerTransform.position.z - 152f > zSpawn - (numberofTiles * tileLenght))
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
            DeleteTile();
        }
    }

    private void SpawnTile(int tileIndex)
    {
        GameObject go = Instantiate(tilePrefabs[tileIndex], transform.forward * zSpawn, transform.rotation);
        activeTiles.Add(go);
        zSpawn += tileLenght;
    }

    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
