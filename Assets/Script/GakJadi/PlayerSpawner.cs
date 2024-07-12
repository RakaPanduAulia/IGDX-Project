using Photon.Pun;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab;

    private void Start()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f));
        PhotonNetwork.Instantiate(playerPrefab.name, spawnPosition, Quaternion.identity);
    }
}
