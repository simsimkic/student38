/***********************************************************************
 * Module:  DoctorExaminationController.cs
 * Purpose: Definition of the Class Controller.Doctor.DoctorExaminationController
 ***********************************************************************/

using System;

namespace Controller.Doctor
{
   public class DoctorExaminationController
   {
      public Model.Doctor.Perscription PrescribeReceipt(Model.Doctor.Medication medication, String howToUse, String note)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.Hospitalisation HospitalizePatient(Model.Actors.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.Surgery ScheduleOperation(Model.Actors.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.Examination ScheduleExamination(Model.Actors.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.Report AddReport(String describe)
      {
         // TODO: implement
         return null;
      }
   
      public Service.Doctor.DiagnosisService diagnosisService;
      public Service.Doctor.ReportService reportService;
      public Service.Doctor.ExaminationDoctorService examinationDoctorService;
      public Service.Doctor.MedicationService medicationService;
   
   }
}