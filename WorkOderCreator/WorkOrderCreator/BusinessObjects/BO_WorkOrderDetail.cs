using System;
using System.Collections.Generic;
using System.Linq;
using WorkOrderCreator.DataModels;
using WorkOrderCreator.HelperClasses;
using WorkOrderCreator.ReturnObject;

namespace WorkOrderCreator.BusinessObjects
{
    public class BO_WorkOrderDetail : _BO
    {
        public DataValidatorReturn Find(int workOrderID, int itemNumber, int activityID )
        {
            DVR = MethodHelper.IsGreaterThanZero("Work Order Number", workOrderID);

            if (DVR.IsValid == false)
                return DVR;

            DVR = MethodHelper.IsGreaterThanZero("Item Number", itemNumber);

            if (DVR.IsValid == false)
                return DVR;

            DVR = MethodHelper.IsGreaterThanZero("Activity ID", activityID);

            if (DVR.IsValid == false)
                return DVR;

            BO_WorkOrderHeader bO_WorkOrderHeader = new BO_WorkOrderHeader();
            DVR = bO_WorkOrderHeader.Find(workOrderID);

            if (DVR.ItemFound == false)
                return DVR;

            BO_Activity bO_Activity = new BO_Activity();
            DVR = bO_Activity.Find(activityID);

            if (DVR.ItemFound == false)
                return DVR;

            try
            {
                List < WorkOrderDetail > workOrderDetails = new List<WorkOrderDetail>();

                using (var context = new WorkOrderLogEntities())
                {
                    workOrderDetails = context.WorkOrderDetails.Where(x => x.WOHdrID == workOrderID && x.ActivityID == activityID && x.ItemNumber == itemNumber).ToList(); 
                }

                DVR.ItemFound = workOrderDetails.Any();
                DVR.IsValid = true;
                DVR.ReturnType = workOrderDetails.FirstOrDefault();
                if (DVR.ItemFound)
                {
                    DVR.ReturnText = workOrderDetails.Count().ToString() + " Work Order Details Found.";
                    DVR.ReturnType = workOrderDetails.FirstOrDefault();
                }
                else
                {
                    DVR.ReturnText = "Work Order Detail Not Found.";
                }
            }
            catch (Exception exception)
            {
                DVR.IsValid = false;
                DVR.ReturnText = exception.Message;
            }

            return DVR;
        }
    }
}
