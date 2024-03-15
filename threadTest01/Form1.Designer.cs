namespace threadTest01
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_totalCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_passCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_failCount = new System.Windows.Forms.TextBox();
            this.lb_AppName = new System.Windows.Forms.Label();
            this.lbRegion = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbResultConnect = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEnableAiroThrough = new System.Windows.Forms.Button();
            this.btnChangeATOutGain = new System.Windows.Forms.Button();
            this.btnClaim = new System.Windows.Forms.Button();
            this.btnChangeATOutGain2 = new System.Windows.Forms.Button();
            this.btnRoleChange = new System.Windows.Forms.Button();
            this.btnGetAEInfo = new System.Windows.Forms.Button();
            this.btnGetAgentBattery = new System.Windows.Forms.Button();
            this.btnGetPartnerBattery = new System.Windows.Forms.Button();
            this.btnGetPartnerAEInfo = new System.Windows.Forms.Button();
            this.btnGetAudioChannel = new System.Windows.Forms.Button();
            this.btnGetPartnerAudioChannel = new System.Windows.Forms.Button();
            this.btnGetAvaDst = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGetFWVersion = new System.Windows.Forms.Button();
            this.btnGetBDAddr = new System.Windows.Forms.Button();
            this.btnGetFWMode = new System.Windows.Forms.Button();
            this.tbResultFWVersion = new System.Windows.Forms.TextBox();
            this.tbResultBDAddr = new System.Windows.Forms.TextBox();
            this.tbResultFWMode = new System.Windows.Forms.TextBox();
            this.tbResultRWSStat = new System.Windows.Forms.TextBox();
            this.tbResultBATStatus = new System.Windows.Forms.TextBox();
            this.btnSetUserMode = new System.Windows.Forms.Button();
            this.btnSetFactorymode = new System.Windows.Forms.Button();
            this.btnFactoryReset = new System.Windows.Forms.Button();
            this.btnEnterDUTMode = new System.Windows.Forms.Button();
            this.btnGetBatlevel = new System.Windows.Forms.Button();
            this.btnTest1 = new System.Windows.Forms.Button();
            this.btnTest2 = new System.Windows.Forms.Button();
            this.tb_autotest_count = new System.Windows.Forms.TextBox();
            this.btnTest3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnFwVersion = new System.Windows.Forms.Button();
            this.btnPairingmode = new System.Windows.Forms.Button();
            this.btnToneGenerator = new System.Windows.Forms.Button();
            this.btnSetIGDownloadmode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 501);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.Location = new System.Drawing.Point(23, 790);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(1049, 78);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(638, 687);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // lbResult
            // 
            this.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResult.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbResult.Location = new System.Drawing.Point(640, 594);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(250, 190);
            this.lbResult.TabIndex = 4;
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(23, 594);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.Size = new System.Drawing.Size(609, 190);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(34, 555);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "TOTAL:";
            // 
            // tb_totalCount
            // 
            this.tb_totalCount.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_totalCount.Location = new System.Drawing.Point(131, 551);
            this.tb_totalCount.Name = "tb_totalCount";
            this.tb_totalCount.ReadOnly = true;
            this.tb_totalCount.Size = new System.Drawing.Size(167, 35);
            this.tb_totalCount.TabIndex = 7;
            this.tb_totalCount.TabStop = false;
            this.tb_totalCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(451, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "PASS:";
            // 
            // tb_passCount
            // 
            this.tb_passCount.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_passCount.Location = new System.Drawing.Point(535, 551);
            this.tb_passCount.Name = "tb_passCount";
            this.tb_passCount.ReadOnly = true;
            this.tb_passCount.Size = new System.Drawing.Size(156, 35);
            this.tb_passCount.TabIndex = 7;
            this.tb_passCount.TabStop = false;
            this.tb_passCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(842, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "FAIL:";
            // 
            // tb_failCount
            // 
            this.tb_failCount.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_failCount.Location = new System.Drawing.Point(911, 552);
            this.tb_failCount.Name = "tb_failCount";
            this.tb_failCount.ReadOnly = true;
            this.tb_failCount.Size = new System.Drawing.Size(159, 35);
            this.tb_failCount.TabIndex = 7;
            this.tb_failCount.TabStop = false;
            this.tb_failCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_AppName
            // 
            this.lb_AppName.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_AppName.Location = new System.Drawing.Point(23, 4);
            this.lb_AppName.Name = "lb_AppName";
            this.lb_AppName.Size = new System.Drawing.Size(1047, 37);
            this.lb_AppName.TabIndex = 8;
            this.lb_AppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRegion
            // 
            this.lbRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRegion.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbRegion.Location = new System.Drawing.Point(897, 594);
            this.lbRegion.Name = "lbRegion";
            this.lbRegion.Size = new System.Drawing.Size(173, 190);
            this.lbRegion.TabIndex = 9;
            this.lbRegion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(1123, 44);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(126, 23);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbResultConnect
            // 
            this.tbResultConnect.Location = new System.Drawing.Point(1256, 44);
            this.tbResultConnect.Name = "tbResultConnect";
            this.tbResultConnect.Size = new System.Drawing.Size(100, 21);
            this.tbResultConnect.TabIndex = 11;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(1123, 74);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(126, 23);
            this.btnDisconnect.TabIndex = 12;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1256, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 13;
            // 
            // btnEnableAiroThrough
            // 
            this.btnEnableAiroThrough.Location = new System.Drawing.Point(1123, 104);
            this.btnEnableAiroThrough.Name = "btnEnableAiroThrough";
            this.btnEnableAiroThrough.Size = new System.Drawing.Size(126, 23);
            this.btnEnableAiroThrough.TabIndex = 14;
            this.btnEnableAiroThrough.Text = "Enable AT";
            this.btnEnableAiroThrough.UseVisualStyleBackColor = true;
            this.btnEnableAiroThrough.Click += new System.EventHandler(this.btnEnableAiroThrough_Click);
            // 
            // btnChangeATOutGain
            // 
            this.btnChangeATOutGain.Location = new System.Drawing.Point(1123, 165);
            this.btnChangeATOutGain.Name = "btnChangeATOutGain";
            this.btnChangeATOutGain.Size = new System.Drawing.Size(126, 23);
            this.btnChangeATOutGain.TabIndex = 15;
            this.btnChangeATOutGain.Text = "AT Out Gain D -10";
            this.btnChangeATOutGain.UseVisualStyleBackColor = true;
            this.btnChangeATOutGain.Click += new System.EventHandler(this.btnChangeATOutGain_Click);
            // 
            // btnClaim
            // 
            this.btnClaim.Location = new System.Drawing.Point(1123, 134);
            this.btnClaim.Name = "btnClaim";
            this.btnClaim.Size = new System.Drawing.Size(126, 23);
            this.btnClaim.TabIndex = 16;
            this.btnClaim.Text = "Claim?";
            this.btnClaim.UseVisualStyleBackColor = true;
            this.btnClaim.Click += new System.EventHandler(this.btnClaim_Click);
            // 
            // btnChangeATOutGain2
            // 
            this.btnChangeATOutGain2.Location = new System.Drawing.Point(1123, 195);
            this.btnChangeATOutGain2.Name = "btnChangeATOutGain2";
            this.btnChangeATOutGain2.Size = new System.Drawing.Size(126, 23);
            this.btnChangeATOutGain2.TabIndex = 17;
            this.btnChangeATOutGain2.Text = "AT Out Gain D 10";
            this.btnChangeATOutGain2.UseVisualStyleBackColor = true;
            this.btnChangeATOutGain2.Click += new System.EventHandler(this.btnChangeATOutGain2_Click);
            // 
            // btnRoleChange
            // 
            this.btnRoleChange.Location = new System.Drawing.Point(1123, 236);
            this.btnRoleChange.Name = "btnRoleChange";
            this.btnRoleChange.Size = new System.Drawing.Size(126, 23);
            this.btnRoleChange.TabIndex = 18;
            this.btnRoleChange.Text = "Role Change";
            this.btnRoleChange.UseVisualStyleBackColor = true;
            this.btnRoleChange.Click += new System.EventHandler(this.btnRoleChange_Click);
            // 
            // btnGetAEInfo
            // 
            this.btnGetAEInfo.Location = new System.Drawing.Point(1123, 276);
            this.btnGetAEInfo.Name = "btnGetAEInfo";
            this.btnGetAEInfo.Size = new System.Drawing.Size(126, 23);
            this.btnGetAEInfo.TabIndex = 19;
            this.btnGetAEInfo.Text = "Get AE Info";
            this.btnGetAEInfo.UseVisualStyleBackColor = true;
            this.btnGetAEInfo.Click += new System.EventHandler(this.btnGetAEInfo_Click);
            // 
            // btnGetAgentBattery
            // 
            this.btnGetAgentBattery.Location = new System.Drawing.Point(1123, 316);
            this.btnGetAgentBattery.Name = "btnGetAgentBattery";
            this.btnGetAgentBattery.Size = new System.Drawing.Size(126, 23);
            this.btnGetAgentBattery.TabIndex = 20;
            this.btnGetAgentBattery.Text = "Agent Battery";
            this.btnGetAgentBattery.UseVisualStyleBackColor = true;
            this.btnGetAgentBattery.Click += new System.EventHandler(this.btnGetAgentBattery_Click);
            // 
            // btnGetPartnerBattery
            // 
            this.btnGetPartnerBattery.Location = new System.Drawing.Point(1266, 316);
            this.btnGetPartnerBattery.Name = "btnGetPartnerBattery";
            this.btnGetPartnerBattery.Size = new System.Drawing.Size(144, 23);
            this.btnGetPartnerBattery.TabIndex = 21;
            this.btnGetPartnerBattery.Text = "Partner Battery";
            this.btnGetPartnerBattery.UseVisualStyleBackColor = true;
            this.btnGetPartnerBattery.Click += new System.EventHandler(this.btnGetPartnerBattery_Click);
            // 
            // btnGetPartnerAEInfo
            // 
            this.btnGetPartnerAEInfo.Location = new System.Drawing.Point(1266, 276);
            this.btnGetPartnerAEInfo.Name = "btnGetPartnerAEInfo";
            this.btnGetPartnerAEInfo.Size = new System.Drawing.Size(144, 23);
            this.btnGetPartnerAEInfo.TabIndex = 22;
            this.btnGetPartnerAEInfo.Text = "Get Partner AE Info";
            this.btnGetPartnerAEInfo.UseVisualStyleBackColor = true;
            this.btnGetPartnerAEInfo.Click += new System.EventHandler(this.btnGetPartnerAEInfo_Click);
            // 
            // btnGetAudioChannel
            // 
            this.btnGetAudioChannel.Location = new System.Drawing.Point(1123, 358);
            this.btnGetAudioChannel.Name = "btnGetAudioChannel";
            this.btnGetAudioChannel.Size = new System.Drawing.Size(126, 23);
            this.btnGetAudioChannel.TabIndex = 23;
            this.btnGetAudioChannel.Text = "Get AUD Channel";
            this.btnGetAudioChannel.UseVisualStyleBackColor = true;
            this.btnGetAudioChannel.Click += new System.EventHandler(this.btnGetAudioChannel_Click);
            // 
            // btnGetPartnerAudioChannel
            // 
            this.btnGetPartnerAudioChannel.Location = new System.Drawing.Point(1266, 358);
            this.btnGetPartnerAudioChannel.Name = "btnGetPartnerAudioChannel";
            this.btnGetPartnerAudioChannel.Size = new System.Drawing.Size(197, 23);
            this.btnGetPartnerAudioChannel.TabIndex = 24;
            this.btnGetPartnerAudioChannel.Text = "Get Partner AUD Channel";
            this.btnGetPartnerAudioChannel.UseVisualStyleBackColor = true;
            this.btnGetPartnerAudioChannel.Click += new System.EventHandler(this.btnGetPartnerAudioChannel_Click);
            // 
            // btnGetAvaDst
            // 
            this.btnGetAvaDst.Location = new System.Drawing.Point(1123, 394);
            this.btnGetAvaDst.Name = "btnGetAvaDst";
            this.btnGetAvaDst.Size = new System.Drawing.Size(126, 23);
            this.btnGetAvaDst.TabIndex = 25;
            this.btnGetAvaDst.Text = "Get AVA DST";
            this.btnGetAvaDst.UseVisualStyleBackColor = true;
            this.btnGetAvaDst.Click += new System.EventHandler(this.btnGetAvaDst_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1266, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Get VP Lang ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGetAudioChannel_Click);
            // 
            // btnGetFWVersion
            // 
            this.btnGetFWVersion.Location = new System.Drawing.Point(1123, 439);
            this.btnGetFWVersion.Name = "btnGetFWVersion";
            this.btnGetFWVersion.Size = new System.Drawing.Size(100, 23);
            this.btnGetFWVersion.TabIndex = 26;
            this.btnGetFWVersion.Text = "Get FW ver";
            this.btnGetFWVersion.UseVisualStyleBackColor = true;
            this.btnGetFWVersion.Click += new System.EventHandler(this.btnGetFWVersion_Click);
            // 
            // btnGetBDAddr
            // 
            this.btnGetBDAddr.Location = new System.Drawing.Point(1123, 469);
            this.btnGetBDAddr.Name = "btnGetBDAddr";
            this.btnGetBDAddr.Size = new System.Drawing.Size(100, 23);
            this.btnGetBDAddr.TabIndex = 27;
            this.btnGetBDAddr.Text = "Get BD Addr";
            this.btnGetBDAddr.UseVisualStyleBackColor = true;
            this.btnGetBDAddr.Click += new System.EventHandler(this.btnGetBDAddr_Click);
            // 
            // btnGetFWMode
            // 
            this.btnGetFWMode.Location = new System.Drawing.Point(1123, 500);
            this.btnGetFWMode.Name = "btnGetFWMode";
            this.btnGetFWMode.Size = new System.Drawing.Size(100, 23);
            this.btnGetFWMode.TabIndex = 28;
            this.btnGetFWMode.Text = "Get FW Mode";
            this.btnGetFWMode.UseVisualStyleBackColor = true;
            this.btnGetFWMode.Click += new System.EventHandler(this.btnGetFWMode_Click);
            // 
            // tbResultFWVersion
            // 
            this.tbResultFWVersion.Location = new System.Drawing.Point(1344, 439);
            this.tbResultFWVersion.Name = "tbResultFWVersion";
            this.tbResultFWVersion.Size = new System.Drawing.Size(100, 21);
            this.tbResultFWVersion.TabIndex = 30;
            // 
            // tbResultBDAddr
            // 
            this.tbResultBDAddr.Location = new System.Drawing.Point(1344, 469);
            this.tbResultBDAddr.Name = "tbResultBDAddr";
            this.tbResultBDAddr.Size = new System.Drawing.Size(100, 21);
            this.tbResultBDAddr.TabIndex = 38;
            // 
            // tbResultFWMode
            // 
            this.tbResultFWMode.Location = new System.Drawing.Point(1344, 500);
            this.tbResultFWMode.Name = "tbResultFWMode";
            this.tbResultFWMode.Size = new System.Drawing.Size(100, 21);
            this.tbResultFWMode.TabIndex = 39;
            // 
            // tbResultRWSStat
            // 
            this.tbResultRWSStat.Location = new System.Drawing.Point(1344, 530);
            this.tbResultRWSStat.Name = "tbResultRWSStat";
            this.tbResultRWSStat.Size = new System.Drawing.Size(100, 21);
            this.tbResultRWSStat.TabIndex = 40;
            // 
            // tbResultBATStatus
            // 
            this.tbResultBATStatus.Location = new System.Drawing.Point(1344, 559);
            this.tbResultBATStatus.Name = "tbResultBATStatus";
            this.tbResultBATStatus.Size = new System.Drawing.Size(100, 21);
            this.tbResultBATStatus.TabIndex = 41;
            // 
            // btnSetUserMode
            // 
            this.btnSetUserMode.Location = new System.Drawing.Point(1229, 469);
            this.btnSetUserMode.Name = "btnSetUserMode";
            this.btnSetUserMode.Size = new System.Drawing.Size(100, 23);
            this.btnSetUserMode.TabIndex = 45;
            this.btnSetUserMode.Text = "Set Normal";
            this.btnSetUserMode.UseVisualStyleBackColor = true;
            this.btnSetUserMode.Click += new System.EventHandler(this.btnSetUserMode_Click);
            // 
            // btnSetFactorymode
            // 
            this.btnSetFactorymode.Location = new System.Drawing.Point(1229, 500);
            this.btnSetFactorymode.Name = "btnSetFactorymode";
            this.btnSetFactorymode.Size = new System.Drawing.Size(100, 23);
            this.btnSetFactorymode.TabIndex = 47;
            this.btnSetFactorymode.Text = "Set Factory";
            this.btnSetFactorymode.UseVisualStyleBackColor = true;
            this.btnSetFactorymode.Click += new System.EventHandler(this.btnSetFactorymode_Click);
            // 
            // btnFactoryReset
            // 
            this.btnFactoryReset.Location = new System.Drawing.Point(1229, 564);
            this.btnFactoryReset.Name = "btnFactoryReset";
            this.btnFactoryReset.Size = new System.Drawing.Size(100, 23);
            this.btnFactoryReset.TabIndex = 48;
            this.btnFactoryReset.Text = "Factory Reset";
            this.btnFactoryReset.UseVisualStyleBackColor = true;
            this.btnFactoryReset.Click += new System.EventHandler(this.btnFactoryReset_Click);
            // 
            // btnEnterDUTMode
            // 
            this.btnEnterDUTMode.Location = new System.Drawing.Point(1229, 593);
            this.btnEnterDUTMode.Name = "btnEnterDUTMode";
            this.btnEnterDUTMode.Size = new System.Drawing.Size(100, 23);
            this.btnEnterDUTMode.TabIndex = 49;
            this.btnEnterDUTMode.Text = "DUT Mode";
            this.btnEnterDUTMode.UseVisualStyleBackColor = true;
            this.btnEnterDUTMode.Click += new System.EventHandler(this.btnEnterDUTMode_Click);
            // 
            // btnGetBatlevel
            // 
            this.btnGetBatlevel.Location = new System.Drawing.Point(1229, 439);
            this.btnGetBatlevel.Name = "btnGetBatlevel";
            this.btnGetBatlevel.Size = new System.Drawing.Size(100, 23);
            this.btnGetBatlevel.TabIndex = 52;
            this.btnGetBatlevel.Text = "Get BAT Level";
            this.btnGetBatlevel.UseVisualStyleBackColor = true;
            this.btnGetBatlevel.Click += new System.EventHandler(this.btnGetBatlevel_Click);
            // 
            // btnTest1
            // 
            this.btnTest1.Location = new System.Drawing.Point(1344, 588);
            this.btnTest1.Name = "btnTest1";
            this.btnTest1.Size = new System.Drawing.Size(100, 23);
            this.btnTest1.TabIndex = 55;
            this.btnTest1.Text = "Write Color1";
            this.btnTest1.UseVisualStyleBackColor = true;
            this.btnTest1.Click += new System.EventHandler(this.btnTest1_Click);
            // 
            // btnTest2
            // 
            this.btnTest2.Location = new System.Drawing.Point(1344, 617);
            this.btnTest2.Name = "btnTest2";
            this.btnTest2.Size = new System.Drawing.Size(100, 23);
            this.btnTest2.TabIndex = 56;
            this.btnTest2.Text = "Write Color2";
            this.btnTest2.UseVisualStyleBackColor = true;
            this.btnTest2.Click += new System.EventHandler(this.btnTest2_Click);
            // 
            // tb_autotest_count
            // 
            this.tb_autotest_count.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_autotest_count.Location = new System.Drawing.Point(1363, 44);
            this.tb_autotest_count.Multiline = true;
            this.tb_autotest_count.Name = "tb_autotest_count";
            this.tb_autotest_count.Size = new System.Drawing.Size(100, 93);
            this.tb_autotest_count.TabIndex = 57;
            // 
            // btnTest3
            // 
            this.btnTest3.Location = new System.Drawing.Point(1344, 646);
            this.btnTest3.Name = "btnTest3";
            this.btnTest3.Size = new System.Drawing.Size(100, 23);
            this.btnTest3.TabIndex = 58;
            this.btnTest3.Text = "Write Color3";
            this.btnTest3.UseVisualStyleBackColor = true;
            this.btnTest3.Click += new System.EventHandler(this.btnTest3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1344, 734);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 61;
            this.button2.Text = "Write Color3_R";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1344, 705);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 60;
            this.button3.Text = "Write Color2_R";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1344, 676);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 59;
            this.button4.Text = "Write Color1_R";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnFwVersion
            // 
            this.btnFwVersion.Location = new System.Drawing.Point(1123, 594);
            this.btnFwVersion.Name = "btnFwVersion";
            this.btnFwVersion.Size = new System.Drawing.Size(100, 23);
            this.btnFwVersion.TabIndex = 64;
            this.btnFwVersion.Text = "Version Read";
            this.btnFwVersion.UseVisualStyleBackColor = true;
            this.btnFwVersion.Click += new System.EventHandler(this.btnVersionRead_Click);
            // 
            // btnPairingmode
            // 
            this.btnPairingmode.Location = new System.Drawing.Point(1123, 563);
            this.btnPairingmode.Name = "btnPairingmode";
            this.btnPairingmode.Size = new System.Drawing.Size(100, 23);
            this.btnPairingmode.TabIndex = 63;
            this.btnPairingmode.Text = "Pairing mode";
            this.btnPairingmode.UseVisualStyleBackColor = true;
            this.btnPairingmode.Click += new System.EventHandler(this.btnPairingmode_Click);
            // 
            // btnToneGenerator
            // 
            this.btnToneGenerator.Location = new System.Drawing.Point(1123, 533);
            this.btnToneGenerator.Name = "btnToneGenerator";
            this.btnToneGenerator.Size = new System.Drawing.Size(100, 23);
            this.btnToneGenerator.TabIndex = 62;
            this.btnToneGenerator.Text = "Tone Gen";
            this.btnToneGenerator.UseVisualStyleBackColor = true;
            this.btnToneGenerator.Click += new System.EventHandler(this.btnToneGenerator_Click);
            // 
            // btnSetIGDownloadmode
            // 
            this.btnSetIGDownloadmode.Location = new System.Drawing.Point(1229, 533);
            this.btnSetIGDownloadmode.Name = "btnSetIGDownloadmode";
            this.btnSetIGDownloadmode.Size = new System.Drawing.Size(100, 23);
            this.btnSetIGDownloadmode.TabIndex = 65;
            this.btnSetIGDownloadmode.Text = "Set IG mode";
            this.btnSetIGDownloadmode.UseVisualStyleBackColor = true;
            this.btnSetIGDownloadmode.Click += new System.EventHandler(this.btnSetIGDownloadmode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 880);
            this.Controls.Add(this.btnSetIGDownloadmode);
            this.Controls.Add(this.btnFwVersion);
            this.Controls.Add(this.btnPairingmode);
            this.Controls.Add(this.btnToneGenerator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnTest3);
            this.Controls.Add(this.tb_autotest_count);
            this.Controls.Add(this.btnTest2);
            this.Controls.Add(this.btnTest1);
            this.Controls.Add(this.btnGetBatlevel);
            this.Controls.Add(this.btnEnterDUTMode);
            this.Controls.Add(this.btnFactoryReset);
            this.Controls.Add(this.btnSetFactorymode);
            this.Controls.Add(this.btnSetUserMode);
            this.Controls.Add(this.tbResultBATStatus);
            this.Controls.Add(this.tbResultRWSStat);
            this.Controls.Add(this.tbResultFWMode);
            this.Controls.Add(this.tbResultBDAddr);
            this.Controls.Add(this.tbResultFWVersion);
            this.Controls.Add(this.btnGetFWMode);
            this.Controls.Add(this.btnGetBDAddr);
            this.Controls.Add(this.btnGetFWVersion);
            this.Controls.Add(this.btnGetAvaDst);
            this.Controls.Add(this.btnGetPartnerAudioChannel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGetAudioChannel);
            this.Controls.Add(this.btnGetPartnerAEInfo);
            this.Controls.Add(this.btnGetPartnerBattery);
            this.Controls.Add(this.btnGetAgentBattery);
            this.Controls.Add(this.btnGetAEInfo);
            this.Controls.Add(this.btnRoleChange);
            this.Controls.Add(this.btnChangeATOutGain2);
            this.Controls.Add(this.btnClaim);
            this.Controls.Add(this.btnChangeATOutGain);
            this.Controls.Add(this.btnEnableAiroThrough);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.tbResultConnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lbRegion);
            this.Controls.Add(this.lb_AppName);
            this.Controls.Add(this.tb_failCount);
            this.Controls.Add(this.tb_passCount);
            this.Controls.Add(this.tb_totalCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_totalCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_passCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_failCount;
        private System.Windows.Forms.Label lb_AppName;
        private System.Windows.Forms.Label lbRegion;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbResultConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEnableAiroThrough;
        private System.Windows.Forms.Button btnChangeATOutGain;
        private System.Windows.Forms.Button btnClaim;
        private System.Windows.Forms.Button btnChangeATOutGain2;
        private System.Windows.Forms.Button btnRoleChange;
        private System.Windows.Forms.Button btnGetAEInfo;
        private System.Windows.Forms.Button btnGetAgentBattery;
        private System.Windows.Forms.Button btnGetPartnerBattery;
        private System.Windows.Forms.Button btnGetPartnerAEInfo;
        private System.Windows.Forms.Button btnGetAudioChannel;
        private System.Windows.Forms.Button btnGetPartnerAudioChannel;
        private System.Windows.Forms.Button btnGetAvaDst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGetFWVersion;
        private System.Windows.Forms.Button btnGetBDAddr;
        private System.Windows.Forms.Button btnGetFWMode;
        private System.Windows.Forms.TextBox tbResultBDAddr;
        private System.Windows.Forms.TextBox tbResultFWMode;
        private System.Windows.Forms.TextBox tbResultRWSStat;
        private System.Windows.Forms.TextBox tbResultBATStatus;
        private System.Windows.Forms.Button btnSetUserMode;
        private System.Windows.Forms.Button btnSetFactorymode;
        private System.Windows.Forms.Button btnFactoryReset;
        private System.Windows.Forms.Button btnEnterDUTMode;
        private System.Windows.Forms.Button btnGetBatlevel;
        public System.Windows.Forms.TextBox tbResultFWVersion;
        private System.Windows.Forms.Button btnTest1;
        private System.Windows.Forms.Button btnTest2;
        private System.Windows.Forms.TextBox tb_autotest_count;
        private System.Windows.Forms.Button btnTest3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnFwVersion;
        private System.Windows.Forms.Button btnPairingmode;
        private System.Windows.Forms.Button btnToneGenerator;
        private System.Windows.Forms.Button btnSetIGDownloadmode;
    }
}

