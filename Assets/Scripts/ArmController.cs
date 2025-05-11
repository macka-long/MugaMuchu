using System.Collections.Generic;
using UnityEngine;

public class ArmController : MonoBehaviour
{
    [System.Serializable]
    public class Binding
    {
        public KeyCode key;
        public MoveRandom targetScript;
    }

    public List<Binding> bindings = new List<Binding>();

    void Update()
    {
        foreach (var binding in bindings)
        {
            if (Input.GetKeyDown(binding.key))
            {
                binding.targetScript.MoveRandomly();
            }
        }
    }
}
