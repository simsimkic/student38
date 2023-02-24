/***********************************************************************
 * Module:  Surgery.cs
 * Purpose: Definition of the Class Patient.Surgery
 ***********************************************************************/

using System;

namespace Model.Patient
{
   public class Surgery : MedicalService
   {
      public TypeOfSurgery typeOfSurgery;
      public Model.Manager.Room room;
   
      private Double Duration;
   
   }
}