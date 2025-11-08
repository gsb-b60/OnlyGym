using DataAccess.Object;
using GymManagerment_MVP.MainFeature.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagerment_MVP
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LOGIN());
            while(true)
            {
                using (LOGIN login=new LOGIN())
                {
                    
                    if(login.ShowDialog()==DialogResult.OK)
                    {
                        User u = login.user;
                        if(u != null)
                        {
                            using (Mainfrm frm = new Mainfrm(u))
                            {
                                if(frm.ShowDialog()!=DialogResult.Retry)
                                {
                                    break;
                                }
                            }
                        }
                        
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
