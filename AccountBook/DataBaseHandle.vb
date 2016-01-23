Module DataBaseHandle
    '設定
    Private Prvd As String = "Microsoft.ACE.OLEDB.12.0" 'プロバイダ(accdb用)
    ' Private fol_name As String = "C:\test" 'DBが入ってるフォルダ
    Private DBName As String = "MoneyDataBase.accdb" 'DBファイル名

    Function DBAccess(SQLTxt As String)
        '接続文字列
        ' Dim Cn_txt As String = "Provider=" & Prvd & "; Data Source=" & fol_name & "\" & db_name
        Dim Cn_txt As String = "Provider=" & Prvd & "; Data Source=" & DBName

        'SQL文
        Dim SQL_txt As String = SQLTxt

        'データアダプターを生成
        Dim Adapter As New OleDb.OleDbDataAdapter(SQL_txt, Cn_txt)
        Return Adapter
    End Function

    Sub LoadMoney()
        ' データベース接続
        Dim Adapter As OleDb.OleDbDataAdapter = DBAccess("SELECT * FROM MoneyDataBase")

        'データの読み込み
        Dim MoneyDataBase As New DataTable()
        Adapter.Fill(MoneyDataBase)

        'データソースを設定してDataGridViewにデータを表示
        Dim MoneyBs As New BindingSource
        MoneyBs.DataSource = MoneyDataBase
        AccountBook.AccountDgv.DataSource = MoneyBs
        Adapter.Dispose()
    End Sub

    Sub EditMoney(SQLTxt As String)
        Dim Adapter As OleDb.OleDbDataAdapter = DBAccess(SQLTxt)
        Dim MoneyDataBase As New DataTable()
        Adapter.Fill(MoneyDataBase)
        Adapter.Dispose()
        LoadMoney()
    End Sub

End Module
