using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBCC.Wmad.MyFirstClassLibrary
{
    public class Balloon
    {
        private string color = string.Empty;
        private int diameter;

        /// <summary>
        /// Gets or sets the color of the object
        /// </summary>
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                if (value.ToUpper() == "RED" || value.ToUpper() == "BLUE")
                {
                    color = value;
                }
                else
                {
                    throw new ConstraintException("Color must be red or blue");
                }
            }
        }

        /// <summary>
        /// Gets or sets the diameter of the object
        /// </summary>
        public int Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                if (string.IsNullOrEmpty(color))
                {
                    throw new ConstraintException("Please set the color prior to setting the diameter.");
                }
                else
                {
                    if (color.ToUpper() == "RED")
                    {
                        if (value > 0 && value <= 12)
                        {
                            diameter = value;
                        }
                        else
                        {
                            throw new ConstraintException("Red Balloon must be less than 12 inches");
                        }
                    }
                    else if (color.ToUpper() == "BLUE")
                    {
                        if (value > 0 && value <= 10)
                        {
                            diameter = value;
                        }
                        else
                        {
                            throw new ConstraintException("Blue Balloon must be less than 10 inches");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Gets or sets the Height of the object
        /// </summary>
        public float Height { get; set; }

        /// <summary>
        /// Gets the BurstingPoint of the object. A calculated property
        /// 
        /// The strengh of the material of this balloon has a bursting point of
        /// PI * Height * Diameter
        /// 
        /// </summary>
        public double BurstingPoint
        {
            get
            {
                return (Math.PI * Height * diameter);
            }
        }
    }
}
