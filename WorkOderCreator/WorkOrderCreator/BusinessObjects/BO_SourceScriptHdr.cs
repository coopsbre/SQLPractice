using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WorkOrderCreator.DataModels;
using WorkOrderCreator.HelperClasses;
using WorkOrderCreator.ReturnObject;

namespace WorkOrderCreator.BusinessObjects
{
    public class BO_SourceScriptHdr : _BO
    {
        public DataValidatorReturn Find(int activityTypeID)
        {
            DVR = MethodHelper.IsGreaterThanZero("Activity Type ID", activityTypeID);

            if (DVR.IsValid == false)
                return DVR;

            BO_ActivityType bo_ActivityType = new BO_ActivityType();
            DVR = bo_ActivityType.Find(activityTypeID);

            if (DVR.ItemFound == false)
                return DVR;

            try
            {
                List<SourceScriptHdr> sourceScriptHdrs = new List<SourceScriptHdr>();

                using (var context = new WorkOrderLogEntities())
                {
                    sourceScriptHdrs = context.SourceScriptHdrs.Include(x => x.SourceScriptDtls.Select(c=>c.Client)).Where(x => x.ActivityTypeID == activityTypeID).ToList();

                }

                DVR.ItemFound = sourceScriptHdrs.Any();
                DVR.IsValid = true;
                DVR.ReturnType = sourceScriptHdrs.FirstOrDefault();
                if (DVR.ItemFound)
                {
                    DVR.ReturnText = sourceScriptHdrs.Count().ToString() + " Source Script Headers Found.";
                    DVR.ReturnType = sourceScriptHdrs.FirstOrDefault();
                }
                else
                {
                    DVR.ReturnText = "Source Script Header Not Found.";
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
