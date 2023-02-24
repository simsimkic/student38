/***********************************************************************
 * Module:  EmployeeService.cs
 * Purpose: Definition of the Class Service.Actors.EmployeeService
 ***********************************************************************/

using System;

namespace Service.Actors
{
   public class UserService
   {
      public User LogIn(String username, String password)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean LogOutUser(User user)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean SendFeedback(String feedback)
      {
         // TODO: implement
         return null;
      }
      
      public User GetUser(String username)
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
      
      public Boolean CheckPassword(User user, String password)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.Actors.UserRepository userRepository;
   
   }
}