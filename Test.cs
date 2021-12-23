using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System;
using DelayCallHelper;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Utils.DelayCall_Thread(3, () =>
         {
             Debug.Log("***********DelayCall create new Thread ******************");

         });

        Utils.DelayCall_Async(3, () =>
        {
            Debug.Log("***********DelayCall using Async ******************");

        });

        Utils.DellayCall_Coroutine(3, () =>
        {
            Debug.Log("***********DellayCall using Coroutine ******************");

        });

    }





   
  

    public async void StartAction() 
    {
        await RotateObj();
        await RotateObj2();
        Debug.Log(" StartAction end ");

    }
    public async Task RotateObj() 
    {
        for (int i = 0; i < 100; i++) 
        {
            Debug.Log("RotateObj");
            await Task.Yield();
        }
    } 
    
    public async Task RotateObj2() 
    {
        for (int i = 0; i < 100; i++) 
        {
            Debug.Log("RotateObj2");
              Task.Yield();
        }
    }
}
