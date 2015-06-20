using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1. Reverse your name
            string name = "Malik Gray";
            // In my case, the result would be:
            // yarG kilaM

            //string temp = "";
            //for (int i = name.Length - 1; i >= 0; i--)
            //{
            //    temp += name[i];
            //}
            //name = temp;

            //ResultLabel.Text = name;

            // 2. Reverse this sequence:
            string names = "Luke,Leia,Han,Chewbaca";
            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke
            //string[] namearray = names.Split(',');
            //string temp = "";
            //for(int i = namearray.Length - 1; i >= 0; i--)
            //{
            //    temp += namearray[i] + ",";
            //}
            //names = temp.Remove(temp.Length - 1);
            //ResultLabel.Text = names;


        }
    }
}