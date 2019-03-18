using CarAuctionSL.Model;
using CarAuctionSL.Repository;
using CarAuctionSL.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarAuctionSL.Windows
{
    public partial class Form1 : Form
    {

        RepoBase<User> repbase;
        Repository.RepoBase<ItemMaster> ItemMasterDB = new RepoBase<ItemMaster>("ItemMasters");
        public Form1()
        {
            InitializeComponent();
            repbase = new RepoBase<User>("Users");
        }

        void RefreshData() {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var xx =  repbase.Save(new User() { Id = -1, CityId = 1, CountryId = 1, create_date = DateTime.Now, Email = "cspl.itm@googlemail.com",
            //    First_Name = "Asanga", IsRegistrationComplete = false, Last_Name = "Chandrakumara", Phone = "+94778151151"},1);
            textBox1.Text =  Guid.NewGuid().ToString("N");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDropDownReferances();
        }

        private void LoadDropDownReferances()
        {
            LoadMake();
            LoadYear();
            LoadBodyType();
            LoadMilage();

            RefreshData();
        }

        private void LoadMilage()
        {
           
        }

        private void LoadBodyType()
        {
           
        }

        private void LoadYear()
        {
           
        }

        private void LoadMake()
        {
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.RunWorkerAsync();
            //foreach (var item in values.Result)
            //{
            //    cmb_make.Items.Add(item.Name);
            //}

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var values = new LoadReferanceUOW().LoadAllMakesForDropDowns().Result;

            cmb_make.Invoke((MethodInvoker)delegate {

                foreach (var item in values)
                {
                    cmb_make.Items.Add(item);
                }

            });

            var values2 = new LoadReferanceUOW().LoadAllModelMasterRepoDropDowns(12).Result;

            cmb_models.Invoke((MethodInvoker)delegate {

                foreach (var item in values2)
                {
                    cmb_models.Items.Add(item);
                }

            });

            var values3 = new LoadReferanceUOW().LoadAllMilagesForDropDowns().Result;

            cmb_milage.Invoke((MethodInvoker)delegate {

                foreach (var item in values3)
                {
                    cmb_milage.Items.Add(item);

                }

            });

            var ValueYear = new LoadReferanceUOW().LoadAllYearsForDropDowns().Result;

            cmb_yearmade.Invoke((MethodInvoker)delegate {

                foreach (var item in ValueYear)
                {
                    cmb_yearmade.Items.Add(item);

                }

            });


            var bodytypesr = new LoadReferanceUOW().LoadAllBodyTypeForDropDowns().Result;

            cmb_bodyTypes.Invoke((MethodInvoker)delegate {

                foreach (var item in bodytypesr)
                {
                    cmb_bodyTypes.Items.Add(item);

                }

            });

          


        }

        string CarName = "";

        private string GetCarName() {
            return cmb_make.Text.Trim() + " " + cmb_models.Text.Trim() +  " "  + cmb_yearmade.Text.Trim();
        }

        private void cmb_make_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_carName.Text =  GetCarName();
        }

        private void cmb_models_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_carName.Text = GetCarName();
        }

        private void cmb_yearmade_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_carName.Text = GetCarName();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var xxtyy = ((KeyValuePear)cmb_make.SelectedItem).Value;
           

            if (MessageBox.Show("Do you want to add this car and don;t get upset later ?", "Car Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                var xx = cmb_yearmade.SelectedIndex;
                var xxy = cmb_yearmade.SelectedValue;

                ItemMaster master = new ItemMaster()
                {
                    Id = -1,
                    BodyTypeId = ((KeyValuePear)cmb_bodyTypes.SelectedItem).Value,
                    MakeId = ((KeyValuePear)cmb_make.SelectedItem).Value,
                    ModelId = ((KeyValuePear)cmb_models.SelectedItem).Value ,
                    Milage = ((KeyValuePear)cmb_milage.SelectedItem).Value ,
                    Year = ((KeyValuePear)cmb_yearmade.SelectedItem).Value ,
                    Option = 1,
                    DisplayName = txt_carName.Text
                };

                Repository.RepoBase<ItemMaster> db = new RepoBase<ItemMaster>("ItemMasters");
                db.SaveNonAsync(master, 1);
                MessageBox.Show("Car " + txt_carName.Text + " Added successfully", "Car Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                backgroundWorker2.RunWorkerAsync();
            }

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            var items = new LoadReferanceUOW().LoadAllCarseForDropDowns().Result;
            
            lst_items.Invoke((MethodInvoker)delegate {
                lst_items.Items.Clear();
                foreach (var item in items)
                {
                    int icon = int.Parse(item.Options.ToString());
                    if (icon >= 14)
                    {
                        icon = icon ^ 10;
                    }
                    lst_items.Items.Add(item.Text, icon);
                }

            });
        }
    }
}
