using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Str10 : MonoBehaviour
{
    int sum = 0;
    int[] numbers = { 10, 20, 30, 1, 2, 33, -33, 44, 556, 54345, 3434, -1, 222, 333 };
    void Start()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Debug.Log(sum);

    }
}
