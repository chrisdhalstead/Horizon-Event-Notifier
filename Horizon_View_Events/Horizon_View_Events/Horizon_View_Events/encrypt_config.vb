Imports System.Configuration

Public Class encrypt_config

    Private m_Section As String

    Public Sub New(ByVal section As String)
        If String.IsNullOrEmpty(section) Then _
            Throw New ArgumentNullException("ConfigurationSection")
        m_Section = section
    End Sub

    Public Sub ProtectSection()
        ' Get the current configuration file.
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath)
        Dim protectedSection As ConfigurationSection = config.GetSection(m_Section)

        ' Encrypts when possible
        If ((protectedSection IsNot Nothing) _
        AndAlso (Not protectedSection.IsReadOnly) _
        AndAlso (Not protectedSection.SectionInformation.IsProtected) _
        AndAlso (Not protectedSection.SectionInformation.IsLocked) _
        AndAlso (protectedSection.SectionInformation.IsDeclared)) Then
            ' Protect (encrypt)the section.
            protectedSection.SectionInformation.ProtectSection(Nothing)
            ' Save the encrypted section.
            protectedSection.SectionInformation.ForceSave = True
            config.Save(ConfigurationSaveMode.Full)
        End If
    End Sub
End Class