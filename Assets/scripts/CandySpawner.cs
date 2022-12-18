using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float maxPosn;
    [SerializeField] private float interval;
    public static CandySpawner instance;
    //just to make it available to other classes
    public GameObject[] candies;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        StartSpawingCandies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCandy()
    {
        int random = Random.Range(0, candies.Length);
        float randomPos = Random.Range(-maxPosn, maxPosn);
        Vector3 newPosn = new Vector3(randomPos, transform.position.y, transform.position.z);
        Instantiate(candies[random], newPosn, transform.rotation);
    }

    IEnumerator SpawnCandiesAfterInterval()
    {
        yield return new WaitForSeconds(2f);
        while (true)
        {
            SpawnCandy();
            yield return new WaitForSeconds(interval);
        }
    }

    public void StartSpawingCandies()
    {
        StartCoroutine("SpawnCandiesAfterInterval");
    }

    public void StopSpawningCandies()
    {
        StopCoroutine("SpawnCandiesAfterInterval");
    }
}
