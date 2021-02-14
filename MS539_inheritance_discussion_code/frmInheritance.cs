/*
 
MS539 Discussion Inheritance
Roderick DeValcourt
2/13/2021

Estimate: 8 hours of work

Date            hours of work       Description
2/12/2021       1.0                 setup solution
2/12/2021       0.25                setup github repository
2/12/2021       3.0                 frmInheritance.cs
2/12/2021       1.0                 Part.cs
2/12/2021       1.0                 Transmission.cs
2/12/2021       1.0                 Engine.cs
2/12/2021       1.0                 Director.cs
2/12/2021       1.0                 PartBuilder, TransmissionBuilder, EngineBuilder

 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS539_inheritance_discussion_code
{
    public partial class frmInheritance : Form
    {
        public frmInheritance()
        {
            InitializeComponent();
        }

        private void ResetListBoxes()
        {
            lbPart.Items.Clear();
            lbTransmission.Items.Clear();
            lbEngine.Items.Clear();
        }

        private void ResetErrorMessages()
        {
            errorProvider1.SetError(tbYear, "");
            errorProvider1.SetError(cmbMake, "");
            errorProvider1.SetError(tbModel, "");
            errorProvider1.SetError(tbName, "");
            errorProvider1.SetError(groupBox1, "");
            errorProvider1.SetError(tbCylinder, "");
        }

        private void Clear()
        {
            tbYear.Text = "";
            cmbMake.SelectedIndex = -1;
            tbModel.Text = "";
            tbName.Text = "";
            rbAutomatic.Checked = false;
            rbManual.Checked = false;
            tbCylinder.Text = "";
        }

        private bool CheckPartInputs()
        {
            bool ok = true;
            int count = 0;
            int value = 0;

            ResetErrorMessages();

            if (string.IsNullOrEmpty(tbYear.Text) == true)
            {
                errorProvider1.SetError(tbYear, "Input a Year!");
                count++;
            }
            else
            {
                if (int.TryParse(tbYear.Text, out value) == false)
                {
                    errorProvider1.SetError(tbYear, "Input an INTEGER Year!");
                    count++;

                }
                else
                {
                    if ((value < 1900) || (value > 2030))
                    {
                        errorProvider1.SetError(tbYear, "Input an INTEGER Year (1900 - 2030)!");
                        count++;
                    }
                }
            }

            if (cmbMake.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbMake, "Please Select a Make!");
                count++;
            }
            else
            {
                if (string.IsNullOrEmpty(cmbMake.SelectedItem.ToString()) == true)
                {
                    errorProvider1.SetError(cmbMake, "Please Select a Make!");
                    count++;
                }

            }

            if (string.IsNullOrEmpty(tbModel.Text) == true)
            {
                errorProvider1.SetError(tbModel, "You Must input a Model!");
            }
            if (string.IsNullOrEmpty(tbName.Text) == true)
            {
                errorProvider1.SetError(tbName, "You Must input a Name!");
            }

            if (count > 0)
            {
                ok = false;
            }

            return ok;
        }
        private bool CheckTransmissionInputs()
        {
            bool ok = true;
            int count = 0;
            ResetErrorMessages();
            if ((rbAutomatic.Checked == false) && (rbManual.Checked == false))
            {
                errorProvider1.SetError(groupBox2, "Chose Automatic OR Manual!");
                count++;
            }
            if (count > 0)
            {
                ok = false;
            }
            return ok;
        }
        private bool CheckEngineInputs()
        {
            bool ok = true;
            int count = 0;

            int value = 0;

            ResetErrorMessages();
            if (count > 0)
            {

                if (string.IsNullOrEmpty(tbCylinder.Text) == true)
                {
                    errorProvider1.SetError(tbCylinder, "Input a Cylynder count!");
                    count++;
                }
                else
                {
                    if (int.TryParse(tbCylinder.Text, out value) == false)
                    {
                        errorProvider1.SetError(tbCylinder, "Input a INTEGER Cylynder count!");
                        count++;

                    }
                    else
                    {
                        switch (value)
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 4:
                                break;
                            case 6:
                                break;
                            case 8:
                                break;
                            case 12:
                                break;
                            default:
                                errorProvider1.SetError(tbCylinder, "Input a valid INTEGER Cylynder count (1,2,4,6,8,12)!");
                                count++;

                                break;

                        }
                    }
                }

            }

            if (count > 0)
            {
                ok = false;
            }

            return ok;
        }

        private void btnGoPart_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = null;
            string messageText = "";
            Exception exceptionDetails = null;
            Director director = null;
            PartBuilder partBuilder = null;
            string[] parameters = null;
            bool buildOk = false;
            string[] lines = null;
            char[] sep = new char[] { '\n' };
            try
            {
                ResetListBoxes();
                ResetErrorMessages();
                if (CheckPartInputs() == true)
                {
                    parameters = new string[] { tbYear.Text,cmbMake.SelectedText,tbModel.Text,tbName.Text };
                    if (parameters != null)
                    {
                        director = new Director();
                        if (director != null)
                        {
                            partBuilder = new PartBuilder();
                            if (partBuilder != null)
                            {
                                buildOk = director.Construct(partBuilder, parameters);
                                if (buildOk == true)
                                {
                                    if (partBuilder.BuildResult != null)
                                    {
                                        messageText = partBuilder.BuildResult.FormatDisplayString();

                                        lines = messageText.Split(sep);

                                        foreach (string s in lines)
                                        {
                                            lbPart.Items.Add(s);
                                        }

                                    }
                                    else
                                    {
                                        lbPart.Items.Add("partBuilder.BuildResult = null!");
                                    }
                                }
                                else
                                {
                                    lbPart.Items.Add("buildOk = false!");
                                }
                            }
                            else
                            {
                                lbPart.Items.Add("partBuilder = null!");
                            }
                        }
                        else
                        {
                            lbPart.Items.Add("director = null!");

                        }
                    }
                    else
                    {
                        lbPart.Items.Add("parameters null, couldn't create part!");
                    }
                }

            }
            catch (Exception exception)
            {
                stringBuilder = new StringBuilder();
                exceptionDetails = exception;

                while (exceptionDetails != null)
                {

                    messageText = "\r\nMessage: " + exceptionDetails.Message + "\r\nSource: " + exceptionDetails.Source + "\r\nStack Trace: " + exceptionDetails.StackTrace + "\r\n----------\r\n";

                    stringBuilder.Append(messageText);

                    exceptionDetails = exceptionDetails.InnerException;

                }

                messageText = stringBuilder.ToString();
                MessageBox.Show(messageText, "Inheritance - Error", MessageBoxButtons.OK);
            }
        }

        private void btnGoTransmission_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = null;
            string messageText = "";
            Exception exceptionDetails = null;
            Director director = null;
            TransmissionBuilder transmissionBuilder = null;
            string[] parameters = null;
            Boolean automatic = false;
            Boolean manual = false;
            bool buildOk = false;
            string[] lines = null;
            char[] sep = new char[] { '\n' };
            try
            {
                ResetListBoxes();
                ResetErrorMessages();
                if ((CheckPartInputs() == true) && (CheckTransmissionInputs() == true))
                {
                    if (rbAutomatic.Checked == true)
                    {
                        automatic = true;
                        manual = false;
                    }
                    if (rbManual.Checked == true)
                    {
                        automatic = false;
                        manual = true;
                    }

                    parameters = new string[] { tbYear.Text, cmbMake.SelectedItem.ToString(), tbModel.Text, tbName.Text, automatic.ToString(), manual.ToString() };

                    if (parameters != null)
                    {

                        director = new Director();
                        if (director != null)
                        {
                            transmissionBuilder = new TransmissionBuilder();
                            if (transmissionBuilder != null)
                            {
                                buildOk = director.Construct(transmissionBuilder, parameters);
                                if (buildOk == true)
                                {
                                    if (transmissionBuilder.BuildResult != null)
                                    {
                                        messageText = transmissionBuilder.BuildResult.FormatDisplayString();
                                        lines = messageText.Split(sep);

                                        foreach (string s in lines)
                                        {
                                            lbTransmission.Items.Add(s);
                                        }
                                    }
                                    else 
                                    {
                                        lbTransmission.Items.Add("transmissionBuilder.BuildResult = null!");
                                    }
                                }
                                else
                                {
                                    lbTransmission.Items.Add("buildOk = false!");
                                }
                            }
                            else
                            {
                                lbTransmission.Items.Add("transmissionBuilder = null!");
                            }
                        }
                        else
                        {
                            lbTransmission.Items.Add("director = null!");
                        }
                    }
                    else
                    {
                        lbTransmission.Items.Add("parameters null, couldn't create transmission!");
                    }
                }

            }
            catch (Exception exception)
            {
                stringBuilder = new StringBuilder();
                exceptionDetails = exception;

                while (exceptionDetails != null)
                {

                    messageText = "\r\nMessage: " + exceptionDetails.Message + "\r\nSource: " + exceptionDetails.Source + "\r\nStack Trace: " + exceptionDetails.StackTrace + "\r\n----------\r\n";

                    stringBuilder.Append(messageText);

                    exceptionDetails = exceptionDetails.InnerException;

                }

                messageText = stringBuilder.ToString();
                MessageBox.Show(messageText, "Inheritance - Error", MessageBoxButtons.OK);
            }
        }

        private void btnGoEngine_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = null;
            string messageText = "";
            Exception exceptionDetails = null;
            Director director = null;
            EngineBuilder engineBuilder = null;
            string[] parameters = null;
            int value = 0;
            bool buildOk = false;
            string[] lines = null;
            char[] sep = new char[] { '\n' };
            try
            {
                ResetListBoxes();
                ResetErrorMessages();
                if ((CheckPartInputs() == true) && (CheckEngineInputs() == true))
                {
                    if (int.TryParse(tbCylinder.Text, out value) == true)
                    {
                        parameters = new string[] { tbYear.Text, cmbMake.SelectedText, tbModel.Text, tbName.Text, value.ToString() };


                        if (parameters != null)
                        {

                            director = new Director();
                            if (director != null)
                            {
                                engineBuilder = new EngineBuilder();
                                if (engineBuilder != null)
                                {
                                    buildOk = director.Construct(engineBuilder, parameters);
                                    if (buildOk == true)
                                    {
                                        if (engineBuilder.BuildResult != null)
                                        {
                                            messageText = engineBuilder.BuildResult.FormatDisplayString();
                                            lines = messageText.Split(sep);
                                            foreach (string s in lines)
                                            {
                                                lbEngine.Items.Add(s);
                                            }
                                        }
                                        else
                                        {
                                            lbEngine.Items.Add("engineBuilder.BuildResult = null!");

                                        }
                                    }
                                    else
                                    {
                                        lbEngine.Items.Add("buildOk = false!");
                                    }
                                }
                                else
                                {
                                    lbEngine.Items.Add("engineBuilder = null!");
                                }
                            }
                            else
                            {
                                lbEngine.Items.Add("director = null!");

                            }

                        }
                        else
                        {
                            lbEngine.Items.Add("parameters null, couldn't create engine!");
                        }
                    }
                    else
                    {
                        lbEngine.Items.Add("int.tryparse failed, couldn't create engine");
                    }
                }

            }
            catch (Exception exception)
            {
                stringBuilder = new StringBuilder();
                exceptionDetails = exception;

                while (exceptionDetails != null)
                {

                    messageText = "\r\nMessage: " + exceptionDetails.Message + "\r\nSource: " + exceptionDetails.Source + "\r\nStack Trace: " + exceptionDetails.StackTrace + "\r\n----------\r\n";

                    stringBuilder.Append(messageText);

                    exceptionDetails = exceptionDetails.InnerException;

                }

                messageText = stringBuilder.ToString();
                MessageBox.Show(messageText, "Inheritance - Error", MessageBoxButtons.OK);
            }
        }

        private void frmInheritance_Load(object sender, EventArgs e)
        {
            this.cmbMake.Items.Add("Chevrolet");
            this.cmbMake.Items.Add("Dodge");
            this.cmbMake.Items.Add("Ford");
            this.cmbMake.Items.Add("Harley Davidson");
            this.cmbMake.Items.Add("Indian Motorcycle");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetErrorMessages();
            Clear();
            ResetListBoxes();
        }
    }
}
