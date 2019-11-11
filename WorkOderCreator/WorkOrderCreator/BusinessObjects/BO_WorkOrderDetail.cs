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

        public DataValidatorReturn Create(int workOrderID, int itemNumber, int activityID)
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

            if (Find(workOrderID,itemNumber,activityID).ItemFound)
            {
                DVR.IsValid = false;
                DVR.ReturnText = "Work Order Detail # " + workOrderID.ToString() + " already exists.";
                DVR.ItemFound = true;
                return DVR;
            }

            using (var context = new WorkOrderLogEntities())
            {
                WorkOrderDetail workOrderDetail = new WorkOrderDetail()
                {
                    WOHdrID = workOrderID,
                    ItemNumber = itemNumber,
                    ActivityID = activityID
                };

                try
                {
                    context.WorkOrderDetails.Add(workOrderDetail);
                    //Once we have created a work order detail need to look for the  
                    //Activity using the activity Id, and then get the activityTypeId
                    //Go to the sourcescripthdr table and get the sourcescripthdrid 
                    //and use the info from the sourcescriptdtl table to create 
                    //WorkOrderDtlScript records also need to create these actual files 
                    //by retrieving the source items and pasting to the new files.
                    context.SaveChanges();
                    DVR.IsValid = true;
                    DVR.ReturnText = "Work Order Detail #" + workOrderID.ToString() + " Added to the Database.";
                    DVR.ReturnType = workOrderDetail;
                }
                catch (Exception exception)
                {
                    DVR.IsValid = false;
                    DVR.ReturnText = exception.Message;
                }
            }

            return DVR;
        }
    }
}
