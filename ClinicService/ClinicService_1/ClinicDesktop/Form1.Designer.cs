namespace ClinicDesktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUpdate = new Button();
            listViewClients = new ListView();
            Id = new ColumnHeader();
            SurName = new ColumnHeader();
            FirstName = new ColumnHeader();
            PatronymicName = new ColumnHeader();
            Birthday = new ColumnHeader();
            Document = new ColumnHeader();
            firsNameInput = new TextBox();
            surNameInput = new TextBox();
            firsNameText = new Label();
            surNameText = new Label();
            patronymicInput = new TextBox();
            patronymicText = new Label();
            birthdayInput = new DateTimePicker();
            birthdayText = new Label();
            addClient = new Button();
            documentText = new Label();
            documentInput = new TextBox();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(633, 379);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(95, 35);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // listViewClients
            // 
            listViewClients.Columns.AddRange(new ColumnHeader[] { Id, SurName, FirstName, PatronymicName, Birthday, Document });
            listViewClients.FullRowSelect = true;
            listViewClients.GridLines = true;
            listViewClients.Location = new Point(12, 12);
            listViewClients.Name = "listViewClients";
            listViewClients.Size = new Size(781, 302);
            listViewClients.TabIndex = 0;
            listViewClients.UseCompatibleStateImageBehavior = false;
            listViewClients.View = View.Details;
            // 
            // Id
            // 
            Id.Text = "#";
            Id.Width = 40;
            // 
            // SurName
            // 
            SurName.Text = "Фамилия";
            SurName.Width = 150;
            // 
            // FirstName
            // 
            FirstName.Text = "Имя";
            FirstName.Width = 150;
            // 
            // PatronymicName
            // 
            PatronymicName.Text = "Отчество";
            PatronymicName.Width = 150;
            // 
            // Birthday
            // 
            Birthday.Text = "Дата рождения";
            Birthday.Width = 150;
            // 
            // Document
            // 
            Document.Text = "Номер паспорта";
            Document.Width = 120;
            // 
            // firsNameInput
            // 
            firsNameInput.Location = new Point(12, 341);
            firsNameInput.Name = "firsNameInput";
            firsNameInput.Size = new Size(140, 23);
            firsNameInput.TabIndex = 1;
            // 
            // surNameInput
            // 
            surNameInput.Location = new Point(12, 391);
            surNameInput.Name = "surNameInput";
            surNameInput.Size = new Size(140, 23);
            surNameInput.TabIndex = 2;
            // 
            // firsNameText
            // 
            firsNameText.AutoSize = true;
            firsNameText.Location = new Point(12, 323);
            firsNameText.Name = "firsNameText";
            firsNameText.Size = new Size(31, 15);
            firsNameText.TabIndex = 3;
            firsNameText.Text = "Имя";
            // 
            // surNameText
            // 
            surNameText.AutoSize = true;
            surNameText.Location = new Point(12, 376);
            surNameText.Name = "surNameText";
            surNameText.Size = new Size(58, 15);
            surNameText.TabIndex = 4;
            surNameText.Text = "Фамилия";
            // 
            // patronymicInput
            // 
            patronymicInput.Location = new Point(173, 341);
            patronymicInput.Name = "patronymicInput";
            patronymicInput.Size = new Size(140, 23);
            patronymicInput.TabIndex = 5;
            // 
            // patronymicText
            // 
            patronymicText.AutoSize = true;
            patronymicText.Location = new Point(173, 323);
            patronymicText.Name = "patronymicText";
            patronymicText.Size = new Size(58, 15);
            patronymicText.TabIndex = 6;
            patronymicText.Text = "Отчество";
            // 
            // birthdayInput
            // 
            birthdayInput.Location = new Point(173, 391);
            birthdayInput.Name = "birthdayInput";
            birthdayInput.Size = new Size(140, 23);
            birthdayInput.TabIndex = 7;
            // 
            // birthdayText
            // 
            birthdayText.AutoSize = true;
            birthdayText.Location = new Point(173, 373);
            birthdayText.Name = "birthdayText";
            birthdayText.Size = new Size(90, 15);
            birthdayText.TabIndex = 8;
            birthdayText.Text = "Дата рождения";
            // 
            // addClient
            // 
            addClient.Location = new Point(364, 376);
            addClient.Name = "addClient";
            addClient.Size = new Size(95, 35);
            addClient.TabIndex = 9;
            addClient.Text = "Add client";
            addClient.UseVisualStyleBackColor = true;
            addClient.Click += addClient_Click;
            // 
            // documentText
            // 
            documentText.AutoSize = true;
            documentText.Location = new Point(319, 323);
            documentText.Name = "documentText";
            documentText.Size = new Size(99, 15);
            documentText.TabIndex = 11;
            documentText.Text = "Номер паспорта";
            // 
            // documentInput
            // 
            documentInput.Location = new Point(319, 341);
            documentInput.Name = "documentInput";
            documentInput.Size = new Size(140, 23);
            documentInput.TabIndex = 10;
            // 
            // Form1
            // 
            ClientSize = new Size(805, 426);
            Controls.Add(documentText);
            Controls.Add(documentInput);
            Controls.Add(addClient);
            Controls.Add(birthdayText);
            Controls.Add(birthdayInput);
            Controls.Add(patronymicText);
            Controls.Add(patronymicInput);
            Controls.Add(surNameText);
            Controls.Add(firsNameText);
            Controls.Add(surNameInput);
            Controls.Add(firsNameInput);
            Controls.Add(listViewClients);
            Controls.Add(btnUpdate);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Animals clinic";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private ListView listViewClients;
        private ColumnHeader Id;
        private ColumnHeader SurName;
        private ColumnHeader FirstName;
        private ColumnHeader PatronymicName;
        private ColumnHeader Birthday;
        private TextBox firsNameInput;
        private TextBox surNameInput;
        private TextBox patronymicInput;
        private DateTimePicker birthdayInput;
        private Label firsNameText;
        private Label surNameText;
        private Label patronymicText;
        private Label birthdayText;

        private Button addClient;
        private Label documentText;
        private TextBox documentInput;
        private ColumnHeader Document;
    }
}
