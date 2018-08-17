using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddPerson : MonoBehaviour {

    public GameObject PersonName;

	// Use this for initialization
	void Start () {
		
	}

    public void SubmitPerson()
    {
        string name = PersonName.GetComponent<Text>().text;
        PersonRepository repo = GetComponent<PersonRepository>();
        repo.AddPerson(name);

        PersonList personList = GetComponent<PersonList>();
        personList.Prime();
    }


}
