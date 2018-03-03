﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TestPlatform.Models;
using TestPlatform.Views;
using TestPlatform.Controllers;
using System.Resources;
using System.Globalization;

namespace TestPlatform
{
    public partial class FormWordColorConfig : UserControl
    {
        private bool isListNameValid = false;

        List<string> wordsList = new List<string>(), colorsList = new List<string>();
        private ResourceManager LocRM = new ResourceManager("TestPlatform.Resources.Localizations.LocalizedResources", typeof(FormMain).Assembly);
        private CultureInfo currentCulture = CultureInfo.CurrentUICulture;

        public bool isValid()
        {
            return isListNameValid;
        }

        public FormWordColorConfig(bool editFile)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            if (editFile)
            {
                openFilesForEdition();
            }
            else
            {
                wordsListCheckBox.Checked = true;
                colorsListCheckBox.Checked = true;
            }
            updateListsCounters();
            checkTypeOfList();
        }
        
        private void updateListsCounters()
        {
            numberItensWord.Text = wordListView.Items.Count.ToString();
            numberItensColor.Text = colorListView.Items.Count.ToString();
        }

        private void openFilesForEdition()
        {
            try
            {
                FormDefine defineFilePath = new FormDefine(LocRM.GetString("wordList", currentCulture), Global.testFilesPath + Global.listFolderName, "lst", "_words_color", true, false);
                var result = defineFilePath.ShowDialog();

                if (result == DialogResult.OK)
                {
                    isListNameValid = true;
                    string fileName = defineFilePath.ReturnValue;

                    if(fileName == "")
                    {
                        isListNameValid = false;
                        return;
                    }

                    fileName = fileName.Remove(fileName.Length - 6);
                    listNameTextBox.Text = fileName;

                    string wFile = Global.testFilesPath + Global.listFolderName + "/" + fileName + "_words.lst";
                    string cFile = Global.testFilesPath + Global.listFolderName + "/" + fileName + "_color.lst";
                    if(!File.Exists(wFile) && !File.Exists(cFile))
                    {
                        return;
                    }
                    if (File.Exists(wFile))
                    {
                        string[] wordsArray = StrList.readListFile(wFile);
                        foreach(string word in wordsArray)
                        {
                            wordsList.Add(word);
                        }
                        wordsListCheckBox.Checked = true;
                    }
                    if (File.Exists(cFile))
                    {
                        string[] colorsArray = StrList.readListFile(cFile);
                        foreach(string color in colorsArray)
                        {
                            colorsList.Add(color);
                        }
                        colorsListCheckBox.Checked = true;
                    }
                    addItems();
                }
                else
                {
                    wordsListCheckBox.Checked = true;
                    colorsListCheckBox.Checked = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addItems()
        {
            int count = this.colorListView.Items.Count;
            foreach (string color in colorsList)
            {
                if (Validations.isHexPattern(color))
                {
                    ListViewItem newItem = colorListView.Items.Add(color);
                    newItem.ForeColor = ColorTranslator.FromHtml(color);
                }
            }
            foreach(string word in wordsList)
            {
                wordListView.Items.Add(word);
            }
        }


        private void newWordItemButton_Click(object sender, EventArgs e)
        {
            try
            {
               if (wordItemTextBox.TextLength > 0)
                {
                    wordsList.Add(wordItemTextBox.Text);
                    wordListView.Items.Add(wordItemTextBox.Text);
                    wordItemTextBox.Text = "";
                    this.errorProvider1.SetError(this.wordItemTextBox, "");
                }
               else
                {
                    this.errorProvider1.SetError(this.wordItemTextBox, LocRM.GetString("emptyBox", currentCulture));
                }
                
                updateListsCounters();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newColorButton_Click(object sender, EventArgs e)
        {
            try
            {
                string color = colorItemTextBox.Text;
                if (Validations.isHexPattern(color))
                {
                    colorsList.Add(color);
                    ListViewItem newItem = colorListView.Items.Add(color);
                    newItem.ForeColor = ColorTranslator.FromHtml(color);
                    colorItemTextBox.Text = "";
                    this.errorProvider1.SetError(this.colorItemTextBox, "");
                }
                else
                {
                    this.errorProvider1.SetError(this.colorItemTextBox, LocRM.GetString("colorMatch", currentCulture));
                }

                updateListsCounters();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void wordsListCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!wordsListCheckBox.Checked && !colorsListCheckBox.Checked)
            {
                colorsListCheckBox.Checked = !wordsListCheckBox.Checked;
            }
            checkTypeOfList();
        }

        private void colorsListCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!wordsListCheckBox.Checked && !colorsListCheckBox.Checked)
            {
                wordsListCheckBox.Checked = !colorsListCheckBox.Checked;
            }
            checkTypeOfList();
        }

        private void checkTypeOfList()
        {
            try
            {
                string listName = listNameTextBox.Text;
                if (wordsListCheckBox.Checked && colorsListCheckBox.Checked)
                {
                    wordGroupBox.Name = listName + "_words";
                    colorListGroupBox.Name = listName + "_color";
                    wordGroupBox.Enabled = true;
                    colorListGroupBox.Enabled = true;
                }
                else if (wordsListCheckBox.Checked && !colorsListCheckBox.Checked)
                {
                    wordGroupBox.Name = listName + "_words";
                    colorListGroupBox.Name = "-";

                    wordGroupBox.Enabled = true;
                    colorListGroupBox.Enabled = false;
                }
                else if (!wordsListCheckBox.Checked && colorsListCheckBox.Checked)
                {
                    wordGroupBox.Name = "-";
                    colorListGroupBox.Name = listName + "_color";

                    wordGroupBox.Enabled = false;
                    colorListGroupBox.Enabled = true;
                }

                updateListsCounters();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void upWordItem_Click(object sender, EventArgs e)
        {
            moveUpListView(wordListView, wordsList);           
        }

        private void upColorItem_Click(object sender, EventArgs e)
        {
            moveUpListView(colorListView, colorsList);
        }

        private void downWordItem_Click(object sender, EventArgs e)
        {
            moveDownListView(wordListView, wordsList);
        }

        private void downColorItem_Click(object sender, EventArgs e)
        {
            moveDownListView(colorListView, colorsList);
        }

        private void moveUpListView(ListView listView, List<string> list)
        {
            if (!(listView.Items.Count == 0))
            {
                ListViewItem selectedItem = listView.SelectedItems[0];
                if (selectedItem.Index > 0)
                {
                    int index = selectedItem.Index - 1;
                    moveUpItem(list, selectedItem.Index);
                    listView.Items.RemoveAt(selectedItem.Index);
                    listView.Items.Insert(index, selectedItem);
                }
            }
            else
            {
                return;
            }
        }

        private void moveDownListView(ListView listView, List<string> list)
        {
            if (!(listView.Items.Count == 0))
            {
                ListViewItem selectedItem = listView.SelectedItems[0];
                if (selectedItem.Index < listView.Items.Count-1)
                {
                    int index = selectedItem.Index + 1;
                    moveDownItem(list, selectedItem.Index);
                    listView.Items.RemoveAt(selectedItem.Index);
                    listView.Items.Insert(index, selectedItem);
                }
            }
            else
            {
                return;
            }
        }

        private void moveUpItem(List<string> list, int index)
        {
            try
            {
                if (index == 0)
                    return;
                string item = list[index];
                list.RemoveAt(index);
                list.Insert(index - 1, item);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void moveDownItem(List<string> list, int index)
        {
            try
            {
                if (index == list.Count - 1)
                    return;
                string item = list[index];
                list.RemoveAt(index);
                list.Insert(index + 1, item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool saveListFile(List<string> list, string fileName, string fileType, string type)
        {
            StrList strlist;
            if ((MessageBox.Show(LocRM.GetString("wishToSave", currentCulture) + type + " '" + fileName + "' ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK))
            {
                strlist = ListController.CreateList(list, fileName, fileType);
                if (strlist.exists())
                {
                    DialogResult dialogResult = MessageBox.Show(LocRM.GetString("listExists", currentCulture), "", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.Cancel)
                    {
                        MessageBox.Show(LocRM.GetString("listNotSaved", currentCulture));
                        return false;
                    }
                }
                if (strlist.save())
                {
                    MessageBox.Show(LocRM.GetString("list", currentCulture) + fileName + LocRM.GetString("listSaveSuccess", currentCulture));
                    
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (!this.ValidateChildren(ValidationConstraints.Enabled))
                MessageBox.Show(LocRM.GetString("notFilledProperlyMessage", currentCulture));
            else
            {
                if (wordsListCheckBox.Checked)
                    valid = saveListFile(wordsList, listNameTextBox.Text, "_words", LocRM.GetString("words", currentCulture));
                if (colorsListCheckBox.Checked)
                    valid = saveListFile(colorsList, listNameTextBox.Text, "_color", LocRM.GetString("colors", currentCulture));                
                if (valid)
                {
                    this.Parent.Controls.Remove(this);
                    ListController.recoverEditingProgram(listNameTextBox.Text);
                }
                else
                    MessageBox.Show(LocRM.GetString("listNotSaved", currentCulture));
            }
        }

        private void listName_Validating(object sender,
                                     System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidListName(listNameTextBox.Text, out errorMsg))
            {
                e.Cancel = true;
                this.errorProvider1.SetError(this.listNameTextBox, errorMsg);
            }
        }

        private void listName_Validated(object sender, System.EventArgs e)
        {
            errorProvider1.SetError(this.listNameTextBox, "");
        }

        public bool ValidListName(string name, out string errorMessage)
        {
            if (Validations.isEmpty(name))
            {
                errorMessage = LocRM.GetString("emptyListName", currentCulture);
                return false;
            }
            if (!Validations.isAlphanumeric(name))
            {
                errorMessage = LocRM.GetString("listNotAlphanumeric", currentCulture);
                return false;
            }
            errorMessage = "";
            return true;
        }

        public bool ValidListLength(int number, out string errorMessage)
        {
            if (number == 0)
            {
                errorMessage = LocRM.GetString("emptyList", currentCulture);
                return false;
            }

            errorMessage = "";
            return true;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            FormInstructions infoBox = new FormInstructions(LocRM.GetString("wordColorConfigInstructions", currentCulture));
            try
            {
                infoBox.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chooseColorButton_Click(object sender, EventArgs e)
        {
            string colorCode = pickColor();
            if (colorCode != null)
            {
                colorPanel.ForeColor = ColorTranslator.FromHtml(colorCode);
                colorItemTextBox.Text = colorCode;
            }
        }

        private string pickColor()
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.CustomColors = new int[] {
                                        ColorTranslator.ToOle(ColorTranslator.FromHtml("#F8E000")),
                                        ColorTranslator.ToOle(ColorTranslator.FromHtml("#007BB7")),
                                        ColorTranslator.ToOle(ColorTranslator.FromHtml("#7EC845")),
                                        ColorTranslator.ToOle(ColorTranslator.FromHtml("#D01C1F"))
                                      };
            Color colorPicked = this.BackColor;
            string hexColor = null;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                colorPicked = MyDialog.Color;
                hexColor = "#" + colorPicked.R.ToString("X2") + colorPicked.G.ToString("X2") + colorPicked.B.ToString("X2");
            }
            return hexColor;
        }

        private void deleteWordItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (wordListView.Items.Count > 0 && wordListView.SelectedItems.Count > 0)
                {
                    int rowIndex = wordListView.SelectedItems[0].Index;
                    wordListView.Items.RemoveAt(rowIndex);

                    if (wordsList.Count > 0)
                    {
                        wordsList.RemoveAt(rowIndex);
                    }
                    updateListsCounters();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteColorItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (colorListView.Items.Count > 0 && colorListView.SelectedItems.Count > 0)
                {
                    int rowIndex = colorListView.SelectedItems[0].Index;
                    colorListView.Items.RemoveAt(rowIndex);
                    if (colorsList.Count > 0)
                    {
                        colorsList.RemoveAt(rowIndex);
                    }
                    updateListsCounters();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string listName = listNameTextBox.Text;
            if (wordsListCheckBox.Checked)
            {
                wordGroupBox.Name = listName + "_words";
            }
            if (colorsListCheckBox.Checked)
            {
                colorListGroupBox.Name = listName + "_color";
            }
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            this.Parent.Controls.Remove(this);
        }
    }
}
