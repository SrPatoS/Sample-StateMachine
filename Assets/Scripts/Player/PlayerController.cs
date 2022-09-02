using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private bool _walking;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
            Example();
    }
    
    private void Example()
    {
        var state = new State();
        state.Name = Name.WALK;

        StateMachine.SetState(_walking, state);
    }
}
