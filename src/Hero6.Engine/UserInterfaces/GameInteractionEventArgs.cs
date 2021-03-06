﻿// <copyright file="GameInteractionEventArgs.cs" company="Late Start Studio">
// Copyright (C) Late Start Studio
// This file is subject to the terms and conditions of the MIT license specified in the file
// 'LICENSE.CODE.md', which is a part of this source code package.
// </copyright>

namespace LateStartStudio.Hero6.Engine.UserInterfaces
{
    using System;
    using Campaigns;

    /// <summary>
    /// Event Args to provide information for user interaction.
    /// </summary>
    public class GameInteractionEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameInteractionEventArgs"/> class.
        /// </summary>
        /// <param name="x">The x coordinate of the user interaction.</param>
        /// <param name="y">The y coordinate of the user interaction.</param>
        /// <param name="interaction">The interaction of the user interaction.</param>
        public GameInteractionEventArgs(int x, int y, Interaction interaction)
        {
            this.X = x;
            this.Y = y;
            this.Interaction = interaction;
        }

        /// <summary>
        /// Gets the x coordinate of the user interaction.
        /// </summary>
        /// <value>
        /// The x coordinate of the user interaction.
        /// </value>
        public int X { get; private set; }

        /// <summary>
        /// Gets the y coordinate of the user interaction.
        /// </summary>
        /// <value>
        /// The y coordinate of the user interaction.
        /// </value>
        public int Y { get; private set; }

        /// <summary>
        /// Gets the interaction of the user interaction.
        /// </summary>
        /// <value>
        /// The interaction of the user interaction.
        /// </value>
        public Interaction Interaction { get; private set; }
    }
}
