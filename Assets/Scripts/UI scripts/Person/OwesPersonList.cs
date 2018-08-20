using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwesPersonList : MonoBehaviour {

    private PersonRepository repo;
    public OwesPersonElement prefab; 
    public Transform personList;
    public Person Person;
    public Person OtherTransactionParty;
    public Currency Currency;

    public void Prime()
    {
        Person = GetComponent<PersonDetails>().MainPerson;
        Currency = GetComponent<PersonDetails>().Currency;
        repo = GetComponent<PersonRepository>();
        foreach (Transform child in personList.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        foreach (Person repoPerson in repo.People.Values)
        {
            if (Person.IsOwedOrDue(repoPerson))
            {
                OwesPersonElement element = (OwesPersonElement)Instantiate(prefab);
                element.Prime(Person, repoPerson, Currency);
                element.transform.SetParent(personList, false);
            }
        }
        
    }
}
