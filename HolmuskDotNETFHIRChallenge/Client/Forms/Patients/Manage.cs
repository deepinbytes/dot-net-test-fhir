// -----------------------------------------------------------------------
// <copyright file="Manage.cs" company="Ajay">
//  
// </copyright>
// -----------------------------------------------------------------------

namespace FHIRClientApp.Forms.Patients
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Drawing.Printing;
    using System.Windows.Forms;
    using FHIR.Data.Service;
    using FHIR.Data.Entities;
    using FHIR.Data.Enum;
    using FHIRClientApp.Properties;
    using FHIR.Data.Service.Interface;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Reactive.Linq;
    /// <summary>
    /// Manage screen - For CRUD patients information
    /// </summary>
    public partial class Manage : Form
    {
        /// <summary>
        /// Interface of PatientService
        /// </summary>
        private IFHIRPatientService patientService;


        /// <summary>
        /// Interface of PatientService
        /// </summary>
        private IFHIRServerAccessService FHIRServerService;

        /// <summary>
        /// Variable to store error message
        /// </summary>
        private string errorMessage;

        /// <summary>
        /// Member id
        /// </summary>
        private int memberId;

        /// <summary>
        /// Initializes a new instance of the Manage class
        /// </summary>
        public Manage()
        {
            this.InitializeComponent();
            this.InitializeResourceString();
            this.InitializeDropDownList();
            this.InitilizeDataGridViewStyle();
            this.InitilizeServerDataGridViewStyle();
            this.patientService = new FHIRPatientService();
            this.ResetRegistration();
            this.ResetSearch();
        }
        /// <summary>
        /// fetch all the patient data from local db
        /// </summary>
        public DataTable FetchtAllFromServer()
        {
            try
            {
                this.FHIRServerService = new FHIRServerAccessService(new Uri(ServerURI.Text.ToString()));
                return this.FHIRServerService.FetchAll();
            }
            catch (Exception)
            {
                return null;
            }
  
        }

        /// <summary>
        /// search the local db with given string
        /// </summary>
        public DataTable SearchFromServer(String query)
        {
            try
            {
                this.FHIRServerService = new FHIRServerAccessService(new Uri(ServerURI.Text.ToString()));
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
            return this.FHIRServerService.SearchPatientByName(query);
        }
        /// <summary>
        /// Initializes resource strings
        /// </summary>
        private void InitializeResourceString()
        {
            // Registeration
            lblName.Text = Resources.Registration_Name_Label_Text;
            lblDateOfBirth.Text = Resources.Registration_DateOfBirth_Label_Text;

            lblMaritalStatus.Text = Resources.Registration_MaritalStatus_Label_Text;
            lblHealthStatus.Text = Resources.Registration_HealthStatus_Label_Text;
            lblSalary.Text = Resources.Registration_Fname_Label_Text;

            btnRegister.Text = Resources.Registration_Register_Button_Text;

            // Search, Print, Export, Update, Delete
            btnSearch.Text = Resources.Search_Search_Button_Text;
            btnRefresh.Text = Resources.Search_Refresh_Button_Text;
            btnUpdate.Text = Resources.Update_Button_Text;
            btnDelete.Text = Resources.Delete_Button_Text;
        }

        /// <summary>
        /// Initializes all dropdown controls
        /// </summary>
        private void InitializeDropDownList()
        {
            cmbGenderStatus.DataSource = Enum.GetValues(typeof(Gender));
            cmbHealthStatus.DataSource = Enum.GetValues(typeof(HealthStatus));

        }

        /// <summary>
        /// Resets search criteria
        /// </summary>
        private void ResetSearch()
        {
            QueryString.Text = String.Empty;
        }

        /// <summary>
        /// Resets the registration screen
        /// </summary>
        private void ResetRegistration()
        {
            txtName.Text = string.Empty;
            txtFamilyName.Text = string.Empty;
            cmbHealthStatus.SelectedIndex = -1;
            cmbGenderStatus.SelectedIndex = -1;
        }

        /// <summary>
        /// Initializes all dropdown controls in update section
        /// </summary>
        private void InitializeUpdate()
        {

            cmb2GenderStatus.DataSource = Enum.GetValues(typeof(Gender));
            cmb2HealthStatus.DataSource = Enum.GetValues(typeof(HealthStatus));
        }

        /// <summary>
        /// Resets the update section of manage screen
        /// </summary>
        private void ResetUpdate()
        {
            txt2Name.Text = string.Empty;

            cmb2HealthStatus.SelectedIndex = -1;
            cmb2GenderStatus.SelectedIndex = -1;
        }

        /// <summary>
        /// Validates registration input
        /// </summary>
        /// <returns>true or false</returns>
        private bool ValidateRegistration()
        {
            this.errorMessage = string.Empty;

            if (txtName.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Registration_Name_Required_Text);
            }


            if (cmbGenderStatus.SelectedIndex == -1)
            {
                this.AddErrorMessage(Resources.Registration_MaritalStatus_Select_Text);
            }

            if (cmbHealthStatus.SelectedIndex == -1)
            {
                this.AddErrorMessage(Resources.Registration_HealthStatus_Select_Text);
            }

            return this.errorMessage != string.Empty ? false : true;
        }

        /// <summary>
        /// Validates update data
        /// </summary>
        /// <returns>true or false</returns>
        private bool ValidateUpdate()
        {
            this.errorMessage = string.Empty;

            if (txt2Name.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Registration_Name_Required_Text);
            }


            if (cmb2GenderStatus.SelectedIndex == -1)
            {
                this.AddErrorMessage(Resources.Registration_MaritalStatus_Select_Text);
            }

            if (cmb2HealthStatus.SelectedIndex == -1)
            {
                this.AddErrorMessage(Resources.Registration_HealthStatus_Select_Text);
            }

            return this.errorMessage != string.Empty ? false : true;
        }

        /// <summary>
        /// To generate the error message
        /// </summary>
        /// <param name="error">error message</param>
        private void AddErrorMessage(string error)
        {
            if (this.errorMessage == string.Empty)
            {
                this.errorMessage = Resources.Error_Message_Header + "\n\n";
            }

            this.errorMessage += error + "\n";
        }

        /// <summary>
        /// Method to show general error message on any system level exception
        /// </summary>
        private void ShowErrorMessage(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                //Resources.System_Error_Message, 
                Resources.System_Error_Message_Title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        /// <summary>
        /// Initializes data grid view style
        /// </summary>
        private void InitilizeDataGridViewStyle()
        {
            // Setting the style of the DataGridView control
            dataGridViewPatients.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewPatients.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            dataGridViewPatients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewPatients.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPatients.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewPatients.DefaultCellStyle.BackColor = Color.Empty;
            dataGridViewPatients.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.Info;
            dataGridViewPatients.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridViewPatients.GridColor = SystemColors.ControlDarkDark;
        }
        /// <summary>
        /// Initializes Server data grid view style
        /// </summary>
        private void InitilizeServerDataGridViewStyle()
        {
            dataGridViewServer.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewServer.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            dataGridViewServer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewServer.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewServer.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewServer.DefaultCellStyle.BackColor = Color.Empty;
            dataGridViewServer.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.Info;
            dataGridViewServer.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridViewServer.GridColor = SystemColors.ControlDarkDark;
        }
        /// <summary>
        /// Method to load data grid view
        /// </summary>
        /// <param name="data">data table</param>
        private void LoadDataGridView(DataTable data)
        {
            // Data grid view column setting            
            dataGridViewPatients.DataSource = data;
            dataGridViewPatients.DataMember = data.TableName;

            //dataGridViewMembers.
            dataGridViewPatients.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        /// <summary>
        /// Method to load data server grid view
        /// </summary>
        /// <param name="data">data table</param>
        private void LoadServerDataGridView(DataTable data)
        {
            // Data grid view column setting            
            dataGridViewServer.DataSource = data;
            dataGridViewServer.DataMember = data.TableName;


            dataGridViewServer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }


        /// <summary>
        /// Click event to handle registration of new patient
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event data</param>
        private void Register_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the validation passes
                if (this.ValidateRegistration())
                {
                    // Assign the values to the model
                    PatientEntity patientmodel = new PatientEntity()
                    {
                        Id = (long)Convert.ToDouble(DateTime.Now.ToString("ddMMyyyyHHmmssfff")),
                        Name = txtName.Text.Trim(),
                        DateOfBirth = dtDateOfBirth.Value,

                        HealthStatus = (int)cmbHealthStatus.SelectedValue,
                        Gender = (Gender)cmbGenderStatus.SelectedValue,
                        FamilyName = txtFamilyName.Text.Trim(),

                        Comments = txtComments.Text,
                        CreatedAt = DateTimeOffset.Now,
                        LastModifiedAt = DateTimeOffset.Now
                    };

                    // Call the service method and assign the return status to variable
                    var success = this.patientService.Create(patientmodel);

                    // if status of success variable is true then display a information else display the error message
                    if (success)
                    {
                        // display the message box
                        MessageBox.Show(
                            Resources.Registration_Successful_Message,
                            Resources.Registration_Successful_Message_Title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // Reset the screen
                        this.ResetRegistration();
                    }
                    else
                    {
                        // display the error messge
                        MessageBox.Show(
                            Resources.Registration_Error_Message,
                            Resources.Registration_Error_Message_Title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Display the validation failed message
                    MessageBox.Show(
                        this.errorMessage,
                        Resources.Registration_Error_Message_Title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }
        /// <summary>
        /// supporting function to disable ui buttons
        /// </summary>
        private void DisableButtons()
        {
            btnDelete.Enabled = false;
            btnRefresh.Enabled = false;
            btnUpdate.Enabled = false;
            btnSearch.Enabled = false;

        }
        /// <summary>
        /// supporting function to enable ui buttons
        /// </summary>
        private void EnableButtons()
        {
            btnDelete.Enabled = true;
            btnRefresh.Enabled = true;
            btnUpdate.Enabled = true;
            btnSearch.Enabled = true;

        }


        /// <summary>
        /// Event to handle tab selection
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event data</param>
        private void Tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tab.SelectedIndex == 1)
                {
                    DisableButtons();
                    this.Cursor = Cursors.WaitCursor;
                    LoadLocalData();

                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Event to handle the data formatting in data grid view
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event data</param>
        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    e.Value = string.Format("{0:dd/MM/yyyy}", (DateTime)e.Value);
                }

                if (e.ColumnIndex == 3)
                {
                    e.Value = Enum.GetName(typeof(HealthStatus), e.Value).ToString();
                }

                if (e.ColumnIndex == 5)
                {
                    e.Value = Enum.GetName(typeof(Gender), e.Value).ToString();
                }



            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Click event to handle search
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event data</param>
        private void Search_Click(object sender, EventArgs e)
        {
            DisableButtons();
            this.Cursor = Cursors.WaitCursor;
            LoadLocalData(QueryString.Text.ToString());


        }

        /// <summary>
        /// Click event to handle the refresh
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">event data</param>
        private void Refresh_Click(object sender, EventArgs e)
        {
            DisableButtons();
            this.Cursor = Cursors.WaitCursor;
            LoadLocalData();

        }

        private void dataGridViewMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dataGridViewPatients.SelectedCells[0].RowIndex;
            MessageBox.Show("cell content click");
            try
            {
                string patientid = dataGridViewPatients[0, currentRow].Value.ToString();
                memberId = int.Parse(patientid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Click event to update the data
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateUpdate())
                {
                    PatientEntity patientModel = new PatientEntity()
                    {
                        Id = this.memberId,
                        Name = txt2Name.Text.Trim(),
                        DateOfBirth = dt2DateOfBirth.Value,
                        FamilyName = txtFamilyNameUpd.Text.Trim(),
                        HealthStatus = (int)cmb2HealthStatus.SelectedValue,
                        Gender = (Gender)cmb2GenderStatus.SelectedValue,
                        Comments = txtCommentsUpd.Text.Trim(),
                        LastModifiedAt = DateTimeOffset.Now
                    };

                    var flag = this.patientService.Update(patientModel);

                    if (flag)
                    {
                        DataTable data = this.patientService.GetAll();
                        data.Columns.Remove(Resources.RemoveSoftDelete); data.Columns.Remove(Resources.RemoveMaritalStatus);
                        this.LoadDataGridView(data);

                        MessageBox.Show(
                            Resources.Update_Successful_Message,
                            Resources.Update_Successful_Message_Title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(
                        this.errorMessage,
                        Resources.Registration_Error_Message_Title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }


        /// <summary>
        /// thread to load local data
        /// </summary>
        private void LoadLocalData()
        {
            //Start a thread to load data asynchronously.
            Thread loadDataThread = new Thread(LoadLocalDataAsync);
            loadDataThread.Start();
        }
        /// <summary>
        /// thread to load local data using search query
        /// </summary>
        private void LoadLocalData(string filter)
        {

            Thread loadDataThread = new Thread(() => LoadLocalDataAsync(filter));
            loadDataThread.Start();
        }

        private void LoadLocalDataAsync()
        {
            DataTable data = new DataTable();
            data = this.patientService.GetAll();
            data.Columns.Remove(Resources.RemoveSoftDelete);
            data.Columns.Remove(Resources.RemoveMaritalStatus);
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    PopulatelocalGridUI(data);
                }));
            }

        }

        private void LoadLocalDataAsync(string filter)
        {
            DataTable data = new DataTable();
            data = this.patientService.Search(filter);
            data.Columns.Remove(Resources.RemoveSoftDelete);
            data.Columns.Remove(Resources.RemoveMaritalStatus);
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    PopulatelocalGridUI(data);
                }));
            }

        }

        private void PopulatelocalGridUI(DataTable ds)
        {
            // Populate UI Controls with data from DataSet ds.
            this.InitializeUpdate();
            this.LoadDataGridView(ds);
            this.Cursor = Cursors.Default;
            EnableButtons();
        }
        /// <summary>
        /// click event to handle soft deletion patient data
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var flag = this.patientService.Delete(this.memberId);

                if (flag)
                {
                    DataTable data = this.patientService.GetAll();
                    data.Columns.Remove(Resources.RemoveSoftDelete); data.Columns.Remove(Resources.RemoveMaritalStatus);
                    this.LoadDataGridView(data);

                    MessageBox.Show(
                        Resources.Delete_Successful_Message,
                        Resources.Delete_Successful_Message_Title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        private void dataGridViewMembers_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    string patientId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                    memberId = int.Parse(patientId);

                    DataRow dataRow = this.patientService.GetById(memberId);

                    txt2Name.Text = dataRow[Resources.Name].ToString();
                    txtFamilyNameUpd.Text = dataRow[Resources.FamilyName].ToString();
                    dt2DateOfBirth.Value = Convert.ToDateTime(dataRow[Resources.DateOfBirth]);
                    txtCommentsUpd.Text = dataRow[Resources.Comments].ToString();
                    cmb2GenderStatus.SelectedItem = (Gender)dataRow[Resources.Gender];
                    cmb2HealthStatus.SelectedItem = (HealthStatus)dataRow[Resources.HealthStatus];

                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }
        /// <summary>
        /// click event to handle loading of fhirserverdata
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button1.Enabled = false;
            button5.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            Thread loadDataThread = new Thread(FetchFHIRDataBackground);
            loadDataThread.Start();

        }
        /// <summary>
        /// thread to handle loading of fhirserverdata
        /// </summary>
        private void FetchFHIRDataBackground()
        {
            DataTable data = new DataTable();
            var o = Observable.Start(() =>
            {
                //Get Data from server
                data = FetchtAllFromServer();
                if (data != null)
                {


                    data.Columns.Remove(Resources.RemoveSoftDelete);
                    data.Columns.Remove(Resources.RemoveMaritalStatus);
                    data.Columns.Remove(Resources.RemoveHealthStatus);
                    data.Columns.Remove(Resources.RemoveId);
                    // Check if this code is executed on some other thread than UI thread
                    if (InvokeRequired)
                    {
                        BeginInvoke(new Action(() =>
                        {
                            // Load data to Grid
                       LoadServerDataGridView(data);
                        LoadDataAndEnableControls();
                        }));
                    }
                }
            }).Finally(() =>
                {
                    if (data != null)
                        MessageBox.Show(Resources.Fetch + data.Rows.Count + Resources.From_Server, Resources.Success, MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    else
                    {
                        MessageBox.Show(Resources.InvalidServer, Resources.System_Error_Message_Title,
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);

                        if (InvokeRequired)
                    {
                        BeginInvoke(new Action(() =>
                        {
                            // Load data to Grid
                            LoadDataAndEnableControls();
                        }));
                    }
                    }
                }
           );
            o.Wait();

        }
        /// <summary>
        /// thread to handle loading of fhirserverdata with search query
        /// </summary>
        private void FetchFHIRDataBackground(string filter)
        {
            DataTable data = new DataTable();
            var o = Observable.Start(() =>
            {
                //Get Data from server
                data = SearchFromServer(filter);
                if (data != null)
                {


                    data.Columns.Remove(Resources.RemoveSoftDelete);
                    data.Columns.Remove(Resources.RemoveMaritalStatus);
                    data.Columns.Remove(Resources.RemoveHealthStatus);
                    data.Columns.Remove(Resources.RemoveId);
                    // Check if this code is executed on some other thread than UI thread
                    if (InvokeRequired)
                    {
                        BeginInvoke(new Action(() =>
                        {
                            // Load data to Grid
                            LoadServerDataGridView(data);
                            LoadDataAndEnableControls();
                        }));
                    }
                }
            }).Finally(() =>
                {
                    if (data != null)
                        MessageBox.Show(Resources.Fetch + data.Rows.Count + Resources.From_Server, Resources.Success, MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                    else
                    {
                        MessageBox.Show(Resources.InvalidServer, Resources.System_Error_Message_Title,
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);

                        if (InvokeRequired)
                        {
                            BeginInvoke(new Action(() =>
                            {
                                // Load data to Grid
                                LoadDataAndEnableControls();
                            }));
                        }
                    }
                }
           );
            o.Wait();

        }

        private void LoadDataAndEnableControls()
        {
            button4.Enabled = true;
            button3.Enabled = true;
            button1.Enabled = true;
            button5.Enabled = true;
            this.Cursor = Cursors.Default;
        }
        /// <summary>
        /// click event to handle loading of fhirserverdata with search query
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            if (ServerQuery.Text.Trim() == string.Empty)
            {
                MessageBox.Show(Resources.SearchQueryError, Resources.System_Error_Message_Title,
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;
                button3.Enabled = false;
                button1.Enabled = false;
                button5.Enabled = false;
                Thread loadDataThread = new Thread(() => FetchFHIRDataBackground(ServerQuery.Text.ToString()));
                loadDataThread.Start();
            }

        }
        /// <summary>
        /// click event to handle import of fhirserverdata selected
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            List<PatientEntity> SelectionList = new List<PatientEntity>();
            foreach (DataGridViewRow row in dataGridViewServer.SelectedRows)
            {
                PatientEntity patient = new PatientEntity
                              {
                                  Id = 0,
                                  Name = row.Cells[0].Value.ToString(),
                                  FamilyName = row.Cells[1].Value.ToString(),
                                  DateOfBirth = Convert.ToDateTime(row.Cells[2].Value),
                                  Gender = (Gender)row.Cells[3].Value,
                                  Comments = row.Cells[4].Value.ToString(),
                                  HealthStatus = (int)HealthStatus.Good,
                                  LastModifiedAt = DateTimeOffset.Now,
                                  CreatedAt = DateTimeOffset.Now,

                              };
                SelectionList.Add(patient);
                ++i;
            }

            if (SelectionList.Count > 0)
            {
                var success = this.patientService.BatchCreate(SelectionList);

                if (success)
                {
                    // display the message box
                    MessageBox.Show(
                        "Added " + SelectionList.Count + " Records to Local",
                        Resources.Import_Successful_Message_Title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


                }
                else
                    MessageBox.Show(Resources.SelectionError, Resources.System_Error_Message_Title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

            }
            else
                MessageBox.Show(Resources.SelectionError, Resources.System_Error_Message_Title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
        }
        /// <summary>
        /// click event to reset the ui controls for fhir tab
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            ServerQuery.Text = string.Empty;
            this.dataGridViewServer.DataSource = null;
            this.dataGridViewServer.Rows.Clear();
            this.InitilizeServerDataGridViewStyle();
        }
    }
}
