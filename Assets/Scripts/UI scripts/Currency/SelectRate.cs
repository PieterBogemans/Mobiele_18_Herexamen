using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectRate : MonoBehaviour {

    Toggle toggle;
    public void SelectUserRate(bool active)
    {
        if (active) Currency.UseCustomValues();
    }

    public void SelectDefaultRate(bool active)
    {
        if (active)Currency.UseMemoryValues();
    }
}
