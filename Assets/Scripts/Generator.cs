using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

    public GameObject spawnTrash;
    public float maxTime = 5;
    public float minTime = 2;
    public float xMaxPost = 10;
    public float xMinPost = -10;

    private float time;
    private float spawnTime;

    private float pos;


    void Start () 
    {
        SetRandom();
        time = minTime;
        pos = xMinPost;
	}

    void FixedUpdate()
    {
        time += Time.deltaTime;

        if (time >= spawnTime)
        {
            SpawnTrash();
            SetRandom();
        }
    }

    void SpawnTrash()
    {
        time = minTime;
        Instantiate(spawnTrash, new Vector3(pos, 10, 0), spawnTrash.transform.rotation);
    }

    void SetRandom()
    {
        pos = Random.Range(xMinPost, xMaxPost);
        spawnTime = Random.Range(minTime, maxTime);
    }

	void Update () {
		
	}
}
