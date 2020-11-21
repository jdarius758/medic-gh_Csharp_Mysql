using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace medic_gh
{
    public partial class Form1 : Form
    {
        string connectionString = ("Server=localhost;port=3306;Database=medic+gh;username=root;password=1234;");
        int patient_id = 0;
        int treatment_id = 0;
        int medication_id = 0;
        int diagnosis_id = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))

            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("patient", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_patient_id", patient_id);
                mySqlCmd.Parameters.AddWithValue("_first_name", textBox1.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_last_name", textBox2.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_tel_no", textBox3.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_city", textBox4.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_postal_code", textBox5.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_height", textBox6.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_weight", textBox7.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_ethnicity", textBox8.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_bloodtype", textBox9.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_dr_id", textBox10.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_insurance_id", textBox11.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_access_level", textBox12.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_nic_no", textBox13.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_birthdate", textBox14.Text.Trim());


                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Patient information Saved ");


            }

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void label1_click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))

            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("treatment", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;

                mySqlCmd.Parameters.AddWithValue("_treatment_id", treatment_id);
                mySqlCmd.Parameters.AddWithValue("_patient_id", textBox15.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_diagnosis_id", textBox16.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_treat_description", textBox17.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_dr_id", textBox18.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_date_time", textBox19.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_treat_duration", textBox20.Text.Trim());

                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Patient Treatment information Saved ");

            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            

        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))

            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("medication", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;

                mySqlCmd.Parameters.AddWithValue("_medication_id", medication_id);
                mySqlCmd.Parameters.AddWithValue("_diagnosis_id", textBox21.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_patient_id", textBox22.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_medic_strength", textBox23.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_medic_name", textBox24.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_ndc_code", textBox25.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_dr_id", textBox26.Text.Trim());



                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Patient Medicine information Saved ");

            }



            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))

            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("diagnosis", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;

                mySqlCmd.Parameters.AddWithValue("_diagnosis_id", diagnosis_id);
                mySqlCmd.Parameters.AddWithValue("_patient_id", textBox27.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_acute", textBox28.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_start_yr", textBox29.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_stop_yr", textBox30.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_description_", textBox31.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_icd9_code", textBox32.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_dr_id", textBox33.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_medication_id", textBox34.Text.Trim());



                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Patient Diagnosis information Saved ");

            }


        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();
            textBox26.Clear();
            textBox27.Clear();
            textBox28.Clear();
            textBox29.Clear();
            textBox30.Clear();
            textBox31.Clear();
            textBox32.Clear();
            textBox33.Clear();
            textBox34.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            panel3.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            search ds = new search();
            ds.Show();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            login ps = new login();
            ps.Show();
            this.Hide();

        }
    }
}
