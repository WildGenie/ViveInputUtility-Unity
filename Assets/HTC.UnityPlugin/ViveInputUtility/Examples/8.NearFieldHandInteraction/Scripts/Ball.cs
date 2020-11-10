﻿//========= Copyright 2016-2020, HTC Corporation. All rights reserved. ===========

using UnityEngine;

namespace HTC.UnityPlugin.Vive
{
    public class Ball : MonoBehaviour
    {
        [SerializeField] private float Lifetime = 10.0f;

        public void OnGrabbed()
        {
            Detach();
        }

        private void Detach()
        {
            transform.parent = null;
            Destroy(gameObject, Lifetime);
        }
    }
}