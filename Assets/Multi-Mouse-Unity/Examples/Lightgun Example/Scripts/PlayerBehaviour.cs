using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MultiMouseUnity.Example
{
    public class PlayerBehaviour : MonoBehaviour
    {
        [SerializeField] int playerIndex;
        [SerializeField] int fireButton = 0;
        [SerializeField] int reloadButton = 1;
        int deviceID = -1;

        [Header("Object References")]
        [SerializeField] Canvas canvas;
        [SerializeField] Crosshair crossHair;

        [Header("UI")]
        [SerializeField] CanvasGroup waitingUI;

        float lastFireTime;

        private void Start()
        {
            if (MainMenuUI.PlayData == null)
            {
                deviceID = playerIndex;
            }
            else
            {
                if (MultiMouseWrapper.Instance.ActiveDeviceCount > 0)
                {
                    deviceID = MainMenuUI.PlayData.playerIDs[playerIndex];
                    if (deviceID > -1)
                    {
                        OnDeviceFound(deviceID);
                    }
                }
            }
        }

        private void OnEnable()
        {
            MultiMouseWrapper.OnDeviceFound += OnDeviceFound;
        }

        private void OnDisable()
        {
            MultiMouseWrapper.OnDeviceFound -= OnDeviceFound;
            if (deviceID > -1)
            {
                MultiMouseWrapper.OnLeftMouseButtonDown[deviceID] -= HideCursor;
            }
        }

        private void OnDeviceFound(int mouseID)
        {
            if (mouseID == deviceID)
            {
                waitingUI.alpha = 0;
                crossHair.SetDeviceID(deviceID);
                MultiMouseWrapper.OnLeftMouseButtonDown[deviceID] += HideCursor;
            }
        }

        private void HideCursor()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}