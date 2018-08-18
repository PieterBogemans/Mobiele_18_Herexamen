using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripElementList : MonoBehaviour {

    private TripRepository repo;
    public TripElement prefab; 
    public Transform targetTransform;

    // Use this for initialization
    void Start () {
        Prime();
	}

    public void Prime ()
    {
        repo = GetComponent<TripRepository>();
        foreach (Transform child in targetTransform.transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        foreach (KeyValuePair<int, Trip> trip in repo.Trips)
        {
            TripElement element = (TripElement)Instantiate(prefab);
            element.PrimeButton(trip.Value);
            element.transform.SetParent(targetTransform, false);
        }
    }
}
