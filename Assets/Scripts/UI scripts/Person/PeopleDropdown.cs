using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PeopleDropdown : MonoBehaviour {

    public Dropdown Dropdown;
    List<string> dropdownOptions = new List<string>();
    public string selectedPerson;

    // Use this for initialization
    public void Dropdown_IndexChanged(int index)
    {
        selectedPerson = dropdownOptions[index];
    }

    void Start ()
    {

    }
    public void Prime()
    {
        PersonRepository repo = GetComponent<PersonRepository>();
        if (repo.People != null)
        {
            foreach (KeyValuePair<int, Person> person in repo.People)
            {
                dropdownOptions.Add(person.Value.PersonName);
            }
            Dropdown.AddOptions(dropdownOptions);
            if (dropdownOptions.Count != 0) selectedPerson = dropdownOptions[0];
        }
    }
}
