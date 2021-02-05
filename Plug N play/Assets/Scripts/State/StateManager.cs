using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PP
{
    public abstract class StateManager : MonoBehaviour
    {
        State currentState;
        Dictionary<string, State> allStates = new Dictionary<string, State>();
        private void Start()
        {
            Init();
        }
        public abstract void Init();

        public void Tick()
        {
            if(currentState == null)
            {
                return;
            }

            currentState.Tick();
        }

        public void FixedTick()
        {
            if (currentState == null)
            {
                return;
            }

            currentState.FixedTick();

        }
        public void LateTick()
        {
            if (currentState == null)
            {
                return;
            }

            currentState.LateTick();
        }

        public void ChangeState(string targetId)
        {
            if (currentState != null)
            {
                 //run on exit actions of currentState
            }

            State targetState = GetState(targetId); // run on enter actions

            currentState = targetState;
        }

        State GetState(string targetId)
        {
            allStates.TryGetValue(targetId, out State retVal);
            return retVal;
        }

        protected void RegisterState(string stateId, State state)
        {
            allStates.Add(stateId, state);

        }


    }
}


