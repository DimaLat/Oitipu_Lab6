using System.Collections;

using UnityEngine;

public class SpawnBombs : MonoBehaviour
{

    public GameObject bomb;


    void Start()
    {
        StartCoroutine(Spawn());    
    }
    IEnumerator Spawn()
    {
        while (!Player.lose)
        {
            Instantiate(bomb, new Vector2(Random.Range(-0.38f, 4), 5.1f), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }
}
