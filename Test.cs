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
}
