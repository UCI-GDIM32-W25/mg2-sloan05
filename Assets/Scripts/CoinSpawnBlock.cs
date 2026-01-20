using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawnBlock : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;

    [SerializeField] private float _spawnInterval = 1.5f;

    private float _timer;

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= +_spawnInterval)
        {
            SpawnCoin();
            _timer = 0f;
        }
    }
    public void SpawnCoin()
    {
        GameObject newCoin = Instantiate(_coinPrefab);
        newCoin.transform.position = transform.position;

        Debug.Log("Spawned coin!");
    }
}
