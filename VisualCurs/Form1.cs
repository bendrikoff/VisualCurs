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

    public partial class Form1 : Form
    {
        int filter=0; // 0 - все 1-округа 2 - области 3 - районы
        public Form1()
        {
            InitializeComponent();
            FederalDistricts.list.Add(new FederalDistrict("Черноземье", 15, 25, "Курск"));
           
            


            Region reg = new Region(FederalDistricts.list[0], "asd", 1, 2, "da");
            Regions.list.Add(reg);

            Districts.list.Add(new District(reg, FederalDistricts.list[0], "Глушково",100,100,"Кек"));
            UpdateList();

            

            Hide();
            

        }

        private void createMenuBttn_Click(object sender, EventArgs e)
        {
            CollectionsForm colForm = new CollectionsForm(this);
            colForm.Show();
           
            
        }
        private void updateBttn_Click(object sender, EventArgs e)
        {
            UpdateList();
        }
        void Hide()
        {
            nameLab.Visible = false;
            populationLab.Visible = false;
            areaLab.Visible = false;
            centerLab.Visible = false;
            fedDistLab.Visible = false;
            regionLab.Visible = false;
            deleteBttn.Visible = false;
            changeBttn.Visible = false;
        }
        
        //Обновление для listView1
        public void UpdateList()
        {
            treeView1.Nodes.Clear();
            for (int i = 0; i < FederalDistricts.list.Count; i++)
            {
                treeView1.Nodes.Add(new TreeNode(FederalDistricts.list[i].name));
                for (int j = 0; j < Regions.list.Count; j++)
                {
                    if (Regions.list[j].federalDistrict == FederalDistricts.list[i])
                    {
                        treeView1.Nodes[i].Nodes.Add(Regions.list[j].name);
                        for (int g = 0; g < Districts.list.Count; g++)
                        {
                            if (Regions.list[j] == Districts.list[g].region)
                            {
                                treeView1.Nodes[i].Nodes[j].Nodes.Add(Districts.list[g].name);
                            }
                        }
                    }
                }
            }
        }
        private void changeBttn_Click(object sender, EventArgs e)
        {
            Hide();
            foreach (var a in FederalDistricts.list)
            {
                if (a.name == treeView1.SelectedNode.Text)
                {

                    CollectionsForm colForm = new CollectionsForm(this, a);
                    colForm.Show();
                    return;
                }
            }

                foreach (var a in Regions.list)
                {
                    if (a.name == treeView1.SelectedNode.Text)
                    {
                        CollectionsForm colForm = new CollectionsForm(this, a);
                        colForm.Show();
                        return;
                    }
                }
            
                foreach (var a in Districts.list)
                {
                    if (a.name == treeView1.SelectedNode.Text)
                    {

                        CollectionsForm colForm = new CollectionsForm(this, a);
                        colForm.Show();
                        return;
                    }
                }
            



        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            bool f = false;



            try
            {

                foreach (var a in FederalDistricts.list)
                {
                    if (a.name == treeView1.SelectedNode.Text)
                    {
                        f = true;
                        nameLab.Text = a.name;
                        populationLab.Text = "Население: " + a.population.ToString();
                        areaLab.Text = "Площадь: " + a.area.ToString();
                        centerLab.Text = "Центр: " + a.center;
                    }
                }
                fedDistLab.Visible = false;
                regionLab.Visible = false;

                deleteBttn.Visible = true;
                changeBttn.Visible = true;
                if (!f)
                {
                    foreach (var a in Regions.list)
                    {
                        if (a.name == treeView1.SelectedNode.Text)
                        {
                            f = true;
                            nameLab.Text = a.name;
                            populationLab.Text = "Население: " + a.population.ToString();
                            areaLab.Text = "Площадь:" + a.area.ToString();
                            centerLab.Text = "Центр: " + a.center;
                            fedDistLab.Text = "Федеральный округ: " + a.federalDistrict.name;
                            fedDistLab.Visible = true;
                        }
                    }
                }
                if (!f)
                {
                    foreach (var a in Districts.list)
                    {
                        if (a.name == treeView1.SelectedNode.Text)
                        {

                            nameLab.Text = a.name;
                            populationLab.Text = "Население: " + a.population.ToString();
                            areaLab.Text = "Площадь:" + a.area.ToString();
                            centerLab.Text = "Центр: " + a.center;
                            fedDistLab.Text = "Федеральный округ:" + a.federalDistrict.name;
                            regionLab.Text = "Область:" + a.region.name;
                            fedDistLab.Visible = true;
                            regionLab.Visible = true;
                        }
                    }
                }
                nameLab.Visible = true;
                populationLab.Visible = true;
                areaLab.Visible = true;
                centerLab.Visible = true;
            }
            catch
            {

            }
        }

        private void deleteBttn_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < FederalDistricts.list.Count; i++)
            {
                if (FederalDistricts.list[i].name == treeView1.SelectedNode.Text)
                {
                    FederalDistricts.list.Remove(FederalDistricts.list[i]);
                    UpdateList();
                    return;
                }
            }

            for (int i = 0; i < Regions.list.Count; i++)
            {
                if (Regions.list[i].name == treeView1.SelectedNode.Text)
                {
                    Regions.list.Remove(Regions.list[i]);
                    UpdateList();
                    return;
                }
            }


            for (int i = 0; i < Districts.list.Count; i++)
            {
                if (Districts.list[i].name == treeView1.SelectedNode.Text)
                {
                    Districts.list.Remove(Districts.list[i]);
                    UpdateList();
                    return;
                }
            }
        }


    }
}
