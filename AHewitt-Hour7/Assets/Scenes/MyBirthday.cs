using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BirthdayScript : MonoBehaviour
{
    // Define your birthday month and day here
    private int month = 6;
    private int day = 20;

    void Start()
    {
        // Define a dictionary to store the months and their days
        Dictionary<int, string> monthDict = new Dictionary<int, string>();
        monthDict.Add(1, "January");
        monthDict.Add(2, "February");
        monthDict.Add(3, "March");
        monthDict.Add(4, "April");
        monthDict.Add(5, "May");
        monthDict.Add(6, "June");
        monthDict.Add(7, "July");
        monthDict.Add(8, "August");
        monthDict.Add(9, "September");
        monthDict.Add(10, "October");
        monthDict.Add(11, "November");
        monthDict.Add(12, "December");

        for (int i = 1; i <= 12; i++)
        {
            if (monthDict[i] == "6")
            {
                // If the current month is the birthday month, print "It's my birthday!"
                Debug.Log("It's my birthday!");
            }
            else
            {
                // Otherwise, print the month number and the number of days in the month
                Debug.Log("Month: " + i + "/Month Days: " + monthDict[i]);
            }
        }
    }
}
