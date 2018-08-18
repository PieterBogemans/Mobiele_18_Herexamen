using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddPerson : MonoBehaviour {

    public InputField PersonName;
    public Text invalidPersonName;
    public Button submitButton;

	// Use this for initialization
	void Start () {
		
	}

    public void SubmitPerson()
    {
        string name = PersonName.text;
        PersonRepository repo = GetComponent<PersonRepository>();
        repo.AddPerson(name);

        PersonList personList = GetComponent<PersonList>();
        personList.Prime();

        PersonName.text = "";
        invalidPersonName.text = "";
        submitButton.interactable = false;
    }

    public void ValidatePersonName(string name)
    {
        PersonRepository repo = GetComponent<PersonRepository>();
        submitButton.interactable = repo.GetPerson(name) == null && !string.IsNullOrEmpty(name);
        if (repo.GetPerson(name) != null)
        {
            invalidPersonName.text = "Name already exists";
        }
        else if (string.IsNullOrEmpty(name)) 
        {
            invalidPersonName.text = "Name cannot be empty";
        } else {
            invalidPersonName.text = "";
        }
    }


}
