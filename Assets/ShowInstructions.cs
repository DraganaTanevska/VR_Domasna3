using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShowInstructions : ObjectController
{
    public UnityEvent unityEvent;
    public new GameObject gameObject;
    // Start is called before the first frame update
    new void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        unityEvent.Invoke();
    }
}
