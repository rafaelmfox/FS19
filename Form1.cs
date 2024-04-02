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
                        comboBox.Items.Add(subDirectory);
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

            if (cbSaveGame.SelectedItem != null)
            {
                string selectedDirectory = cbSaveGame.SelectedItem.ToString();
                LoadFarmXmlFile(selectedDirectory);
            }
            else
            {
                MessageBox.Show("Por favor, selecione um diretório antes de carregar o arquivo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        string farmName = farmNode.Attributes["name"].Value;
                        string farmId = farmNode.Attributes["farmId"].Value;

                        // Exibir os valores na label
                        lblNomeSave.Text = "Nome da Fazenda: " + farmName;
                       
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







    }//fim
}
