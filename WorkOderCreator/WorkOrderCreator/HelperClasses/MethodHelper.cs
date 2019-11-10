using System;
using System.Linq;
using WorkOrderCreator.ReturnObject;

namespace WorkOrderCreator.HelperClasses
{
    public static class MethodHelper
    {
        public static DataValidatorReturn IsParameterEmpty(string parameterName, string parameterValue)
        {
            DataValidatorReturn dvr = new DataValidatorReturn();

            bool isEmpty = false;

            isEmpty = parameterValue == string.Empty;

            if (isEmpty)
            {
                dvr.IsValid = false;
                dvr.ReturnText = "Empty Parameter Name: " + parameterName;
            }
            else
            {
                dvr.IsValid = true;
            }

            return dvr;
        }

        internal static DataValidatorReturn IsGreaterThanZero(string parameterName, int parameterValue)
        {
            DataValidatorReturn dvr = new DataValidatorReturn();

            bool isEmpty = false;

            isEmpty = parameterValue == 0;

            if (isEmpty)
            {
                dvr.IsValid = false;
                dvr.ReturnText = "Zero Value for Parameter Name: " + parameterName + ".";
            }
            else
            {
                dvr.IsValid = true;
            }

            return dvr;
        }
    }
}
