/***********************************************************************
 * Module:  PatientService.cs
 * Purpose: Definition of the Class Service.Doctor.PatientService
 ***********************************************************************/

using System;

namespace Service.Patient
{
   public class PatientService
   {
      public Model.Actors.Patient LogInPatient(String email, String password)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean LogOutPatient(Model.Actors.Patient patient)
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
      
      public Boolean RegisterPatient(String name, String surname, String fathersName, String jmbg, String yearOfBirth, String email, String password, String phoneNumber, Model.Actors.Address address, Model.Actors.Clinic homeClinic, Model.Actors.Doctor familyDoctor, Model.Actors.Pharmacy parmacy, Model.Actors.Gender gender)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.Patient.PatientRepository patientRepository;
   
   }
}