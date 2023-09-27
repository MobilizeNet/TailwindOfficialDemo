using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TailwindPOS
{

   partial class frmPayment
   {

#region "Upgrade Support "
      [Intercepted]
      private static frmPayment m_vb6FormDefInstance { get; set; }

      [Intercepted]
      private static bool m_InitializingDefInstance { get; set; }

      public static frmPayment DefInstance
      {
         get
         {
            if ( m_vb6FormDefInstance is null || m_vb6FormDefInstance.IsDisposed )
            {
               m_InitializingDefInstance = true;
               m_vb6FormDefInstance = new frmPayment();
               m_InitializingDefInstance = false;
            }
            return m_vb6FormDefInstance;
         }
         set
         {
            m_vb6FormDefInstance = value;
         }
      }
#endregion

#region "Windows Form Designer generated code "
      [Intercepted]
      private string[] visualControls { get; set; } = new string[] { "components", "ToolTipMain", "cbCash", "cbCreditCard", "cbCheck", "cbGiftCard", "ucNumbers", "gbPayments", "cbFinishPayment", "fgPayments", "cb_Cancel", "lblPaymentReady", "lblChange", "lblChangeTitle", "lblPaidSoFarTitle", "lblRemaining", "lblRemaingTitle", "commandButtonHelper1" };

      //Required by the Windows Form Designer
      [Intercepted]
      private Mobilize.Web.Controls.Interfaces.IContainer components { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolTip ToolTipMain { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cbCash { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cbCreditCard { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cbCheck { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cbGiftCard { get; set; }

      [Intercepted]
      public ucNumbersPad ucNumbers { get; set; }

      [Intercepted]
      public Mobilize.Web.GroupBox gbPayments { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cbFinishPayment { get; set; }

      [Intercepted]
      public Mobilize.Web.VBUC.FlexGrid fgPayments { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cb_Cancel { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblPaymentReady { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblChange { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblChangeTitle { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblPaidSoFarTitle { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblRemaining { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblRemaingTitle { get; set; }

      [Intercepted]
      public Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1 { get; set; }

      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.
      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {
         this.components = new Mobilize.Web.ControlCollection();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
         this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
         this.gbPayments = new Mobilize.Web.GroupBox();
         this.cbCash = new Mobilize.Web.Button();
         this.cbCreditCard = new Mobilize.Web.Button();
         this.cbCheck = new Mobilize.Web.Button();
         this.cbGiftCard = new Mobilize.Web.Button();
         this.ucNumbers = new ucNumbersPad();
         this.cbFinishPayment = new Mobilize.Web.Button();
         this.fgPayments = new Mobilize.Web.VBUC.FlexGrid(this.components);
         this.cb_Cancel = new Mobilize.Web.Button();
         this.lblPaymentReady = new Mobilize.Web.Label();
         this.lblChange = new Mobilize.Web.Label();
         this.lblChangeTitle = new Mobilize.Web.Label();
         this.lblPaidSoFarTitle = new Mobilize.Web.Label();
         this.lblRemaining = new Mobilize.Web.Label();
         this.lblRemaingTitle = new Mobilize.Web.Label();
         this.gbPayments.SuspendLayout();
         this.SuspendLayout();
         this.commandButtonHelper1 = new Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper(this.components);
         // 
         // gbPayments
         // 
         this.gbPayments.AllowDrop = true;
         this.gbPayments.BackColor = System.Drawing.Color.White;
         this.gbPayments.Controls.Add(this.cbCash);
         this.gbPayments.Controls.Add(this.cbCreditCard);
         this.gbPayments.Controls.Add(this.cbCheck);
         this.gbPayments.Controls.Add(this.cbGiftCard);
         this.gbPayments.Controls.Add(this.ucNumbers);
         this.gbPayments.Properties().Cursor = Stub._UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
         this.gbPayments.Enabled = true;
         this.gbPayments.Font = new Mobilize.Web.Font("Gin", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.gbPayments.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.gbPayments.Location = new System.Drawing.Point(16, 24);
         this.gbPayments.Name = "gbPayments";
         this.gbPayments.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.gbPayments.Size = new System.Drawing.Size(729, 529);
         this.gbPayments.TabIndex = 1;
         this.gbPayments.Text = "Payments";
         this.gbPayments.Visible = true;
         // 
         // cbCash
         // 
         this.cbCash.AllowDrop = true;
         this.cbCash.BackColor = System.Drawing.Color.White;
         this.cbCash.Font = new Mobilize.Web.Font("Brandon Grotesque Light", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cbCash.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cbCash.Location = new System.Drawing.Point(368, 56);
         this.cbCash.Name = "cbCash";
         this.cbCash.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cbCash.Size = new System.Drawing.Size(313, 81);
         this.cbCash.TabIndex = 3;
         this.cbCash.Text = "Cash";
         this.cbCash.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cbCash.UseVisualStyleBackColor = false;
         this.cbCash.Click += new System.EventHandler(this.cbCash_Click);
         // 
         // cbCreditCard
         // 
         this.cbCreditCard.AllowDrop = true;
         this.cbCreditCard.BackColor = System.Drawing.Color.White;
         this.cbCreditCard.Font = new Mobilize.Web.Font("Brandon Grotesque Light", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cbCreditCard.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cbCreditCard.Location = new System.Drawing.Point(368, 144);
         this.cbCreditCard.Name = "cbCreditCard";
         this.cbCreditCard.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cbCreditCard.Size = new System.Drawing.Size(313, 81);
         this.cbCreditCard.TabIndex = 4;
         this.cbCreditCard.Text = "Credit Card";
         this.cbCreditCard.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cbCreditCard.UseVisualStyleBackColor = false;
         this.cbCreditCard.Click += new System.EventHandler(this.cbCreditCard_Click);
         // 
         // cbCheck
         // 
         this.cbCheck.AllowDrop = true;
         this.cbCheck.BackColor = System.Drawing.Color.White;
         this.cbCheck.Font = new Mobilize.Web.Font("Brandon Grotesque Light", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cbCheck.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cbCheck.Location = new System.Drawing.Point(368, 232);
         this.cbCheck.Name = "cbCheck";
         this.cbCheck.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cbCheck.Size = new System.Drawing.Size(313, 81);
         this.cbCheck.TabIndex = 5;
         this.cbCheck.Text = "Check";
         this.cbCheck.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cbCheck.UseVisualStyleBackColor = false;
         this.cbCheck.Click += new System.EventHandler(this.cbCheck_Click);
         // 
         // cbGiftCard
         // 
         this.cbGiftCard.AllowDrop = true;
         this.cbGiftCard.BackColor = System.Drawing.Color.White;
         this.cbGiftCard.Font = new Mobilize.Web.Font("Brandon Grotesque Light", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cbGiftCard.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cbGiftCard.Location = new System.Drawing.Point(368, 320);
         this.cbGiftCard.Name = "cbGiftCard";
         this.cbGiftCard.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cbGiftCard.Size = new System.Drawing.Size(313, 81);
         this.cbGiftCard.TabIndex = 6;
         this.cbGiftCard.Text = "Gift Card";
         this.cbGiftCard.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cbGiftCard.UseVisualStyleBackColor = false;
         this.cbGiftCard.Click += new System.EventHandler(this.cbGiftCard_Click);
         // 
         // ucNumbers
         // 
         this.ucNumbers.AllowDrop = true;
         this.ucNumbers.Location = new System.Drawing.Point(8, 48);
         this.ucNumbers.Name = "ucNumbers";
         this.ucNumbers.Size = new System.Drawing.Size(361, 457);
         this.ucNumbers.TabIndex = 2;
         // 
         // cbFinishPayment
         // 
         this.cbFinishPayment.AllowDrop = true;
         this.cbFinishPayment.BackColor = System.Drawing.Color.FromArgb(97, 44, 67);
         this.cbFinishPayment.Font = new Mobilize.Web.Font("Brandon Grotesque Light", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cbFinishPayment.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cbFinishPayment.Location = new System.Drawing.Point(624, 568);
         this.cbFinishPayment.Name = "cbFinishPayment";
         this.cbFinishPayment.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cbFinishPayment.Size = new System.Drawing.Size(289, 81);
         this.cbFinishPayment.TabIndex = 13;
         this.cbFinishPayment.Text = "Continue";
         this.cbFinishPayment.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cbFinishPayment.UseVisualStyleBackColor = false;
         this.cbFinishPayment.Click += new System.EventHandler(this.cbFinishPayment_Click);
         // 
         // fgPayments
         // 
         this.fgPayments.AllowDrop = true;
         this.fgPayments.AllowUserToAddRows = false;
         this.fgPayments.AllowUserToDeleteRows = false;
         this.fgPayments.Properties().AllowUserToResizeColumns = false;
         this.fgPayments.Properties().AllowUserToResizeRows = false;
         this.fgPayments.Properties().BackgroundColor = System.Drawing.Color.White;
         this.fgPayments.Properties().ColumnHeadersHeightSizeMode = Mobilize.Web.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
         this.fgPayments.ColumnsCount = 3;
         this.fgPayments.FixedColumns = 1;
         this.fgPayments.FixedRows = 1;
         this.fgPayments.Font = new Mobilize.Web.Font("Brandon Grotesque Light", 14.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.fgPayments.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.fgPayments.Location = new System.Drawing.Point(816, 256);
         this.fgPayments.Name = "fgPayments";
         this.fgPayments.Properties().ReadOnly = true;
         this.fgPayments.RowsCount = 1;
         this.fgPayments.Properties().SelectionMode = Mobilize.Web.DataGridViewSelectionMode.CellSelect;
         this.fgPayments.Properties().ShowCellToolTips = false;
         this.fgPayments.Size = new System.Drawing.Size(385, 281);
         this.fgPayments.Properties().StandardTab = true;
         this.fgPayments.TabIndex = 12;
         // 
         // cb_Cancel
         // 
         this.cb_Cancel.AllowDrop = true;
         this.cb_Cancel.BackColor = System.Drawing.Color.White;
         this.cb_Cancel.Font = new Mobilize.Web.Font("Brandon Grotesque Light", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cb_Cancel.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cb_Cancel.Location = new System.Drawing.Point(928, 568);
         this.cb_Cancel.Name = "cb_Cancel";
         this.cb_Cancel.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cb_Cancel.Size = new System.Drawing.Size(265, 81);
         this.cb_Cancel.TabIndex = 14;
         this.cb_Cancel.Text = "Cancel";
         this.cb_Cancel.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cb_Cancel.UseVisualStyleBackColor = false;
         this.cb_Cancel.Click += new System.EventHandler(this.cb_Cancel_Click);
         // 
         // lblPaymentReady
         // 
         this.lblPaymentReady.AllowDrop = true;
         this.lblPaymentReady.BackColor = Mobilize.Web.SystemColors.Control;
         this.lblPaymentReady.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblPaymentReady.Font = new Mobilize.Web.Font("Gin", 24f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblPaymentReady.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.lblPaymentReady.Location = new System.Drawing.Point(48, 184);
         this.lblPaymentReady.Name = "lblPaymentReady";
         this.lblPaymentReady.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.lblPaymentReady.Size = new System.Drawing.Size(401, 193);
         this.lblPaymentReady.TabIndex = 10;
         this.lblPaymentReady.Text = "Payment Ready. Press Continue to Print the Receipt";
         this.lblPaymentReady.Visible = false;
         // 
         // lblChange
         // 
         this.lblChange.AllowDrop = true;
         this.lblChange.BackColor = System.Drawing.Color.White;
         this.lblChange.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblChange.Font = new Mobilize.Web.Font("Brandon Grotesque Light", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblChange.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblChange.Location = new System.Drawing.Point(832, 152);
         this.lblChange.Name = "lblChange";
         this.lblChange.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.lblChange.Size = new System.Drawing.Size(361, 41);
         this.lblChange.TabIndex = 9;
         this.lblChange.Text = "$0.00";
         this.lblChange.TextAlign = Mobilize.Web.ContentAlignment.TopRight;
         // 
         // lblChangeTitle
         // 
         this.lblChangeTitle.AllowDrop = true;
         this.lblChangeTitle.BackColor = System.Drawing.Color.White;
         this.lblChangeTitle.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblChangeTitle.Font = new Mobilize.Web.Font("Gin", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblChangeTitle.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblChangeTitle.Location = new System.Drawing.Point(864, 104);
         this.lblChangeTitle.Name = "lblChangeTitle";
         this.lblChangeTitle.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.lblChangeTitle.Size = new System.Drawing.Size(329, 49);
         this.lblChangeTitle.TabIndex = 8;
         this.lblChangeTitle.Text = "Change Due";
         this.lblChangeTitle.TextAlign = Mobilize.Web.ContentAlignment.TopRight;
         // 
         // lblPaidSoFarTitle
         // 
         this.lblPaidSoFarTitle.AllowDrop = true;
         this.lblPaidSoFarTitle.BackColor = System.Drawing.Color.White;
         this.lblPaidSoFarTitle.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblPaidSoFarTitle.Font = new Mobilize.Web.Font("Gin", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblPaidSoFarTitle.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblPaidSoFarTitle.Location = new System.Drawing.Point(864, 200);
         this.lblPaidSoFarTitle.Name = "lblPaidSoFarTitle";
         this.lblPaidSoFarTitle.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.lblPaidSoFarTitle.Size = new System.Drawing.Size(329, 49);
         this.lblPaidSoFarTitle.TabIndex = 11;
         this.lblPaidSoFarTitle.Text = "Paid So Far";
         this.lblPaidSoFarTitle.TextAlign = Mobilize.Web.ContentAlignment.TopRight;
         // 
         // lblRemaining
         // 
         this.lblRemaining.AllowDrop = true;
         this.lblRemaining.BackColor = System.Drawing.Color.White;
         this.lblRemaining.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblRemaining.Font = new Mobilize.Web.Font("Brandon Grotesque Light", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblRemaining.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblRemaining.Location = new System.Drawing.Point(832, 56);
         this.lblRemaining.Name = "lblRemaining";
         this.lblRemaining.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.lblRemaining.Size = new System.Drawing.Size(361, 41);
         this.lblRemaining.TabIndex = 7;
         this.lblRemaining.Text = "$0.00";
         this.lblRemaining.TextAlign = Mobilize.Web.ContentAlignment.TopRight;
         // 
         // lblRemaingTitle
         // 
         this.lblRemaingTitle.AllowDrop = true;
         this.lblRemaingTitle.BackColor = System.Drawing.Color.White;
         this.lblRemaingTitle.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblRemaingTitle.Font = new Mobilize.Web.Font("Gin", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblRemaingTitle.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
         this.lblRemaingTitle.Location = new System.Drawing.Point(864, 8);
         this.lblRemaingTitle.Name = "lblRemaingTitle";
         this.lblRemaingTitle.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.lblRemaingTitle.Size = new System.Drawing.Size(329, 49);
         this.lblRemaingTitle.TabIndex = 0;
         this.lblRemaingTitle.Text = "Amount Remaining";
         this.lblRemaingTitle.TextAlign = Mobilize.Web.ContentAlignment.TopRight;
         // 
         // frmPayment
         // 
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(17, 33);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(1219, 659);
         this.Controls.Add(this.gbPayments);
         this.Controls.Add(this.cbFinishPayment);
         this.Controls.Add(this.fgPayments);
         this.Controls.Add(this.cb_Cancel);
         this.Controls.Add(this.lblPaymentReady);
         this.Controls.Add(this.lblChange);
         this.Controls.Add(this.lblChangeTitle);
         this.Controls.Add(this.lblPaidSoFarTitle);
         this.Controls.Add(this.lblRemaining);
         this.Controls.Add(this.lblRemaingTitle);
         this.Font = new Mobilize.Web.Font("Brandon Grotesque Light", 21.75f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Properties().Location = new System.Drawing.Point(4, 27);
         this.MaximizeBox = true;
         this.MinimizeBox = true;
         this.Name = "frmPayment";
         this.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.CenterScreen;
         this.Text = "Pay";
         this.commandButtonHelper1.SetStyle(this.cbCash, 1);
         this.commandButtonHelper1.SetStyle(this.cbCreditCard, 1);
         this.commandButtonHelper1.SetStyle(this.cbCheck, 1);
         this.commandButtonHelper1.SetStyle(this.cbGiftCard, 1);
         this.commandButtonHelper1.SetStyle(this.cbFinishPayment, 1);
         this.commandButtonHelper1.SetStyle(this.cb_Cancel, 1);
         this.Activated += new System.EventHandler(this.frmPayment_Activated);
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.Load += new System.EventHandler(this.Form_Load);
         this.gbPayments.ResumeLayout(false);
         this.ResumeLayout(false);
      }
#endregion

   }

}