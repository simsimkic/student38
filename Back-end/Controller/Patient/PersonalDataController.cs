/***********************************************************************
 * Module:  PersonalDataController.cs
 * Purpose: Definition of the Class Controller.Patient.PersonalDataController
 ***********************************************************************/

using System;

namespace Controller.Patient
{
   public class PersonalDataController
   {
      public Model.Actors.Patient ChangePersonalData(Model.Actors.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Actors.Doctor ChangePersonalDoctor(Model.Actors.Doctor doctor, Model.Actors.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Actors.Clinic ChangeHomeClinic(Model.Actors.Clinic clinic, Model.Actors.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Actors.Patient ChangeEmailAndPassword(Model.Actors.Patient patient, string newPassword, string newEmail)
      {
         // TODO: implement
         return null;
      }
      
      public List<Doctor> GetDoctors(Model.Actors.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public List<Clinic> GetClinics()
      {
         // TODO: implement
         return null;
      }
      
      public PersonalDataController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      public Service.Patient.PersonalDataService personalDataService;
   
      private PersonalDataController Instance;
   
   }
}