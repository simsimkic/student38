/***********************************************************************
 * Module:  EquipmentController.cs
 * Purpose: Definition of the Class Controller.Manager.EquipmentController
 ***********************************************************************/

using System;

namespace Controller.Manager
{
   public class EquipmentController
   {
      public Model.Manager.Equipment AddEquipment(Model.Manager.Equipment equipment)
      {
         // TODO: implement
         return null;
      }
      
      public void DeleteEquipment(String name)
      {
         // TODO: implement
      }
      
      public Model.Manager.Equipment EditEquipment(Model.Manager.Equipment equipment)
      {
         // TODO: implement
         return null;
      }
      
      public EquipmentController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      public Service.Manager.EquipmentService equipmentService;
   
      private EquipmentController Instance;
   
   }
}