/***********************************************************************
 * Module:  Appointment.cs
 * Purpose: Definition of the Class Model.Secretary.Appointment
 ***********************************************************************/

using System;

namespace Model.Secretary
{
   public class Appointment
   {
      public System.Collections.ArrayList timeBlock;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetTimeBlock()
      {
         if (timeBlock == null)
            timeBlock = new System.Collections.ArrayList();
         return timeBlock;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetTimeBlock(System.Collections.ArrayList newTimeBlock)
      {
         RemoveAllTimeBlock();
         foreach (TimeBlock oTimeBlock in newTimeBlock)
            AddTimeBlock(oTimeBlock);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddTimeBlock(TimeBlock newTimeBlock)
      {
         if (newTimeBlock == null)
            return;
         if (this.timeBlock == null)
            this.timeBlock = new System.Collections.ArrayList();
         if (!this.timeBlock.Contains(newTimeBlock))
            this.timeBlock.Add(newTimeBlock);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveTimeBlock(TimeBlock oldTimeBlock)
      {
         if (oldTimeBlock == null)
            return;
         if (this.timeBlock != null)
            if (this.timeBlock.Contains(oldTimeBlock))
               this.timeBlock.Remove(oldTimeBlock);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllTimeBlock()
      {
         if (timeBlock != null)
            timeBlock.Clear();
      }
   
      private Model.Patient.MedicalService MedicalService;
      private String Note;
   
   }
}