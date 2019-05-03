using System;
using System.Collections.Generic;
using System.Text;

namespace pag123Book
{
    internal class Ball
    {
        // Declare instances
        private float radius;
        private Color color;
        private int throwTimes;

        // Create Propertie that sets value private but its readable everywhere
        public int ThrowTimes { get; private set; }

        // Create Constructors
        public Ball( Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            ThrowTimes = 0;
        }

        // Create pop function
        public void Pop()
        {
            radius = 0;
        }

        /// <summary>
        /// If radius is bigger than 0 ThrowTimes(from the property)
        /// </summary>
        public void Throw()
        {
            if (radius > 0)
            {
                ThrowTimes++;
            }
        }


    }
}
