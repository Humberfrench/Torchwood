Imports Consumer.Data
Namespace Data

    Public Class Dezenas
        Implements IDisposable
#Region "Variáveis"
        Private disposedValue As Boolean = False        ' To detect redundant calls
        Private objLotoFacil As Struct.LotoFacil
        Private objLotoMania As Struct.LotoMania
        Private objSena As Struct.Sena
        Private objQuina As Struct.Quina
        Private objTimeMania As Struct.TimeMania
        Private strKey As String
#End Region

#Region "Construtor"

        Public Sub New()

            objLotoFacil = New Struct.LotoFacil
            objLotoMania = New Struct.LotoMania
            objSena = New Struct.Sena
            objQuina = New Struct.Quina
            objTimeMania = New Struct.TimeMania

        End Sub

        Public Sub New(ByVal pstrKey As String)

            Me.New()
            strKey = pstrKey

        End Sub

#End Region

#Region " IDisposable Support "
        ' IDisposable
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    objLotoFacil = Nothing
                    objLotoMania = Nothing
                    objSena = Nothing
                    objQuina = Nothing
                    objTimeMania = Nothing
                End If
            End If
            Me.disposedValue = True
        End Sub
        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region

#Region "Properties"

        ''' <summary>
        ''' Chave para a conexão com o banco
        ''' </summary>
        ''' <value>String</value>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Property Key() As String
            Get
                Return strKey
            End Get
            Set(ByVal value As String)
                strKey = value
            End Set
        End Property

        Public ReadOnly Property Sena() As Struct.Sena
            Get
                Return objSena
            End Get
        End Property
        Public ReadOnly Property Quina() As Struct.Quina
            Get
                Return objQuina
            End Get
        End Property
        Public ReadOnly Property LotoFacil() As Struct.LotoFacil
            Get
                Return objLotoFacil
            End Get
        End Property
        Public ReadOnly Property LotoMania() As Struct.LotoMania
            Get
                Return objLotoMania
            End Get
        End Property
        Public ReadOnly Property TimeMania() As Struct.TimeMania
            Get
                Return objTimeMania
            End Get
        End Property
#End Region

