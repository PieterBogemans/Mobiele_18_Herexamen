using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonRepository : MonoBehaviour {

    public int IdCount { get; set; }
    public Dictionary<int, Person> People { get; set; }


    public PersonRepository()
    {
        IdCount = 0;
        People = new Dictionary<int, Person>();
    }

    public void AddPerson(string name)
    {
        Person person = new Person(name, IdCount);
        IdCount++;
        People.Add(person.Id, person);
    }

    public Person GetPerson(int id)
    {
        return People[id];
    }

    public Person GetPerson(string name)
    {
        foreach (Person person in People.Values)
        {
            if (person.PersonName.Equals(name))
            {
                return person;
            }
        }
        throw new System.Exception("Name not in repo");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
