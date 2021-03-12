using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPickups : MonoBehaviour
{

    // Start is called before the first frame update
    [SerializeField]
    private Vector2 spawnLocation;
    private Transform spawnTransform;

    [SerializeField]
    public float spawnTime;

    private float currentSpawnTime = 0.0f;

    private Rigidbody2D m_rb;

    public GameObject m_ObjectToSpawn;

    private float xValue;
    private float yValue;

    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        spawnTransform = GetComponent<Transform>();
        xValue = 0.0f;
        yValue = 0.0f;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > currentSpawnTime)
        {
            generateSpawnLocation();
        }
    }

    private void generateSpawnLocation()
    {
        xValue = Random.Range(-6, 6);
        yValue = Random.Range(-4.5f, 4.5f);
        spawnLocation = new Vector2(xValue, yValue);
        spawnTransform.position = spawnLocation;
        Instantiate(m_ObjectToSpawn, spawnTransform);
        currentSpawnTime = Time.time + spawnTime;
    }
}