#Region "Métodos"

        ''' <summary>
        ''' Grava Loteria do Tipo Sena
        ''' </summary>
        ''' <returns>Boolean</returns>
        Public Function GravarSena() As Boolean

            Dim blnRetorno As Boolean

            blnRetorno = False

            Using cmdDados As Command = New Command(Me.Key)

                Dim parDados As New Parameter

                'CREATE PROCEDURE [dbo].[pr_tor_add_dezena_sena](@id_loteria integer, 
                '@nr_concurso integer,
                '@dt_concurso smalldatetime,
                '  @nr_dezena1 integer,
                '  @nr_dezena2 integer,
                '  @nr_dezena3 integer,
                '  @nr_dezena4 integer,
                '  @nr_dezena5 integer,
                '  @nr_dezena6 integer)

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_add_dezena_sena")

                    'id_loteria
                    parDados = New Parameter
                    parDados.Name = "@id_loteria"
                    parDados.Value = Sena.Loteria.ToString
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_concurso
                    parDados = New Parameter
                    parDados.Name = "@nr_concurso"
                    parDados.Value = Sena.Concurso.ToString
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'dt_concurso
                    parDados = New Parameter
                    parDados.Name = "@dt_concurso"
                    parDados.Value = Sena.Data.ToString
                    parDados.DbType = DbType.DateTime
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena1
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena1"
                    parDados.Value = Sena.Dezena01
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena2
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena2"
                    parDados.Value = Sena.Dezena02
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena3
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena3"
                    parDados.Value = Sena.Dezena03
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena4
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena4"
                    parDados.Value = Sena.Dezena04
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena5
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena5"
                    parDados.Value = Sena.Dezena05
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena6
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena6"
                    parDados.Value = Sena.Dezena06
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    cmdDados.Execute()

                    'fim
                    blnRetorno = True
                    cmdDados.Dispose()
                    parDados.Dispose()
                    parDados = Nothing

                Catch ex As Exception
                    blnRetorno = False
                    cmdDados.Dispose()
                    parDados.Dispose()
                    parDados = Nothing
                    Throw New Exception(ex.Message.ToString)
                End Try
            End Using

            Return blnRetorno

        End Function

        ''' <summary>
        ''' Grava Loteria do Tipo Mega-Sena
        ''' </summary>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Function GravarMegaSena() As Boolean

            Dim blnRetorno As Boolean

            blnRetorno = False

            Using cmdDados As Command = New Command(Me.Key)

                Dim parDados As New Parameter

                'CREATE PROCEDURE [dbo].[pr_tor_add_dezena_megasena](@nr_concurso integer,
                '@dt_concurso smalldatetime,
                '  @nr_dezena1 integer,
                '  @nr_dezena2 integer,
                '  @nr_dezena3 integer,
                '  @nr_dezena4 integer,
                '  @nr_dezena5 integer,
                '  @nr_dezena6 integer)

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_add_dezena_megasena")

                    'id_loteria
                    'parDados = New Parameter
                    'parDados.Name = "@id_loteria"
                    'parDados.Value = Sena.Loteria.ToString
                    'parDados.DbType = DbType.Int32
                    'cmdDados.Parameters.Add(parDados)

                    'nr_concurso
                    parDados = New Parameter
                    parDados.Name = "@nr_concurso"
                    parDados.Value = Sena.Concurso.ToString
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'dt_concurso
                    parDados = New Parameter
                    parDados.Name = "@dt_concurso"
                    parDados.Value = Sena.Data.ToString
                    parDados.DbType = DbType.DateTime
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena1
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena1"
                    parDados.Value = Sena.Dezena01
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena2
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena2"
                    parDados.Value = Sena.Dezena02
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena3
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena3"
                    parDados.Value = Sena.Dezena03
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena4
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena4"
                    parDados.Value = Sena.Dezena04
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena5
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena5"
                    parDados.Value = Sena.Dezena05
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena6
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena6"
                    parDados.Value = Sena.Dezena06
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    cmdDados.Execute()

                    'fim
                    blnRetorno = True
                    cmdDados.Dispose()
                    parDados.Dispose()
                    parDados = Nothing

                Catch ex As Exception
                    blnRetorno = False
                    cmdDados.Dispose()
                    parDados.Dispose()
                    parDados = Nothing
                    Throw New Exception(ex.Message.ToString)
                End Try
            End Using

            Return blnRetorno

        End Function

        ''' <summary>
        ''' Grava Loteria do Tipo Dupla-Sena Sorteio 1
        ''' </summary>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Function GravarDuplaSenaS2() As Boolean

            Dim blnRetorno As Boolean

            blnRetorno = False

            Using cmdDados As Command = New Command(Me.Key)

                Dim parDados As New Parameter

                'CREATE PROCEDURE [dbo].[pr_tor_add_dezena_duplasena_s2](@nr_concurso integer,
                '@dt_concurso smalldatetime,
                '  @nr_dezena1 integer,
                '  @nr_dezena2 integer,
                '  @nr_dezena3 integer,
                '  @nr_dezena4 integer,
                '  @nr_dezena5 integer,
                '  @nr_dezena6 integer)

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_add_dezena_duplasena_s2")

                    ''id_loteria
                    'parDados = New Parameter
                    'parDados.Name = "@id_loteria"
                    'parDados.Value = Sena.Loteria.ToString
                    'parDados.DbType = DbType.Int32
                    'cmdDados.Parameters.Add(parDados)

                    'nr_concurso
                    parDados = New Parameter
                    parDados.Name = "@nr_concurso"
                    parDados.Value = Sena.Concurso.ToString
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'dt_concurso
                    parDados = New Parameter
                    parDados.Name = "@dt_concurso"
                    parDados.Value = Sena.Data.ToString
                    parDados.DbType = DbType.DateTime
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena1
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena1"
                    parDados.Value = Sena.Dezena01
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena2
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena2"
                    parDados.Value = Sena.Dezena02
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena3
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena3"
                    parDados.Value = Sena.Dezena03
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena4
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena4"
                    parDados.Value = Sena.Dezena04
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena5
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena5"
                    parDados.Value = Sena.Dezena05
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena6
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena6"
                    parDados.Value = Sena.Dezena06
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    cmdDados.Execute()

                    'fim
                    blnRetorno = True
                    cmdDados.Dispose()
                    parDados.Dispose()
                    parDados = Nothing

                Catch ex As Exception
                    blnRetorno = False
                    cmdDados.Dispose()
                    parDados.Dispose()
                    parDados = Nothing
                    Throw New Exception(ex.Message.ToString)
                End Try
            End Using

            Return blnRetorno

        End Function

        ''' <summary>
        ''' Grava Loteria do Tipo Dupla-Sena Sorteio 1
        ''' </summary>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Function GravarDuplaSenaS1() As Boolean

            Dim blnRetorno As Boolean

            blnRetorno = False

            Using cmdDados As Command = New Command(Me.Key)

                Dim parDados As New Parameter

                'CREATE PROCEDURE [dbo].[pr_tor_add_dezena_duplasena_s1](@nr_concurso integer,
                '@dt_concurso smalldatetime,
                '  @nr_dezena1 integer,
                '  @nr_dezena2 integer,
                '  @nr_dezena3 integer,
                '  @nr_dezena4 integer,
                '  @nr_dezena5 integer,
                '  @nr_dezena6 integer)

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_add_dezena_duplasena_s1")

                    ''id_loteria
                    'parDados = New Parameter
                    'parDados.Name = "@id_loteria"
                    'parDados.Value = Sena.Loteria.ToString
                    'parDados.DbType = DbType.Int32
                    'cmdDados.Parameters.Add(parDados)

                    'nr_concurso
                    parDados = New Parameter
                    parDados.Name = "@nr_concurso"
                    parDados.Value = Sena.Concurso.ToString
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'dt_concurso
                    parDados = New Parameter
                    parDados.Name = "@dt_concurso"
                    parDados.Value = Sena.Data.ToString
                    parDados.DbType = DbType.DateTime
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena1
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena1"
                    parDados.Value = Sena.Dezena01
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena2
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena2"
                    parDados.Value = Sena.Dezena02
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena3
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena3"
                    parDados.Value = Sena.Dezena03
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena4
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena4"
                    parDados.Value = Sena.Dezena04
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena5
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena5"
                    parDados.Value = Sena.Dezena05
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena6
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena6"
                    parDados.Value = Sena.Dezena06
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    cmdDados.Execute()

                    'fim
                    blnRetorno = True
                    cmdDados.Dispose()
                    parDados.Dispose()
                    parDados = Nothing

                Catch ex As Exception
                    blnRetorno = False
                    cmdDados.Dispose()
                    parDados.Dispose()
                    parDados = Nothing
                    Throw New Exception(ex.Message.ToString)
                End Try
            End Using

            Return blnRetorno

        End Function

        ''' <summary>
        ''' Grava Loteria do Tipo LotoFácil
        ''' </summary>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Function GravarLotoFacil() As Boolean

            Dim blnRetorno As Boolean

            blnRetorno = False

            Using cmdDados As Command = New Command(Me.Key)

                Dim parDados As New Parameter

                'PROCEDURE [dbo].[pr_tor_add_dezena_loto_facil](@nr_concurso integer,
                '							              @dt_concurso smalldatetime,
                '						  	              @nr_dezena01 integer,
                '						  	              @nr_dezena02 integer,
                '						  	              @nr_dezena03 integer,
                '						  	              @nr_dezena04 integer,
                '						  	              @nr_dezena05 integer,
                '						  	              @nr_dezena06 integer,
                '						  	              @nr_dezena07 integer,
                '						  	              @nr_dezena08 integer,
                '						  	              @nr_dezena09 integer,
                '						  	              @nr_dezena10 integer,
                '						  	              @nr_dezena11 integer,
                '						  	              @nr_dezena12 integer,
                '						  	              @nr_dezena13 integer,
                '						  	              @nr_dezena14 integer,
                '						  	              @nr_dezena15 integer)
                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_add_dezena_loto_facil")

                    'nr_concurso
                    parDados = New Parameter
                    parDados.Name = "@nr_concurso"
                    parDados.Value = LotoFacil.Concurso.ToString
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'dt_concurso
                    parDados = New Parameter
                    parDados.Name = "@dt_concurso"
                    parDados.Value = LotoFacil.Data.ToString
                    parDados.DbType = DbType.DateTime
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena1
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena01"
                    parDados.Value = LotoFacil.Dezena01
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena2
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena02"
                    parDados.Value = LotoFacil.Dezena02
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena3
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena03"
                    parDados.Value = LotoFacil.Dezena03
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena4
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena04"
                    parDados.Value = LotoFacil.Dezena04
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena5
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena05"
                    parDados.Value = LotoFacil.Dezena05
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena6
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena06"
                    parDados.Value = LotoFacil.Dezena06
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena1
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena07"
                    parDados.Value = LotoFacil.Dezena07
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena2
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena08"
                    parDados.Value = LotoFacil.Dezena08
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena3
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena09"
                    parDados.Value = LotoFacil.Dezena09
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena4
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena10"
                    parDados.Value = LotoFacil.Dezena10
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena5
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena11"
                    parDados.Value = LotoFacil.Dezena11
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena6
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena12"
                    parDados.Value = LotoFacil.Dezena12
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena1
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena13"
                    parDados.Value = LotoFacil.Dezena13
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena2
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena14"
                    parDados.Value = LotoFacil.Dezena14
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena3
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena15"
                    parDados.Value = LotoFacil.Dezena15
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    cmdDados.Execute()

                    'fim
                    blnRetorno = True
                    cmdDados.Dispose()
                    parDados.Dispose()
                    parDados = Nothing

                Catch ex As Exception
                    blnRetorno = False
                    cmdDados.Dispose()
                    parDados.Dispose()
                    parDados = Nothing
                    Throw New Exception(ex.Message.ToString)
                End Try
            End Using

            Return blnRetorno

        End Function

        ''' <summary>
        ''' Grava Loteria do Tipo Quina
        ''' </summary>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Function GravarQuina() As Boolean

            Dim blnRetorno As Boolean

            blnRetorno = False

            Using cmdDados As Command = New Command(Me.Key)

                Dim parDados As New Parameter

                'CREATE PROCEDURE [dbo].[pr_tor_add_dezena_quina](@nr_concurso integer,
                '@dt_concurso smalldatetime,
                '  @nr_dezena1 integer,
                '  @nr_dezena2 integer,
                '  @nr_dezena3 integer,
                '  @nr_dezena4 integer,
                '  @nr_dezena5 integer)

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_add_dezena_quina")

                    'nr_concurso
                    parDados = New Parameter
                    parDados.Name = "@nr_concurso"
                    parDados.Value = objQuina.Concurso.ToString
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'dt_concurso
                    parDados = New Parameter
                    parDados.Name = "@dt_concurso"
                    parDados.Value = objQuina.Data.ToString
                    parDados.DbType = DbType.DateTime
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena1
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena1"
                    parDados.Value = objQuina.Dezena01
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena2
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena2"
                    parDados.Value = objQuina.Dezena02
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena3
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena3"
                    parDados.Value = objQuina.Dezena03
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena4
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena4"
                    parDados.Value = objQuina.Dezena04
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena5
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena5"
                    parDados.Value = objQuina.Dezena05
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    cmdDados.Execute()

                    'fim
                    blnRetorno = True
                    cmdDados.Dispose()
                    parDados.Dispose()
                    parDados = Nothing

                Catch ex As Exception
                    blnRetorno = False
                    cmdDados.Dispose()
                    parDados.Dispose()
                    parDados = Nothing
                    Throw New Exception(ex.Message.ToString)
                End Try
            End Using

            Return blnRetorno

        End Function

        ''' <summary>
        ''' Grava Loteria do Tipo LotoMania
        ''' </summary>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Function GravarLotoMania() As Boolean

            Dim blnRetorno As Boolean

            blnRetorno = False

            Using cmdDados As Command = New Command(Me.Key)

                Dim parDados As New Parameter

                'PROCEDURE [dbo].[pr_tor_add_dezena_loto_mania](@nr_concurso integer,
                '								              @dt_concurso smalldatetime,
                '							  	              @nr_dezena01 integer,
                '							  	              @nr_dezena02 integer,
                '							  	              @nr_dezena03 integer,
                '							  	              @nr_dezena04 integer,
                '							  	              @nr_dezena05 integer,
                '							  	              @nr_dezena06 integer,
                '							  	              @nr_dezena07 integer,
                '							  	              @nr_dezena08 integer,
                '							  	              @nr_dezena09 integer,
                '							  	              @nr_dezena10 integer,
                '							  	              @nr_dezena11 integer,
                '							  	              @nr_dezena12 integer,
                '							  	              @nr_dezena13 integer,
                '							  	              @nr_dezena14 integer,
                '							  	              @nr_dezena15 integer,
                '							  	              @nr_dezena16 integer,
                '							  	              @nr_dezena17 integer,
                '							  	              @nr_dezena18 integer,
                '							  	              @nr_dezena19 integer,
                '							  	              @nr_dezena20 integer)

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_add_dezena_loto_mania")

                    'nr_concurso
                    parDados = New Parameter
                    parDados.Name = "@nr_concurso"
                    parDados.Value = LotoMania.Concurso.ToString
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'dt_concurso
                    parDados = New Parameter
                    parDados.Name = "@dt_concurso"
                    parDados.Value = LotoMania.Data.ToString
                    parDados.DbType = DbType.DateTime
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena1
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena01"
                    parDados.Value = LotoMania.Dezena01
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena2
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena02"
                    parDados.Value = LotoMania.Dezena02
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena3
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena03"
                    parDados.Value = LotoMania.Dezena03
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena4
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena04"
                    parDados.Value = LotoMania.Dezena04
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena5
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena05"
                    parDados.Value = LotoMania.Dezena05
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena6
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena06"
                    parDados.Value = LotoMania.Dezena06
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena1
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena07"
                    parDados.Value = LotoMania.Dezena07
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena2
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena08"
                    parDados.Value = LotoMania.Dezena08
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena3
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena09"
                    parDados.Value = LotoMania.Dezena09
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena4
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena10"
                    parDados.Value = LotoMania.Dezena10
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena5
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena11"
                    parDados.Value = LotoMania.Dezena11
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena6
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena12"
                    parDados.Value = LotoMania.Dezena12
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena1
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena13"
                    parDados.Value = LotoMania.Dezena13
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena2
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena14"
                    parDados.Value = LotoMania.Dezena14
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena3
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena15"
                    parDados.Value = LotoMania.Dezena15
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena5
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena16"
                    parDados.Value = LotoMania.Dezena16
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena6
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena17"
                    parDados.Value = LotoMania.Dezena17
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena1
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena18"
                    parDados.Value = LotoMania.Dezena18
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena2
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena19"
                    parDados.Value = LotoMania.Dezena19
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena3
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena20"
                    parDados.Value = LotoMania.Dezena20
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    cmdDados.Execute()

                    'fim
                    blnRetorno = True
                    cmdDados.Dispose()
                    parDados.Dispose()
                    parDados = Nothing

                Catch ex As Exception
                    blnRetorno = False
                    cmdDados.Dispose()
                    parDados.Dispose()
                    parDados = Nothing
                    Throw New Exception(ex.Message.ToString)
                End Try
            End Using

            Return blnRetorno

        End Function

        ''' <summary>
        ''' Grava Loteria do Tipo TimeMania
        ''' </summary>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Function GravarTimeMania() As Boolean

            Dim blnRetorno As Boolean

            blnRetorno = False

            Using cmdDados As Command = New Command(Me.Key)

                Dim parDados As New Parameter

                'CREATE PROCEDURE [dbo].[pr_tor_add_dezena_Timemania](@nr_concurso integer,
                '@dt_concurso smalldatetime,
                '@nr_dezena01 integer,
                '@nr_dezena02 integer,
                '@nr_dezena03 integer,
                '@nr_dezena04 integer,
                '@nr_dezena05 integer,
                '@nr_dezena06 integer,
                '@nr_dezena07 integer,
                '@id_time integer)

                Try

                    cmdDados.CommandType = CommandType.StoredProcedure
                    cmdDados.CommandTextObject.Append("pr_tor_add_dezena_Timemania")

                    'nr_concurso
                    parDados = New Parameter
                    parDados.Name = "@nr_concurso"
                    parDados.Value = TimeMania.Concurso.ToString
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'dt_concurso
                    parDados = New Parameter
                    parDados.Name = "@dt_concurso"
                    parDados.Value = TimeMania.Data.ToString
                    parDados.DbType = DbType.DateTime
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena1
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena01"
                    parDados.Value = TimeMania.Dezena01
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena2
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena02"
                    parDados.Value = TimeMania.Dezena02
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena3
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena03"
                    parDados.Value = TimeMania.Dezena03
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena4
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena04"
                    parDados.Value = TimeMania.Dezena04
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena5
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena05"
                    parDados.Value = TimeMania.Dezena05
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena6
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena06"
                    parDados.Value = TimeMania.Dezena06
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'nr_dezena7
                    parDados = New Parameter
                    parDados.Name = "@nr_dezena07"
                    parDados.Value = TimeMania.Dezena07
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    'time
                    parDados = New Parameter
                    parDados.Name = "@nr_time"
                    parDados.Value = TimeMania.Time.Codigo
                    parDados.DbType = DbType.Int32
                    cmdDados.Parameters.Add(parDados)

                    cmdDados.Execute()

                    'fim
                    blnRetorno = True
                    cmdDados.Dispose()
                    parDados.Dispose()
                    parDados = Nothing

                Catch ex As Exception
                    blnRetorno = False
                    cmdDados.Dispose()
                    parDados.Dispose()
                    parDados = Nothing
                    Throw New Exception(ex.Message.ToString)
                End Try
            End Using

            Return blnRetorno

        End Function

#End Region

    End Class

End Namespace