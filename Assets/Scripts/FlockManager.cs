using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlockManager : MonoBehaviour
{
    public static FlockManager FM;
    public GameObject FishPrefab;
    public int numfish = 20;
    public GameObject[] allfish;
    public Vector3 swimLimits = new Vector3(5, 5, 5);

    [Header("Fish Settings")]
    [Range(0.0f, 5.0f)]
    public float minSpeed;
    [Range(0.0f, 5.0f)]
    public float maxSpeed;

    // Start is called before the first frame update
    void Start()
    {
        allfish = new GameObject[numfish];
        for (int i = 0; i < numfish; i++)
        {
            Vector3 pos = this.transform.position + new Vector3(Random.Range(-swimLimits.x, swimLimits.x),
                                                                Random.Range(-swimLimits.y, swimLimits.y),
                                                                Random.Range(-swimLimits.z, swimLimits.z));
            allfish[i] = Instantiate(FishPrefab, pos, Quaternion.identity);
                                                        
        }
        FM = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
