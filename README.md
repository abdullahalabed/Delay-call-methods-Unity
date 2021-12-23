# Delay-call-methods-Unity
this class used to delay call block of codes that needs to be run in unity after period of time

In order to use this class :
 1-use the namespace  -> using DellayCallHelper;
 2-call the method you need like this :
  	  
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
        
        
        That's it !!
