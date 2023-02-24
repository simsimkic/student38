/***********************************************************************
 * Module:  PatientRepository.cs
 * Purpose: Definition of the Class Repository.Patient.PatientRepository
 ***********************************************************************/

using System;

namespace Repository.Patient
{
   public class PatientRepository
   {
      public Model.Actors.Patient GetSpecificPatient(String patientID)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean RegisterPatient(Model.Actors.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Actors.Patient LogInPatient(String email, String password)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean LogOutPatient(String jmbg)
      {
         // TODO: implement
         return null;
      }
   
      private List<Patient> Patients;
   
   }
}