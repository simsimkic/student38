/***********************************************************************
 * Module:  ExaminationService.cs
 * Purpose: Definition of the Class Service.Doctor.ExaminationService
 ***********************************************************************/

using System;

namespace Service.Doctor
{
   public class ExaminationDoctorService
   {
      public Model.Doctor.Perscription PrescribeReceipt(String patientName, String patientSurname, String medicationName, String howToUse, String note, Model.Doctor.Diagnosis diagnosis)
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
      
      public Boolean AddReport(Model.Doctor.Report report)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.Patient.PrescriptionRepository prescriptionRepository;
      public ReportService reportService;
      public DiagnosisService diagnosisService;
      public Repository.Secretary.AppointmentRepository appointmentRepository;
   
   }
}