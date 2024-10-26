
//-----------------------------------------------------------------
//    <copyright file="Person.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>26-10-2024</date>
//    <author>Cláudio Fernandes</author>
//-----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_30517.Person
{
    /// <summary>
    /// Abstract class Person
    /// </summary>
    public abstract class Person: IComparable
    {
        #region Private Properties        
        /// <summary>
        /// Private - Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        private static int nextId = 1;
        private int id { get; set; }
        private string name { get; set; }
        private DateTime birthdate { get; set; }
        private int age { get; set; }
        private string citizenCard { get; set; }
        private string phone { get; set; }
        private string email { get; set; }
        private string address { get; set; }
        private string nationality { get; set; }
        #endregion

        #region Public Properties        
        /// <summary>
        /// Public - Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public DateTime Birthdate
        {
            get => birthdate;
            set => birthdate = value;
        }
        public int Age
        {
            get => age;
            set => age = value;
        }
        public string CitizenCard
        {
            get => citizenCard;
            set => citizenCard = value;
        }
        public string Phone
        {
            get => phone;
            set => phone = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string Address
        {
            get => address;
            set => address = value;
        }
        public string Nationality
        {
            get => nationality;
            set => nationality = value;
        }
        #endregion

        #region Constructors        
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="Birthdate">The birthdate.</param>
        /// <param name="CitizenCard">The citizen card.</param>
        /// <param name="Phone">The phone.</param>
        /// <param name="Address">The address.</param>
        public Person(string name, DateTime Birthdate, string CitizenCard, string Phone, string Address)
        {
            Id = GenerateId();
            this.name = name;
            this.birthdate = birthdate;
            this.citizenCard = CitizenCard;
            this.Phone = Phone; 
            this.Address = Address;
        }
        #endregion

        #region Public Methods
        public int CompareTo(object? other)
        {
            if (!(other is Person))
            {
                throw new ArgumentException("Object must be of type Person");
            }

            // Comparar pelo ID
            return this.Id.CompareTo(((Person)other).Id);
        }
        #endregion

        #region Private Methods
        private static int GenerateId()
        {
            return nextId++;
        }
        #endregion
    }
}
