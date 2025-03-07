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
            this.teCourse = new DevExpress.XtraEditors.TextEdit();
            this.gcStudent = new DevExpress.XtraGrid.GridControl();
            this.gvStudent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Course = new DevExpress.XtraGrid.Columns.GridColumn();
            this.YearLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.teYearLevel = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCourse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teYearLevel.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // teFirstName
            // 
            this.teFirstName.Location = new System.Drawing.Point(38, 36);
            this.teFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.teFirstName.Name = "teFirstName";
            this.teFirstName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teFirstName.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.teFirstName.Properties.Appearance.Options.UseFont = true;
            this.teFirstName.Properties.Appearance.Options.UseForeColor = true;
            this.teFirstName.Properties.AutoHeight = false;
            this.teFirstName.Properties.NullText = "First Name";
            this.teFirstName.Properties.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.teFirstName.Size = new System.Drawing.Size(122, 45);
            this.teFirstName.TabIndex = 0;
            this.teFirstName.TabStop = false;
            // 
            // deBirthDate
            // 
            this.deBirthDate.EditValue = null;
            this.deBirthDate.Location = new System.Drawing.Point(427, 36);
            this.deBirthDate.Margin = new System.Windows.Forms.Padding(4);
            this.deBirthDate.Name = "deBirthDate";
            this.deBirthDate.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deBirthDate.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.deBirthDate.Properties.Appearance.Options.UseFont = true;
            this.deBirthDate.Properties.Appearance.Options.UseForeColor = true;
            this.deBirthDate.Properties.AutoHeight = false;
            this.deBirthDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deBirthDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deBirthDate.Properties.NullText = "Date Of Birth";
            this.deBirthDate.Properties.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.deBirthDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deBirthDate.Size = new System.Drawing.Size(122, 45);
            this.deBirthDate.TabIndex = 5;
            this.deBirthDate.TabStop = false;
            // 
            // teMiddleName
            // 
            this.teMiddleName.Location = new System.Drawing.Point(168, 36);
            this.teMiddleName.Margin = new System.Windows.Forms.Padding(4);
            this.teMiddleName.Name = "teMiddleName";
            this.teMiddleName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teMiddleName.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.teMiddleName.Properties.Appearance.Options.UseFont = true;
            this.teMiddleName.Properties.Appearance.Options.UseForeColor = true;
            this.teMiddleName.Properties.AutoHeight = false;
            this.teMiddleName.Properties.NullText = "Middle Name";
            this.teMiddleName.Properties.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.teMiddleName.Size = new System.Drawing.Size(122, 45);
            this.teMiddleName.TabIndex = 6;
            this.teMiddleName.TabStop = false;
            // 
            // teLastName
            // 
            this.teLastName.Location = new System.Drawing.Point(298, 36);
            this.teLastName.Margin = new System.Windows.Forms.Padding(4);
            this.teLastName.Name = "teLastName";
            this.teLastName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teLastName.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.teLastName.Properties.Appearance.Options.UseFont = true;
            this.teLastName.Properties.Appearance.Options.UseForeColor = true;
            this.teLastName.Properties.AutoHeight = false;
            this.teLastName.Properties.NullText = "Last Name";
            this.teLastName.Properties.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.teLastName.Size = new System.Drawing.Size(122, 45);
            this.teLastName.TabIndex = 7;
            this.teLastName.TabStop = false;
            // 
            // teCourse
            // 
            this.teCourse.Location = new System.Drawing.Point(555, 36);
            this.teCourse.Margin = new System.Windows.Forms.Padding(4);
            this.teCourse.Name = "teCourse";
            this.teCourse.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teCourse.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.teCourse.Properties.Appearance.Options.UseFont = true;
            this.teCourse.Properties.Appearance.Options.UseForeColor = true;
            this.teCourse.Properties.AutoHeight = false;
            this.teCourse.Properties.NullText = "Course";
            this.teCourse.Properties.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.teCourse.Size = new System.Drawing.Size(151, 45);
            this.teCourse.TabIndex = 8;
            this.teCourse.TabStop = false;
            // 
            // gcStudent
            // 
            this.gcStudent.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcStudent.Location = new System.Drawing.Point(39, 164);
            this.gcStudent.MainView = this.gvStudent;
            this.gcStudent.Margin = new System.Windows.Forms.Padding(4);
            this.gcStudent.Name = "gcStudent";
            this.gcStudent.Size = new System.Drawing.Size(773, 488);
            this.gcStudent.TabIndex = 9;
            this.gcStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStudent});
            // 
            // gvStudent
            // 
            this.gvStudent.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvStudent.Appearance.GroupRow.Options.UseFont = true;
            this.gvStudent.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gvStudent.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvStudent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.DateOfBirth,
            this.Course,
            this.YearLevel});
            this.gvStudent.DetailHeight = 458;
            this.gvStudent.GridControl = this.gcStudent;
            this.gvStudent.Name = "gvStudent";
            this.gvStudent.OptionsBehavior.Editable = false;
            this.gvStudent.OptionsBehavior.ReadOnly = true;
            this.gvStudent.OptionsEditForm.PopupEditFormWidth = 933;
            this.gvStudent.OptionsView.ShowGroupPanel = false;
            this.gvStudent.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvStudent_FocusedRowChanged);
            // 
            // FirstName
            // 
            this.FirstName.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.AppearanceCell.Options.UseFont = true;
            this.FirstName.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.AppearanceHeader.Options.UseFont = true;
            this.FirstName.AppearanceHeader.Options.UseTextOptions = true;
            this.FirstName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FirstName.Caption = "First Name";
            this.FirstName.FieldName = "FirstName";
            this.FirstName.MinWidth = 23;
            this.FirstName.Name = "FirstName";
            this.FirstName.OptionsColumn.AllowEdit = false;
            this.FirstName.OptionsColumn.AllowFocus = false;
            this.FirstName.Visible = true;
            this.FirstName.VisibleIndex = 0;
            this.FirstName.Width = 87;
            // 
            // MiddleName
            // 
            this.MiddleName.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleName.AppearanceCell.Options.UseFont = true;
            this.MiddleName.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleName.AppearanceHeader.Options.UseFont = true;
            this.MiddleName.AppearanceHeader.Options.UseTextOptions = true;
            this.MiddleName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MiddleName.Caption = "Middle Name";
            this.MiddleName.FieldName = "MiddleName";
            this.MiddleName.MinWidth = 23;
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.OptionsColumn.AllowEdit = false;
            this.MiddleName.OptionsColumn.AllowFocus = false;
            this.MiddleName.Visible = true;
            this.MiddleName.VisibleIndex = 1;
            this.MiddleName.Width = 87;
            // 
            // LastName
            // 
            this.LastName.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.AppearanceCell.Options.UseFont = true;
            this.LastName.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.AppearanceHeader.Options.UseFont = true;
            this.LastName.AppearanceHeader.Options.UseTextOptions = true;
            this.LastName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LastName.Caption = "Last Name";
            this.LastName.FieldName = "LastName";
            this.LastName.MinWidth = 23;
            this.LastName.Name = "LastName";
            this.LastName.OptionsColumn.AllowEdit = false;
            this.LastName.OptionsColumn.AllowFocus = false;
            this.LastName.Visible = true;
            this.LastName.VisibleIndex = 2;
            this.LastName.Width = 87;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirth.AppearanceCell.Options.UseFont = true;
            this.DateOfBirth.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirth.AppearanceHeader.Options.UseFont = true;
            this.DateOfBirth.AppearanceHeader.Options.UseTextOptions = true;
            this.DateOfBirth.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DateOfBirth.Caption = "Date Of Birth";
            this.DateOfBirth.FieldName = "DateOfBirth";
            this.DateOfBirth.MinWidth = 23;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.OptionsColumn.AllowEdit = false;
            this.DateOfBirth.OptionsColumn.AllowFocus = false;
            this.DateOfBirth.Visible = true;
            this.DateOfBirth.VisibleIndex = 3;
            this.DateOfBirth.Width = 94;
            // 
            // Course
            // 
            this.Course.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course.AppearanceCell.Options.UseFont = true;
            this.Course.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course.AppearanceHeader.Options.UseFont = true;
            this.Course.AppearanceHeader.Options.UseTextOptions = true;
            this.Course.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Course.Caption = "Course";
            this.Course.FieldName = "Course";
            this.Course.MinWidth = 23;
            this.Course.Name = "Course";
            this.Course.OptionsColumn.AllowEdit = false;
            this.Course.OptionsColumn.AllowFocus = false;
            this.Course.Visible = true;
            this.Course.VisibleIndex = 4;
            this.Course.Width = 87;
            // 
            // YearLevel
            // 
            this.YearLevel.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLevel.AppearanceHeader.Options.UseFont = true;
            this.YearLevel.AppearanceHeader.Options.UseTextOptions = true;
            this.YearLevel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.YearLevel.Caption = "Year Level";
            this.YearLevel.FieldName = "YearLevel";
            this.YearLevel.MinWidth = 25;
            this.YearLevel.Name = "YearLevel";
            this.YearLevel.OptionsColumn.AllowEdit = false;
            this.YearLevel.OptionsColumn.AllowFocus = false;
            this.YearLevel.Visible = true;
            this.YearLevel.VisibleIndex = 5;
            this.YearLevel.Width = 94;
            // 
            // btnLoad
            // 
            this.btnLoad.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Appearance.Options.UseFont = true;
            this.btnLoad.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoad.ImageOptions.SvgImage")));
            this.btnLoad.Location = new System.Drawing.Point(396, 101);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(98, 46);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Location = new System.Drawing.Point(502, 101);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 46);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdate.ImageOptions.SvgImage")));
            this.btnUpdate.Location = new System.Drawing.Point(608, 101);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 46);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Location = new System.Drawing.Point(714, 101);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 46);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // teYearLevel
            // 
            this.teYearLevel.Location = new System.Drawing.Point(714, 37);
            this.teYearLevel.Name = "teYearLevel";
            this.teYearLevel.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.teYearLevel.Properties.Appearance.Options.UseForeColor = true;
            this.teYearLevel.Properties.AutoHeight = false;
            this.teYearLevel.Properties.NullText = "Year Level";
            this.teYearLevel.Properties.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.teYearLevel.Size = new System.Drawing.Size(98, 45);
            this.teYearLevel.TabIndex = 14;
            // 
            // Mainform
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 687);
            this.Controls.Add(this.teYearLevel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.gcStudent);
            this.Controls.Add(this.teCourse);
            this.Controls.Add(this.teLastName);
            this.Controls.Add(this.teMiddleName);
            this.Controls.Add(this.deBirthDate);
            this.Controls.Add(this.teFirstName);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Mainform.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCourse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teYearLevel.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teFirstName;
        private DevExpress.XtraEditors.DateEdit deBirthDate;
        private DevExpress.XtraEditors.TextEdit teMiddleName;
        private DevExpress.XtraEditors.TextEdit teLastName;
        private DevExpress.XtraEditors.TextEdit teCourse;
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
        private DevExpress.XtraGrid.Columns.GridColumn Course;
        private DevExpress.XtraGrid.Columns.GridColumn YearLevel;
        private DevExpress.XtraEditors.TextEdit teYearLevel;
    }
}