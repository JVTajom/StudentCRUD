namespace StudentCRUD.Form
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.teFirstName = new DevExpress.XtraEditors.TextEdit();
            this.deBirthDate = new DevExpress.XtraEditors.DateEdit();
            this.teMiddleName = new DevExpress.XtraEditors.TextEdit();
            this.teLastName = new DevExpress.XtraEditors.TextEdit();
            this.teAddress = new DevExpress.XtraEditors.TextEdit();
            this.gcStudent = new DevExpress.XtraGrid.GridControl();
            this.gvStudent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // teFirstName
            // 
            this.teFirstName.Location = new System.Drawing.Point(33, 28);
            this.teFirstName.Name = "teFirstName";
            this.teFirstName.Properties.AutoHeight = false;
            this.teFirstName.Properties.NullText = "First Name";
            this.teFirstName.Size = new System.Drawing.Size(105, 34);
            this.teFirstName.TabIndex = 0;
            // 
            // deBirthDate
            // 
            this.deBirthDate.EditValue = null;
            this.deBirthDate.Location = new System.Drawing.Point(366, 28);
            this.deBirthDate.Name = "deBirthDate";
            this.deBirthDate.Properties.AutoHeight = false;
            this.deBirthDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deBirthDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deBirthDate.Properties.NullText = "Date Of Birth";
            this.deBirthDate.Size = new System.Drawing.Size(105, 34);
            this.deBirthDate.TabIndex = 5;
            // 
            // teMiddleName
            // 
            this.teMiddleName.Location = new System.Drawing.Point(144, 28);
            this.teMiddleName.Name = "teMiddleName";
            this.teMiddleName.Properties.AutoHeight = false;
            this.teMiddleName.Properties.NullText = "Middle Name";
            this.teMiddleName.Size = new System.Drawing.Size(105, 34);
            this.teMiddleName.TabIndex = 6;
            // 
            // teLastName
            // 
            this.teLastName.Location = new System.Drawing.Point(255, 28);
            this.teLastName.Name = "teLastName";
            this.teLastName.Properties.AutoHeight = false;
            this.teLastName.Properties.NullText = "Last Name";
            this.teLastName.Size = new System.Drawing.Size(105, 34);
            this.teLastName.TabIndex = 7;
            // 
            // teAddress
            // 
            this.teAddress.Location = new System.Drawing.Point(477, 28);
            this.teAddress.Name = "teAddress";
            this.teAddress.Properties.AutoHeight = false;
            this.teAddress.Properties.NullText = "Address";
            this.teAddress.Size = new System.Drawing.Size(105, 34);
            this.teAddress.TabIndex = 8;
            // 
            // gcStudent
            // 
            this.gcStudent.Location = new System.Drawing.Point(33, 121);
            this.gcStudent.MainView = this.gvStudent;
            this.gcStudent.Name = "gcStudent";
            this.gcStudent.Size = new System.Drawing.Size(549, 302);
            this.gcStudent.TabIndex = 9;
            this.gcStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStudent});
            // 
            // gvStudent
            // 
            this.gvStudent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.DateOfBirth,
            this.Address});
            this.gvStudent.GridControl = this.gcStudent;
            this.gvStudent.Name = "gvStudent";
            this.gvStudent.OptionsView.ShowGroupPanel = false;
            // 
            // FirstName
            // 
            this.FirstName.Caption = "First Name";
            this.FirstName.FieldName = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.Visible = true;
            this.FirstName.VisibleIndex = 0;
            // 
            // MiddleName
            // 
            this.MiddleName.Caption = "Middle Name";
            this.MiddleName.FieldName = "MiddleName";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Visible = true;
            this.MiddleName.VisibleIndex = 1;
            // 
            // LastName
            // 
            this.LastName.Caption = "Last Name";
            this.LastName.FieldName = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.Visible = true;
            this.LastName.VisibleIndex = 2;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Caption = "Date Of Birth";
            this.DateOfBirth.FieldName = "DateOfBirth";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Visible = true;
            this.DateOfBirth.VisibleIndex = 3;
            // 
            // Address
            // 
            this.Address.Caption = "Address";
            this.Address.FieldName = "Address";
            this.Address.Name = "Address";
            this.Address.Visible = true;
            this.Address.VisibleIndex = 4;
            // 
            // btnLoad
            // 
            this.btnLoad.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoad.ImageOptions.SvgImage")));
            this.btnLoad.Location = new System.Drawing.Point(244, 80);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(80, 35);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Location = new System.Drawing.Point(330, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 35);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdate.ImageOptions.SvgImage")));
            this.btnUpdate.Location = new System.Drawing.Point(416, 80);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 35);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Location = new System.Drawing.Point(502, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 35);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "DELETE";
            // 
            // Mainform
            // 
            this.Appearance.BackColor = System.Drawing.Color.Teal;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.gcStudent);
            this.Controls.Add(this.teAddress);
            this.Controls.Add(this.teLastName);
            this.Controls.Add(this.teMiddleName);
            this.Controls.Add(this.deBirthDate);
            this.Controls.Add(this.teFirstName);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Mainform.IconOptions.SvgImage")));
            this.Name = "Mainform";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teFirstName;
        private DevExpress.XtraEditors.DateEdit deBirthDate;
        private DevExpress.XtraEditors.TextEdit teMiddleName;
        private DevExpress.XtraEditors.TextEdit teLastName;
        private DevExpress.XtraEditors.TextEdit teAddress;
        private DevExpress.XtraGrid.GridControl gcStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStudent;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn FirstName;
        private DevExpress.XtraGrid.Columns.GridColumn MiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn LastName;
        private DevExpress.XtraGrid.Columns.GridColumn DateOfBirth;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
    }
}