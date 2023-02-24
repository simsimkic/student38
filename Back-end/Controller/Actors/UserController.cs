/***********************************************************************
 * Module:  EmployeeService.cs
 * Purpose: Definition of the Class Service.Actors.EmployeeService
 ***********************************************************************/

using System;

namespace Controller.Actors
{
   public class UserController
   {
      public User LogIn(String username, String password)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean LogOutEmployee(Model.Actors.Employee employee)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean LogOutPatient(Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean SendFeedback(String feedback)
      {
         // TODO: implement
         return null;
      }
      
      public User GetUser(String userID)
      {
         // TODO: implement
         return null;
      }
      
      public User AddUser(User user)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean EditUser(User user)
      {
         // TODO: implement
         return null;
      }
      
      public List<User> GetAllUsers()
      {
         // TODO: implement
         return null;
      }
      
      public UserController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      public Service.Actors.EmployeeService employeeService;
      public Service.Patient.PatientService patientService;
      public Service.Actors.UserService userService;
   
      private ActorController Instance;
   
   }
}