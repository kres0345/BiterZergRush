﻿using System.Drawing;

namespace BiterZergRushForms
{
    public abstract class GameEntity
    {
        /// <summary>
        /// Location in pixels.
        /// </summary>
        public virtual GameVector Location { get; set; }
        /// <summary>
        /// The rotation of the sprite in radians, range: 0 to 2pi.
        /// </summary>
        public float Rotation { get; set; } = 0;
        public float Scale { get; set; } = 1;
        /// <summary>
        /// Can be null, to not display anything.
        /// </summary>
        public abstract Image Sprite { get; }
        public float Health;

        public virtual void OnUpdate(float deltaSeconds)
        {
        }
    }
}
