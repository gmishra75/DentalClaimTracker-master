using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace C_DentalClaimTracker
{
    public partial class start_screen_buttons : DataObject
    {
        /// <summary>
        /// Returns an ordered list of start screen buttons for a user (sorted by category then order_id)
        /// </summary>
        /// <param name="CurrentUser"></param>
        /// <returns></returns>
        public static List<start_screen_buttons> GetUserButtons(user CurrentUser)
        {
            List<start_screen_buttons> toReturn = new List<start_screen_buttons>();
            start_screen_buttons ssb = new start_screen_buttons();

            DataTable userButtons = ssb.Search(
                string.Format("SELECT ssb.* FROM user_start_screen_buttons ussb INNER JOIN start_screen_buttons ssb ON ussb.button_id = " +
                "ssb.ID WHERE user_id = {0} ORDER BY category_id, order_id", CurrentUser.id));

            foreach (DataRow aRow in userButtons.Rows)
            {
                ssb = new start_screen_buttons();
                ssb.Load(aRow);

                toReturn.Add(ssb);
            }

            return toReturn;
        }
    }
}
