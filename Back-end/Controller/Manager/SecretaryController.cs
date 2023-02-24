/***********************************************************************
 * Module:  SecretaryController.cs
 * Purpose: Definition of the Class Controller.Manager.SecretaryController
 ***********************************************************************/

using System;

namespace Controller.Manager
{
   public class SecretaryController
   {
      public List<Secretary> GetAllSecretaries()
      {
         // TODO: implement
         return null;
      }
      
      public void DeleteSecretary(String jmbg)
      {
         // TODO: implement
      }
      
      public Model.Actors.Secretary AddSecretary(Model.Actors.Secretary secretary)
      {
         // TODO: implement
         return null;
      }
      
      public SecretaryController GetInstance()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Secretary.Secretary EditSecretary(Model.Secretary.Secretary secretary)
      {
         // TODO: implement
         return null;
      }
   
      public Service.Manager.SecretaryService secretaryService;
   
      private SecretaryController Instance;
   
   }
}