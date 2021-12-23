using System;
using System.Collections;
using System.Threading.Tasks;
using UnityEngine;


namespace DellayCallHelper
{

    public static class Utils
    {
        //Create a class that actually inheritance from MonoBehaviour
        public class UtilsMB : MonoBehaviour { }


        //Variable reference for the class
        private static UtilsMB utilsMB;



        //Now Initialize the variable (instance)
        private static void Init()
        {
            //If the instance not exit the first time we call the static class
            if (utilsMB == null)
            {
                //Create an empty object called MyStatic
                GameObject gameObject = new GameObject("Utils");


                //Add this script to the object
                utilsMB = gameObject.AddComponent<UtilsMB>();
            }
        }

        //============================================================================================
        // IEnumerators methods 

        static IEnumerator DellayCall_IEnum(float seconds, Action callback)
        {
            yield return new WaitForSeconds(seconds);
            callback();
        }
        
        
        //============================================================================================
        /// <summary>
        /// call to delay call execution block of code using Coroutine
        /// </summary>
         public static void DellayCall_Coroutine(float seconds, Action callback)
        {
            //Call the Initialization
            Init();
            //Call the Coroutine
            utilsMB.StartCoroutine(DellayCall_IEnum(seconds, callback));
        }

        /// <summary>
        /// call to delay call execution block of code using async
        /// </summary>
        public static async void DelayCall_Async(float seconds, Action action)
        {
            await Task.Delay(TimeSpan.FromSeconds(seconds));
            action?.Invoke();
        }



        /// <summary>
        /// create new thread and delay call execution block of code using async 
        /// </summary>
        public static async void DelayCall_Thread(int seconds, Action method)
        {
            await Task.Delay(TimeSpan.FromSeconds(seconds));
            Task.Run(method).GetAwaiter().GetResult();
        }
    }
}