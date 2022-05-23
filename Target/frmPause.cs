using System;
using UpgradeHelpers.Helpers;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TailwindPOS
{

   [Observable]
   internal partial class frmPause
      : Mobilize.Web.Form
   {

   	public frmPause()
   		: base()
   	{
   		if (m_vb6FormDefInstance is null)
   		{
   			if (m_InitializingDefInstance)
   			{
   				m_vb6FormDefInstance = this;
   			}
   			else
   			{
   				try
   				{
   					//For the start-up form, the first instance created is the default instance.
   					if (!(System.Reflection.Assembly.GetExecutingAssembly().EntryPoint is null) && System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
                  {
                  	m_vb6FormDefInstance = this;
                  }
               }
               catch
               {
               }
            }
         }
         //This call is required by the Windows Form Designer.
         InitializeComponent();
      }


      private void frmPause_Activated(System.Object eventSender, System.EventArgs eventArgs)
      {
         if ( Stub._UpgradeHelpers.Gui.ActivateHelper.myActiveForm != eventSender)
         {
            Stub._UpgradeHelpers.Gui.ActivateHelper.myActiveForm = (Mobilize.Web.Form) eventSender;
         }
      }

      [Intercepted]
      int m_BreakId { get; set; } = 0;
      private void cbReturn_Click(Object eventSender, EventArgs eventArgs)
      {
      	decimal MINIMUM_CASH = 0;
      	decimal Total = 0;
      	frmCashCount cash = null;
      	int ShiftID = 0;
      	if (MainModule.CurrentShift.UserID == 0)
         {
            Mobilize.Web.MessageBox.Show("You are starting your shift, please count cash on drawer", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()));
            Total = 0;
            while (Total < 300)
            {
            	cash = frmCashCount.CreateInstance();
            	cash.ShowDialog();
            	Total = cash.Total;
            	// Validate that the POS has enough cash on Drawer to
            	// Begin shift
            	if (Total > MINIMUM_CASH)
            	{
            		// Start a shift and register it into database
            		System.DateTime tempRefParam = DateTime.Now;
            		ShiftID = MainModule.StartShiftWithAmount(MainModule.CurrentPOS.POSID, MainModule.CurrentShift.UserID, Mobilize.Web.ReferenceExtensions.Ref(() => tempRefParam), Total);
                  if (ShiftID > 0)
                  {
                  	this.Hide();
                  	MainModule.CurrentShift.ShiftID = ShiftID;
                  }
               }
               else
               {
                  Mobilize.Web.MessageBox.Show("You need to have a minimum of " + MINIMUM_CASH.ToString() + " to Start a Shift", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()));
               }
            }
         }
         else
         {
            this.Hide();
         }
      }

      //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
      private void Form_Load()
      {
         int CurrentUserID = 0;
         m_BreakId = 0;
         // There is a Current Shift Then Register a Break
         if (MainModule.CurrentShift.ShiftID != 0)
         {
         	System.DateTime tempRefParam = DateTime.Now;
         	m_BreakId = MainModule.RegisterBreakStart(MainModule.CurrentPOS.POSID, MainModule.CurrentShift.ShiftID, Mobilize.Web.ReferenceExtensions.Ref(() => tempRefParam));
         }
         else
         {
         	if (CurrentUserID == 0)
            {
            	lblPauseMessage.Text = "No user Logged In";
            }

         }
      }

      private void Form_Closed(Object eventSender, EventArgs eventArgs)
      {
         if (m_BreakId != 0)
         {
         	System.DateTime tempRefParam = DateTime.Now;
         	MainModule.RegisterBreakEnd(MainModule.CurrentPOS.POSID, MainModule.CurrentShift.ShiftID, m_BreakId, Mobilize.Web.ReferenceExtensions.Ref(() => tempRefParam));
         }
      }

   }
}