/***********************************************************************
 * Module:  PatientInfo.cs
 * Purpose: Definition of the Class Model.Patient.PatientInfo
 ***********************************************************************/

using System;

namespace Model.Patient
{
   public class PatientInfo
   {
      private int Height;
      private int Weight;
      private BloodType Bloodtype;
      private double Dioptre;
      private Boolean Smoker = false;
      private List<String> Desises;
   
   }
}