/***********************************************************************
 * Module:  Clinic.cs
 * Purpose: Definition of the Class Model.Actors.Clinic
 ***********************************************************************/

using System;

namespace Model.Actors
{
   public class Clinic
   {
      public User[] user;
      public Pharmacy[] pharmacy;
      public Address address;
   
      private String Name;
      private String ClinicID;
   
   }
}