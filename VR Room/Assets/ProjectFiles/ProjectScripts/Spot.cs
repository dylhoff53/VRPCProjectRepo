using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spot : MonoBehaviour
{
    public bool isBusy;
    public void Died()
    {
        isBusy = false;
    }
}
