using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualCurs
{
    public partial class CollectionsForm : Form
    {
        Form1 form1;
        int mode; //0-создание 1 - редактирование фед округа 2 - области 3- района
        public CollectionsForm(Form1 form)
        {
            mode = 0;
            form1 = form;
            //fedDistBox.Visible = false;
            InitializeComponent();
            // typeBox.SelectedIndex = 0;
            fedDistLabel.Visible = false;
            fedDistBox.Visible = false;
            regionLabel.Visible = false;
            regionBox.Visible = false;


            //создаем список имен фед оругов
            if (FederalDistricts.list.Count > 0)
            {
                List<string> fedDistNames = new List<string>();

                foreach (FederalDistrict a in FederalDistricts.list)
                {
                    fedDistNames.Add(a.name);
                }
                fedDistBox.DataSource = fedDistNames;
            }
            
            if (Regions.list.Count > 0)
            {
                List<string> regionsNames = new List<string>();

                foreach (Region a in Regions.list)
                {
                    regionsNames.Add(a.name);
                }
                regionBox.DataSource = regionsNames;
            }
        }
        FederalDistrict federalDistrict;
        Region region;
        District district;
        public CollectionsForm(Form1 form,FederalDistrict fedDist )
        {
            
            mode = 1;
            form1 = form;
            InitializeComponent();

            federalDistrict = fedDist;
            
            fedDistLabel.Visible = false;
            fedDistBox.Visible = false;
            regionLabel.Visible = false;
            regionBox.Visible = false;

            nameBox.Text = fedDist.name;
            areaBox.Value = fedDist.area;
            populationBox.Value = fedDist.population;
            centerBox.Text = fedDist.center;
            typeBox.SelectedIndex = 0;
            createBttn.Text = "Изменить";
            typeBox.Visible = false;
            label1.Visible = false;
        }
        public CollectionsForm(Form1 form, Region reg)
        {
            mode = 2;
            form1 = form;
            InitializeComponent();

            region = reg;


            regionLabel.Visible = false;
            regionBox.Visible = false;

            nameBox.Text = reg.name;
            areaBox.Value = reg.area;
            populationBox.Value = reg.population;
            centerBox.Text = reg.center;

            if (FederalDistricts.list.Count > 0)
            {
                List<string> fedDistNames = new List<string>();

                foreach (FederalDistrict a in FederalDistricts.list)
                {
                    fedDistNames.Add(a.name);
                }
                fedDistBox.DataSource = fedDistNames;
            }

            fedDistBox.SelectedIndex = FederalDistricts.list.IndexOf(reg.federalDistrict);
            typeBox.SelectedIndex = 1;
            createBttn.Text = "Изменить";
            typeBox.Visible = false;
            label1.Visible = false;
        }
        public CollectionsForm(Form1 form, District dist)
        {
            mode = 3;
            form1 = form;
            InitializeComponent();

            district = dist;


            nameBox.Text = dist.name;
            areaBox.Value = dist.area;
            populationBox.Value = dist.population;
            centerBox.Text = dist.center;

            if (FederalDistricts.list.Count > 0)
            {
                List<string> fedDistNames = new List<string>();

                foreach (FederalDistrict a in FederalDistricts.list)
                {
                    fedDistNames.Add(a.name);
                }
                fedDistBox.DataSource = fedDistNames;
            }
            if (Regions.list.Count > 0)
            {
                List<string> regionsNames = new List<string>();

                foreach (Region a in Regions.list)
                {
                    regionsNames.Add(a.name);
                }
                regionBox.DataSource = regionsNames;
            }

            fedDistBox.SelectedIndex = FederalDistricts.list.IndexOf(dist.federalDistrict);
            regionBox.SelectedIndex = Regions.list.IndexOf(dist.region);
            typeBox.SelectedIndex = 2;
            createBttn.Text = "Изменить";
            typeBox.Visible = false;
            label1.Visible = false;

        }




        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (typeBox.SelectedIndex)
            {
                case 0:
                    fedDistLabel.Visible = false;
                    fedDistBox.Visible = false;
                    regionLabel.Visible = false;
                    regionBox.Visible = false;
                    break;
                case 1:
                    fedDistLabel.Visible = true;
                    fedDistBox.Visible = true;
                    regionLabel.Visible = false;
                    regionBox.Visible = false;

                    break;
                case 2:
                    fedDistLabel.Visible = true;
                    fedDistBox.Visible = true;
                    regionLabel.Visible = true;
                    regionBox.Visible = true;
                    break;
            }
        }

       
        bool Valid()
        {
           
            if (typeBox.SelectedIndex == -1)
            {
                
                errorProviderType.SetError(typeBox, "Укажите тип");
                return false;
            }
            else
            {

                errorProviderType.Dispose();
            }
            //Валидация имени

            if (!validationString(nameBox.Text))
            {
               
                errorProviderName.SetError(nameBox, "Неправильный формат ввода");
                return false;

            }
            else
            {

                errorProviderName.Dispose();
            }
            foreach(var a in FederalDistricts.list)
            {
                if (a.name.ToLower() == nameBox.Text.ToLower())
                {
                    errorProviderName.SetError(nameBox, "Такое имя уже существует");
                    return false;
                }
            }
            foreach (var a in Regions.list)
            {
                if (a.name.ToLower() == nameBox.Text.ToLower())
                {
                    errorProviderName.SetError(nameBox, "Такое имя уже существует");
                    return false;
                }
            }
            foreach (var a in Districts.list)
            {
                if (a.name.ToLower() == nameBox.Text.ToLower())
                {
                    errorProviderName.SetError(nameBox, "Такое имя уже существует");
                    return false;
                }
            }
            //Валидация центра
            if (!validationString(centerBox.Text))
            {
               
                errorProviderCenter.SetError(centerBox, "Неправильный формат ввода");
                return false;
            }
            else
            {

                errorProviderCenter.Dispose();
            }
            //Валидация федерального округа
            //Если textbox виден,то производим валидацию
            if (fedDistBox.Visible)
            {
                if (!validationString(fedDistBox.Text))
                {
                   
                    errorProviderFedDist.SetError(fedDistBox, "Неправильный формат ввода");
                    return false;
                }
                else
                {

                    errorProviderFedDist.Dispose();
                }
            }
            //Валидация области
            //Если textbox виден,то производим валидацию
            if (regionBox.Visible)
            {
                if (!validationString(regionBox.Text))
                {
                    
                    errorProviderRegion.SetError(regionBox, "Неправильный формат ввода");
                    return false;
                }
                else
                {

                    errorProviderRegion.Dispose();
                }
            }
            
            return true;
        }
        private void createBttn_Click(object sender, EventArgs e)
        {
            //bool valid = true;
            ////Валидация выбора типа
            //if (typeBox.SelectedIndex == -1)
            //{
            //    valid = false;
            //    errorProviderType.SetError(typeBox, "Укажите тип");
            //}
            //else
            //{

            //    errorProviderType.Dispose();
            //}
            ////Валидация имени

            //if (!validationString(nameBox.Text))
            //{
            //    valid = false;
            //    errorProviderName.SetError(nameBox,"Неправильный формат ввода");

            //}
            //else
            //{

            //    errorProviderName.Dispose();
            //}
            ////Валидация центра
            //if (!validationString(centerBox.Text))
            //{
            //    valid = false;
            //    errorProviderCenter.SetError(centerBox, "Неправильный формат ввода");
            //}
            //else
            //{

            //    errorProviderCenter.Dispose();
            //}
            ////Валидация федерального округа
            ////Если textbox виден,то производим валидацию
            //if (fedDistBox.Visible)
            //{
            //    if (!validationString(fedDistBox.Text))
            //    {
            //        valid = false;
            //        errorProviderFedDist.SetError(fedDistBox, "Неправильный формат ввода");
            //    }
            //    else
            //    {

            //        errorProviderFedDist.Dispose();
            //    }
            //}
            ////Валидация области
            ////Если textbox виден,то производим валидацию
            //if (regionBox.Visible)
            //{
            //    if (!validationString(regionBox.Text))
            //    {
            //        valid = false;
            //        errorProviderRegion.SetError(regionBox, "Неправильный формат ввода");
            //    }
            //    else
            //    {

            //        errorProviderRegion.Dispose();
            //    }
            //}
            if (Valid())
            {
                switch (mode)
                {
                    case 0:

                        switch (typeBox.SelectedIndex)
                        {
                            case 0:
                                FederalDistricts.list.Add(new FederalDistrict(nameBox.Text, Convert.ToInt32(areaBox.Value), Convert.ToInt32(populationBox.Value), centerBox.Text));

                                break;
                            case 1:
                                Regions.list.Add(new Region(FederalDistricts.list[fedDistBox.SelectedIndex], nameBox.Text, Convert.ToInt32(areaBox.Value), Convert.ToInt32(populationBox.Value), centerBox.Text));

                                break;
                            case 2:
                                Districts.list.Add(new District(Regions.list[regionBox.SelectedIndex], FederalDistricts.list[fedDistBox.SelectedIndex], nameBox.Text, Convert.ToInt32(areaBox.Value), Convert.ToInt32(populationBox.Value), centerBox.Text));

                                break;
                        }



                        break;
                    case 1:
                        FederalDistricts.list[FederalDistricts.list.IndexOf(federalDistrict)].name = nameBox.Text;
                        FederalDistricts.list[FederalDistricts.list.IndexOf(federalDistrict)].area = Convert.ToInt32(areaBox.Value);
                        FederalDistricts.list[FederalDistricts.list.IndexOf(federalDistrict)].population = Convert.ToInt32(populationBox.Value);
                        FederalDistricts.list[FederalDistricts.list.IndexOf(federalDistrict)].center = centerBox.Text;

                        break;
                    case 2:
                        Regions.list[Regions.list.IndexOf(region)].name = nameBox.Text;
                        Regions.list[Regions.list.IndexOf(region)].area = Convert.ToInt32(areaBox.Value);
                        Regions.list[Regions.list.IndexOf(region)].population = Convert.ToInt32(populationBox.Value);
                        Regions.list[Regions.list.IndexOf(region)].center = centerBox.Text;
                        Regions.list[Regions.list.IndexOf(region)].federalDistrict = FederalDistricts.list[fedDistBox.SelectedIndex];
                        break;
                    case 3:
                        Districts.list[Districts.list.IndexOf(district)].name = nameBox.Text;
                        Districts.list[Districts.list.IndexOf(district)].area = Convert.ToInt32(areaBox.Value);
                        Districts.list[Districts.list.IndexOf(district)].population = Convert.ToInt32(populationBox.Value);
                        Districts.list[Districts.list.IndexOf(district)].center = centerBox.Text;
                        Districts.list[Districts.list.IndexOf(district)].federalDistrict = FederalDistricts.list[fedDistBox.SelectedIndex];
                        Districts.list[Districts.list.IndexOf(district)].region = Regions.list[regionBox.SelectedIndex];


                        break;

                }
                form1.UpdateList();
                this.Close();
            }

        }
        private bool validationString(string str)
        {
            foreach (char a in str)
            {
                //Если символ не пробел и не буква, то вызываем ошибку
                if (!(Char.IsLetter(a) || Char.IsWhiteSpace(a)))
                {
                   // label2.Text = a.ToString();
                    return false;
                }
            }
            if (String.IsNullOrEmpty(str))
            {
                
                return false;
            }
            return true;
        }

        private void cancelBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
