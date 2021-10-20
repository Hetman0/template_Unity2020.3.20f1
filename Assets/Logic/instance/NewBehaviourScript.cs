using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

namespace template_Unity
{
    public class NewBehaviourScript : MonoBehaviour
    {
        InputManager input;
        private void Awake()
        {
            input = new InputManager();
        }
        private void OnEnable()
        {
            input.Enable();
        }
        private void OnDisable()
        {
            input.Disable();
        }

        // Start is called before the first frame update
        void Start()
        {
            input.Player.Select.performed += cont => Debug.Log("Performed");
        }

        // Update is called once per frame
        void Update()
        {
            if (input.Player.Select.ReadValue<float>() != 0)
            {
                Debug.Log(input.Player.Select.ReadValueAsObject());
            }
        }
    }
}
