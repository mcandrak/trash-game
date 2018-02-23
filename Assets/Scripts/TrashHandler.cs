using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TrashHandler : MonoBehaviour 
{

    [SerializeField]
    private float lifeTime = 1.5f;

    


    void Awake()
    {
        Invoke("SelfDestroy", lifeTime);
    }

	void Start () {
		
	}
	
	void Update () {
		
	}

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.transform.tag == "TrashBag")
        {
            Destroy(this.gameObject);
        }
    }

    void SelfDestroy()
    {
        Destroy(this.gameObject);
    }
}
