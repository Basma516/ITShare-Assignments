using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_System
{
    internal struct UserCredentials
    {
        public string CardNumber { get; set; }
        private int Pin { get; set; }
        public UserCredentials(string cardNumber, int pin)
        {
            CardNumber = cardNumber;
            Pin = pin;
        }
        public bool ValidatePin(int inputPin)
        {
            return Pin == inputPin;
        }
       
    }
}
