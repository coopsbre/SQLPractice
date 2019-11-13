using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkOrderCreator.DataModels;
using WorkOrderCreator.HelperClasses;
using WorkOrderCreator.ReturnObject;

namespace WorkOrderCreator.BusinessObjects
{
    public class BO_WorkOrderDtlScripts : _BO
    {
        public DataValidatorReturn Create(int workOrderDtlID, string fileName)
        {

            DVR = MethodHelper.IsGreaterThanZero("Work Order Dtl ID", workOrderDtlID);

            if (DVR.IsValid == false)
                return DVR;

            DVR = MethodHelper.IsParameterEmpty("File Name", fileName);

            if (DVR.IsValid == false)
                return DVR;
            
            using (var context = new WorkOrderLogEntities())
            {
                WorkOrderDtlScript workderOrderDtlScript = new WorkOrderDtlScript()
                {
                    WODtlID = workOrderDtlID,
                    FileName = fileName
                };

                try
                {
                    context.WorkOrderDtlScripts.Add(workderOrderDtlScript);
                    context.SaveChanges();
                    DVR.IsValid = true;
                    DVR.ReturnText = "Work Order Dtl Script For Work Order Detail#" + workOrderDtlID.ToString() + " Added to the Database.";
                    DVR.ReturnType = workderOrderDtlScript;
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
