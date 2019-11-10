using System;
using System.Collections.Generic;
using System.Linq;
using WorkOrderCreator.DataModels;
using WorkOrderCreator.HelperClasses;
using WorkOrderCreator.ReturnObject;

namespace WorkOrderCreator.BusinessObjects
{
    public class BO_Activity : _BO
    {
        public DataValidatorReturn Find(int activityID)
        {
            DVR = MethodHelper.IsGreaterThanZero("Activity", activityID);

            if (DVR.IsValid == false)
                return DVR;

            try
            {
                List<Activity> activities = new List<Activity>();

                using (var context = new WorkOrderLogEntities())
                {
                    activities = context.Activities.Where(x => x.ActivityID == activityID).ToList();
                }

                DVR.ItemFound = activities.Any();
                DVR.IsValid = true;
                DVR.ReturnType = activities.FirstOrDefault();
                if (DVR.ItemFound)
                {
                    DVR.ReturnText = activities.Count().ToString() + " Activity Found.";
                    DVR.ReturnType = activities.FirstOrDefault();
                }
                else
                {
                    DVR.ReturnText = "Activity Not Found.";
                }
            }
            catch (Exception exception)
            {
                DVR.IsValid = false;
                DVR.ReturnText = exception.Message;
            }

            return DVR;
        }

        public DataValidatorReturn Find(string activityDescription)
        {
            DVR = MethodHelper.IsParameterEmpty("Activity", activityDescription);

            if (DVR.IsValid == false)
                return DVR;

            try
            {
                List<Activity> activities = new List<Activity>();

                using (var context = new WorkOrderLogEntities())
                {
                    activities = context.Activities.Where(x => x.ActivityDescription == activityDescription).ToList();
                }

                DVR.ItemFound = activities.Any();
                DVR.IsValid = true;
                DVR.ReturnType = activities.FirstOrDefault();
                if (DVR.ItemFound)
                {
                    DVR.ReturnText = activities.Count().ToString() + " Activity Found.";
                    DVR.ReturnType = activities.FirstOrDefault();
                }
                else
                {
                    DVR.ReturnText = "Activity Not Found.";
                }
            }
            catch (Exception exception)
            {
                DVR.IsValid = false;
                DVR.ReturnText = exception.Message;
            }

            return DVR;
        }

        public DataValidatorReturn Create(string activityDescription, int activityTypeID)
        {
            DVR = MethodHelper.IsParameterEmpty("Activity", activityDescription);

            if (DVR.IsValid == false)
                return DVR;

            if (Find(activityDescription).ItemFound)
            {
                DVR.IsValid = false;
                DVR.ReturnText = activityDescription + " already exists.";
                DVR.ItemFound = true;
                return DVR;
            }

            BO_ActivityType bO_ActivityType = new BO_ActivityType();
            DVR = bO_ActivityType.Find(activityTypeID);

            if (DVR.ItemFound == false)
            {
                return DVR;
            }

            using (var context = new WorkOrderLogEntities())
            {
                Activity activity = new Activity()
                {
                    ActivityDescription = activityDescription,
                    ActivityTypeID = activityTypeID
                };

                try
                {
                    context.Activities.Add(activity);
                    context.SaveChanges();
                    DVR.IsValid = true;
                    DVR.ReturnText = "Activity: " + activityDescription + " Added to the Database.";
                    DVR.ReturnType = activity;
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
