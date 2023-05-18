namespace e_Agenda.WinApp.ModuloCompromisso
{
    partial class TelaCompromissoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtAssunto = new TextBox();
            txtId = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            cmbContatos = new ComboBox();
            dateTimeData = new DateTimePicker();
            label2 = new Label();
            label7 = new Label();
            dateTimeInicio = new DateTimePicker();
            dateTimeTermino = new DateTimePicker();
            ckbCompromisso = new CheckBox();
            groupBox1 = new GroupBox();
            txtLink = new TextBox();
            txtLocal = new TextBox();
            rbRemoto = new RadioButton();
            rBPresencial = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 137);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 27;
            label6.Text = "Início:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(271, 140);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 26;
            label5.Text = "Término:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 53);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 24;
            label3.Text = "Assunto:";
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(89, 50);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(149, 23);
            txtAssunto.TabIndex = 20;
            // 
            // txtId
            // 
            txtId.Location = new Point(89, 21);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 17;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 21);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 16;
            label1.Text = "Numero:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(568, 425);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(487, 425);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 14;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // cmbContatos
            // 
            cmbContatos.FormattingEnabled = true;
            cmbContatos.Location = new Point(173, 228);
            cmbContatos.Name = "cmbContatos";
            cmbContatos.Size = new Size(235, 23);
            cmbContatos.TabIndex = 28;
            // 
            // dateTimeData
            // 
            dateTimeData.Location = new Point(89, 79);
            dateTimeData.Name = "dateTimeData";
            dateTimeData.Size = new Size(235, 23);
            dateTimeData.TabIndex = 29;
            dateTimeData.Value = new DateTime(2023, 5, 18, 9, 25, 16, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 85);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 30;
            label2.Text = "Data:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(116, 231);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 31;
            label7.Text = "Contato:";
            // 
            // dateTimeInicio
            // 
            dateTimeInicio.CustomFormat = "HH:mm";
            dateTimeInicio.Location = new Point(89, 137);
            dateTimeInicio.Name = "dateTimeInicio";
            dateTimeInicio.Size = new Size(149, 23);
            dateTimeInicio.TabIndex = 33;
            dateTimeInicio.Value = new DateTime(2023, 5, 17, 15, 51, 0, 0);
            // 
            // dateTimeTermino
            // 
            dateTimeTermino.CustomFormat = "\"HH:mm\"";
            dateTimeTermino.Location = new Point(335, 137);
            dateTimeTermino.Name = "dateTimeTermino";
            dateTimeTermino.Size = new Size(149, 23);
            dateTimeTermino.TabIndex = 34;
            dateTimeTermino.Value = new DateTime(2023, 5, 17, 15, 51, 0, 0);
            // 
            // ckbCompromisso
            // 
            ckbCompromisso.AutoSize = true;
            ckbCompromisso.Location = new Point(116, 182);
            ckbCompromisso.Name = "ckbCompromisso";
            ckbCompromisso.Size = new Size(278, 19);
            ckbCompromisso.TabIndex = 35;
            ckbCompromisso.Text = "Deseja marcar um contato nesse compromisso?";
            ckbCompromisso.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLink);
            groupBox1.Controls.Add(txtLocal);
            groupBox1.Controls.Add(rbRemoto);
            groupBox1.Controls.Add(rBPresencial);
            groupBox1.Location = new Point(172, 290);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(418, 100);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Localização";
            // 
            // txtLink
            // 
            txtLink.Location = new Point(117, 49);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(260, 23);
            txtLink.TabIndex = 39;
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(117, 21);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(260, 23);
            txtLocal.TabIndex = 38;
            // 
            // rbRemoto
            // 
            rbRemoto.Location = new Point(35, 49);
            rbRemoto.Name = "rbRemoto";
            rbRemoto.Size = new Size(76, 24);
            rbRemoto.TabIndex = 40;
            rbRemoto.Text = "Remoto";
            // 
            // rBPresencial
            // 
            rBPresencial.AutoSize = true;
            rBPresencial.Location = new Point(35, 25);
            rBPresencial.Name = "rBPresencial";
            rBPresencial.Size = new Size(78, 19);
            rBPresencial.TabIndex = 0;
            rBPresencial.TabStop = true;
            rBPresencial.Text = "Presencial";
            rBPresencial.UseVisualStyleBackColor = true;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 478);
            Controls.Add(groupBox1);
            Controls.Add(ckbCompromisso);
            Controls.Add(dateTimeTermino);
            Controls.Add(dateTimeInicio);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(dateTimeData);
            Controls.Add(cmbContatos);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtAssunto);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCompromissoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Compromissos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox txtAssunto;
        private TextBox txtId;
        private Label label1;
        private Button btnCancelar;
        private Button btnGravar;
        private ComboBox cmbContatos;
        private DateTimePicker dateTimeData;
        private Label label2;
        private Label label7;
        private DateTimePicker dateTimeInicio;
        private DateTimePicker dateTimeTermino;
        private CheckBox ckbCompromisso;
        private GroupBox groupBox1;
        private RadioButton rbRemoto;
        private RadioButton rBPresencial;
        private TextBox txtLink;
        private TextBox txtLocal;
    }
}