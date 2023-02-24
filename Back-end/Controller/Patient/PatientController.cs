/***********************************************************************
 * Module:  PatientService.cs
 * Purpose: Definition of the Class Service.Doctor.PatientService
 ***********************************************************************/

using System;

namespace Controller.Patient
{
   public class PatientController
   {
      public Model.Actors.Patient LogInPatient(String emial, String password)
      {
         // TODO: implement
         return null;
      }
      
      public List<Patient> GetAllPatients()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Actors.Patient GetSpecificPatient(String patientID)
      {
         // TODO: implement
         return null;
      }
      
      public PatientController GetInstance()
      {
         // TODO: implement
         return null;
      }
      
      public Boolean RegisterPatient(String name, String surname, String fathersName, String jmbg, String yearOfBirth, String email, String password, String phoneNumber, Model.Actors.Address address, Model.Actors.Clinic homeClinic, Model.Actors.Doctor familyDoctor, Model.Actors.Pharmacy parmacy, Model.Actors.Gender gender)
      {
         // TODO: implement
         return null;
      }
   
      public Service.Patient.PatientService patientService;
   
      private PatientController Instance;
   
   }
}