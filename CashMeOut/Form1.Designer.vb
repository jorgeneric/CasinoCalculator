<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblDaveCasino = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSlots = New System.Windows.Forms.TextBox()
        Me.txtBlackJack = New System.Windows.Forms.TextBox()
        Me.txtPoker = New System.Windows.Forms.TextBox()
        Me.txtRoulette = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtSlotsPct = New System.Windows.Forms.TextBox()
        Me.txtBlackJackPct = New System.Windows.Forms.TextBox()
        Me.txtPokerPct = New System.Windows.Forms.TextBox()
        Me.txtRoulettePct = New System.Windows.Forms.TextBox()
        Me.txtTotalPct = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDaveCasino
        '
        Me.lblDaveCasino.AutoSize = True
        Me.lblDaveCasino.Font = New System.Drawing.Font("Lucida Handwriting", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaveCasino.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblDaveCasino.Location = New System.Drawing.Point(117, 68)
        Me.lblDaveCasino.Name = "lblDaveCasino"
        Me.lblDaveCasino.Size = New System.Drawing.Size(539, 83)
        Me.lblDaveCasino.TabIndex = 0
        Me.lblDaveCasino.Text = "Dave's Casino"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Slots"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Black Jack"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 307)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Poker"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(112, 363)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Roulette"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(112, 419)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Total Take"
        '
        'txtSlots
        '
        Me.txtSlots.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSlots.Location = New System.Drawing.Point(241, 189)
        Me.txtSlots.Name = "txtSlots"
        Me.txtSlots.Size = New System.Drawing.Size(132, 26)
        Me.txtSlots.TabIndex = 0
        Me.txtSlots.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBlackJack
        '
        Me.txtBlackJack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBlackJack.Location = New System.Drawing.Point(241, 245)
        Me.txtBlackJack.Name = "txtBlackJack"
        Me.txtBlackJack.Size = New System.Drawing.Size(132, 26)
        Me.txtBlackJack.TabIndex = 1
        Me.txtBlackJack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPoker
        '
        Me.txtPoker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoker.Location = New System.Drawing.Point(241, 301)
        Me.txtPoker.Name = "txtPoker"
        Me.txtPoker.Size = New System.Drawing.Size(132, 26)
        Me.txtPoker.TabIndex = 2
        Me.txtPoker.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRoulette
        '
        Me.txtRoulette.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoulette.Location = New System.Drawing.Point(241, 357)
        Me.txtRoulette.Name = "txtRoulette"
        Me.txtRoulette.Size = New System.Drawing.Size(132, 26)
        Me.txtRoulette.TabIndex = 3
        Me.txtRoulette.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(241, 413)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(132, 26)
        Me.txtTotal.TabIndex = 10
        Me.txtTotal.TabStop = False
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSlotsPct
        '
        Me.txtSlotsPct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSlotsPct.Location = New System.Drawing.Point(432, 189)
        Me.txtSlotsPct.Name = "txtSlotsPct"
        Me.txtSlotsPct.ReadOnly = True
        Me.txtSlotsPct.Size = New System.Drawing.Size(88, 26)
        Me.txtSlotsPct.TabIndex = 11
        Me.txtSlotsPct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBlackJackPct
        '
        Me.txtBlackJackPct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBlackJackPct.Location = New System.Drawing.Point(432, 245)
        Me.txtBlackJackPct.Name = "txtBlackJackPct"
        Me.txtBlackJackPct.ReadOnly = True
        Me.txtBlackJackPct.Size = New System.Drawing.Size(88, 26)
        Me.txtBlackJackPct.TabIndex = 12
        Me.txtBlackJackPct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPokerPct
        '
        Me.txtPokerPct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPokerPct.Location = New System.Drawing.Point(432, 301)
        Me.txtPokerPct.Name = "txtPokerPct"
        Me.txtPokerPct.ReadOnly = True
        Me.txtPokerPct.Size = New System.Drawing.Size(88, 26)
        Me.txtPokerPct.TabIndex = 13
        Me.txtPokerPct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRoulettePct
        '
        Me.txtRoulettePct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoulettePct.Location = New System.Drawing.Point(432, 357)
        Me.txtRoulettePct.Name = "txtRoulettePct"
        Me.txtRoulettePct.ReadOnly = True
        Me.txtRoulettePct.Size = New System.Drawing.Size(88, 26)
        Me.txtRoulettePct.TabIndex = 14
        Me.txtRoulettePct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalPct
        '
        Me.txtTotalPct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPct.Location = New System.Drawing.Point(432, 413)
        Me.txtTotalPct.Name = "txtTotalPct"
        Me.txtTotalPct.ReadOnly = True
        Me.txtTotalPct.Size = New System.Drawing.Size(88, 26)
        Me.txtTotalPct.TabIndex = 15
        Me.txtTotalPct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(590, 189)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(140, 26)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(590, 245)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(140, 26)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(590, 301)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(140, 26)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit Program"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(549, 363)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 204)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 734)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtTotalPct)
        Me.Controls.Add(Me.txtRoulettePct)
        Me.Controls.Add(Me.txtPokerPct)
        Me.Controls.Add(Me.txtBlackJackPct)
        Me.Controls.Add(Me.txtSlotsPct)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtRoulette)
        Me.Controls.Add(Me.txtPoker)
        Me.Controls.Add(Me.txtBlackJack)
        Me.Controls.Add(Me.txtSlots)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDaveCasino)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDaveCasino As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSlots As TextBox
    Friend WithEvents txtBlackJack As TextBox
    Friend WithEvents txtPoker As TextBox
    Friend WithEvents txtRoulette As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtSlotsPct As TextBox
    Friend WithEvents txtBlackJackPct As TextBox
    Friend WithEvents txtPokerPct As TextBox
    Friend WithEvents txtRoulettePct As TextBox
    Friend WithEvents txtTotalPct As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
