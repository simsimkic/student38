/***********************************************************************
 * Module:  Report.cs
 * Purpose: Definition of the Class Patient.Report
 ***********************************************************************/

using System;

namespace Model.Doctor
{
   public class Report
   {
      public Diagnosis[] diagnosis;
      public Model.Actors.Doctor doctor;
   
      private String ExamDescription;
   
   }
}