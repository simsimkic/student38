/***********************************************************************
 * Module:  Doctor.cs
 * Purpose: Definition of the Class Doctor.Doctor
 ***********************************************************************/

using System;

namespace Model.Actors
{
   public class Doctor : Employee
   {
      public Boolean IzdajeLek()
      {
         // TODO: implement
         return null;
      }
      
      public void PogledajSveZakazanePreglede()
      {
         // TODO: implement
      }
      
      public Boolean DodajIzvestaj()
      {
         // TODO: implement
         return null;
      }
      
      public Boolean HospitalizujPacijenta()
      {
         // TODO: implement
         return null;
      }
      
      public Boolean ZakaziOperaciju()
      {
         // TODO: implement
         return null;
      }
      
      public Boolean PropisiRecept()
      {
         // TODO: implement
         return null;
      }
      
      public Boolean ZakaziPregled()
      {
         // TODO: implement
         return null;
      }
      
      public void PomeriPregled()
      {
         // TODO: implement
      }
      
      public void PomeriOperaciju()
      {
         // TODO: implement
      }
   
      public Patient[] patient;
      public Specialization[] specialization;
   
      private Boolean IsSpecialist = false;
   
   }
}