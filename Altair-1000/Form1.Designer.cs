namespace Altair_1000
{
    partial class FMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBank = new System.Windows.Forms.Panel();
            this.panelRam = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelIO = new System.Windows.Forms.Panel();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelInput = new System.Windows.Forms.Panel();
            this.terminalBox = new System.Windows.Forms.TextBox();
            this.groupInput = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnInputSend = new System.Windows.Forms.Button();
            this.panelReg = new System.Windows.Forms.Panel();
            this.groupReg = new System.Windows.Forms.GroupBox();
            this.gridReg = new System.Windows.Forms.DataGridView();
            this.RegName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataBin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelState = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.panelCPU = new System.Windows.Forms.Panel();
            this.groupState = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelStatStarting = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelStatService = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelStatWorking = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelStatDeInit = new System.Windows.Forms.Panel();
            this.groupCPU = new System.Windows.Forms.GroupBox();
            this.btnSwitchState = new System.Windows.Forms.Button();
            this.checkService = new System.Windows.Forms.CheckBox();
            this.labelError = new System.Windows.Forms.Label();
            this.panelStatError = new System.Windows.Forms.Panel();
            this.labelStatCPU = new System.Windows.Forms.Label();
            this.panelStatCPU = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textCPUCycles = new System.Windows.Forms.TextBox();
            this.groupCpuControl = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnCpuStep = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelIO.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.groupInput.SuspendLayout();
            this.panelReg.SuspendLayout();
            this.groupReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReg)).BeginInit();
            this.panelState.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.panelCPU.SuspendLayout();
            this.groupState.SuspendLayout();
            this.groupCPU.SuspendLayout();
            this.groupCpuControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelRight, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 731);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelRam);
            this.panel1.Controls.Add(this.panelBank);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 725);
            this.panel1.TabIndex = 0;
            // 
            // panelBank
            // 
            this.panelBank.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBank.Location = new System.Drawing.Point(0, 625);
            this.panelBank.Name = "panelBank";
            this.panelBank.Size = new System.Drawing.Size(436, 100);
            this.panelBank.TabIndex = 0;
            // 
            // panelRam
            // 
            this.panelRam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRam.Location = new System.Drawing.Point(0, 0);
            this.panelRam.Name = "panelRam";
            this.panelRam.Size = new System.Drawing.Size(436, 625);
            this.panelRam.TabIndex = 1;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.panelControl);
            this.panelRight.Controls.Add(this.panelIO);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(445, 3);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(436, 725);
            this.panelRight.TabIndex = 1;
            // 
            // panelIO
            // 
            this.panelIO.Controls.Add(this.terminalBox);
            this.panelIO.Controls.Add(this.panelInput);
            this.panelIO.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIO.Location = new System.Drawing.Point(0, 0);
            this.panelIO.Name = "panelIO";
            this.panelIO.Size = new System.Drawing.Size(436, 296);
            this.panelIO.TabIndex = 0;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.panelState);
            this.panelControl.Controls.Add(this.panelReg);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 296);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(436, 429);
            this.panelControl.TabIndex = 1;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.groupInput);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInput.Location = new System.Drawing.Point(0, 216);
            this.panelInput.Name = "panelInput";
            this.panelInput.Padding = new System.Windows.Forms.Padding(5);
            this.panelInput.Size = new System.Drawing.Size(436, 80);
            this.panelInput.TabIndex = 0;
            // 
            // terminalBox
            // 
            this.terminalBox.BackColor = System.Drawing.Color.Black;
            this.terminalBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.terminalBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.terminalBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.terminalBox.ForeColor = System.Drawing.Color.White;
            this.terminalBox.Location = new System.Drawing.Point(0, 0);
            this.terminalBox.Multiline = true;
            this.terminalBox.Name = "terminalBox";
            this.terminalBox.ReadOnly = true;
            this.terminalBox.Size = new System.Drawing.Size(436, 216);
            this.terminalBox.TabIndex = 1;
            this.terminalBox.Text = "Hello, World!\r\nSecond string\r\n123";
            // 
            // groupInput
            // 
            this.groupInput.Controls.Add(this.btnInputSend);
            this.groupInput.Controls.Add(this.textBox1);
            this.groupInput.Controls.Add(this.label1);
            this.groupInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupInput.Location = new System.Drawing.Point(5, 5);
            this.groupInput.Name = "groupInput";
            this.groupInput.Padding = new System.Windows.Forms.Padding(5);
            this.groupInput.Size = new System.Drawing.Size(426, 70);
            this.groupInput.TabIndex = 0;
            this.groupInput.TabStop = false;
            this.groupInput.Text = "Ввод данных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ввод неактивен";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(11, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnInputSend
            // 
            this.btnInputSend.Enabled = false;
            this.btnInputSend.Location = new System.Drawing.Point(277, 34);
            this.btnInputSend.Name = "btnInputSend";
            this.btnInputSend.Size = new System.Drawing.Size(141, 23);
            this.btnInputSend.TabIndex = 2;
            this.btnInputSend.Text = "Отправить";
            this.btnInputSend.UseVisualStyleBackColor = true;
            // 
            // panelReg
            // 
            this.panelReg.Controls.Add(this.groupReg);
            this.panelReg.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReg.Location = new System.Drawing.Point(0, 0);
            this.panelReg.Name = "panelReg";
            this.panelReg.Padding = new System.Windows.Forms.Padding(5);
            this.panelReg.Size = new System.Drawing.Size(436, 242);
            this.panelReg.TabIndex = 0;
            // 
            // groupReg
            // 
            this.groupReg.Controls.Add(this.gridReg);
            this.groupReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupReg.Location = new System.Drawing.Point(5, 5);
            this.groupReg.Name = "groupReg";
            this.groupReg.Size = new System.Drawing.Size(426, 232);
            this.groupReg.TabIndex = 0;
            this.groupReg.TabStop = false;
            this.groupReg.Text = "Состояние регистров";
            // 
            // gridReg
            // 
            this.gridReg.AllowUserToAddRows = false;
            this.gridReg.AllowUserToDeleteRows = false;
            this.gridReg.AllowUserToResizeColumns = false;
            this.gridReg.AllowUserToResizeRows = false;
            this.gridReg.BackgroundColor = System.Drawing.Color.White;
            this.gridReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegName,
            this.Addr,
            this.DataBin,
            this.DataDec});
            this.gridReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridReg.Location = new System.Drawing.Point(3, 16);
            this.gridReg.MultiSelect = false;
            this.gridReg.Name = "gridReg";
            this.gridReg.ReadOnly = true;
            this.gridReg.RowHeadersVisible = false;
            this.gridReg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridReg.Size = new System.Drawing.Size(420, 213);
            this.gridReg.TabIndex = 0;
            // 
            // RegName
            // 
            this.RegName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RegName.HeaderText = "Название";
            this.RegName.Name = "RegName";
            this.RegName.ReadOnly = true;
            this.RegName.Width = 82;
            // 
            // Addr
            // 
            this.Addr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Addr.HeaderText = "Адрес";
            this.Addr.Name = "Addr";
            this.Addr.ReadOnly = true;
            this.Addr.Width = 63;
            // 
            // DataBin
            // 
            this.DataBin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataBin.HeaderText = "Данные [BIN]";
            this.DataBin.Name = "DataBin";
            this.DataBin.ReadOnly = true;
            // 
            // DataDec
            // 
            this.DataDec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataDec.HeaderText = "Данные [DEC]";
            this.DataDec.Name = "DataDec";
            this.DataDec.ReadOnly = true;
            // 
            // panelState
            // 
            this.panelState.Controls.Add(this.panelCPU);
            this.panelState.Controls.Add(this.panelStatus);
            this.panelState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelState.Location = new System.Drawing.Point(0, 242);
            this.panelState.Name = "panelState";
            this.panelState.Size = new System.Drawing.Size(436, 187);
            this.panelState.TabIndex = 1;
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.groupState);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStatus.Location = new System.Drawing.Point(0, 0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Padding = new System.Windows.Forms.Padding(5);
            this.panelStatus.Size = new System.Drawing.Size(150, 187);
            this.panelStatus.TabIndex = 0;
            // 
            // panelCPU
            // 
            this.panelCPU.Controls.Add(this.groupCpuControl);
            this.panelCPU.Controls.Add(this.groupCPU);
            this.panelCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCPU.Location = new System.Drawing.Point(150, 0);
            this.panelCPU.Name = "panelCPU";
            this.panelCPU.Padding = new System.Windows.Forms.Padding(5);
            this.panelCPU.Size = new System.Drawing.Size(286, 187);
            this.panelCPU.TabIndex = 1;
            // 
            // groupState
            // 
            this.groupState.Controls.Add(this.labelError);
            this.groupState.Controls.Add(this.panelStatError);
            this.groupState.Controls.Add(this.checkService);
            this.groupState.Controls.Add(this.btnSwitchState);
            this.groupState.Controls.Add(this.label6);
            this.groupState.Controls.Add(this.panelStatDeInit);
            this.groupState.Controls.Add(this.label5);
            this.groupState.Controls.Add(this.panelStatWorking);
            this.groupState.Controls.Add(this.label4);
            this.groupState.Controls.Add(this.panelStatService);
            this.groupState.Controls.Add(this.label3);
            this.groupState.Controls.Add(this.panelStatStarting);
            this.groupState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupState.Location = new System.Drawing.Point(5, 5);
            this.groupState.Name = "groupState";
            this.groupState.Padding = new System.Windows.Forms.Padding(10);
            this.groupState.Size = new System.Drawing.Size(140, 177);
            this.groupState.TabIndex = 0;
            this.groupState.TabStop = false;
            this.groupState.Text = "Состояние машины";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(39, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Запускается";
            // 
            // panelStatStarting
            // 
            this.panelStatStarting.BackColor = System.Drawing.Color.DarkGray;
            this.panelStatStarting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatStarting.Location = new System.Drawing.Point(13, 25);
            this.panelStatStarting.Name = "panelStatStarting";
            this.panelStatStarting.Size = new System.Drawing.Size(20, 10);
            this.panelStatStarting.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(39, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Сервис";
            // 
            // panelStatService
            // 
            this.panelStatService.BackColor = System.Drawing.Color.DarkGray;
            this.panelStatService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatService.Location = new System.Drawing.Point(13, 38);
            this.panelStatService.Name = "panelStatService";
            this.panelStatService.Size = new System.Drawing.Size(20, 10);
            this.panelStatService.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(39, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Работает";
            // 
            // panelStatWorking
            // 
            this.panelStatWorking.BackColor = System.Drawing.Color.DarkGray;
            this.panelStatWorking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatWorking.Location = new System.Drawing.Point(13, 65);
            this.panelStatWorking.Name = "panelStatWorking";
            this.panelStatWorking.Size = new System.Drawing.Size(20, 10);
            this.panelStatWorking.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(39, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Выключается";
            // 
            // panelStatDeInit
            // 
            this.panelStatDeInit.BackColor = System.Drawing.Color.DarkGray;
            this.panelStatDeInit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatDeInit.Location = new System.Drawing.Point(13, 78);
            this.panelStatDeInit.Name = "panelStatDeInit";
            this.panelStatDeInit.Size = new System.Drawing.Size(20, 10);
            this.panelStatDeInit.TabIndex = 8;
            // 
            // groupCPU
            // 
            this.groupCPU.Controls.Add(this.textCPUCycles);
            this.groupCPU.Controls.Add(this.label2);
            this.groupCPU.Controls.Add(this.labelStatCPU);
            this.groupCPU.Controls.Add(this.panelStatCPU);
            this.groupCPU.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupCPU.Location = new System.Drawing.Point(5, 5);
            this.groupCPU.Name = "groupCPU";
            this.groupCPU.Padding = new System.Windows.Forms.Padding(10);
            this.groupCPU.Size = new System.Drawing.Size(276, 75);
            this.groupCPU.TabIndex = 0;
            this.groupCPU.TabStop = false;
            this.groupCPU.Text = "Процессор";
            // 
            // btnSwitchState
            // 
            this.btnSwitchState.Location = new System.Drawing.Point(13, 113);
            this.btnSwitchState.Name = "btnSwitchState";
            this.btnSwitchState.Size = new System.Drawing.Size(114, 23);
            this.btnSwitchState.TabIndex = 10;
            this.btnSwitchState.Text = "Запустить";
            this.btnSwitchState.UseVisualStyleBackColor = true;
            // 
            // checkService
            // 
            this.checkService.AutoSize = true;
            this.checkService.Location = new System.Drawing.Point(13, 144);
            this.checkService.Name = "checkService";
            this.checkService.Size = new System.Drawing.Size(120, 17);
            this.checkService.TabIndex = 11;
            this.checkService.Text = "Сервисный режим";
            this.checkService.UseVisualStyleBackColor = true;
            // 
            // labelError
            // 
            this.labelError.Location = new System.Drawing.Point(39, 49);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(100, 13);
            this.labelError.TabIndex = 13;
            this.labelError.Text = "Ошибка";
            // 
            // panelStatError
            // 
            this.panelStatError.BackColor = System.Drawing.Color.DarkGray;
            this.panelStatError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatError.Location = new System.Drawing.Point(13, 51);
            this.panelStatError.Name = "panelStatError";
            this.panelStatError.Size = new System.Drawing.Size(20, 10);
            this.panelStatError.TabIndex = 12;
            // 
            // labelStatCPU
            // 
            this.labelStatCPU.Location = new System.Drawing.Point(38, 22);
            this.labelStatCPU.Name = "labelStatCPU";
            this.labelStatCPU.Size = new System.Drawing.Size(100, 13);
            this.labelStatCPU.TabIndex = 15;
            this.labelStatCPU.Text = "Работает";
            // 
            // panelStatCPU
            // 
            this.panelStatCPU.BackColor = System.Drawing.Color.DarkGray;
            this.panelStatCPU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatCPU.Location = new System.Drawing.Point(12, 24);
            this.panelStatCPU.Name = "panelStatCPU";
            this.panelStatCPU.Size = new System.Drawing.Size(20, 10);
            this.panelStatCPU.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Тактов";
            // 
            // textCPUCycles
            // 
            this.textCPUCycles.Location = new System.Drawing.Point(58, 43);
            this.textCPUCycles.Name = "textCPUCycles";
            this.textCPUCycles.ReadOnly = true;
            this.textCPUCycles.Size = new System.Drawing.Size(210, 20);
            this.textCPUCycles.TabIndex = 17;
            this.textCPUCycles.Text = "0";
            this.textCPUCycles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupCpuControl
            // 
            this.groupCpuControl.Controls.Add(this.btnCpuStep);
            this.groupCpuControl.Controls.Add(this.numericUpDown1);
            this.groupCpuControl.Controls.Add(this.label7);
            this.groupCpuControl.Controls.Add(this.radioButton3);
            this.groupCpuControl.Controls.Add(this.radioButton2);
            this.groupCpuControl.Controls.Add(this.radioButton1);
            this.groupCpuControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupCpuControl.Location = new System.Drawing.Point(5, 80);
            this.groupCpuControl.Name = "groupCpuControl";
            this.groupCpuControl.Size = new System.Drawing.Size(276, 102);
            this.groupCpuControl.TabIndex = 1;
            this.groupCpuControl.TabStop = false;
            this.groupCpuControl.Text = "Управление процессором";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(44, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Нет";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(62, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Замедлить";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(149, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(82, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Пошаговое";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(12, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Микросекунд на операцию";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(158, 42);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(110, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnCpuStep
            // 
            this.btnCpuStep.Enabled = false;
            this.btnCpuStep.Location = new System.Drawing.Point(15, 69);
            this.btnCpuStep.Name = "btnCpuStep";
            this.btnCpuStep.Size = new System.Drawing.Size(253, 23);
            this.btnCpuStep.TabIndex = 5;
            this.btnCpuStep.Text = "Выполнить такт";
            this.btnCpuStep.UseVisualStyleBackColor = true;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 731);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Эмулятор компьютера Altair 1000";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelIO.ResumeLayout(false);
            this.panelIO.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.groupInput.ResumeLayout(false);
            this.groupInput.PerformLayout();
            this.panelReg.ResumeLayout(false);
            this.groupReg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridReg)).EndInit();
            this.panelState.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.panelCPU.ResumeLayout(false);
            this.groupState.ResumeLayout(false);
            this.groupState.PerformLayout();
            this.groupCPU.ResumeLayout(false);
            this.groupCPU.PerformLayout();
            this.groupCpuControl.ResumeLayout(false);
            this.groupCpuControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelRam;
        private System.Windows.Forms.Panel panelBank;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelIO;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.TextBox terminalBox;
        private System.Windows.Forms.GroupBox groupInput;
        private System.Windows.Forms.Button btnInputSend;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelReg;
        private System.Windows.Forms.GroupBox groupReg;
        private System.Windows.Forms.DataGridView gridReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataBin;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDec;
        private System.Windows.Forms.Panel panelState;
        private System.Windows.Forms.Panel panelCPU;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.GroupBox groupState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelStatDeInit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelStatWorking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelStatService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelStatStarting;
        private System.Windows.Forms.GroupBox groupCPU;
        private System.Windows.Forms.Button btnSwitchState;
        private System.Windows.Forms.CheckBox checkService;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Panel panelStatError;
        private System.Windows.Forms.Label labelStatCPU;
        private System.Windows.Forms.Panel panelStatCPU;
        private System.Windows.Forms.TextBox textCPUCycles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupCpuControl;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnCpuStep;
    }
}

