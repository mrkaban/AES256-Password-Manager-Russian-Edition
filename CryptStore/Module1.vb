Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

Public Class Crypto

    ''' <summary>
    '''   Encrypts string with AES256 algorithm
    ''' </summary>
    Friend Class AES256
        Private Shared ReadOnly MD5 As New MD5CryptoServiceProvider()
        Private ReadOnly _rDel As New RijndaelManaged()

        ''' <summary>
        '''   Class Constructor
        ''' </summary>
        ''' <param name="key"> Encryption key </param>
        Friend Sub New(ByVal key As String)
            Dim bkey As Byte() = Encoding.[Default].GetBytes(key)
            Dim rkey As Byte() = New Byte(31) {}
            MD5.ComputeHash(bkey).CopyTo(rkey, 0)
            Array.Reverse(bkey)
            MD5.ComputeHash(bkey).CopyTo(rkey, 16)

            _rDel.Key = rkey
            _rDel.Mode = CipherMode.ECB
            _rDel.Padding = PaddingMode.PKCS7
        End Sub

        ''' <summary>
        '''   Encrypts a string
        ''' </summary>
        ''' <param name="toEncrypt"> String to encrypt </param>
        ''' <returns> Encrypted and base64 encoded string </returns>
        Friend Function Encrypt(ByVal toEncrypt As String) As String
            Dim toEncryptArray As Byte() = Encoding.[Default].GetBytes(toEncrypt)

            Dim ct As ICryptoTransform = _rDel.CreateEncryptor()
            Dim resultArray As Byte() = ct.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length)
            Return Convert.ToBase64String(resultArray, 0, resultArray.Length)
        End Function


        ''' <summary>
        '''   Decrypts a string
        ''' </summary>
        ''' <param name="toDecrypt"> Encrypted and base64 encoded string </param>
        ''' <returns> Decrypted string </returns>
        Friend Function Decrypt(ByVal toDecrypt As String) As String
            Try
                Dim toEncryptArray As Byte() = Convert.FromBase64String(toDecrypt)

                Dim ct As ICryptoTransform = _rDel.CreateDecryptor()
                Dim resultArray As Byte() = ct.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length)
                Return Encoding.[Default].GetString(resultArray)
            Catch generatedExceptionName As Exception
                Return ("Chiave errata")

            End Try
        End Function
    End Class

End Class