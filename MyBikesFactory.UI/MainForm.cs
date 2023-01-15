using MyBikesFactory.Business; // ----
using MyBikesFactory.Business.Enums; // ----
using MyBikesFactory.Data; // -----
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBikesFactory.UI
{
    public partial class MainForm : Form
    {
        private List<Bike> listOfBikes = BikeXmlData.Load();
        private Dictionary<int, int> dictionaryOfIndexes = new Dictionary<int, int>();
        private bool thereAreUnsavedChanges = false;

        public MainForm()
        {
            InitializeComponent();
            RefreshDisplayList();
        }

        #region Support Method
        private int GetIndexFromDictionary()
        {
            int listBoxIndex = lstBikes.SelectedIndex;
            if (listBoxIndex < 0)
                return -1;

            return dictionaryOfIndexes[listBoxIndex];
        }
        private Bike? FindBikeBySerialNumber(int serialNumber)
        {
            // Search Part
            Bike? bikeFound = null;

            foreach (var bike in listOfBikes)
            {
                if (bike.SerialNumber == serialNumber)
                {
                    bikeFound = bike;
                    break;
                }
            }

            return bikeFound;
        }
        private void RefreshDisplayList()
        {
            lstBikes.Items.Clear();

            dictionaryOfIndexes.Clear();

            int i = 0;
            foreach (var bike in listOfBikes)
            {
                bool include = false;

                if (rbAll.Checked)
                    include = true;
                else if (rbMountainBikes.Checked && bike is MountainBike)
                    include = true;
                else if (rbRoadBikes.Checked && bike is RoadBike)
                    include = true;

                if (include)
                {
                    dictionaryOfIndexes.Add(lstBikes.Items.Count, i);
                    lstBikes.Items.Add(bike.ToString());
                }
                i++;
            }
        }

        private bool AllFieldsAreOk()
        {
            if (cbBikeType.Text == "")
            {
                MessageBox.Show("Please select a bike type");
                return false;
            }
            else if (txtSerialNumber.Text == "" || !Validator.ValidateSerialNumber(txtSerialNumber.Text))
            {
                MessageBox.Show("Serial Number is required and should contain numbers only");
                return false;
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("Please inform a name");
                return false;
            }
            else if (txtModel.Text == "")
            {
                MessageBox.Show("Please inform a model");
                return false;
            }
            else if (!Validator.ValidateModel(txtModel.Text))
            {
                MessageBox.Show("Model should contain 5 characters (numbers or letters)");
                return false;
            }
            else if (txtManufacturingYear.Text == "")
            {
                MessageBox.Show("Please inform the manufacturing year");
                return false;
            }
            else if (!Validator.ValidateManufacturingYear(txtManufacturingYear.Text))
            {
                MessageBox.Show("Manufacturing year should contain 4 characters (numbers only).");
                return false;
            }
            else if (cbColor.Text == "")
            {
                MessageBox.Show("Please select a color");
                return false;
            }
            else if (cbBikeType.Text == "Mountain Bike" && cbSuspensionType.Text == "")
            {
                MessageBox.Show("Please select a suspension type");
                return false;
            }
            else if (cbBikeType.Text == "Road Bike" && cbTireType.Text == "")
            {
                MessageBox.Show("Please select a tire type");
                return false;
            }
            return true;
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!AllFieldsAreOk())
                return;
            else if(!Validator.ValidateUniqueSerialNumber(txtSerialNumber.Text, listOfBikes))
            {
                MessageBox.Show("This serial number is already used", 
                                "Warning",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                return;
            }

            Bike bikeToAdd;
            if (cbBikeType.Text == "Mountain Bike")
            {
                ESuspensionType suspensionType = (ESuspensionType)cbSuspensionType.SelectedIndex;
                bikeToAdd = new MountainBike(suspensionType);
            }
            else
            {
                ETireType tireType = (ETireType)cbTireType.SelectedIndex;
                bikeToAdd = new RoadBike(tireType);
            }

            bikeToAdd.SerialNumber = Convert.ToInt32(txtSerialNumber.Text);
            bikeToAdd.Name = txtName.Text;
            bikeToAdd.Model = txtModel.Text;
            bikeToAdd.ManufacturingYear = Convert.ToInt32(txtManufacturingYear.Text);

            bikeToAdd.Color = (EColor)cbColor.SelectedIndex;

            listOfBikes.Add(bikeToAdd);

            cbBikeType.SelectedIndex = -1;
            txtSerialNumber.Text = "";
            txtName.Text = "";
            txtModel.Text = "";
            txtManufacturingYear.Text = "";
            cbColor.SelectedIndex = -1;
            cbSuspensionType.SelectedIndex = -1;
            cbTireType.SelectedIndex = -1;

            RefreshDisplayList();

            thereAreUnsavedChanges = true;

            MessageBox.Show("The bike has been added");
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BikeXmlData.Save(listOfBikes);

            thereAreUnsavedChanges = false;

            MessageBox.Show("The list of bikes has been saved");
        }

        private void cbBikeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBikeType.Text == "Mountain Bike")
            {
                cbSuspensionType.Enabled = true;
                cbTireType.Enabled = false;
                cbSuspensionType.SelectedIndex = 0;
                cbTireType.SelectedIndex = -1;
            }
            else
            {
                cbSuspensionType.Enabled = false;
                cbTireType.Enabled = true;
                cbSuspensionType.SelectedIndex = -1;
                cbTireType.SelectedIndex = 0;
            }
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            // Filter the contents
            RefreshDisplayList();
        }

        private void rbMountainBikes_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDisplayList();
        }

        private void rbRoadBikes_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDisplayList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSerialNumber.Text == "" || !Validator.ValidateSerialNumber(txtSerialNumber.Text))
            {
                MessageBox.Show("Serial number is required and should be numeric");
                return;
            }

            int serialNumber = Convert.ToInt32(txtSerialNumber.Text);
            var bikeFound = FindBikeBySerialNumber(serialNumber);

            if (bikeFound == null)
            {
                MessageBox.Show("Bike not found");
                return;
            }

            string message = bikeFound.ToString().Replace(",", Environment.NewLine);
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = GetIndexFromDictionary();

            if (index < 0)
            {
                MessageBox.Show("Please select a skateboard");
                return;
            }

            var result = MessageBox.Show("Do you really want to remove?",
                                         "Confirmation",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            listOfBikes.RemoveAt(index);
            lstBikes.Items.RemoveAt(lstBikes.SelectedIndex); // Removes it form the index of list box
            thereAreUnsavedChanges = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!AllFieldsAreOk())
                return;
            else if (txtSerialNumber.Text != txtOriginalId.Text)
            {
                if (!Validator.ValidateUniqueSerialNumber(txtSerialNumber.Text, listOfBikes))
                {
                    MessageBox.Show("This serial number is already used",
                                    "Warning",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }
            }

            var bikeToUpdate = FindBikeBySerialNumber(Convert.ToInt32(txtOriginalId.Text));

            if (bikeToUpdate is MountainBike && cbBikeType.Text == "Road Bike" ||
                bikeToUpdate is RoadBike && cbBikeType.Text == "Mountain Bike")
            {
                int listIndex = GetIndexFromDictionary();
                listOfBikes.RemoveAt(listIndex);

                if (cbBikeType.Text == "Road Bike")
                    bikeToUpdate = new RoadBike();
                else
                    bikeToUpdate = new MountainBike();

                listOfBikes.Insert(listIndex, bikeToUpdate);

            }

            if (cbBikeType.Text == "Mountain Bike")
            {
                (bikeToUpdate as MountainBike)!.SuspensionType = (ESuspensionType)cbSuspensionType.SelectedIndex;
            }
            else
            {
                (bikeToUpdate as RoadBike)!.TireType = (ETireType)cbTireType.SelectedIndex;
            }

            bikeToUpdate.SerialNumber = Convert.ToInt32(txtSerialNumber.Text);
            bikeToUpdate.Name = txtName.Text;
            bikeToUpdate.Model = txtModel.Text;
            bikeToUpdate.ManufacturingYear = Convert.ToInt32(txtManufacturingYear.Text);

            bikeToUpdate.Color = (EColor)cbColor.SelectedIndex;

            int currentSelectedIndex = lstBikes.SelectedIndex;
            RefreshDisplayList();
            lstBikes.SelectedIndex = currentSelectedIndex;

            thereAreUnsavedChanges = true;

            MessageBox.Show("The bike has been updated");

        }

        private void lstBikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int listIndex = GetIndexFromDictionary();
            // when selecting an item, it will bring back the values on screen

            //Something selected
            if (listIndex < 0)
                return;

            var bike = listOfBikes[listIndex];

            if (bike is MountainBike)
            {
                cbBikeType.SelectedIndex = 0;
                var bikeAsMountainBike = (MountainBike)bike;
                cbSuspensionType.SelectedIndex = (int)bikeAsMountainBike.SuspensionType;
            }
            else
            {
                cbBikeType.SelectedIndex = 1;
                var bikeAsRoadBike = (RoadBike)bike;
                cbTireType.SelectedIndex = (int)bikeAsRoadBike.TireType;
            }

            txtSerialNumber.Text = bike.SerialNumber.ToString();
            txtOriginalId.Text = txtSerialNumber.Text;
            txtName.Text = bike.Name;
            txtModel.Text = bike.Model;
            cbColor.SelectedIndex = (int)bike.Color;
            txtManufacturingYear.Text = bike.ManufacturingYear.ToString();


        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message;
            MessageBoxIcon icon;
            if (thereAreUnsavedChanges)
            {
                message = "*** THERE ARE UNSAVED CHANGES! ***\n\n" +
                            "Do you really want to exit?";
                icon = MessageBoxIcon.Warning;
            }
            else
            {
                message = "Do you really want to exit?";
                icon = MessageBoxIcon.Information;
            }
            var result = MessageBox.Show(message,
                                         "Confirmation",
                                         MessageBoxButtons.YesNo,
                                         icon);

            if (result == DialogResult.No)
                e.Cancel = true; 
        }
    }
}
