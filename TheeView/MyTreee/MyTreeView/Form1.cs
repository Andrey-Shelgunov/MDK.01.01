using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTreeView
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
            PopulateTreeView();
        }
            private object selectedNodeTextBox;
    
        public static object Nodes { get; private set; }
        private void PopulateTreeView()
        {
            // Главный узел: Жанры
            TreeNode genresNode = new TreeNode("Жанры");
            Form1.Nodes.Add(genresNode);

            // Жанр: Стратегии
            TreeNode strategyNode = new TreeNode("Стратегии");
            genresNode.Nodes.Add(strategyNode);

            // Игры в жанре Стратегии
            strategyNode.Nodes.Add(new TreeNode("Civilization VI"));
            strategyNode.Nodes.Add(new TreeNode("StarCraft II"));
            strategyNode.Nodes.Add(new TreeNode("Crusader Kings III"));

            // Жанр: RPG (Ролевые игры)
            TreeNode rpgNode = new TreeNode("RPG");
            genresNode.Nodes.Add(rpgNode);

            // Игры в жанре RPG
            rpgNode.Nodes.Add(new TreeNode("The Witcher 3: Wild Hunt"));
            rpgNode.Nodes.Add(new TreeNode("Elden Ring"));
            rpgNode.Nodes.Add(new TreeNode("Cyberpunk 2077"));

            // Жанр: Шутеры
            TreeNode shooterNode = new TreeNode("Шутеры");
            genresNode.Nodes.Add(shooterNode);

            // Игры в жанре Шутеры
            shooterNode.Nodes.Add(new TreeNode("Counter-Strike: Global Offensive"));
            shooterNode.Nodes.Add(new TreeNode("Valorant"));
            shooterNode.Nodes.Add(new TreeNode("Call of Duty: Warzone"));


            // Главный узел: Платформы
            TreeNode platformsNode = new TreeNode("Платформы");
            Form1.Nodes.Add(platformsNode);

            // Платформа: PC
            TreeNode pcNode = new TreeNode("PC");
            platformsNode.Nodes.Add(pcNode);

            // Игры на PC (можно добавить те же игры, что и в жанрах, это пример)
            pcNode.Nodes.Add(new TreeNode("Civilization VI"));
            pcNode.Nodes.Add(new TreeNode("The Witcher 3: Wild Hunt"));
            pcNode.Nodes.Add(new TreeNode("Counter-Strike: Global Offensive"));

            // Платформа: PlayStation
            TreeNode playStationNode = new TreeNode("PlayStation");
            platformsNode.Nodes.Add(playStationNode);

            // Игры на PlayStation
            playStationNode.Nodes.Add(new TreeNode("The Last of Us Part II"));
            playStationNode.Nodes.Add(new TreeNode("Spider-Man: Miles Morales"));
            playStationNode.Nodes.Add(new TreeNode("God of War Ragnarök"));


            // Разворачиваем дерево для удобства просмотра
            genresNode.Expand();
            platformsNode.Expand();
        }

        private void gameTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Обработчик события выбора узла
            if (e.Node != null)
            {
                // Выводим текст выбранного узла в TextBox (можно сделать что-то другое)
                selectedNodeTextBox.Text = e.Node.Text;
            }
        }

        }
}

