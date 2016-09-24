using UnityEngine;
using System.Collections;

public class oneTimeStop : MonoBehaviour {
    private GameObject car;

    private NavMeshAgent _nav;
    private float leftTime;
    public float stopTime;
	// Use this for initialization
	void Start () {
        car = GameObject.Find("Car");
        _nav = car.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        leftTime += Time.deltaTime;
        _nav.speed = 0;
        if (leftTime > stopTime)
        {
            _nav.speed = 3;
        }

	}
}
