using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = new int[3] { 2, 4, 6 };
    }

    // Update is called once per frame
    int PrintArraySum(int[] array)
    {
       int sum = 0;
     for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
       return sum;
    }


}
