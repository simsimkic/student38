/***********************************************************************
 * Module:  Patient.cs
 * Purpose: Definition of the Class Patient.Patient
 ***********************************************************************/

using System;

namespace Model.Actors
{
   public class Patient : User
   {
      public Doctor doctor;
      public Pharmacy pharmacy;
   
   }
}