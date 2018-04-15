using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalClicks : MonoBehaviour
{
    public GameObject currencyDisplay;
    public static int currencyCount;
    private int internalCurrency;

    void Update()
    {
        internalCurrency = currencyCount;
        currencyDisplay.GetComponent<Text>().text = "$" + internalCurrency;
    }
}
