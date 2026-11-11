namespace ExpressionParser.Views;

partial class MainView
{
    private System.ComponentModel.IContainer components = null;

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
        AntdUI.Tabs.StyleLine styleLine1 = new AntdUI.Tabs.StyleLine();
        tabsMain = new AntdUI.Tabs();
        pageCalculator = new AntdUI.TabPage();
        label1 = new AntdUI.Label();
        txtCalcExpression = new AntdUI.Input();
        lblCalcResult = new AntdUI.Label();
        btnOpenParen = new AntdUI.Button();
        btnCloseParen = new AntdUI.Button();
        btnBackspace = new AntdUI.Button();
        btnClear = new AntdUI.Button();
        btn7 = new AntdUI.Button();
        btn8 = new AntdUI.Button();
        btn9 = new AntdUI.Button();
        btnDivide = new AntdUI.Button();
        btn4 = new AntdUI.Button();
        btn5 = new AntdUI.Button();
        btn6 = new AntdUI.Button();
        btnMultiply = new AntdUI.Button();
        btn1 = new AntdUI.Button();
        btn2 = new AntdUI.Button();
        btn3 = new AntdUI.Button();
        btnMinus = new AntdUI.Button();
        btn0 = new AntdUI.Button();
        btnDot = new AntdUI.Button();
        btnEqual = new AntdUI.Button();
        btnPlus = new AntdUI.Button();
        pageText = new AntdUI.TabPage();
        lblExprTitle = new AntdUI.Label();
        txtExpression = new AntdUI.Input();
        btnCalculate = new AntdUI.Button();
        lblStatusTitle = new AntdUI.Label();
        lblResult = new AntdUI.Label();
        tabsMain.SuspendLayout();
        pageCalculator.SuspendLayout();
        pageText.SuspendLayout();
        SuspendLayout();
        // 
        // tabsMain
        // 
        tabsMain.Controls.Add(pageCalculator);
        tabsMain.Controls.Add(pageText);
        tabsMain.Cursor = System.Windows.Forms.Cursors.Hand;
        tabsMain.Dock = System.Windows.Forms.DockStyle.Fill;
        tabsMain.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        tabsMain.Location = new System.Drawing.Point(0, 0);
        tabsMain.Name = "tabsMain";
        tabsMain.Pages.Add(pageText);
        tabsMain.Pages.Add(pageCalculator);
        tabsMain.SelectedIndex = 1;
        tabsMain.Size = new System.Drawing.Size(820, 560);
        tabsMain.Style = styleLine1;
        tabsMain.TabIndex = 0;
        // 
        // pageCalculator
        // 
        pageCalculator.Controls.Add(label1);
        pageCalculator.Controls.Add(txtCalcExpression);
        pageCalculator.Controls.Add(lblCalcResult);
        pageCalculator.Controls.Add(btnOpenParen);
        pageCalculator.Controls.Add(btnCloseParen);
        pageCalculator.Controls.Add(btnBackspace);
        pageCalculator.Controls.Add(btnClear);
        pageCalculator.Controls.Add(btn7);
        pageCalculator.Controls.Add(btn8);
        pageCalculator.Controls.Add(btn9);
        pageCalculator.Controls.Add(btnDivide);
        pageCalculator.Controls.Add(btn4);
        pageCalculator.Controls.Add(btn5);
        pageCalculator.Controls.Add(btn6);
        pageCalculator.Controls.Add(btnMultiply);
        pageCalculator.Controls.Add(btn1);
        pageCalculator.Controls.Add(btn2);
        pageCalculator.Controls.Add(btn3);
        pageCalculator.Controls.Add(btnMinus);
        pageCalculator.Controls.Add(btn0);
        pageCalculator.Controls.Add(btnDot);
        pageCalculator.Controls.Add(btnEqual);
        pageCalculator.Controls.Add(btnPlus);
        pageCalculator.Location = new System.Drawing.Point(0, 41);
        pageCalculator.Name = "pageCalculator";
        pageCalculator.Size = new System.Drawing.Size(820, 519);
        pageCalculator.TabIndex = 1;
        pageCalculator.Text = "  Bàn phím máy tính  ";
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 10F);
        label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)140)), ((int)((byte)140)), ((int)((byte)140)));
        label1.Location = new System.Drawing.Point(176, 68);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(471, 28);
        label1.TabIndex = 22;
        label1.Text = "Kết quả phân giải & tính toán:";
        // 
        // txtCalcExpression
        // 
        txtCalcExpression.Font = new System.Drawing.Font("Segoe UI", 13F);
        txtCalcExpression.Location = new System.Drawing.Point(160, 20);
        txtCalcExpression.Name = "txtCalcExpression";
        txtCalcExpression.PlaceholderText = "Biểu thức: (ví dụ: (8 + 2) * 5)";
        txtCalcExpression.Radius = 8;
        txtCalcExpression.ReadOnly = true;
        txtCalcExpression.Size = new System.Drawing.Size(500, 42);
        txtCalcExpression.TabIndex = 0;
        // 
        // lblCalcResult
        // 
        lblCalcResult.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
        lblCalcResult.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)38)), ((int)((byte)38)), ((int)((byte)38)));
        lblCalcResult.Location = new System.Drawing.Point(176, 102);
        lblCalcResult.Name = "lblCalcResult";
        lblCalcResult.Size = new System.Drawing.Size(471, 79);
        lblCalcResult.TabIndex = 1;
        lblCalcResult.Text = "";
        lblCalcResult.TextAlign = System.Drawing.ContentAlignment.TopLeft;
        // 
        // btnOpenParen
        // 
        btnOpenParen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnOpenParen.Location = new System.Drawing.Point(163, 187);
        btnOpenParen.Name = "btnOpenParen";
        btnOpenParen.Radius = 8;
        btnOpenParen.Size = new System.Drawing.Size(110, 46);
        btnOpenParen.TabIndex = 2;
        btnOpenParen.Text = "(";
        // 
        // btnCloseParen
        // 
        btnCloseParen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnCloseParen.Location = new System.Drawing.Point(293, 187);
        btnCloseParen.Name = "btnCloseParen";
        btnCloseParen.Radius = 8;
        btnCloseParen.Size = new System.Drawing.Size(110, 46);
        btnCloseParen.TabIndex = 3;
        btnCloseParen.Text = ")";
        // 
        // btnBackspace
        // 
        btnBackspace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnBackspace.Location = new System.Drawing.Point(423, 187);
        btnBackspace.Name = "btnBackspace";
        btnBackspace.Radius = 8;
        btnBackspace.Size = new System.Drawing.Size(110, 46);
        btnBackspace.TabIndex = 4;
        btnBackspace.Text = "⌫";
        // 
        // btnClear
        // 
        btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnClear.Location = new System.Drawing.Point(553, 187);
        btnClear.Name = "btnClear";
        btnClear.Radius = 8;
        btnClear.Size = new System.Drawing.Size(110, 46);
        btnClear.TabIndex = 5;
        btnClear.Text = "C";
        // 
        // btn7
        // 
        btn7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn7.Location = new System.Drawing.Point(163, 245);
        btn7.Name = "btn7";
        btn7.Radius = 8;
        btn7.Size = new System.Drawing.Size(110, 46);
        btn7.TabIndex = 6;
        btn7.Text = "7";
        // 
        // btn8
        // 
        btn8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn8.Location = new System.Drawing.Point(293, 245);
        btn8.Name = "btn8";
        btn8.Radius = 8;
        btn8.Size = new System.Drawing.Size(110, 46);
        btn8.TabIndex = 7;
        btn8.Text = "8";
        // 
        // btn9
        // 
        btn9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn9.Location = new System.Drawing.Point(423, 245);
        btn9.Name = "btn9";
        btn9.Radius = 8;
        btn9.Size = new System.Drawing.Size(110, 46);
        btn9.TabIndex = 8;
        btn9.Text = "9";
        // 
        // btnDivide
        // 
        btnDivide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnDivide.Location = new System.Drawing.Point(553, 245);
        btnDivide.Name = "btnDivide";
        btnDivide.Radius = 8;
        btnDivide.Size = new System.Drawing.Size(110, 46);
        btnDivide.TabIndex = 9;
        btnDivide.Text = "/";
        // 
        // btn4
        // 
        btn4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn4.Location = new System.Drawing.Point(163, 303);
        btn4.Name = "btn4";
        btn4.Radius = 8;
        btn4.Size = new System.Drawing.Size(110, 46);
        btn4.TabIndex = 10;
        btn4.Text = "4";
        // 
        // btn5
        // 
        btn5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn5.Location = new System.Drawing.Point(293, 303);
        btn5.Name = "btn5";
        btn5.Radius = 8;
        btn5.Size = new System.Drawing.Size(110, 46);
        btn5.TabIndex = 11;
        btn5.Text = "5";
        // 
        // btn6
        // 
        btn6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn6.Location = new System.Drawing.Point(423, 303);
        btn6.Name = "btn6";
        btn6.Radius = 8;
        btn6.Size = new System.Drawing.Size(110, 46);
        btn6.TabIndex = 12;
        btn6.Text = "6";
        // 
        // btnMultiply
        // 
        btnMultiply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnMultiply.Location = new System.Drawing.Point(553, 303);
        btnMultiply.Name = "btnMultiply";
        btnMultiply.Radius = 8;
        btnMultiply.Size = new System.Drawing.Size(110, 46);
        btnMultiply.TabIndex = 13;
        btnMultiply.Text = "*";
        // 
        // btn1
        // 
        btn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn1.Location = new System.Drawing.Point(163, 361);
        btn1.Name = "btn1";
        btn1.Radius = 8;
        btn1.Size = new System.Drawing.Size(110, 46);
        btn1.TabIndex = 14;
        btn1.Text = "1";
        // 
        // btn2
        // 
        btn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn2.Location = new System.Drawing.Point(293, 361);
        btn2.Name = "btn2";
        btn2.Radius = 8;
        btn2.Size = new System.Drawing.Size(110, 46);
        btn2.TabIndex = 15;
        btn2.Text = "2";
        // 
        // btn3
        // 
        btn3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn3.Location = new System.Drawing.Point(423, 361);
        btn3.Name = "btn3";
        btn3.Radius = 8;
        btn3.Size = new System.Drawing.Size(110, 46);
        btn3.TabIndex = 16;
        btn3.Text = "3";
        // 
        // btnMinus
        // 
        btnMinus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnMinus.Location = new System.Drawing.Point(553, 361);
        btnMinus.Name = "btnMinus";
        btnMinus.Radius = 8;
        btnMinus.Size = new System.Drawing.Size(110, 46);
        btnMinus.TabIndex = 17;
        btnMinus.Text = "-";
        // 
        // btn0
        // 
        btn0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btn0.Location = new System.Drawing.Point(163, 419);
        btn0.Name = "btn0";
        btn0.Radius = 8;
        btn0.Size = new System.Drawing.Size(110, 46);
        btn0.TabIndex = 18;
        btn0.Text = "0";
        // 
        // btnDot
        // 
        btnDot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnDot.Location = new System.Drawing.Point(293, 419);
        btnDot.Name = "btnDot";
        btnDot.Radius = 8;
        btnDot.Size = new System.Drawing.Size(110, 46);
        btnDot.TabIndex = 19;
        btnDot.Text = ".";
        // 
        // btnEqual
        // 
        btnEqual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnEqual.Location = new System.Drawing.Point(423, 419);
        btnEqual.Name = "btnEqual";
        btnEqual.Radius = 8;
        btnEqual.Size = new System.Drawing.Size(110, 46);
        btnEqual.TabIndex = 20;
        btnEqual.Text = "=";
        btnEqual.Type = AntdUI.TTypeMini.Primary;
        // 
        // btnPlus
        // 
        btnPlus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnPlus.Location = new System.Drawing.Point(553, 419);
        btnPlus.Name = "btnPlus";
        btnPlus.Radius = 8;
        btnPlus.Size = new System.Drawing.Size(110, 46);
        btnPlus.TabIndex = 21;
        btnPlus.Text = "+";
        // 
        // pageText
        // 
        pageText.Controls.Add(lblExprTitle);
        pageText.Controls.Add(txtExpression);
        pageText.Controls.Add(btnCalculate);
        pageText.Controls.Add(lblStatusTitle);
        pageText.Controls.Add(lblResult);
        pageText.Location = new System.Drawing.Point(-1640, -1038);
        pageText.Name = "pageText";
        pageText.Size = new System.Drawing.Size(820, 519);
        pageText.TabIndex = 0;
        pageText.Text = "  Nhập chuỗi biểu thức  ";
        // 
        // lblExprTitle
        // 
        lblExprTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblExprTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)38)), ((int)((byte)38)), ((int)((byte)38)));
        lblExprTitle.Location = new System.Drawing.Point(50, 40);
        lblExprTitle.Name = "lblExprTitle";
        lblExprTitle.Size = new System.Drawing.Size(720, 32);
        lblExprTitle.TabIndex = 0;
        lblExprTitle.Text = "Nhập biểu thức số học:";
        // 
        // txtExpression
        // 
        txtExpression.AllowClear = true;
        txtExpression.Font = new System.Drawing.Font("Segoe UI", 12F);
        txtExpression.Location = new System.Drawing.Point(50, 80);
        txtExpression.Name = "txtExpression";
        txtExpression.PlaceholderText = "Ví dụ: 2 * (3 + 6) / 4 hoặc 8 - 3 - 2";
        txtExpression.Radius = 8;
        txtExpression.Size = new System.Drawing.Size(540, 46);
        txtExpression.TabIndex = 1;
        // 
        // btnCalculate
        // 
        btnCalculate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        btnCalculate.Location = new System.Drawing.Point(605, 80);
        btnCalculate.Name = "btnCalculate";
        btnCalculate.Radius = 8;
        btnCalculate.Size = new System.Drawing.Size(165, 46);
        btnCalculate.TabIndex = 2;
        btnCalculate.Text = "Tính giá trị";
        btnCalculate.Type = AntdUI.TTypeMini.Primary;
        // 
        // lblStatusTitle
        // 
        lblStatusTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
        lblStatusTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)140)), ((int)((byte)140)), ((int)((byte)140)));
        lblStatusTitle.Location = new System.Drawing.Point(50, 155);
        lblStatusTitle.Name = "lblStatusTitle";
        lblStatusTitle.Size = new System.Drawing.Size(720, 28);
        lblStatusTitle.TabIndex = 3;
        lblStatusTitle.Text = "Kết quả phân giải & tính toán:";
        // 
        // lblResult
        // 
        lblResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)38)), ((int)((byte)38)), ((int)((byte)38)));
        lblResult.Location = new System.Drawing.Point(50, 190);
        lblResult.Name = "lblResult";
        lblResult.Size = new System.Drawing.Size(720, 143);
        lblResult.TabIndex = 4;
        lblResult.Text = "";
        lblResult.TextAlign = System.Drawing.ContentAlignment.TopLeft;
        // 
        // MainView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        ClientSize = new System.Drawing.Size(820, 560);
        Controls.Add(tabsMain);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Phân giải và tính toán biểu thức số học";
        tabsMain.ResumeLayout(false);
        pageCalculator.ResumeLayout(false);
        pageText.ResumeLayout(false);
        ResumeLayout(false);
    }

    private AntdUI.Tabs tabsMain;
    private AntdUI.TabPage pageText;
    private AntdUI.TabPage pageCalculator;

    // Controls for Tab 1
    private AntdUI.Label lblExprTitle;
    private AntdUI.Input txtExpression;
    private AntdUI.Button btnCalculate;
    private AntdUI.Label lblStatusTitle;
    private AntdUI.Label lblResult;

    // Controls for Tab 2
    private AntdUI.Input txtCalcExpression;
    private AntdUI.Label lblCalcResult;

    private AntdUI.Button btnOpenParen;
    private AntdUI.Button btnCloseParen;
    private AntdUI.Button btnBackspace;
    private AntdUI.Button btnClear;

    private AntdUI.Button btn7;
    private AntdUI.Button btn8;
    private AntdUI.Button btn9;
    private AntdUI.Button btnDivide;

    private AntdUI.Button btn4;
    private AntdUI.Button btn5;
    private AntdUI.Button btn6;
    private AntdUI.Button btnMultiply;

    private AntdUI.Button btn1;
    private AntdUI.Button btn2;
    private AntdUI.Button btn3;
    private AntdUI.Button btnMinus;

    private AntdUI.Button btn0;
    private AntdUI.Button btnDot;
    private AntdUI.Button btnEqual;
    private AntdUI.Button btnPlus;

    #endregion

    private AntdUI.Label label1;
}
