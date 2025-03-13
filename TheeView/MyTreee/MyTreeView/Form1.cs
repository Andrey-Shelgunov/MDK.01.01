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

       
        private TextBox selectedNodeTextBox;
        private static readonly object Nodes;
        private TreeNode AddNode(string v, object nodes)
        {
            throw new NotImplementedException();
        }

        private void PopulateTreeView()
        {
            // Главный узел: Жанры
            TreeNode genresNode = AddNode("Жанры", Form1.Nodes);

            // Жанр: Стратегии
            TreeNode strategyNode = AddNode("Стратегии", genresNode.Nodes);

            // Игры в жанре Стратегии
            AddNode("Civilization VI", strategyNode.Nodes);
            AddNode("StarCraft II", strategyNode.Nodes);
            AddNode("Crusader Kings III", strategyNode.Nodes);

            // Жанр: RPG (Ролевые игры)
            TreeNode rpgNode = AddNode("RPG", genresNode.Nodes);

            // Игры в жанре RPG
            AddNode("The Witcher 3: Wild Hunt", rpgNode.Nodes);
            AddNode("Elden Ring", rpgNode.Nodes);
            AddNode("Cyberpunk 2077", rpgNode.Nodes);

            // Жанр: Шутеры
            TreeNode shooterNode = AddNode("Шутеры", genresNode.Nodes);

            // Игры в жанре Шутеры
            AddNode("Counter-Strike: Global Offensive", shooterNode.Nodes);
            AddNode("Valorant", shooterNode.Nodes);
            AddNode("Call of Duty: Warzone", shooterNode.Nodes);


            // Главный узел: Платформы
            TreeNode platformsNode = AddNode("Платформы", Form1.Nodes);

            // Платформа: PC
            TreeNode pcNode = AddNode("PC", platformsNode.Nodes);

            // Игры на PC (можно добавить те же игры, что и в жанрах, это пример)
            AddNode("Civilization VI", pcNode.Nodes);
            AddNode("The Witcher 3: Wild Hunt", pcNode.Nodes);
            AddNode("Counter-Strike: Global Offensive", pcNode.Nodes);

            // Платформа: PlayStation
            TreeNode playStationNode = AddNode("PlayStation", platformsNode.Nodes);

            // Игры на PlayStation
            AddNode("The Last of Us Part II", playStationNode.Nodes);
            AddNode("Spider-Man: Miles Morales", playStationNode.Nodes);
            AddNode("God of War Ragnarök", playStationNode.Nodes);


            // Разворачиваем дерево для удобства просмотра
            genresNode.Expand();
            platformsNode.Expand();
        }

        

        // Вспомогательный метод для добавления узлов
        private TreeNode AddNode(string text, TreeNodeCollection nodes)
        {
            TreeNode node = new TreeNode(text);
            nodes.Add(node);
            return node; // Возвращаем добавленный узел, чтобы можно было сразу добавлять дочерние узлы.
        }

        private void gameTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Обработчик события выбора узла
            if (e.Node != null && selectedNodeTextBox != null) // Важно: проверка на null!
            {
                selectedNodeTextBox.Text = e.Node.Text;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}

