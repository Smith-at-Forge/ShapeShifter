using UnityEngine;
using System.Collections;

public class PrefabInstantiator : MonoBehaviour
{
    public GameObject prefabToInstantiate;
    public Transform spawnPoint; // Der Spawn-Punkt, den du im Inspektor zuweisen wirst
    public float instantiationInterval = 3f;

    private void Start()
    {
        StartCoroutine(InstantiatePrefabsContinuously());
    }

    private IEnumerator InstantiatePrefabsContinuously()
    {
        while (true)
        {
            // Instanziiere das Prefab am Spawn-Punkt
            GameObject newPrefab = Instantiate(prefabToInstantiate, spawnPoint.position, spawnPoint.rotation);

            yield return new WaitForSeconds(instantiationInterval);
        }
    }
}