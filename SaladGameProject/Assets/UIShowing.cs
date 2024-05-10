using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIShowing : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI AmountMoney;



    private void Update()
    {
        AmountMoney.text = "Current Money: " + SeneManagement.instance.Money ;
    }
}
