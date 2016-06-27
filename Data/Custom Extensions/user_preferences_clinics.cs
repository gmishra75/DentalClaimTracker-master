using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace C_DentalClaimTracker
{
    public partial class user_preferences_clinics : DataObject
    {
        public static void Set(int userID, int clinicID, bool value)
        {
            user_preferences_clinics temp = new user_preferences_clinics();

            DataTable matches = temp.Search(string.Format("SELECT * FROM user_preferences_clinics WHERE user_id = {0} and clinic_id = {1}", userID, clinicID));

            if (matches.Rows.Count > 0)
                temp.ExecuteNonQuery(string.Format("UPDATE user_preferences_clinics  SET visible = {0} WHERE user_id = {1} and clinic_id = {2}", Convert.ToInt32(value), userID, clinicID));
            else
                temp.ExecuteNonQuery(string.Format("INSERT INTO user_preferences_clinics (user_id, clinic_id, visible) VALUES ({0}, {1}, {2})", userID, clinicID, Convert.ToInt32(value)));
        }

        public static bool Get(int userID, int clinicID)
        {
            user_preferences_clinics temp = new user_preferences_clinics();
            DataTable matches = temp.Search(string.Format("SELECT * FROM user_preferences_clinics WHERE user_id = {0} and clinic_id = {1}", userID, clinicID));

            if (matches.Rows.Count > 0)
                return Convert.ToBoolean(matches.Rows[0]["visible"]);
            else
                return true;
        }
    }
}
