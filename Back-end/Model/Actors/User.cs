/***********************************************************************
 * Module:  Patient.cs
 * Purpose: Definition of the Class Patient.Patient
 ***********************************************************************/

using System;

namespace Model.Actors
{
   public abstract class User
   {
      public void NotificationReading()
      {
         // TODO: implement
      }
      
      public void SentFeedback()
      {
         // TODO: implement
      }
      
      public void LogIn()
      {
         // TODO: implement
      }
   
      public Address address;
      public Clinic clinic;
   
      private String Name;
      private String Surname;
      private String FathersName;
      private String Jmbg;
      private Gender Gender;
      private DateTime DateOfBirth;
      private String Email;
      private String PhoneNumber;
      private String Username;
      private String Password;
   
   }
}