﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Microsoft.MixedReality.Toolkit.CameraSystem
{
    /// <summary>
    /// Manager interface for a camera system in the Mixed Reality Toolkit.
    /// The camera system is expected to manage settings on the main camera.
    /// It should update the camera's clear settings, render mask, etc based on platform.
    /// </summary>
    public interface IMixedRealityCameraSystem : IMixedRealityEventSystem, IMixedRealityEventSource, IMixedRealityService
    {
        /// <summary>
        /// Typed representation of the ConfigurationProfile property.
        /// </summary>
        MixedRealityCameraProfile CameraProfile { get; }

        /// <summary>
        /// Is the current camera displaying on an opaque (VR / immersive) or a transparent (AR) device
        /// </summary>
        bool IsOpaque { get; }

        /// <summary>
        /// Override the camera's projection matrices for a smaller field of view
        /// but rendered content will have more detail.  <see href="https://docs.microsoft.com/en-us/hololens/hololens2-display">Reading Mode</see> documentation.
        /// While this will work on all Windows Mixed Reality platforms, this
        /// is primarily  useful on HoloLens 2 hardware.  
        /// If holograms are not stable, change the Stereo Rendering Mode from
        /// "Single Pass Instanced" to "Multi Pass" to work around a bug in Unity
        /// </summary>
        bool ReadingModeEnabled { get; set; }
    }
}