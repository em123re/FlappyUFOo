using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab;
    public float minYukseklik = -1f;
    public float maxYukseklik = 1.5f;
    public float tekrarRate = 1.5f;

    public void Start()
    {
        InvokeRepeating(nameof(Spawn), tekrarRate, tekrarRate);
    }
    public void Spawn()
    {
        GameObject meteor = Instantiate(meteorPrefab, transform.position, Quaternion.identity);
        meteor.transform.position += Vector3.up * Random.Range(minYukseklik, maxYukseklik);
    }
}
