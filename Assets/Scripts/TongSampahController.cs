using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TongSampahController : MonoBehaviour {

    public float speed = 1.0f;

    public Text textScore;
    private int score = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKey(KeyCode.A))
        {
            //objek ke kiri
            GoLeft();
        }
        if (Input.GetKey(KeyCode.D))
        {
            //objek ke kanan
            GoRight();
        }
	}

    public void OnTriggerEnter(Collider collider)
    {
            score++;
            textScore.text = score.ToString();
    }

    private void GoLeft()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    private void GoRight()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }


}
