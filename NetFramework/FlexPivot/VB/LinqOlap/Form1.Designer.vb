﻿Namespace LinqFlexPivot
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">True if managed resources should be disposed; otherwise, False.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me._c1FlexPivotPage = New C1.Win.FlexPivot.C1FlexPivotPage()
            CType(Me._c1FlexPivotPage, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' _c1FlexPivotPage
            ' 
            Me._c1FlexPivotPage.Dock = DockStyle.Fill
            Me._c1FlexPivotPage.Location = New Point(0, 0)
            Me._c1FlexPivotPage.Margin = New Padding(3, 2, 3, 2)
            Me._c1FlexPivotPage.Name = "_c1FlexPivotPage"
            Me._c1FlexPivotPage.Size = New Size(957, 483)
            Me._c1FlexPivotPage.TabIndex = 3
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New SizeF(9.0F, 17.0F)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.ClientSize = New Size(957, 483)
            Me.Controls.Add(Me._c1FlexPivotPage)
            Me.Font = New Font("Verdana", 8.25F)
            Me.Margin = New Padding(4)
            Me.Name = "Form1"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "NorthWind Sales Data Analysis (with LINQ)"
            CType(Me._c1FlexPivotPage, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private _c1FlexPivotPage As C1.Win.FlexPivot.C1FlexPivotPage
    End Class
End Namespace

