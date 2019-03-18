using CarAuctionSL.Model;
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
    public partial class PersonalInterest : Form
    {
        ExistanceCheckUOW exrepo;
        public PersonalInterest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to add this user and don;t get upset later ?", "Car Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                backgroundWorker2.RunWorkerAsync();

            }
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        void LoadUsers() {
          
        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            Repository.RepoBase<User> repouser = new Repository.RepoBase<User>("Users");
            var list = repouser.FindALL().Result;

            lst_users.Invoke((MethodInvoker)delegate
            {
                lst_users.Items.Clear();
               
                foreach (var item in list)
                {
                    lst_users.Items.Add(item.UserName, 0).Tag = item;
                }
            });

            var values = new LoadReferanceUOW().LoadAllCitiesForDropDowns().Result;

            cmb_City.Invoke((MethodInvoker)delegate
            {

                foreach (var item in values)
                {
                    cmb_City.Items.Add(item);
                }

            });
            var towns = new LoadReferanceUOW().LoadAllTownsForDropDowns(1).Result;

            cmb_town.Invoke((MethodInvoker)delegate
            {

                foreach (var item in towns)
                {
                    cmb_town.Items.Add(item);
                }

            });





            var values342 = new LoadReferanceUOW().LoadAllMakesForDropDowns().Result;

            cmb_make.Invoke((MethodInvoker)delegate {

                foreach (var item in values342)
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

        private void PersonalInterest_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            exrepo = new ExistanceCheckUOW();

            txt_priceto.Text = trackBar2.Value.ToString();
            txt_pricefrom.Text = trackBar1.Value.ToString();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            Repository.RepoBase<User> repouser = new Repository.RepoBase<User>("Users");
            if (ExistanceCheckUOW.CheckUserEsitanceViaEmail(txt_Email.Text.Trim()).Result)
            {
                MessageBox.Show("Email Address already exists on the Database. Please choose another one Or Log in", "Car Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (ExistanceCheckUOW.CheckUserEsitanceViaMobile(txt_mobile.Text.Trim()).Result)
            {
                MessageBox.Show("Mobile Numner already exists on the Database. Please choose another one Or Log in", "Car Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            cmb_town.Invoke((MethodInvoker)delegate
            {
                if (txt_mobile.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Mobile number cannot be empty. Please enter a mobile number", "Car Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_Email.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Email number cannot be empty. Please enter a Email ", "Car Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_firstname.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("First Name cannot be empty. Please enter a First Name ", "Car Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_lastname.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Last Name cannot be empty. Please enter a Last Name ", "Car Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_username.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("User Name cannot be empty. Please enter a User Name ", "Car Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_password.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Password cannot be empty. Please enter a Password", "Car Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
         

            User user = new User();
            user.Id = -1;
            user.Access_Token = "";
            user.CityId = cmb_City.SelectedIndex;
            user.TownId = cmb_town.SelectedIndex;
            user.CountryId = 1;
            user.create_date = DateTime.Now;
            user.Email = txt_Email.Text.Trim();
            user.First_Name = txt_firstname.Text.Trim();
            user.IsRegistrationComplete = false;
            user.Last_Name = txt_lastname.Text;
            user.Mobile = txt_mobile.Text.Trim();
            user.Password = txt_password.Text;
            user.PasswordSalt = "";
            user.Phone = "";
            user.UserName = txt_username.Text.Trim();
            user.UserState = 1;

         
            var result=  repouser.Save(user, 1);
            });

          
            var list = repouser.FindALL().Result;

            lst_users.Invoke((MethodInvoker)delegate
            {
                lst_users.Items.Clear();

                foreach (var item in list)
                {
                    lst_users.Items.Add(item.UserName, 0).Tag = item;
                }
            });

        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("User  Added successfully", "Car Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        User globaluser;
        private void lst_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_users.SelectedItems.Count > 0)
            {
                globaluser = (User)lst_users.SelectedItems[0].Tag;
                lbl_selectedCustomer.Text = globaluser.UserName;
            }
            else {
                MessageBox.Show("Select a Customer Please", "Car Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            lbl_selectedCustomer.Invoke((MethodInvoker)delegate
            {
                if (lst_users.SelectedItems.Count > 0)
                {
                    globaluser = (User)lst_users.SelectedItems[0].Tag;
                    lbl_selectedCustomer.Text = globaluser.UserName;
                }
                else
                {
                    MessageBox.Show("Select a Customer Please", "Car Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            });


                if (globaluser != null) {
                UserInterest inte = new UserInterest();
                inte.Id = -1;
              
                rdo_basedonmakemodel.Invoke((MethodInvoker)delegate
                {
                    inte.FullCarName = cmb_make.Text + " " + cmb_models.Text;
                    if (rdo_basedonmakemodel.Checked)
                    {
                        inte.InterestFactor = 2;
                    }
                    if (rdo_basedonprice.Checked)
                    {
                        inte.InterestFactor = 1;
                    }

                    inte.Makeid = cmb_make.SelectedIndex;
                    inte.ModelId = cmb_models.SelectedIndex;
                    inte.UserId = globaluser.Id;
                    inte.YearId = cmb_yearmade.SelectedIndex;
                    inte.MilageId = cmb_milage.SelectedIndex;

                    inte.MinPrice = decimal.Parse(txt_pricefrom.Text.Trim());
                    inte.MaxPrice = decimal.Parse(txt_priceto.Text.Trim());

                    Repository.RepoBase<UserInterest> db = new Repository.RepoBase<UserInterest>("UserInterests");
                    var x = db.Save(inte, 1);
                });
             
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker3.RunWorkerAsync();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
          
            txt_pricefrom.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            txt_priceto.Text = trackBar2.Value.ToString();
        }
    }
}
