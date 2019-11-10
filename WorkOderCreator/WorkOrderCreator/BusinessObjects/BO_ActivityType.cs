using System;
using System.Collections.Generic;
using System.Linq;
using WorkOrderCreator.DataModels;
using WorkOrderCreator.HelperClasses;
using WorkOrderCreator.ReturnObject;

namespace WorkOrderCreator.BusinessObjects
{
    public class BO_ActivityType : _BO
    {
        public DataValidatorReturn Find(int activityTypeId)
        {
            DVR = MethodHelper.IsGreaterThanZero("Activity Type", activityTypeId);

            if (DVR.IsValid == false)
                return DVR;

            try
            {
                List<ActivityType> activityTypes = new List<ActivityType>();

                using (var context = new WorkOrderLogEntities())
                {
                    activityTypes = context.ActivityTypes.Where(x => x.ActivityTypeID == activityTypeId).ToList();
                }

                DVR.ItemFound = activityTypes.Any();
                DVR.IsValid = true;
                DVR.ReturnType = activityTypes.FirstOrDefault();
                if (DVR.ItemFound)
                {
                    DVR.ReturnText = activityTypes.Count().ToString() + " Activity Type Found.";
                    DVR.ReturnType = activityTypes.FirstOrDefault();
                }
                else
                {
                    DVR.ReturnText = "Activity Type Not Found.";
                }
            }
            catch (Exception exception)
            {
                DVR.IsValid = false;
                DVR.ReturnText = exception.Message;
            }

            return DVR;
        }

        public DataValidatorReturn Find(string activityTypeShortDesc)
        {
            DVR = MethodHelper.IsParameterEmpty("Activity Type", activityTypeShortDesc);

            if (DVR.IsValid == false)
                return DVR;

            try
            {
                List<ActivityType> activityTypes = new List<ActivityType>();

                using (var context = new WorkOrderLogEntities())
                {
                    activityTypes = context.ActivityTypes.Where(x => x.ShortDescription == activityTypeShortDesc).ToList();
                }

                DVR.ItemFound = activityTypes.Any();
                DVR.IsValid = true;
                DVR.ReturnType = activityTypes.FirstOrDefault();
                if (DVR.ItemFound)
                {
                    DVR.ReturnText = activityTypes.Count().ToString() + " Activity Type Found.";
                    DVR.ReturnType = activityTypes.FirstOrDefault();
                }
                else
                {
                    DVR.ReturnText = "Activity Type Not Found.";
                }
            }
            catch (Exception exception)
            {
                DVR.IsValid = false;
                DVR.ReturnText = exception.Message;
            }

            return DVR;
        }

        /// <summary>
        /// Purpose is to create a client given a Client Code and Client Folder. 
        /// </summary>
        /// <param name="clientCode">Unique Client Code</param>
        /// <param name="clientFolder">Unique Client Folder</param>
        /// <returns></returns>
        public DataValidatorReturn Create(string activityTypeShortDesc, string activityTypeLongDesc)
        {
            DVR = MethodHelper.IsParameterEmpty("Activity Type", activityTypeShortDesc);

            if (DVR.IsValid == false)
                return DVR;

            DVR = MethodHelper.IsParameterEmpty("Activity Type Description", activityTypeLongDesc);

            if (DVR.IsValid == false)
                return DVR;

            if (Find(activityTypeShortDesc).ItemFound)
            {
                DVR.IsValid = false;
                DVR.ReturnText = activityTypeShortDesc + " already exists.";
                DVR.ItemFound = true;
                return DVR;
            }

            using (var context = new WorkOrderLogEntities())
            {
                ActivityType activityType = new ActivityType()
                {
                    ShortDescription = activityTypeShortDesc,
                    LongDescription = activityTypeLongDesc
                };

                try
                {
                    context.ActivityTypes.Add(activityType);
                    context.SaveChanges();
                    DVR.IsValid = true;
                    DVR.ReturnText = "Activity Type: " + activityTypeShortDesc + " Added to the Database.";
                    DVR.ReturnType = activityType;
                }
                catch (Exception exception)
                {
                    DVR.IsValid = false;
                    DVR.ReturnText = exception.Message;
                }
            }

            return DVR;
        }

        public DataValidatorReturn Delete(int activityTypeID)
        {
            DVR = MethodHelper.IsGreaterThanZero("Activity Type", activityTypeID);

            if (DVR.IsValid == false)
                return DVR;

            DataValidatorReturn dvr = new DataValidatorReturn();
            dvr = Find(activityTypeID);

            if (dvr.ItemFound == false)
            {
                DVR.IsValid = false;
                DVR.ReturnText = activityTypeID + " not found.";
                DVR.ItemFound = false;
                return DVR;
            }

            using (var context = new WorkOrderLogEntities())
            {
                try
                {
                    int numWorkOrderDetails = 0;
                    int numActivities = 0;
                    int currentActivityId = 0;

                    //Delete foreign relationships etc.

                    //Get the activities. 
                    var activities = context.Activities.Where(x => x.ActivityTypeID == activityTypeID).ToList();

                    if (activities.Any())
                    {
                        numActivities = activities.Count();

                        for (int i = 0; i < numActivities; i++)
                        {
                            currentActivityId = activities[i].ActivityID;

                            List<WorkOrderDetail> workOrderDetails = context.WorkOrderDetails.Where(x => x.ActivityID == currentActivityId).ToList();

                            if (workOrderDetails.Any())
                            {
                                numWorkOrderDetails = workOrderDetails.Count();
                                for (int j = 0; j < numWorkOrderDetails; j++)
                                {
                                    WorkOrderDetail workOrderDetail = workOrderDetails[j];
                                    context.WorkOrderDetails.Remove(workOrderDetail);
                                }
                            }

                            Activity activity = activities[i];
                            context.Activities.Remove(activity);
                        }
                    }

                    ActivityType activityType = context.ActivityTypes.Where(x => x.ActivityTypeID == activityTypeID).FirstOrDefault();

                    context.ActivityTypes.Remove(activityType);

                    context.SaveChanges();

                    DVR.IsValid = true;
                    DVR.ReturnText = activityType.ShortDescription + " Removed Successfully." + Environment.NewLine + numActivities.ToString() +
                                     " Activities Removed successfully." + Environment.NewLine +
                                     numWorkOrderDetails + " Removed Successfully.";
                }
                catch (Exception exception)
                {
                    DVR.IsValid = false;
                    DVR.ErrorText = exception.Message;
                }
            }

            return DVR;
        }
    }
}
