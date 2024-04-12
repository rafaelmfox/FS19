using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace FS19
{
    public partial class Form1 : Form
    {
        public string farmName; 
        public string farmId;
        public string money; 
                               

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "My Games", "FarmingSimulator2019");
            ListSaveGameFolders(directoryPath, cbSaveGame);
            SortComboBoxNumerically2(cbSaveGame);

        }


        static void ListSaveGameFolders(string directoryPath, ComboBox comboBox)
        {
            try
            {
                string[] subDirectories = Directory.GetDirectories(directoryPath);

                foreach (string subDirectory in subDirectories)
                {
                    if (subDirectory.ToLower().Contains("savegame"))
                    {
                        string folderName = Path.GetFileName(subDirectory); // Obtém apenas o nome da pasta
                        comboBox.Items.Add(folderName); // Adiciona o nome da pasta à ComboBox
                    }

                    ListSaveGameFolders(subDirectory, comboBox);
                }
                comboBox.Sorted = true;
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine($"Acesso não autorizado: {e.Message}");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine($"Diretório não encontrado: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro: {e.Message}");
            }
        }

        static void SortComboBoxNumerically2(ComboBox comboBox)
        {
            comboBox.Sorted = true; // Isso vai ajudar a ordernar numericamente
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(tbControle.SelectedIndex.ToString());


            if (cbSaveGame.SelectedItem != null)
            {
                string selectedDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "My Games", "FarmingSimulator2019", cbSaveGame.SelectedItem.ToString());

                LoadFarmXmlFile(selectedDirectory);
                LoadFarmlandXmlFile(selectedDirectory);
                LoadEnvironmentXmlFile(selectedDirectory);
                





            }
            else
            {
                //MessageBox.Show("Por favor, selecione um diretório antes de carregar o arquivo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        public void LoadFarmXmlFile(string directoryPath)
        {
            try
            {
                string farmsXmlPath = Path.Combine(directoryPath, "farms.xml");

                if (File.Exists(farmsXmlPath))
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(farmsXmlPath);

                    // Acessar o primeiro nó <farm>
                    XmlNode farmNode = xmlDoc.SelectSingleNode("/farms/farm");

                    if (farmNode != null)
                    {
                        // Pegar os valores dos atributos 'name' e 'farmId'
                        farmName = farmNode.Attributes["name"].Value;
                        farmId = farmNode.Attributes["farmId"].Value;
                        money = farmNode.Attributes["money"].Value;

                        // Exibir os valores na label
                        lblNomeSave.Text = "Save: " + farmName;
                        txtFarmMoney.Text = money;

                    }
                    else
                    {
                        Console.WriteLine("Nenhuma fazenda encontrada no arquivo farms.xml.");
                    }
                }
                else
                {
                    Console.WriteLine("O arquivo farms.xml não foi encontrado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao carregar o arquivo farms.xml: {ex.Message}");
            }
        }

        public void LoadFarmlandXmlFile(string directoryPath)
        {
            try
            {
                string farmsXmlPath = Path.Combine(directoryPath, "farmland.xml");

                if (File.Exists(farmsXmlPath))
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(farmsXmlPath);

                    XmlNodeList farmlandNodes = xmlDoc.SelectNodes("/farmlands/farmland");

                    if (farmlandNodes != null)
                    {
                        foreach (XmlNode node in farmlandNodes)
                        {
                            string farmId = node.Attributes["id"].Value;
                            bool isChecked = (node.Attributes["farmId"] != null && node.Attributes["farmId"].Value == "1");
                            cbListaDeFarm.Items.Add("ID" + farmId, isChecked); // Adiciona o ID à CheckedListBox com o status de checagem
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhum farmland encontrado no arquivo farmland.xml.");
                    }
                }
                else
                {
                    Console.WriteLine("O arquivo farmland.xml não foi encontrado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao carregar o arquivo farmland.xml: {ex.Message}");
            }
        }

        public void LoadEnvironmentXmlFile(string directoryPath)
        {
            try
            {
                string environmentXmlPath = Path.Combine(directoryPath, "environment.xml");

                if (File.Exists(environmentXmlPath))
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(environmentXmlPath);

                    XmlNode environmentNode = xmlDoc.SelectSingleNode("/environment");
                    if (environmentNode != null)
                    {
                        XmlNode currentDayNode = environmentNode.SelectSingleNode("currentDay");
                        if (currentDayNode != null)
                        {
                            string currentDayValue = currentDayNode.InnerText; // Obtenha o valor do elemento currentDay
                            lblNomeSave.Text = lblNomeSave.Text + " -Dia: " + currentDayValue;
                        }
                    }
                }
     

            }
            catch (Exception ex)
            {
               
            }
        }





    }//fim
}
