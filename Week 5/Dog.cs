﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    [Serializable]
    public class Dog : Animal
    {
        // Backing field for property, see actual properties for their description.
        private SimpleDate lastWalkDate;

        /// <summary>
        /// Creates a dog.
        /// </summary>
        /// <param name="chipRegistrationNumber">A five digit number containing the chip registration 
        ///                                      number of the animal. 
        ///                                      If the given number contains less than 5 digits, then it 
        ///                                      will be stuffed with zero's from the left. 
        ///                                      So "5" becomes "00005"
        ///                                      If the given number contains more than 5 digits, then 
        ///                                      the number is truncated after the 5th position.
        ///                                      So "1234567" becomes "12345"</param>
        /// <param name="dateOfBirth">The date of birth of the animal or null if unknown</param>
        /// <param name="name">The name of the animal or null if unknown</param>
        /// <param name="lastWalkDate">The date of the last walk with the dog or null if unknown.</param>
        public Dog(string chipRegistrationNumber, SimpleDate dateOfBirth, string name, SimpleDate lastWalkDate, bool reserved)
            : base(chipRegistrationNumber, dateOfBirth, name, reserved)
        {
            this.lastWalkDate = lastWalkDate;
        }

        /// <summary>
        /// The date of the last walk of the dog. Contains null if unknown.
        /// </summary>
        public SimpleDate LastWalkDate
        {
            get { return lastWalkDate; }
            set { lastWalkDate = value; }
        }

        /// <summary>
        /// Retrieve information about this dog
        /// 
        /// Note: Every class inherits (automagically) from the 'Object' class,
        /// which contains the virtual ToString() method which you can override.
        /// </summary>
        /// <returns>A string containing the information of this animal.
        ///          The format of the returned string is
        ///          "Dog: <ChipRegistrationNumber>, <DateOfBirth>, <Name>, <IsReserved>, <LastWalkDate>"
        ///          Where: DateOfBirth will be "00-00-0000" if unknown or the actual date otherwise.
        ///                 Name will be "noname" if unknown or the actual name otherwise.
        ///                 IsReserved will be "reserved" if reserved or "not reserved" otherwise.
        ///                 LastWalkDate will be "00-00-0000" if unknown or the actual date otherwise.
        /// </returns>
        public override string ToString()
        {
            string lastWalk;
            if (this.LastWalkDate == null)
            {
                lastWalk = "00-00-000";
            }
            else
            {
                lastWalk = this.LastWalkDate.ToString();
            }

            return "Dog: " + base.ToString() + ", " + lastWalk + ", " + Price.ToString();
        }

        public override decimal Price
        {
            get
            {
                return (Convert.ToInt32(ChipRegistrationNumber) < 50000) ? 200 : 350;
            }
        }

        public override string AnimalType
        {
            get
            {
                return "Dog";
            }
        }
    }
}
