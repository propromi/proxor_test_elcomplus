using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace Ispitanie_xmlem
{
    public partial class Form1 : Form
    {
        //Обявление переменных
        private string tempURL;
        private XmlDocument drawDoc = new XmlDocument();

        public Form1()
        {
            InitializeComponent();
        }

        //Скачивание файла по ссылке в папку с программой
        private void Zagruzka()
        {
            WebClient clientZagruzka = new WebClient();

            labelStatus.Text = "Статус: Загрузка в процессе...";
            clientZagruzka.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            //Асинхронность, чтобы форма не "зависала", так приятней
            clientZagruzka.DownloadFileAsync(new Uri (tempURL), "usefile.xml");

        }

        //Обработка и отображение завершения скачивания файла
        private void Completed(object sender, AsyncCompletedEventArgs e) {
            if(e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                labelStatus.Text = "Статус: Загрузка завершена";
            }
        }

        //Создание ствола и инициализация рекурсии
        private void LoadTreeFromXmlDoc(XmlDocument xmlDoc, TreeView treeView)
        {
            treeView.Nodes.Clear();
            AddTreeNode(treeView.Nodes, xmlDoc.DocumentElement);
        }

        //Рекурсивная функция построениея дерева
        private void AddTreeNode(TreeNodeCollection parentNodes, XmlNode xmlNode)
        {
            TreeNode tempNode = parentNodes.Add(xmlNode.Name);

            foreach (XmlNode childNode in xmlNode.ChildNodes)
            {
                AddTreeNode(tempNode.Nodes, childNode);
            }
        }

        //Кнопка загрузки
        private void buttonDownload_Click(object sender, EventArgs e)
        {
            if (textBoxLink.Text != "")
            {
                tempURL = textBoxLink.Text;
                Zagruzka();
            }
        }

        //Кнопка постройки дерева
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            treeViewMy.Nodes.Clear();

            if (textBoxLink.Text != "")
            {
                drawDoc.Load(Application.StartupPath + @"\\usefile.xml");

                LoadTreeFromXmlDoc(drawDoc, treeViewMy);
                treeViewMy.ExpandAll();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelStatus.Text = "Статус: Ничего не происходит";
            //Инструкция
            textBoxBreath.Text = "Инструкция: \r\n \r\n Чтобы загрузить файл по ссылке: \r\n" + 
                "1)Вставьте ссылку в соответствующее поле, просьба загружать только файлы формата XML \r\n" +
                "2)Нажать на кнопку “Загрузить” \r\n \r\n" + 
                "Чтобы построить дерево: \r\n" +
                "1)Загрузите файл \r\n 2)Нажмите кнопку “Построить” ";
        }
        //Created by Proxor|propromi jan 2021
    }
}
